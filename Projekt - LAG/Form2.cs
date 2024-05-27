using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projekt___LAG
{
    public partial class Form2 : Form
    {
        // Variabler till spelet

        int rättSvar;
        int questionNumber = 1;
        private int score = 0;
        int totalQuestions;




        public Form2()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 5;
        }


        private void checkAnswerEvent(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;

            int knapptryck = Convert.ToInt32(senderObject.Tag);

            if (knapptryck == rättSvar)
            {
                score++;
                UpdateScoreLabel();
            }

            if (questionNumber == totalQuestions)
            {
                MessageBox.Show(
                    "Slut på quizet!" + Environment.NewLine +
                    "Du svarade rätt på " + score + " antal frågor." + Environment.NewLine +
                    "Klicka på OK för att ta dig tillbaka till startidan för att gissa på städer"
                    );
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            questionNumber++;
            askQuestion(questionNumber);
        }


        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.svergie;
                    lblquestion.Text = "Vilket land är detta?";

                    button1.Text = "Danmark";
                    button1.Tag = 1;
                    button2.Text = "Sverige";
                    button2.Tag = 2;
                    button3.Text = "Ukraina";
                    button3.Tag = 3;

                    rättSvar = 2;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.island;
                    lblquestion.Text = "Vilket land är detta?";

                    button1.Text = "Nya Zeeland";
                    button1.Tag = 1;
                    button2.Text = "Norge";
                    button2.Tag = 2;
                    button3.Text = "Island";
                    button3.Tag = 3;

                    rättSvar = 3;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.denmark;
                    lblquestion.Text = "Vilken flagga är detta?";

                    button1.Text = "Danmark";
                    button1.Tag = 1;
                    button2.Text = "USA";
                    button2.Tag = 2;
                    button3.Text = "Ryssland";
                    button3.Tag = 3;

                    rättSvar = 1;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.norge;
                    lblquestion.Text = "Vilken flagga är detta?";

                    button1.Text = "Island";
                    button1.Tag = 1;
                    button2.Text = "Norge";
                    button2.Tag = 2;
                    button3.Text = "Grönland";
                    button3.Tag = 3;

                    rättSvar = 2;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.finland;
                    lblquestion.Text = "Vems flagga är denna?";

                    button1.Text = "Finland";
                    button1.Tag = 1;
                    button2.Text = "Antarktis";
                    button2.Tag = 2;
                    button3.Text = "Polen";
                    button3.Tag = 3;

                    rättSvar = 1;
                    break;
            }

        }

        private void UpdateScoreLabel()
        {
            lblscore.Text = "Antal rätt: " + score.ToString();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            score = 0;
            UpdateScoreLabel();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
