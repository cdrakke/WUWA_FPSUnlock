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
            btn_radio75 = new RadioButton();
            btn_radio90 = new RadioButton();
            btn_radio120 = new RadioButton();
            cb_persistentUnlock = new CheckBox();
            label2 = new Label();
            btn_FolderSelect = new Button();
            label1 = new Label();
            btn_Submit = new Button();
            pathTB = new TextBox();
            fbd_FolderSelect = new FolderBrowserDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_radio75);
            panel1.Controls.Add(btn_radio90);
            panel1.Controls.Add(btn_radio120);
            panel1.Controls.Add(cb_persistentUnlock);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_FolderSelect);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_Submit);
            panel1.Controls.Add(pathTB);
            panel1.Location = new Point(14, 15);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(631, 267);
            panel1.TabIndex = 8;
            // 
            // btn_radio75
            // 
            btn_radio75.AutoSize = true;
            btn_radio75.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_radio75.Location = new Point(379, 188);
            btn_radio75.Name = "btn_radio75";
            btn_radio75.Size = new Size(94, 28);
            btn_radio75.TabIndex = 5;
            btn_radio75.TabStop = true;
            btn_radio75.Text = "75 FPS";
            btn_radio75.UseVisualStyleBackColor = true;
            // 
            // btn_radio90
            // 
            btn_radio90.AutoSize = true;
            btn_radio90.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_radio90.Location = new Point(279, 188);
            btn_radio90.Name = "btn_radio90";
            btn_radio90.Size = new Size(94, 28);
            btn_radio90.TabIndex = 4;
            btn_radio90.TabStop = true;
            btn_radio90.Text = "90 FPS";
            btn_radio90.UseVisualStyleBackColor = true;
            // 
            // btn_radio120
            // 
            btn_radio120.AutoSize = true;
            btn_radio120.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_radio120.Location = new Point(168, 188);
            btn_radio120.Name = "btn_radio120";
            btn_radio120.Size = new Size(105, 28);
            btn_radio120.TabIndex = 3;
            btn_radio120.TabStop = true;
            btn_radio120.Text = "120 FPS";
            btn_radio120.UseVisualStyleBackColor = true;
            // 
            // cb_persistentUnlock
            // 
            cb_persistentUnlock.AutoSize = true;
            cb_persistentUnlock.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_persistentUnlock.Location = new Point(187, 154);
            cb_persistentUnlock.Name = "cb_persistentUnlock";
            cb_persistentUnlock.Size = new Size(260, 28);
            cb_persistentUnlock.TabIndex = 2;
            cb_persistentUnlock.Text = "Persistent FPS Unlock";
            cb_persistentUnlock.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Font = new Font("Cascadia Mono", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 86);
            label2.Name = "label2";
            label2.Size = new Size(624, 28);
            label2.TabIndex = 4;
            label2.Text = "Wuthering Waves Folder";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_FolderSelect
            // 
            btn_FolderSelect.FlatStyle = FlatStyle.System;
            btn_FolderSelect.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_FolderSelect.Location = new Point(241, 44);
            btn_FolderSelect.Margin = new Padding(3, 4, 3, 4);
            btn_FolderSelect.Name = "btn_FolderSelect";
            btn_FolderSelect.Size = new Size(157, 38);
            btn_FolderSelect.TabIndex = 1;
            btn_FolderSelect.Text = "Select Folder";
            btn_FolderSelect.UseVisualStyleBackColor = true;
            btn_FolderSelect.Click += btn_FolderSelect_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(624, 40);
            label1.TabIndex = 7;
            label1.Text = "Select root folder of Wuthering Waves";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Submit
            // 
            btn_Submit.FlatStyle = FlatStyle.System;
            btn_Submit.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Submit.Location = new Point(250, 223);
            btn_Submit.Margin = new Padding(3, 4, 3, 4);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(135, 38);
            btn_Submit.TabIndex = 0;
            btn_Submit.Text = "Submit";
            btn_Submit.UseVisualStyleBackColor = true;
            btn_Submit.Click += btn_Submit_Click;
            // 
            // pathTB
            // 
            pathTB.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pathTB.Location = new Point(38, 118);
            pathTB.Margin = new Padding(3, 4, 3, 4);
            pathTB.Name = "pathTB";
            pathTB.ReadOnly = true;
            pathTB.Size = new Size(546, 29);
            pathTB.TabIndex = 6;
            pathTB.TextChanged += pathTB_TextChanged;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 295);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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
        private CheckBox cb_persistentUnlock;
        private Label label2;
        private Button btn_FolderSelect;
        private FolderBrowserDialog fbd_FolderSelect;
        private RadioButton btn_radio75;
        private RadioButton btn_radio90;
        private RadioButton btn_radio120;
    }
}
