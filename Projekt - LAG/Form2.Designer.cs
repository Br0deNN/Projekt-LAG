namespace Projekt___LAG
{
    partial class Form2
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
            lblquestion = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lblscore = new Label();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = Properties.Resources.norge;
            pictureBox1.Location = new Point(67, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblquestion
            // 
            lblquestion.BackColor = Color.Transparent;
            lblquestion.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblquestion.Location = new Point(67, 256);
            lblquestion.Name = "lblquestion";
            lblquestion.Size = new Size(345, 43);
            lblquestion.TabIndex = 1;
            lblquestion.Text = "Fråga";
            lblquestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(26, 302);
            button1.Name = "button1";
            button1.Size = new Size(140, 88);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += checkAnswerEvent;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(172, 302);
            button2.Name = "button2";
            button2.Size = new Size(140, 88);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += checkAnswerEvent;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(318, 302);
            button3.Name = "button3";
            button3.Size = new Size(140, 88);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += checkAnswerEvent;
            // 
            // lblscore
            // 
            lblscore.AutoSize = true;
            lblscore.BackColor = Color.Transparent;
            lblscore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblscore.ForeColor = Color.Black;
            lblscore.Location = new Point(313, 431);
            lblscore.Name = "lblscore";
            lblscore.Size = new Size(57, 21);
            lblscore.TabIndex = 5;
            lblscore.Text = "label1";
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.ForeColor = Color.Black;
            button7.Location = new Point(12, 432);
            button7.Name = "button7";
            button7.Size = new Size(90, 23);
            button7.TabIndex = 6;
            button7.Text = "<-- Startsidan";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(484, 461);
            Controls.Add(button7);
            Controls.Add(lblscore);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblquestion);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Länder";
            Load += Form2_Load;
            Click += checkAnswerEvent;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblquestion;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label lblscore;
        private Button button7;
    }
}