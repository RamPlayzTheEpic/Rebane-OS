namespace RebaneOS
{
    partial class Desktop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Browser = new Button();
            Credits = new Button();
            button1 = new Button();
            label1 = new Label();
            terminal = new Button();
            SuspendLayout();
            // 
            // Browser
            // 
            Browser.Location = new Point(27, 25);
            Browser.Name = "Browser";
            Browser.Size = new Size(133, 23);
            Browser.TabIndex = 0;
            Browser.Text = "Bare Bones Browser ";
            Browser.UseVisualStyleBackColor = true;
            Browser.Click += Browser_Click;
            // 
            // Credits
            // 
            Credits.Location = new Point(219, 25);
            Credits.Name = "Credits";
            Credits.Size = new Size(132, 23);
            Credits.TabIndex = 1;
            Credits.Text = "Credits";
            Credits.UseVisualStyleBackColor = true;
            Credits.Click += Credits_Click;
            // 
            // button1
            // 
            button1.Location = new Point(27, 117);
            button1.Name = "button1";
            button1.Size = new Size(133, 23);
            button1.TabIndex = 2;
            button1.Text = "Rebane's Notepad";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 209);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 3;
            label1.Text = "More Apps Coming Soon!";
            
            // 
            // terminal
            // 
            terminal.Location = new Point(223, 118);
            terminal.Name = "terminal";
            terminal.Size = new Size(128, 23);
            terminal.TabIndex = 4;
            terminal.Text = "Terminal";
            terminal.UseVisualStyleBackColor = true;
            terminal.Click += terminal_Click;
            // 
            // Desktop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 252);
            Controls.Add(terminal);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(Credits);
            Controls.Add(Browser);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Desktop";
            Text = "Desktop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Browser;
        private Button Credits;
        private Button button1;
        private Label label1;
        private Button terminal;
    }
}
