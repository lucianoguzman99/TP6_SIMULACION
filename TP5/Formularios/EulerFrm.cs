using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5.Formularios
{
    public partial class EulerFrm : Form
    {
        //Variables
        private double k=100;
        private double h = 0.1;
        private double t;
        private double tAnterior;
        private double p;
        double pAnterior;
        private double aux;
        private Random random = new Random();
        private DataTable dataTable;


        public EulerFrm(double k)
        {
            this.k = k;
            //this.h = h;
            InitializeComponent();
        }

        private void EulerFrm_Load(object sender, EventArgs e)
        {
          
        }

        public void GenerarDT()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("t");
            dataTable.Columns.Add("P");
            dataTable.Columns.Add("dP/dt");
            dataTable.Columns.Add("t(i+1)");
            dataTable.Columns.Add("P(i+1)");
        }
        public void GenerarEuler()
        {
            GenerarDT();
            t = 0;
            tAnterior = 0;
            p = 0;
            pAnterior = 0;
            double euler = 0;
            Object[] filaEuler;
            filaEuler = new Object[5];

            
            if (100 <= k && k < 200)
            {
                aux = 100;
            }
            else if (200 <= k && k <= 300)
            {
                aux = 200;
            }
            else
            {
                aux = 300;
            }

            while (pAnterior <= aux)
            {
                filaEuler[0] = tAnterior;
                filaEuler[1] = pAnterior;
                filaEuler[2] = euler;
                filaEuler[3] = t;
                filaEuler[4] = p + h * euler;

                tAnterior = t;
                pAnterior = p;
                //Console.WriteLine("{0:0.###}\t {1:0.###}\t {2:0.###} {3:0.###}\t {4:0.###}", t, p, euler, t + h, p + h * euler);
                euler = aux / 5;
                t = t + h;
                p = p + h * euler;

                dataTable.Rows.Add(filaEuler);
            }

            dgvEuler.DataSource = dataTable;


        }
    }
}
