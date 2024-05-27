namespace Projekt___LAG
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            lblquestion2 = new Label();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            lblscore2 = new Label();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.stockholm;
            pictureBox1.Location = new Point(4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(475, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblquestion2
            // 
            lblquestion2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblquestion2.Location = new Point(4, 261);
            lblquestion2.Name = "lblquestion2";
            lblquestion2.Size = new Size(475, 43);
            lblquestion2.TabIndex = 2;
            lblquestion2.Text = "Fråga";
            lblquestion2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(323, 307);
            button6.Name = "button6";
            button6.Size = new Size(152, 80);
            button6.TabIndex = 7;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += checkAnswerEvent2;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(165, 307);
            button5.Name = "button5";
            button5.Size = new Size(152, 80);
            button5.TabIndex = 6;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += checkAnswerEvent2;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(7, 307);
            button4.Name = "button4";
            button4.Size = new Size(152, 80);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += checkAnswerEvent2;
            // 
            // lblscore2
            // 
            lblscore2.AutoSize = true;
            lblscore2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblscore2.Location = new Point(323, 432);
            lblscore2.Name = "lblscore2";
            lblscore2.Size = new Size(57, 21);
            lblscore2.TabIndex = 8;
            lblscore2.Text = "label1";
            lblscore2.Click += Form3_Load;
            // 
            // button8
            // 
            button8.Location = new Point(7, 430);
            button8.Name = "button8";
            button8.Size = new Size(90, 23);
            button8.TabIndex = 9;
            button8.Text = "<-- Startsidan";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(484, 461);
            Controls.Add(button8);
            Controls.Add(lblscore2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(lblquestion2);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Städer";
            Load += Form3_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblquestion2;
        private Button button6;
        private Button button5;
        private Button button4;
        private Label lblscore2;
        private Button button8;
    }
}