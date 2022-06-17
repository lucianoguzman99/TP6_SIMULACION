using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Clases
{
    class Empleado
    {
        public static string LIBRE = "Libre";

        public static string OCUPADO = "Ocupado";

        private string nombre;
        private string estado;
        private double fin_atencion;
        private Cliente cliente_atendiendo;

        public Empleado(string nombre)
        {
            this.nombre = nombre;
            this.estado = LIBRE;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public void setOcupado()
        {
            this.estado = OCUPADO;
        }

        public void setLibre()
        {
            this.estado = LIBRE;
        }

        public string getEstado()
        {
            return this.estado;
        }

        public void setFinAtencion(double value)
        {
            this.fin_atencion = value;
        }

        public double getFinAtencion()
        {
            return this.fin_atencion;
        }
        public void setClienteAtendiendo(Cliente value)
        {
            this.cliente_atendiendo = value;
        }

        public Cliente getClienteAtendiendo()
        {
            return cliente_atendiendo;
        }
    }
}
