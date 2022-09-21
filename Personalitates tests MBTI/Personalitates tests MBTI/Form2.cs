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
    public partial class Form2 : Form
    {
        string[] jautajumi = new string[]
        {
            "Vai tev ir viegli iegūt jaunus draugus?",
            "Cik daudz tu socializējies?",
            "Kādā cilvēku pulkā tu jūties ērtāk?"
        };
        string[] pozitivi = new string[]
        {
            "Jā",
            "Daudz",
            "Lielā"
        };
        string[] negativi = new string[]
        {
            "Nē",
            "Maz",
            "Mazā",
        };
        int seciba = 0;
        int skaits = 1;
        int jautskaits = 1;
        public static string personalitate1;
        public Form2()
        {
            InitializeComponent();
        }

        private void butJa_Load(object sender, EventArgs e)
        {
            label1.Text = jautajumi[seciba];
            butJā.Text = pozitivi[seciba];
            butNē.Text = negativi[seciba];
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
                personalitate1 = "E";
            }
            else if (skaits <= 0)
            {
                personalitate1 = "I";
            }
            if (seciba < 3)
            {
                label1.Text = jautajumi[seciba];
                butJā.Text = pozitivi[seciba];
                butNē.Text = negativi[seciba];
                labelJautSkaits.Text = (jautskaits = jautskaits + 1) + ". no 12 jautājumiem";
            }
            else
            {
                skaits = 1;
                this.Hide();
                Form4 jautajumi2 = new Form4();
                jautajumi2.Show();
            }
        }

        private void butNē_Click(object sender, EventArgs e)
        {
            skaits = skaits - 1;
            seciba = seciba + 1;
            if (skaits >= 2)
            {
                personalitate1 = "E";
            }
            else if (skaits <= 0)
            {
                personalitate1 = "I";
            }
            if (seciba < 3)
            {
                label1.Text = jautajumi[seciba];
                butJā.Text = pozitivi[seciba];
                butNē.Text = negativi[seciba];
                labelJautSkaits.Text = (jautskaits = jautskaits + 1) + ". no 12 jautājumiem";
            }
            else
            {
                skaits = 1;
                this.Hide();
                Form4 jautajumi2 = new Form4();
                jautajumi2.Show();
            }
        }

        private void labelJautSkaits_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
