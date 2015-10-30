using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeTeerling
{
    public partial class teerlingview : UserControl
    {
        TeerlingController _controller;
        

        public teerlingview(TeerlingController controller)
        {
            InitializeComponent();
            _controller = controller;
            
        }

        private void teerlingview_Load(object sender, EventArgs e)
        {

        }

        private void wepButton_Click(object sender, EventArgs e)
        {
            //Random random = new Random();
            //int nieuwGetal = random.Next(1, 7);
            //teerlingLabel.Text = nieuwGetal.ToString();
            _controller.werpTeerling();            
        }

        public void changeLabelNumber()
        {
            teerlingLabel.Text = _controller._model.AantalOgen.ToString();
        }

        private void teerlingLabel_Click(object sender, EventArgs e)
        {
            _controller.toggleTeerling();
           // wepButton.Enabled = _controller._model.TeerlingIsStuck;
            teerlingLabel.BackColor = _controller._model.Kleur;
           
        }
    }
}
