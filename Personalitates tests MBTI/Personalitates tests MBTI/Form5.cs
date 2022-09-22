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
    public partial class Form5 : Form
    {
        string[] jautajumi3 = new string[]
        {
            "Vai tu vairāk uzticies sirdij vai prātam?",
            "Vai tu domā ka pasaule būtu labāka ja cilvēki domātu racionāli?",
            "Vai tu strādātu kopā ar cilvēku pat ja zinātu, ka viņi nav tik spējīgi cik tu?"
        };
        string[] pozitivi3 = new string[]
        {
            "Prātam",
            "Jā",
            "Nestrādātu"
        };
        string[] negativi3 = new string[]
        {
            "Sirdij",
            "Nē",
            "Strādātu"
        };
        int seciba = 0;
        int skaits = 1;
        int jautskaits = 6;
        public static string personalitate3;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = jautajumi3[seciba];
            butJā.Text = pozitivi3[seciba];
            butNē.Text = negativi3[seciba];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butJā_Click(object sender, EventArgs e)
        {
            skaits = skaits + 1;
            seciba = seciba + 1;
            if (skaits >= 2)
            {
                personalitate3 = "T";
            }
            else if (skaits <= 0)
            {
                personalitate3 = "F";
            }
            if (seciba < 3)
            {
                label1.Text = jautajumi3[seciba];
                butJā.Text = pozitivi3[seciba];
                butNē.Text = negativi3[seciba];
                labelJautSkaits.Text = (jautskaits = jautskaits + 1) + ". no 12 jautājumiem";
            }
            else
            {
                skaits = 1;
                this.Hide();
                Form6 jautajumi4 = new Form6();
                jautajumi4.Show();
            }
        }

        private void butNē_Click(object sender, EventArgs e)
        {
            skaits = skaits - 1;
            seciba = seciba + 1;
            if (skaits >= 2)
            {
                personalitate3 = "T";
            }
            else if (skaits <= 0)
            {
                personalitate3 = "F";
            }
            if (seciba < 3)
            {
                label1.Text = jautajumi3[seciba];
                butJā.Text = pozitivi3[seciba];
                butNē.Text = negativi3[seciba];
                labelJautSkaits.Text = (jautskaits = jautskaits + 1) + ". no 12 jautājumiem";
            }
            else
            {
                skaits = 1;
                this.Hide();
                Form6 jautajumi4 = new Form6();
                jautajumi4.Show();
            }
        }

        private void labelJautSkaits_Click(object sender, EventArgs e)
        {

        }
    }
}
