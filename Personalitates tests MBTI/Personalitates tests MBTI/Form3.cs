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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "Jūsu personalitātes tips ir: " + Form2.personalitate1 + Form4.personalitate2 + Form5.personalitate3 + Form6.personalitate4;
            if (label1.Text == "Jūsu personalitātes tips ir: ISTJ") label2.Text = "Jūs esat atbildīgs, sirsnīgs, analītisks, rezervēts, realistisks, sistemātisks. Cītīgi strādājošs un uzticams, ar skaidru un praktisku domāšanu.";
            else if (label1.Text == "Jūsu personalitātes tips ir: ISFJ") label2.Text = "Jūs esat jauks, saudzīgs, maigs, atbildīgs, pragmatisks, pilnīgs. Veltīts uzraudzītājs, kas izbauda palīdzēt citiem.";
            else if (label1.Text == "Jūsu personalitātes tips ir: INFJ") label2.Text = "Jūs esat idealistisks, organizēts, asprātīgs, uzticams, līdzjūtīgs, maigs. Meklē mieru un sabiedrību, izbauda intelektuālu stimulāciju.";
            else if (label1.Text == "Jūsu personalitātes tips ir: INTJ") label2.Text = "Jūs esat inovatīvs, patstāvīgs, stratēģisks, loģisks, atturīgs, asprātīgs. Vadīts pēc paša idejām lai iegūtu sasniegumus.";
            else if (label1.Text == "Jūsu personalitātes tips ir: ISTP") label2.Text = "Jūs esat orientēts uz darbību, loģisks, analītisks, patvaļīgs, atturīgs, patstāvīgs. Izbaudat piedzīvojumus, labi izprotāt kā strādā mehāniskas lietas.";
            else if (label1.Text == "Jūsu personalitātes tips ir: ISFP") label2.Text = "Jūs esat maigs, jūtīgs, ātrs apguvējs, noderīgs, ar elastīgiem plāniem, realistisks. Meklējat personīgu vidi, kas ir gan patīkama, gan praktiska.";
            else if (label1.Text == "Jūsu personalitātes tips ir: INFP") label2.Text = "Jūs esat jūtīgs, radošs, ideālistisks, acīgs, gādīgs, lojāls. Novertējat mentālo mieru un personsko izaugsmi, koncentrējaties uz saviem sapņiem un iespējām.";
            else if (label1.Text == "Jūsu personalitātes tips ir: INTP") label2.Text = "Jūs esat intelektuāls, loģisks, precīzs, atturīgs, ar elastīgiem plāniem, tēlains. Oriģināls domātājs, kas izbauda spekulēt un labot radošas problēmas";
            else if (label1.Text == "Jūsu personalitātes tips ir: ESTP") label2.Text = "Jūs esat aptvērts, realistiks, orientēts uz darbību, ziņkārīgs, daudzpusīgs, patvaļīgs. Labs problēmu labotājs un sarunu vedējs.";
            else if (label1.Text == "Jūsu personalitātes tips ir: ESFP") label2.Text = "Jūs esat jautrs/rotaļīgs, viegli sajūsmināts, draudzīgs, patvaļīgs, taktisks, ar elastīgiem plāniem. Piemīt labs veselais saprāts, izbaudat palīdzēt cilvēkiem dažādos veidos.";
            else if (label1.Text == "Jūsu personalitātes tips ir: ENFP") label2.Text = "Jūs esat viegli sajūsmināts, radošs, patvaļīgs, optimistisks, atbalstošs, jautrs/rotaļīgs. Novertējat iedvesmu, izbaudat sākt jaunus projektus, redziet potenciālu citos.";
            else if (label1.Text == "Jūsu personalitātes tips ir: ENTP") label2.Text = "Jūs esat atjautīgs, viegli sajūsmināts, stratēģisks, uzņēmīgs, zinātkārs, daudzpusīgs. Izbaudat jaunas idejas un izaicinājumus, novertējat iedvesmu.";
            else if (label1.Text == "Jūsu personalitātes tips ir: ESTJ") label2.Text = "Jūs esat prasmīgs, aptvērts, analītisks, sistemātisks, uzticams, realistisks. Izbaudat būt līderis un parādīt visiem, kā jādara lietas.";
            else if (label1.Text == "Jūsu personalitātes tips ir: ESFJ") label2.Text = "Jūs esat draudzīgs, aptvērts, drošs, rūpīgs, organizēts, praktisks. Cenšaties būt noderīgs, izbaudiet būt aktīvs un produktīvs.";
            else if (label1.Text == "Jūsu personalitātes tips ir: ENFJ") label2.Text = "Jūs esat gādīgs, viegli sajūsmināts, ideālistisks, organizēts, diplomātisks, atbildīgs. Esat prasmīgs runātājs, kas novērtē saikni ar cilvēkiem.";
            else if (label1.Text == "Jūsu personalitātes tips ir: ENTJ") label2.Text = "Jūs esat stratēģisks, loģisks, prasmīgs, aptvērts, ambiciozs, patvaļīgs. Esat prasmīgs cilvēku organizētājs un prasmīgs plānotājs.";
            else label2.Text = "Ir notikusi kļūda...";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void butPabeigt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
