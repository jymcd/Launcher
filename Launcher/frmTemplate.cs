using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class frmTemplate : Form
    {
        public frmTemplate()
        {
            InitializeComponent();
        }

        internal void status(string msg)
        {
            toolStripStatus.Text = msg.ToString();
        }
    }
}
