namespace Projekt___LAG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkCyan;
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Rockwell Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.SpringGreen;
            groupBox1.Location = new Point(53, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(287, 187);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Norden Quiz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 66);
            label2.Name = "label2";
            label2.Size = new Size(250, 84);
            label2.TabIndex = 0;
            label2.Text = "I detta program kommer\r\ndu att testa dina kunskaper\r\nkring norden. Lycka till!!\r\n\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkCyan;
            label1.Font = new Font("Engravers MT", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SpringGreen;
            label1.Location = new Point(184, 9);
            label1.Name = "label1";
            label1.Size = new Size(405, 75);
            label1.TabIndex = 1;
            label1.Text = "Norden";
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Stencil", 20.25F, FontStyle.Underline, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(508, 125);
            button1.Name = "button1";
            button1.Size = new Size(162, 66);
            button1.TabIndex = 2;
            button1.Text = "Länder";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Font = new Font("Stencil", 20.25F, FontStyle.Underline, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(508, 201);
            button2.Name = "button2";
            button2.Size = new Size(162, 66);
            button2.TabIndex = 3;
            button2.Text = "Städer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(736, 314);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Norden spel";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}