using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.LinkLabel;

namespace cookieclicker
{
    public partial class Form1 : Form
    {

        public int cookies = 0;
        public int purchases = 0;
        public int perclick = 1;
        public int price = 50;
        public int lvl = 1;
        public int lvlrq = 50;
        public bool loop = false;
        public string savetest = "false";
        public string[] savearray = [];
        

        public Form1()
        {
            InitializeComponent();
            try
            {
                savearray = File.ReadAllLines("save.txt");
                savetest = savearray[0];
            }
            catch (Exception)
            {
                ///////
            }

            if (savetest == "true")
            {
                cookies = Int32.Parse(savearray[1]);
                purchases = Int32.Parse(savearray[2]);
                perclick = Int32.Parse(savearray[3]);
                price = Int32.Parse(savearray[4]);
                lvl = Int32.Parse(savearray[5]);
                lvlrq = Int32.Parse(savearray[6]);
                MessageBox.Show("Save loaded.");
            }
            else
            {
                MessageBox.Show("Save file is corrupted or this is your first time playing.");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cookies += perclick;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            purchases += 1;
            perclick += lvl;
            cookies -= price;
        }

        private void updateLoop_Tick(object sender, EventArgs e)
        {
            richTextBox1.Text = $"{cookies.ToString()} cookies ({perclick} per click)";
            button2.Text = $"+{lvl.ToString()} cookies per click for {price} cookies";
            if (cookies < price)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
            richTextBox2.Text = $"{purchases}/{lvlrq}";


            ////////////////////////////////////////////////////////////////
            if (purchases > lvlrq)
            {
                lvl *= 10;
                lvlrq *= 10;
                price *= 10;
                purchases = 0;
            }
            else if (purchases == lvlrq)
            {
                lvl *= 10;
                lvlrq *= 10;
                price *= 10;
                purchases = 0;
            }


        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            loop = true;

            while (loop == true)
            {
                if (cookies < price)
                {
                    loop = false;
                }
                else
                {
                    purchases += 1;
                    perclick += lvl;
                    cookies -= price;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] savestring = ["true", cookies.ToString(), purchases.ToString(), perclick.ToString(), price.ToString(), lvl.ToString(), lvlrq.ToString()];

            File.WriteAllLines("save.txt", savestring);

            MessageBox.Show("Game Saved.");
            Application.Exit();
        }



    }
}

