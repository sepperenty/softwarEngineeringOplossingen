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
    public partial class scoreBoard : UserControl
    {
        YahtzeeController yahtzeeController;


        public scoreBoard()
        {
            InitializeComponent();
        }

        public scoreBoard(YahtzeeController controller)
        {
            yahtzeeController = controller;
        }

        private void scoreBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
