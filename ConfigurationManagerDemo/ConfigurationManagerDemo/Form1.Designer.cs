namespace ConfigurationManagerDemo
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
            lblSetting1 = new Label();
            lblSetting2 = new Label();
            lblSetting3 = new Label();
            btnNorthwind = new Button();
            btnGEX2025 = new Button();
            SuspendLayout();
            // 
            // lblSetting1
            // 
            lblSetting1.AutoSize = true;
            lblSetting1.Location = new Point(35, 25);
            lblSetting1.Name = "lblSetting1";
            lblSetting1.Size = new Size(64, 20);
            lblSetting1.TabIndex = 0;
            lblSetting1.Text = "Setting1";
            // 
            // lblSetting2
            // 
            lblSetting2.AutoSize = true;
            lblSetting2.Location = new Point(35, 65);
            lblSetting2.Name = "lblSetting2";
            lblSetting2.Size = new Size(64, 20);
            lblSetting2.TabIndex = 1;
            lblSetting2.Text = "Setting2";
            lblSetting2.Click += label2_Click;
            // 
            // lblSetting3
            // 
            lblSetting3.AutoSize = true;
            lblSetting3.Location = new Point(35, 107);
            lblSetting3.Name = "lblSetting3";
            lblSetting3.Size = new Size(64, 20);
            lblSetting3.TabIndex = 2;
            lblSetting3.Text = "Setting3";
            // 
            // btnNorthwind
            // 
            btnNorthwind.Location = new Point(35, 176);
            btnNorthwind.Name = "btnNorthwind";
            btnNorthwind.Size = new Size(127, 71);
            btnNorthwind.TabIndex = 3;
            btnNorthwind.Text = "Connect to northwind";
            btnNorthwind.UseVisualStyleBackColor = true;
            btnNorthwind.Click += btnNorthwind_Click;
            // 
            // btnGEX2025
            // 
            btnGEX2025.Location = new Point(35, 270);
            btnGEX2025.Name = "btnGEX2025";
            btnGEX2025.Size = new Size(127, 71);
            btnGEX2025.TabIndex = 4;
            btnGEX2025.Text = "Connect to GEX2025";
            btnGEX2025.UseVisualStyleBackColor = true;
            btnGEX2025.Click += btnGEX2025_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGEX2025);
            Controls.Add(btnNorthwind);
            Controls.Add(lblSetting3);
            Controls.Add(lblSetting2);
            Controls.Add(lblSetting1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSetting1;
        private Label lblSetting2;
        private Label lblSetting3;
        private Button btnNorthwind;
        private Button btnGEX2025;
    }
}
