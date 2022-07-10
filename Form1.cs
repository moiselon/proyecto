using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desarrollo_web
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnadelante_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txturl.Text);
        }

        private void txturl_Click_1(object sender, EventArgs e)
        {

        }
    }
}
