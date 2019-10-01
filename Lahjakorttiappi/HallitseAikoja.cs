using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lahjakorttiappi
{
    public partial class HallitseAikoja : Form
    {
        public HallitseAikoja()
        {
            InitializeComponent();
        }

        private void HallitseAikoja_Load(object sender, EventArgs e)
        {

        }

        private void BtnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
