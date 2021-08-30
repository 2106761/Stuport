using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stuport
{
    class DefaultMethods
    {
        public static void LaunchActivity(Form parent, Form target, bool closeParent)
        {
            parent.Hide();
            target.ShowDialog();
            if (closeParent) parent.Close();
            else parent.Show();
        }

        public static void setFlowLayoutHoverColor(FlowLayoutPanel layout)
        {
            layout.BackColor = Color.DarkSlateBlue;
        }

        public static void setFlowLayoutNormalColor(FlowLayoutPanel layout)
        {
            layout.BackColor = Color.FromArgb(53, 29, 78);
        }

        public static void setLabelHoverColor(Label lbl) {
            lbl.BackColor = Color.Purple;
        }

        public static void setLabelNormalColor(Label lbl) {
            lbl.BackColor = Color.DarkSlateBlue;
        }
    }
}
