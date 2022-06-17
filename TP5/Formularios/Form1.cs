using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP5.Clases;

namespace TP5
{
    public partial class Form1 : Form
    {
        // Variables
        public int reloj_max; // X
        public int cantidad_iteracciones; // i iteracciones desde la hora j
        public double hora_desde ; // j
        public double llegada_personas;
        public double prob_pedido;
        public double prob_devolucion;
        public double prob_consulta;
        public double consulta_min;
        public double consulta_max;
        public double porc_retiran_biblo;
        public int tiempo_uso_instalacion ;
        public bool mostrar_columnas_estado = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Valida campos nulos o vacios
        private bool validar_campos()
        {
            if (string.IsNullOrEmpty(txt_tiempo_simular.Text) || string.IsNullOrEmpty(txt_consulta_min.Text) || string.IsNullOrEmpty(txt_consulta_max.Text) 
                || string.IsNullOrEmpty(txt_probabilidad_retirarse.Text) || string.IsNullOrEmpty(txt_tiempo_uso_instalacion.Text) || string.IsNullOrEmpty(txt_pedido.Text)
                || string.IsNullOrEmpty(txt_devolucion.Text) || string.IsNullOrEmpty(txt_consulta.Text) || string.IsNullOrEmpty(txt_desde_hora.Text) 
                || string.IsNullOrEmpty(txt_iteracciones.Text) || string.IsNullOrEmpty(txt_tiempo_llegadas.Text))
            {
                MessageBox.Show("Una de las entradas está vacía.");
                return false;
            }
            else
            {
                reloj_max = int.Parse(txt_tiempo_simular.Text);
                consulta_min = double.Parse(txt_consulta_min.Text);
                consulta_max = double.Parse(txt_consulta_max.Text);
                porc_retiran_biblo = double.Parse(txt_probabilidad_retirarse.Text) / 100;
                tiempo_uso_instalacion = int.Parse(txt_tiempo_uso_instalacion.Text);
                prob_pedido = double.Parse(txt_pedido.Text) / 100;
                prob_devolucion = double.Parse(txt_devolucion.Text) / 100;
                prob_consulta = double.Parse(txt_consulta.Text) / 100;
                hora_desde = int.Parse(txt_desde_hora.Text);
                cantidad_iteracciones = int.Parse(txt_iteracciones.Text);
                llegada_personas = double.Parse(txt_tiempo_llegadas.Text);

                if (!validar_probabilidades())
                {
                    MessageBox.Show("Las probabilidades no suman 100%.");
                    return false;
                }
                if (!validar_desde_hasta_consultas())
                {
                    return false;
                }
                return true;
            }
        }

        // Valida rangos de valores
        private bool validar_desde_hasta_consultas()
        {
            if (consulta_min > reloj_max)
            {
                MessageBox.Show("El tiempo mínimo de consulta no puede ser mayor al tiempo a simular.");
                return false;
            }
            if (consulta_max < consulta_min)
            {
                MessageBox.Show("El tiempo máximo de consulta no puede ser menor al tiempo mínimo.");
                return false;
            }
            if (consulta_max > reloj_max)
            {
                MessageBox.Show("El tiempo máximo de consulta no puede ser mayor al tiempo a simular.");
                return false;
            }
            if (hora_desde > reloj_max)
            {
                MessageBox.Show("El tiempo 'desde' de consulta no puede ser mayor al tiempo a simular.");
                return false;
            }
            return true;
        }

        // Valida que las probabilidades sean 100%
        private bool validar_probabilidades()
        {
            double suma_prob = prob_pedido + prob_devolucion + prob_consulta;
            if (suma_prob == 1)
            {
                return true;
            } else
            {
                return false;
            }
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {            
            if (validar_campos())
            {
                Simulacion simulacion = new Simulacion(this);
                DataTable dt = simulacion.generar_simulacion();
                DataTable dt2 = new DataTable();                   
                int fila = 0;
                // Importa las columnas del DataTable Original
                foreach (DataColumn dataColumn in dt.Columns)
                {
                    dt2.Columns.Add(dataColumn.ColumnName);
                }

                // Obtiene las filas que no hay que filtrar (fila filtrada = no aparece)
                foreach (DataRow row in dt.Rows)
                {
                    if (double.Parse(row[2].ToString()) >= hora_desde)
                    {
                        fila = int.Parse(row[0].ToString());
                        break;
                    }                    
                }

                // Importa solo las filas no filtradas (fila filtrada = no aparece)
                for (int i = fila; i < fila + cantidad_iteracciones; i++)
                {
                    if (i < dt.Rows.Count-1)
                    {
                        dt2.ImportRow(dt.Rows[i]);
                    }                    
                }

                // Importa la ultima fila
                DataRow dr = dt.Rows[dt.Rows.Count - 1];
                dt2.ImportRow(dr);

                // i = Filas, j = Columnas
                int cantidad_columnas = dt2.Columns.Count;
                int cantidad_filas = dt2.Rows.Count;
                List<int> columnas_a_eliminar = new List<int>();
                for (int j = 16; j < cantidad_columnas; j++)
                {
                    bool eliminar_columna = true;
                    string nombre_columna = dt2.Columns[j].ColumnName;
                    for (int i = 0; i < cantidad_filas; i++)
                    {
                        if (!string.IsNullOrEmpty(dt2.Rows[i][nombre_columna].ToString()))
                        {
                            eliminar_columna = false;
                        }
                        
                    }

                   // if (eliminar_columna)
                    //{
                     //   columnas_a_eliminar.Add(j);
                   // }
                }

                // Se eliminan las columnas de la lista. Se hace un reverse primero asi se eliminan de atras para delante y no modifica los indices de los que estan adelante
                columnas_a_eliminar.Reverse();
                columnas_a_eliminar.ForEach(index => dt2.Columns.RemoveAt(index));

                double promedio = 0;
                double tiempoPromedio = double.Parse(dr[15].ToString());
                double contadorAtencion = double.Parse(dr[14].ToString());

                if (dr[11].ToString() == "Ocupado" )
                {
                    contadorAtencion += 1;                    
                }
                if (dr[12].ToString() == "Ocupado")
                {
                    contadorAtencion += 1;
                }

                promedio = tiempoPromedio / contadorAtencion;

                label_resultado_promedio.Text = (Math.Truncate(promedio * 100) / 100).ToString();

                dgv_simulacion.DataSource = dt2;
            } 
        }

        private void checkbox_columnas_CheckedChanged(object sender, EventArgs e)
        {
            this.mostrar_columnas_estado = !this.mostrar_columnas_estado;
        }
    }
}
