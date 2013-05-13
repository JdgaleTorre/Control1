using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control1
{
    public partial class Control1 : UserControl
    {

        private System.Drawing.Color ColFColor;
        private System.Drawing.Color ColBack;



        public Control1()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        protected void timer1_Tick(object sender, EventArgs e)
        {
            lblDisplay.Text = string.Format("HH:mm:ss", DateTime.Now);

        }


        //Declaramos la propiedad para el colFuente
        public System.Drawing.Color ColorFuente
        {
            get
            {
                return ColFColor;
            }
            set
            {
                ColFColor = value;
                lblDisplay.ForeColor = ColFColor;

            }


        }
    }

}
