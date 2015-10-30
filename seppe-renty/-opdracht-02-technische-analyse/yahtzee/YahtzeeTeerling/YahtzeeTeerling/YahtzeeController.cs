using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace YahtzeeTeerling
{
    public class YahtzeeController
    {
       public YahtzeeModel model = new YahtzeeModel();
        public scoreBoard scoreBoardVieuw;

        public YahtzeeController()
        {
            scoreBoardVieuw = new scoreBoard(this);
        }

        public void trowAll(List<TeerlingController> teerlingen)
        {
             if (model.AantalWorpen < model.MaxAantalWorpen)
            {
                for (int teerlingNummer = 0; teerlingNummer < teerlingen.Count; ++teerlingNummer)
                {
                    TeerlingController huidigeTeerling = teerlingen[teerlingNummer];
                    huidigeTeerling.werpTeerling();
                }
                updateScore(teerlingen);

            }

            if (model.AantalWorpen == 3)
            {
                model.ResetEn = true;
                model.TrowEn = false;
            }
        }

        public scoreBoard getVieuw()
       {
                return scoreBoardVieuw;
        } 

        public void updateScore(List<TeerlingController> teerlingen)
        {
            for (int teerlingNummer = 0; teerlingNummer < teerlingen.Count; ++teerlingNummer)
            {
                TeerlingController huidigeTeerling = teerlingen[teerlingNummer];
                model.HuidigeScore = model.HuidigeScore + huidigeTeerling._model.AantalOgen;
            }
            model.AantalWorpen++;

            if (model.HighScore < model.HuidigeScore)
            {
                model.HighScore = model.HuidigeScore;
            }

            
        }

       

        public void reset()
        {

            model.ResetEn = false;
            model.TrowEn = true;
            model.HuidigeScore = 0;
            model.AantalWorpen = 0;
        

        }
    }
}
