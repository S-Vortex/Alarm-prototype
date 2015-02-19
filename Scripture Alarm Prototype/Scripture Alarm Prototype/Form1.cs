using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scripture_Alarm_Prototype
{
    public partial class Form1 : Form
    {
        public String passage = "trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
        public String passageTitle = "Proverbs 3: 5-6";
        public String[] words;
        public String[] wordsWithBlanks;
        public int len;
        public int[] flagList = new int[1];
        


        public Form1()
        {
            loadDefaultPassage();
            InitializeComponent();
            populate();
            label3.Text = passageTitle;
            int len = words.Length;
            TextBox[] textBoxes = new TextBox[len];
            Label[] labels = new Label[len];

            for (int i = 0; i < len; i++)
            {
                textBoxes[i] = new TextBox();
                textBoxes[i].Size = new Size(50, 15);

                labels[i] = new Label();
                labels[i].Text = words[i];
                labels[i].Size = new Size(50, 15);
            }
            int posx;
            int line = 0;
            for (int i = 0; i < len; i++)
            {
                posx = i%5;
                if(posx == 0){
                    line++;
                }
                if (flagList[i] == 1)
                {
                    textBoxes[i].Location = new Point(posx * 50, (line * 17));
                    panel2.Controls.Add(textBoxes[i]);
                }
                if (flagList[i] == 0)
                {
                    labels[i].Location = new Point(posx * 50, line * 17);
                    panel2.Controls.Add(labels[i]);
                }
            }
            panel2.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void populate()
        {
            TextBox texta = new TextBox();
            texta.Text = "For";
        }

        private void loadDefaultPassage()
        {
            words = this.passage.Split(' ');
            wordsWithBlanks = words;
            len = words.Length;
            int[] flagList2 = new int[len];
            flagList = flagList2;
            System.Random RandNum = new System.Random();
            int MyRandomNumber = RandNum.Next(0,4);

            for(int i = 0; i < len; i++){
                flagList[i] = 0;
            }

            for (int i = 0; i < len; i++)
            {
                int number = RandNum.Next(0, 4);
                if (number == 3)
                {
                    wordsWithBlanks[i] = "________";
                    flagList[i] = 1;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
