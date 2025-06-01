using System;
using System.Threading;
using System.Windows.Forms;

namespace RebaneOS
{
    public partial class Desktop : Form
    {
        public Desktop()
        {
            InitializeComponent();
        }

        // This stub is only here to satisfy the call.
        

        private void Browser_Click(object sender, EventArgs e)
        {
            Browser browserWindow = new Browser(); // Create an instance of Browser form
            browserWindow.Show(); // Use ShowDialog() if you want it modal
        }

        private void Credits_Click(object sender, EventArgs e)
        {
            Credits creditsWindow = new Credits(); // Create an instance of Credits form
            creditsWindow.Show(); // Use ShowDialog() if you want it modal
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Notepad notepadWindow = new Notepad(); // Create an instance of Notepad form
            notepadWindow.Show(); // Use ShowDialog() if you want it modal
        }

        private void terminal_Click(object sender, EventArgs e)
        {
            // Run the terminal on a separate thread so that it does not block the UI.
            Thread terminalThread = new Thread(() =>
            {
                Terminal terminal = new Terminal();
                terminal.Start();
            });
            terminalThread.IsBackground = true;
            terminalThread.Start();
        }
    }
}