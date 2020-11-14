using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstroRaws
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void packBtn_Click(object sender, EventArgs e)
        {

        }

        private void makeBtn_Click(object sender, EventArgs e)
        {
            packcomp pc = new packcomp();
            pc.Show();
        }
    }
}
