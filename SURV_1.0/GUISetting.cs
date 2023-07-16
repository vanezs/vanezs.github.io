using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SURV_1._0
{
    internal class GUISetting
    {
        public void setLabell(Label label) 
        { 
            label.BackColor = System.Drawing.Color.Transparent;
            label.ForeColor= System.Drawing.Color.White;
            label.Font = new Font(label.Font, label.Font.Style | FontStyle.Bold | FontStyle.Italic);
        }

    }
}
