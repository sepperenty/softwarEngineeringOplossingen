using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class YahtzeeModel
    {

        int _AantalWorpen;
        int _HighScore;
        int _HuidigeScore;
        int _MaxAantalWopren = 3;
        bool _TrowEn = true;
        bool _resetEn = false;
        

        public bool TrowEn
        {
            get { return _TrowEn; }
            set { _TrowEn = value; }
        }

        public bool ResetEn
        {
            get { return _resetEn; }
            set { _resetEn = value; }
        }

        public int AantalWorpen
        {
            get { return _AantalWorpen; }
            set { _AantalWorpen = value; }
        }

        public int HighScore
        {
            get { return _HighScore; }
            set { _HighScore = value; }
        }

        public int HuidigeScore
        {
            get { return _HuidigeScore; }
            set { _HuidigeScore = value; }
        }

        public int MaxAantalWorpen
        {
            get { return _MaxAantalWopren; }
            set { _MaxAantalWopren = value; }
        }
 
    }
}
