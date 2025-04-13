namespace WUWA_FPSUnlock
{
    partial class Main
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
            panel1 = new Panel();
            label1 = new Label();
            btn_Submit = new Button();
            pathTB = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_Submit);
            panel1.Controls.Add(pathTB);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(552, 103);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(546, 33);
            label1.TabIndex = 2;
            label1.Text = "Enter local storage file path of Wuthering Waves";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Submit
            // 
            btn_Submit.FlatStyle = FlatStyle.System;
            btn_Submit.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Submit.Location = new Point(224, 68);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(118, 30);
            btn_Submit.TabIndex = 1;
            btn_Submit.Text = "Submit";
            btn_Submit.UseVisualStyleBackColor = true;
            btn_Submit.Click += btn_Submit_Click;
            // 
            // pathTB
            // 
            pathTB.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pathTB.Location = new Point(37, 36);
            pathTB.Name = "pathTB";
            pathTB.Size = new Size(478, 26);
            pathTB.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 127);
            Controls.Add(panel1);
            Name = "Main";
            Text = "Wuthering Waves FPS Unlock";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btn_Submit;
        private TextBox pathTB;
    }
}
