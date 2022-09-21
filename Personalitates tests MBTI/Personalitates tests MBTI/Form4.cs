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
    public partial class Form4 : Form
    {
        string[] jautajumi2 = new string[]
            {
            "Vai tev patīk filmas ar skaidri saprotamām beigām vai ar beigām, kur vajadzīga paša interpretācija?",
            "Kādas ir tavas domas par mākslu?",
            "Vai tev ir interese filozofiskos tematos?"
            };
        string[] pozitivi2 = new string[]
            {
            "Saprotamām",
            "Tā ir garlaicīga",
            "Nē"
            };
        string[] negativi2 = new string[]
            {
            "Ar paša interpretāciju",
            "Tā ir interesanta",
            "Jā"
            };
        int seciba = 0;
        int skaits = 1;
        int jautskaits = 3;
        public static string personalitate2;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = jautajumi2[seciba];
            butJā.Text = pozitivi2[seciba];
            butNē.Text = negativi2[seciba];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void butJā_Click(object sender, EventArgs e)
        {
            skaits = skaits + 1;
            seciba = seciba + 1;
            if (skaits >= 2)
            {
                personalitate2 = "S";
            }
            else if (skaits <= 0)
            {
                personalitate2 = "N";
            }
            if (seciba < 3)
            {
                label1.Text = jautajumi2[seciba];
                butJā.Text = pozitivi2[seciba];
                butNē.Text = negativi2[seciba];
                labelJautSkaits.Text = (jautskaits = jautskaits + 1) + ". no 12 jautājumiem";
            }
            else
            {
                skaits = 1;
                this.Hide();
                Form5 jautajumi3 = new Form5();
                jautajumi3.Show();
            }
        }

        private void butNē_Click(object sender, EventArgs e)
        {
            skaits = skaits - 1;
            seciba = seciba + 1;
            if (skaits >= 2)
            {
                personalitate2 = "S";
            }
            else if (skaits <= 0)
            {
                personalitate2 = "N";
            }
            if (seciba < 3)
            {
                label1.Text = jautajumi2[seciba];
                butJā.Text = pozitivi2[seciba];
                butNē.Text = negativi2[seciba];
                labelJautSkaits.Text = (jautskaits = jautskaits + 1) + ". no 12 jautājumiem";
            }
            else
            {
                skaits = 1;
                this.Hide();
                Form5 jautajumi3 = new Form5();
                jautajumi3.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelJautSkaits_Click(object sender, EventArgs e)
        {

        }
    }
}
