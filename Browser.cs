using Microsoft.Web.WebView2.WinForms;
using System;
using System.Windows.Forms;

namespace RebaneOS
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
            webView21.Source = new Uri("https://www.duckduckgo.com"); // Default homepage
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text; // Ensure textBox1 exists

            if (!string.IsNullOrWhiteSpace(url))
            {
                try
                {
                    webView21.Source = new Uri(url);
                }
                catch (UriFormatException)
                {
                    MessageBox.Show("Invalid URL. Please enter a valid address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}