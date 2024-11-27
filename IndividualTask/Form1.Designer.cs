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
            panel1 = new Panel();
            SizeDownButton = new Button();
            SizeUpButton = new Button();
            HideButton = new Button();
            ShowButton = new Button();
            MoveLeftButton = new Button();
            MoveRightButton = new Button();
            MoveUpButton = new Button();
            MoveDownButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pMain
            // 
            pMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pMain.BackColor = Color.White;
            pMain.Location = new Point(0, 0);
            pMain.Name = "pMain";
            pMain.Size = new Size(520, 450);
            pMain.TabIndex = 0;
            pMain.Resize += pMain_Resize;
            // 
            // panel1
            // 
            panel1.Controls.Add(MoveDownButton);
            panel1.Controls.Add(MoveUpButton);
            panel1.Controls.Add(MoveRightButton);
            panel1.Controls.Add(MoveLeftButton);
            panel1.Controls.Add(SizeDownButton);
            panel1.Controls.Add(SizeUpButton);
            panel1.Controls.Add(HideButton);
            panel1.Controls.Add(ShowButton);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(526, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 450);
            panel1.TabIndex = 1;
            // 
            // SizeDownButton
            // 
            SizeDownButton.Location = new Point(182, 172);
            SizeDownButton.Name = "SizeDownButton";
            SizeDownButton.Size = new Size(94, 29);
            SizeDownButton.TabIndex = 4;
            SizeDownButton.Text = "Size Down";
            SizeDownButton.UseVisualStyleBackColor = true;
            SizeDownButton.Click += SizeDownButton_Click;
            // 
            // SizeUpButton
            // 
            SizeUpButton.Location = new Point(50, 172);
            SizeUpButton.Name = "SizeUpButton";
            SizeUpButton.Size = new Size(94, 29);
            SizeUpButton.TabIndex = 3;
            SizeUpButton.Text = "Size Up";
            SizeUpButton.UseVisualStyleBackColor = true;
            SizeUpButton.Click += SizeUpButton_Click;
            // 
            // HideButton
            // 
            HideButton.Location = new Point(122, 98);
            HideButton.Name = "HideButton";
            HideButton.Size = new Size(94, 29);
            HideButton.TabIndex = 2;
            HideButton.Text = "Hide";
            HideButton.UseVisualStyleBackColor = true;
            HideButton.Click += HideButton_Click;
            // 
            // ShowButton
            // 
            ShowButton.Location = new Point(122, 63);
            ShowButton.Name = "ShowButton";
            ShowButton.Size = new Size(94, 29);
            ShowButton.TabIndex = 1;
            ShowButton.Text = "Show";
            ShowButton.UseVisualStyleBackColor = true;
            ShowButton.Click += ShowButton_Click;
            // 
            // MoveLeftButton
            // 
            MoveLeftButton.Location = new Point(50, 288);
            MoveLeftButton.Name = "MoveLeftButton";
            MoveLeftButton.Size = new Size(94, 29);
            MoveLeftButton.TabIndex = 5;
            MoveLeftButton.Text = "MoveLeft";
            MoveLeftButton.UseVisualStyleBackColor = true;
            MoveLeftButton.Click += MoveLeftButton_Click;
            // 
            // MoveRightButton
            // 
            MoveRightButton.Location = new Point(182, 288);
            MoveRightButton.Name = "MoveRightButton";
            MoveRightButton.Size = new Size(94, 29);
            MoveRightButton.TabIndex = 6;
            MoveRightButton.Text = "MoveRight";
            MoveRightButton.UseVisualStyleBackColor = true;
            MoveRightButton.Click += MoveRightButton_Click;
            // 
            // MoveUpButton
            // 
            MoveUpButton.Location = new Point(122, 253);
            MoveUpButton.Name = "MoveUpButton";
            MoveUpButton.Size = new Size(94, 29);
            MoveUpButton.TabIndex = 7;
            MoveUpButton.Text = "MoveUp";
            MoveUpButton.UseVisualStyleBackColor = true;
            MoveUpButton.Click += MoveUpButton_Click;
            // 
            // MoveDownButton
            // 
            MoveDownButton.Location = new Point(122, 323);
            MoveDownButton.Name = "MoveDownButton";
            MoveDownButton.Size = new Size(94, 29);
            MoveDownButton.TabIndex = 8;
            MoveDownButton.Text = "MoveDown";
            MoveDownButton.UseVisualStyleBackColor = true;
            MoveDownButton.Click += MoveDownButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 450);
            Controls.Add(panel1);
            Controls.Add(pMain);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pMain;
        private Panel panel1;
        private Button ShowButton;
        private Button HideButton;
        private Button SizeDownButton;
        private Button SizeUpButton;
        private Button MoveUpButton;
        private Button MoveRightButton;
        private Button MoveLeftButton;
        private Button MoveDownButton;
    }
}
