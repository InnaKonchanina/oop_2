namespace IndividualTask
{
    partial class Form1
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
            pMain = new Panel();
            panel2 = new Panel();
            newButton = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pMain
            // 
            pMain.Dock = DockStyle.Left;
            pMain.Location = new Point(0, 0);
            pMain.Name = "pMain";
            pMain.Size = new Size(400, 450);
            pMain.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(newButton);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(396, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(404, 450);
            panel2.TabIndex = 0;
            // 
            // newButton
            // 
            newButton.Location = new Point(266, 271);
            newButton.Name = "newButton";
            newButton.Size = new Size(94, 29);
            newButton.TabIndex = 0;
            newButton.Text = "button1";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(pMain);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pMain;
        private Panel panel2;
        private Button newButton;
    }
}
