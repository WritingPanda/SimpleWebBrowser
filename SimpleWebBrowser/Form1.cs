using System;
using System.Windows.Forms;

namespace SimpleWebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadbutton_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(new Uri(addressbar.Text));
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void forwardbutton_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }
    }
}
