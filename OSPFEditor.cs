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
        TopologyCanvas canvas;

        public OSPFEditor()
        {
            InitializeComponent();
            tsbDeployLine.Click += new EventHandler(tsbDeployLine_Click);
            tscbSpeed.SelectedIndexChanged += new EventHandler(tscbSpeed_SelectedIndexChanged);
            canvas = new TopologyCanvas();
            toolStripContainer1.ContentPanel.Controls.Add(canvas);
        }

        void tscbSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            canvas.LinkCost = CostOfLinkType();
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

        void tsbDeployLine_Click(object sender, EventArgs e)
        {
            tsbDeployLine.Checked = !canvas.AllowLineDeploy;
            canvas.AllowLineDeploy = tsbDeployLine.Checked;
            canvas.Refresh();
        }

        private void OSPFEditor_Load(object sender, EventArgs e)
        {
            
        }
    }
}
