using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design1
{
    public partial class myInputDialog : UserControl
    {
        public myInputDialog()
        {
            InitializeComponent();
        }

        private void valider_Click(object sender, EventArgs e)
        {
            this.Visible=false;
        }
    }
}
