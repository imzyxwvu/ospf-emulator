using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OSPF
{
    public partial class OSPFEditor : Form
    {
        List<Router> routers = new List<Router>();
        List<Dictionary<Router, int>> adjMat = new List<Dictionary<Router, int>>();
        Point deployPosition;
        Router routerHover;
        Router routerSelected;
        Router routerFrom;
        Router routerSearchFrom;
        Point mousePos = new Point();
        Bitmap buffer;
        Canvas canvas = new Canvas();

        public OSPFEditor()
        {
            InitializeComponent();
            this.Resize += new EventHandler(OSPFEditor_Resize);
            canvas.Paint += new PaintEventHandler(canvas_Paint);
            canvas.MouseMove += new MouseEventHandler(canvas_MouseMove);
            canvas.MouseDown += new MouseEventHandler(canvas_MouseDown);
            canvas.MouseUp += new MouseEventHandler(canvas_MouseUp);
            tsbDeployLine.Click += new EventHandler(tsbDeployLine_Click);
            menuItemSearch.Click += new EventHandler(menuItemSearch_Click);
            menuItemDelete.Click += new EventHandler(menuItemDelete_Click);
            menuItemDeploy.Click += new EventHandler(menuItemDeploy_Click);
            toolStripContainer1.ContentPanel.Controls.Add(canvas);
        }

        void menuItemSearch_Click(object sender, EventArgs e)
        {
            if (menuItemSearch.Checked)
            {
                routerSearchFrom = null;
            }
            else
            {
                tsbDeployLine.Checked = false;
                if (routerFrom != null)
                {
                    routerSearchFrom = routerFrom;
                    routerFrom = null;
                    UpdateRouterCosts(routers.IndexOf(routerSearchFrom));
                }
            }
            canvas.Refresh();
        }

        void menuItemDeploy_Click(object sender, EventArgs e)
        {
            routers.Add(new Router(deployPosition));
            EnlargeAdjMat();
            canvas.Refresh();
        }

        void menuItemDelete_Click(object sender, EventArgs e)
        {
            if (routerFrom != null)
            {
                for (int i = 0; i < routers.Count; i++)
                {
                    if (adjMat[i].ContainsKey(routerFrom))
                        adjMat[i].Remove(routerFrom);
                }
                adjMat.RemoveAt(routers.IndexOf(routerFrom));
                routers.Remove(routerFrom);
                canvas.Refresh();
                routerFrom = null;
            }
        }

        void OSPFEditor_Resize(object sender, EventArgs e)
        {
            if (canvas.Width > 0 && canvas.Height > 0)
            {
                buffer.Dispose();
                buffer = new Bitmap(canvas.Width, canvas.Height);
            }
        }

        void EnlargeAdjMat()
        {
            adjMat.Add(new Dictionary<Router, int>());
        }

        int CostOfLinkType()
        {
            switch (tscbSpeed.Text)
            {
                case "Ethernet":
                    return 100;
                case "FastEthernet":
                    return 50;
                case "GigabitEthernet":
                    return 10;
                case "TenGigabitEthernet":
                    return 1;
                default:
                    return 1;
            }
        }

        void EstablishLine(int from, Router to)
        {
            if (from != routers.IndexOf(to))
            {
                int cost = CostOfLinkType();
                adjMat[from][to] = cost;
                adjMat[routers.IndexOf(to)][routers[from]] = cost;
            }
        }

        void EstablishLine(Router from, Router to)
        {
            EstablishLine(routers.IndexOf(from), to);
        }

        void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                routerSelected = routerHover;
                if (tsbDeployLine.Checked && routerSelected != null)
                {
                    if (routerFrom != null)
                    {
                        EstablishLine(routerFrom, routerSelected);
                    }
                }
                routerFrom = routerSelected;
                canvas.Refresh();
            }
        }

        void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                routerSelected = null;
                canvas.Refresh();
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (routerHover == null)
                {
                    routerFrom = null;
                    deployPosition = e.Location;
                    canvas.Refresh();
                    menuDeploy.Show(canvas, e.Location);
                }
                else
                {
                    routerFrom = routerHover;
                    routerHover = null;
                    canvas.Refresh();
                    menuItemSearch.Checked = routerSearchFrom == routerFrom;
                    menuRouter.Show(canvas, e.Location);
                }
            }
        }

        void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            routerHover = null;
            for (int i = 0; i < routers.Count; i++)
                if (routers[i].Hover(e.X, e.Y))
                    routerHover = routers[i];
            if (routerSelected == null)
            {
                canvas.Cursor = routerHover == null ? Cursors.Arrow : Cursors.Hand;
            }
            else
            {
                routerSelected.x = e.X;
                routerSelected.y = e.Y;
                canvas.Cursor = Cursors.Hand;
            }
            mousePos.X = e.X;
            mousePos.Y = e.Y;
            if(routerSelected != null || tsbDeployLine.Checked)
                canvas.Refresh();
        }

        void tsbDeployLine_Click(object sender, EventArgs e)
        {
            if (tsbDeployLine.Checked = !tsbDeployLine.Checked)
            {
                routerSearchFrom = null;
            }
            canvas.Refresh();
        }

        public bool HasLinkBetween(int a, Router b)
        {
            if (!adjMat[a].ContainsKey(b))
                return false;
            return adjMat[a][b] < 10000;
        }

        public int CostBetween(int a, Router b)
        {
            if (!adjMat[a].ContainsKey(b))
                return 10000;
            return adjMat[a][b];
        }

        public int CostBetween(int a, int b)
        {
            return CostBetween(a, routers[b]);
        }

        public void UpdateRouterCosts(int src)
        {
            bool[] visited = new bool[routers.Count];
            int visitedCount = 1;
            int a = src;
            for (int i = 0; i < routers.Count; i++)
            {
                routers[i].Path.Clear();
                routers[i].Cost = 10000;
                routers[i].Path.Add(a);
                visited[i] = false;
            }
            routers[a].Cost = 0;
            while (visitedCount < routers.Count)
            {
                visited[a] = true;
                for (int i = 0; i < routers.Count; i++)
                {
                    if (!visited[i])
                    {
                        int cost = CostBetween(a, i);
                        if (routers[a].Cost + cost < routers[i].Cost)
                        {
                            routers[i].Path.Clear();
                            routers[i].Path.AddRange(routers[a].Path);
                            routers[i].Path.Add(i);
                            routers[i].Cost = routers[a].Cost + cost;
                        }
                    }
                }
                visitedCount++;
                int lowestCost = int.MaxValue;
                for (int i = 0; i < routers.Count; i++)
                {
                    if (routers[i].Cost < lowestCost && !visited[i])
                    {
                        lowestCost = routers[i].Cost;
                        a = i;
                    }
                }
            }
        }

        void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Graphics.FromImage(buffer);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);
            for (int i = 0; i < routers.Count; i++)
            {
                for (int j = i + 1; j < routers.Count; j++)
                {
                    int cost = CostBetween(i, j);
                    if (cost < 10000)
                    {
                        if (routerSearchFrom != null && routerFrom != null && routerFrom.HasPathBetween(i, j))
                            g.DrawLine(new Pen(Brushes.Red, 2), routers[i].ToPoint(), routers[j].ToPoint());
                        else if (cost <= 10)
                            g.DrawLine(new Pen(Brushes.Black, 2), routers[i].ToPoint(), routers[j].ToPoint());
                        else
                            g.DrawLine(Pens.Black, routers[i].ToPoint(), routers[j].ToPoint());
                    }
                }
            }
            if (tsbDeployLine.Checked && routerFrom != null)
                g.DrawLine(Pens.DarkGray, routerFrom.ToPoint(), mousePos);
            for (int i = 0; i < routers.Count; i++)
            {
                g.DrawImage(OSPF.Properties.Resources.Router, routers[i].x - 25, routers[i].y - 25, 50, 50);
                if(routerSearchFrom == routers[i])
                    g.DrawEllipse(new Pen(Color.Magenta, 2.0f), routers[i].x - 28, routers[i].y - 28, 56, 56);
                else if (routerFrom == routers[i])
                    g.DrawEllipse(new Pen(Color.Navy, 2.0f), routers[i].x - 28, routers[i].y - 28, 56, 56);
                g.DrawString(i.ToString(), new Font("simsun", 12), Brushes.Gray, routers[i].x + 20, routers[i].y + 15);
            }
            e.Graphics.DrawImageUnscaled(buffer, 0, 0);
            GC.Collect();
        }

        private void OSPFEditor_Load(object sender, EventArgs e)
        {
            buffer = new Bitmap(canvas.Width, canvas.Height);
        }
    }

    public class Canvas : Control
    {
        public Canvas()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.Dock = DockStyle.Fill;
        }
    }

    public class Router
    {
        public int x;
        public int y;
        public List<int> Path;
        public int Cost;

        public Router(Point position)
        {
            x = position.X;
            y = position.Y;
            Path = new List<int>();
        }

        public bool Hover(int mx, int my)
        {
            return Math.Pow(mx - x, 2) + Math.Pow(my - y, 2) < 625;
        }

        public bool HasPathBetween(int i, int j)
        {
            if (!Path.Contains(i) || !Path.Contains(j))
                return false;
            return Math.Abs(Path.IndexOf(i) - Path.IndexOf(j)) == 1;
        }

        public Point ToPoint()
        {
            return new Point(x, y);
        }
    }
}
