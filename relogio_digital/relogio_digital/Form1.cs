using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace relogio_digital
{
    public partial class Form1 : Form
    {
        private int horas {  get; set; }
        private int minutos { get; set; }
        private int segundos { get; set; }

        public Form1()
        {
            InitializeComponent();

            horas = DateTime.Now.Hour;
            minutos = DateTime.Now.Minute;
            segundos = DateTime.Now.Second;

            LBLHORAS.Text = Convert.ToString(horas);
            LBLMINUTOS.Text = Convert.ToString(minutos);
            LBLSEGUNDOS.Text = Convert.ToString(segundos);

        }

        private void timer_Tick(object sender, EventArgs e)
        {
           if(segundos == 59)
           {
                segundos = 0;

                if(minutos == 59)
                {
                    minutos = 0;

                    if (horas == 23)
                    {
                        horas = 0;
                    }
                    else
                    {
                        horas++;
                    }
                }
                else
                {
                    minutos++;
                }
           }
           else
           {
                segundos++;

                LBLHORAS.Text = Convert.ToString(horas).PadLeft(2, '0');
                LBLMINUTOS.Text = Convert.ToString(minutos).PadLeft(2, '0');
                LBLSEGUNDOS.Text = Convert.ToString(segundos).PadLeft(2, '0');
            }
        }
    }
}
