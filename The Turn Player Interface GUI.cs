namespace The_Turn_Player_Interface
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
            groupBox1 = new GroupBox();
            HPlblOne = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            HPLbl2 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.IMG_2975;
            groupBox1.Controls.Add(HPlblOne);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(12, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 241);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dragon Name,Dragon Type's Turn";
            // 
            // HPlblOne
            // 
            HPlblOne.AutoSize = true;
            HPlblOne.BackColor = Color.FromArgb(255, 192, 128);
            HPlblOne.ForeColor = SystemColors.ActiveCaptionText;
            HPlblOne.Location = new Point(105, 27);
            HPlblOne.Name = "HPlblOne";
            HPlblOne.Size = new Size(26, 15);
            HPlblOne.TabIndex = 3;
            HPlblOne.Text = "HP:";
            HPlblOne.Click += label1_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.IMG_2977;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(17, 176);
            button3.Name = "button3";
            button3.Size = new Size(267, 51);
            button3.TabIndex = 2;
            button3.Text = "Block";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.IMG_2978;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(18, 115);
            button2.Name = "button2";
            button2.Size = new Size(266, 55);
            button2.TabIndex = 1;
            button2.Text = "Special Attack";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources._360_F_621052209_XTmVDmuxeADsO17fap7lmzhfQFnTyQSH;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(18, 60);
            button1.Name = "button1";
            button1.Size = new Size(266, 49);
            button1.TabIndex = 0;
            button1.Text = "Attack";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = Properties.Resources.IMG_2975;
            groupBox2.Controls.Add(HPLbl2);
            groupBox2.Controls.Add(label2);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(359, 73);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(366, 154);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Opponent: Player Name";
            // 
            // HPLbl2
            // 
            HPLbl2.AutoSize = true;
            HPLbl2.BackColor = Color.FromArgb(255, 192, 128);
            HPLbl2.ForeColor = SystemColors.ActiveCaptionText;
            HPLbl2.Location = new Point(155, 55);
            HPLbl2.Name = "HPLbl2";
            HPLbl2.Size = new Size(26, 15);
            HPLbl2.TabIndex = 1;
            HPLbl2.Text = "HP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 128);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(111, 19);
            label2.Name = "label2";
            label2.Size = new Size(150, 15);
            label2.TabIndex = 0;
            label2.Text = "Dragon Name,Dragon Type";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(255, 192, 128);
            groupBox3.BackgroundImage = Properties.Resources.IMG_2975;
            groupBox3.Controls.Add(textBox1);
            groupBox3.ForeColor = SystemColors.ButtonHighlight;
            groupBox3.Location = new Point(16, 260);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(717, 175);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Battle Log";
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.FromArgb(255, 224, 192);
            textBox1.Location = new Point(11, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(698, 143);
            textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.IMG_2974;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private Label HPlblOne;
        private Label HPLbl2;
        private Label label2;
    }
}
