using System;
using System.IO; // Needed for file operations
using System.Windows.Forms;

namespace RebaneOS
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        // Event handler for the "Open" menu item.
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog instance.
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                // Set filter options (optional).
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Open Text File"
            };

            // If the user selects a file and clicks OK...
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Read all text from the selected file.
                    string fileContent = File.ReadAllText(openFileDialog.FileName);
                    // Set the file content to textBox1.
                    textBox1.Text = fileContent;
                }
                catch (Exception ex)
                {
                    // Show any error messages that occur.
                    MessageBox.Show("Error reading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler for the "Save" menu item.
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a SaveFileDialog instance.
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                // Set filter options (optional).
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Save Text File"
            };

            // If the user picks a file and clicks OK...
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Write the content of textBox1 to the selected file.
                    File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
                    MessageBox.Show("File saved successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Show error message if something goes wrong.
                    MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}