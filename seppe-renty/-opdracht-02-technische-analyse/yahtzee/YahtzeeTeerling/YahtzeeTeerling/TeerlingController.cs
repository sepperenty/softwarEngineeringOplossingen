using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace YahtzeeTeerling
{
   public class TeerlingController
    {
      public teerlingview _vieuw;
      public TeerlingModel _model;
      static int seeder = 0;
      Random _random = new Random(++seeder);


        public TeerlingController()
        {
           _vieuw = new teerlingview(this);
            _model = new TeerlingModel();
        }

        public void werpTeerling()
        {
            if (_model.TeerlingIsStuck)
            {
                //Random random = new Random();
                int nieuwGetal = _random.Next(1, 7);
                _model.AantalOgen = nieuwGetal;
                _vieuw.changeLabelNumber();
                
            }
        }

        public void toggleTeerling()
        {
            if(_model.TeerlingIsStuck)
            {
                _model.TeerlingIsStuck = false;
                _model.Kleur = Color.Red;
                _model.AantalOgen = 0;
            }

            else
            {
                _model.TeerlingIsStuck = true;
                
                _model.Kleur = Color.White;
            }
        }


        public teerlingview getVieuw()
        {
            return _vieuw;
        }
    }
}
