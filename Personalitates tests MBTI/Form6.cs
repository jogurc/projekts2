using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personalitates_tests_2
{
    public partial class Form6 : Form
    {
        string[] jautajumi4 = new string[]
        {
            "Vai tev bieži mēdz būt rezerves plāns?",
            "Vai tu pabeidz darīt vienu lietu un tad ķeries pie nākamās, vai arī centies visu izdarīt reizē?",
            "Vai tev patīk organizēt grafikus, plānus vai citus veida sarakstus?"
        };
        string[] pozitivi4 = new string[]
        {
            "Jā",
            "Pabeigt vienu lietu",
            "Jā"
        };
        string[] negativi4 = new string[]
        {
            "Nē",
            "Darīt visu reizē",
            "Nē"
        };
        int seciba = 0;
        int skaits = 1;
        int jautskaits = 9;
        public static string personalitate4;
        public Form6()
        {
            InitializeComponent();
        }

        private void labelJautSkaits_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butJā_Click(object sender, EventArgs e)
        {
            {
                skaits = skaits + 1;
                seciba = seciba + 1;
                if (skaits >= 2)
                {
                    personalitate4 = "J";
                }
                else if (skaits <= 0)
                {
                    personalitate4 = "P";
                }
                if (seciba < 3)
                {
                    label1.Text = jautajumi4[seciba];
                    butJā.Text = pozitivi4[seciba];
                    butNē.Text = negativi4[seciba];
                    labelJautSkaits.Text = (jautskaits = jautskaits + 1) + ". no 12 jautājumiem";
                }
                else
                {
                    skaits = 1;
                    this.Hide();
                    Form3 label1 = new Form3();
                    label1.Show();
                }
            }
        }

        private void butNē_Click(object sender, EventArgs e)
        {
            {
                skaits = skaits - 1;
                seciba = seciba + 1;
                if (skaits >= 2)
                {
                    personalitate4 = "J";
                }
                else if (skaits <= 0)
                {
                    personalitate4 = "P";
                }
                if (seciba < 3)
                {
                    label1.Text = jautajumi4[seciba];
                    butJā.Text = pozitivi4[seciba];
                    butNē.Text = negativi4[seciba];
                    labelJautSkaits.Text = (jautskaits = jautskaits + 1) + ". no 12 jautājumiem";
                }
                else
                {
                    skaits = 1;
                    this.Hide();
                    Form3 label1 = new Form3();
                    label1.Show();
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label1.Text = jautajumi4[seciba];
            butJā.Text = pozitivi4[seciba];
            butNē.Text = negativi4[seciba];
        }
    }
}
