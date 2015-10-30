using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeTeerling
{
    public partial class Yahtzee : Form
    {
        int aantalTeerlingen;
        List<TeerlingController> teerlingen;
        YahtzeeController yahtzeeController = new YahtzeeController();


        public Yahtzee()
        {
            InitializeComponent();
            aantalTeerlingen = 3;
            teerlingen = new List<TeerlingController>();
            
        }

        private void Yahtzee_Load(object sender, EventArgs e)
        {

            for (int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; ++teerlingNummer)
            {
                TeerlingController nieuweTeerling = new TeerlingController();

                teerlingen.Add(nieuweTeerling);
            }

            for (int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; ++teerlingNummer)
            {
                TeerlingController huidigeTeerling = teerlingen[teerlingNummer];
                teerlingview huidigeTeerlingVieuw = huidigeTeerling.getVieuw();
                int xPos = huidigeTeerlingVieuw.Width * teerlingNummer;
                huidigeTeerlingVieuw.Location = new Point(xPos, 0);
                Controls.Add(huidigeTeerlingVieuw);
            }

            int xPositie = 450;
            scoreBoard scoreBoardVieuw = new scoreBoard();
            scoreBoardVieuw.Location = new Point(1000, 500);
            Console.WriteLine(scoreBoardVieuw);
            Controls.Add(scoreBoardVieuw);


        }

        private void btnTrowAll_Click(object sender, EventArgs e)
        {
            
            yahtzeeController.trowAll(teerlingen);
            btnReset.Enabled = yahtzeeController.model.ResetEn;
            btnTrowAll.Enabled = yahtzeeController.model.TrowEn;
            lblHuidigeScore.Text = yahtzeeController.model.HuidigeScore.ToString();
            lblHuidigAantalWorpen.Text = yahtzeeController.model.AantalWorpen.ToString();
            lblHighScore.Text = yahtzeeController.model.HighScore.ToString();

        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            yahtzeeController.reset();
            btnReset.Enabled = yahtzeeController.model.ResetEn;
            btnTrowAll.Enabled = yahtzeeController.model.TrowEn;
            lblHuidigeScore.Text = yahtzeeController.model.HuidigeScore.ToString();
            lblHuidigAantalWorpen.Text = yahtzeeController.model.AantalWorpen.ToString();
        }
    }
}
