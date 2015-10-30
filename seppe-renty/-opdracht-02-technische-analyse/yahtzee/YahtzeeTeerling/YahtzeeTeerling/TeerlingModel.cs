using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace YahtzeeTeerling
{
   public class TeerlingModel
    {
        int _aantalOgen;
        bool _teerlingIsStuck = true;
        Color _kleur = new Color();
        
        

        public int AantalOgen
        {
            get { return _aantalOgen; }

            set
            {
                _aantalOgen = value;
            }
        }


        public bool TeerlingIsStuck
        {
            get {
                return _teerlingIsStuck;
            }
            set
            {
                _teerlingIsStuck = value;
            }
        }

        public Color Kleur
        {
            get
            {
                return _kleur;
            }

            set
            {
                _kleur = value;
            }
        }




    }
}
