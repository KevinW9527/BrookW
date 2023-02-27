using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrookW.UC
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            this.btnAddServer.BackColor = Color.FromArgb(0, 174, 219);
            this.btnAddServer.ForeColor = Color.White;
            this.btnAddServer.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular);
        }

         
    }
}
