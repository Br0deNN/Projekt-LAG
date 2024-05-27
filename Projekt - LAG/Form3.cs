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
    public partial class Form3 : Form
    {


        int rättSvar2;
        int questionNumber2 = 1;
        private int score2 = 0;
        int totalQuestions2;

        public Form3()
        {
            InitializeComponent();

            askQuestion2(questionNumber2);

            totalQuestions2 = 5;
        }


        private void checkAnswerEvent2(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;

            int knapptryck = Convert.ToInt32(senderObject.Tag);

            if (knapptryck == rättSvar2)
            {
                score2++;
                UpdateScoreLabel2();
            }

            if (questionNumber2 == totalQuestions2)
            {
                MessageBox.Show(
                    "Slut på quizet!" + Environment.NewLine +
                    "Du svarade rätt på " + score2 + " antal frågor." + Environment.NewLine +
                    "Klicka på OK för att ta dig tillbaka till startidan för att gissa mer"
                    );
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            questionNumber2++;
            askQuestion2(questionNumber2);
        }


        private void askQuestion2(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.helsinki;
                    lblquestion2.Text = "Vad heter Finlands huvudstad?";

                    button4.Text = "Helsingfors";
                    button4.Tag = 1;
                    button5.Text = "Åbo";
                    button5.Tag = 2;
                    button6.Text = "Åland";
                    button6.Tag = 3;

                    rättSvar2 = 1;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.oslo;
                    lblquestion2.Text = "Vad heter Norges huvudstad?";

                    button4.Text = "Bergen";
                    button4.Tag = 1;
                    button5.Text = "Oslo";
                    button5.Tag = 2;
                    button6.Text = "Trondheim";
                    button6.Tag = 3;

                    rättSvar2 = 2;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.stockholm;
                    lblquestion2.Text = "Vad heter Svergies huvudstad?";

                    button4.Text = "Malmö";
                    button4.Tag = 1;
                    button5.Text = "Göteborg";
                    button5.Tag = 2;
                    button6.Text = "Stockholm";
                    button6.Tag = 3;

                    rättSvar2 = 3;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.copenhagen;
                    lblquestion2.Text = "Vad heter Danmarks huvudstad?";

                    button4.Text = "Köpenhamn";
                    button4.Tag = 1;
                    button5.Text = "Pölse";
                    button5.Tag = 2;
                    button6.Text = "Århus";
                    button6.Tag = 3;

                    rättSvar2 = 1;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.reykavik;
                    lblquestion2.Text = "Vad heter Islands huvudstad?";

                    button4.Text = "Akureyri";
                    button4.Tag = 1;
                    button5.Text = "Reykjavik";
                    button5.Tag = 2;
                    button6.Text = "Vikinga";
                    button6.Tag = 3;

                    rättSvar2 = 2;
                    break;

            }

        }

        private void UpdateScoreLabel2()
        {
            lblscore2.Text = "Antal rätt: " + score2.ToString();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            score2 = 0;
            UpdateScoreLabel2();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            UpdateScoreLabel2();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
