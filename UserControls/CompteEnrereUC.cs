using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
    public partial class CompteEnrereUC : UserControl
    {
        public CompteEnrereUC()
        {
            InitializeComponent();
        }

        public bool tempsLimit = false;

        // Temps de 3 min
        public int contSeg = 00;
        public int contMin = 3;

        public string min, seg;


        private bool _iniciat;

        public bool Iniciat
        {
            get { return _iniciat; }
            set
            {
                _iniciat = value;
                
                if (_iniciat)
                {
                    timer.Interval = 1000;
                    timer.Start();
                }
            }
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            contSeg --;

            if (contSeg < 0 && contMin > 0)
            {
                contSeg = 59;
                contMin--;

            } 
            
            if (contMin == 0 && contSeg == 0)
            {
                tempsLimit = true;
                timer.Stop();
            }

            // Dues xifres
            min = $"{contMin:D2}";
            seg = $"{contSeg:D2}";

            lbMinuts.Text = min;
            lbSegons.Text = seg;
        }
    }
}
