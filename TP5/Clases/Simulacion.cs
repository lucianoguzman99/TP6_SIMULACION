using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Clases
{
    class Simulacion
    {
        private static int NUMERO_GRANDE = 999999999;
        private DataTable dataTable;
        private Random random = new Random();
        private Empleado empleado1 = new Empleado("E1");
        private Empleado empleado2 = new Empleado("E2");
        private Form1 formulario;
        private int maximo_simulacion = 100000;
        private int cont_personas_llegada = 0;
        private string evento = "";
        private double reloj = 0;
        private double proxima_llegada = 0;
        private double rnd_tipo_llegada = 0;
        private string tipo_llegada = "";
        private double rnd_tiempo_atencion = 0;
        private double tiempo_atencion = 0;
        private double tiempoAtencionPorCargarE1 = 0;
        private double tiempoAtencionPorCargarE2 = 0;
        private int cola = 0;
        private int contador_atencion = 0;
        private double tiempo_permanencia = 0;
        private string estado = "";
        private double rnd_permanencia = 0;
        private List<Cliente> clientes_llegaron_biblioteca = new List<Cliente>();
        private List<Cliente> clientes_permanencen_biblioteca = new List<Cliente>();
        private List<Cliente> clientes_en_cola = new List<Cliente>();
        private double prox_fin_uso_instalacion = 0;
        private Cliente prox_cliente_fin_uso_instalacion;
        private int cantidad_iteracciones = 0;
        private bool iteracciones_cumplidas = false;

        public Simulacion(Form1 formulario)
        {
            this.formulario = formulario;
        }

        // Genera columnas del DataTable
        private void generar_dt()
        {
            dataTable = new DataTable();

            dataTable.Columns.Add("i");
            dataTable.Columns.Add("Evento");
            dataTable.Columns.Add("Reloj");
            dataTable.Columns.Add("Proxima llegada");
            dataTable.Columns.Add("RND Tipo llegada");
            dataTable.Columns.Add("Tipo");
            dataTable.Columns.Add("RND Tiempo atencion");
            dataTable.Columns.Add("Tiempo atencion");
            dataTable.Columns.Add("Fin atencion(1)");
            dataTable.Columns.Add("Fin atencion(2)");
            dataTable.Columns.Add("RND Permanencia");
            dataTable.Columns.Add("Estado (E1)");
            dataTable.Columns.Add("Estado (E2)");
            dataTable.Columns.Add("Cola");
            dataTable.Columns.Add("Contador atencion");
            dataTable.Columns.Add("Tiempo permanencia");
        }

        // Determina si las iteracciones llegaron a las definidas en la vista. 
        // Ej: Si se muestra desde reloj = 10 | i = 4 y queremos ver las proximas X = 100, cuenta las iteracciones hasta llegar a i+X (4+100).
        private void calcular_iteraciones()
        {
            // Entra al condicional si el reloj es mayor a la hora desde y todavia no se llegaron a las i+X iteracciones
            // Si no entra, significa que todavia no se llegó a la hora desde, o que ya se cumplio el i+X
            if (reloj >= formulario.hora_desde && !iteracciones_cumplidas)
            {
                cantidad_iteracciones++;

                // Si las iteraciones llegaron a i+X, significa que cumplimos la cantidad de iteraciones y se actualiza dicha variable.
                if (cantidad_iteracciones == formulario.cantidad_iteracciones)
                {
                    iteracciones_cumplidas = true;
                }

            }
        }

        // Cargar filas de DataTable
        private void cargar_fila(int i)
        {
            Object[] variables_imprimir;

            // Si el reloj no llegó a la hora_desde que queremos mostrar O se cumplió con las X iteracciones que queríamos mostrar. Solamente generaremos 16 columnas (las principales).
            // Caso contrario, significa que estamos en el rango de la tabla que queremos ver las columnas estado de los clientes, por lo que generaremos Z columnas segun la cantidad 
            // de personas en la biblioteca
            if (reloj < formulario.hora_desde || iteracciones_cumplidas) {
                variables_imprimir = new Object[16];
            } else
            {
                agregar_columnas_persona(clientes_permanencen_biblioteca);
                int contador_columnas = dataTable.Columns.Count;
                variables_imprimir = new Object[contador_columnas];
            }

            variables_imprimir[0] = i;
            variables_imprimir[1] = evento;
            variables_imprimir[2] = reloj;
            variables_imprimir[3] = proxima_llegada;
            variables_imprimir[4] = rnd_tipo_llegada == 0 ? "" : rnd_tipo_llegada.ToString();
            variables_imprimir[5] = tipo_llegada;
            variables_imprimir[6] = rnd_tiempo_atencion == 0 ? "" : rnd_tiempo_atencion.ToString();
            variables_imprimir[7] = tiempo_atencion == 0 ? "" : tiempo_atencion.ToString();
            variables_imprimir[8] = empleado1.getFinAtencion() == 0 ? "" : empleado1.getFinAtencion().ToString();
            variables_imprimir[9] = empleado2.getFinAtencion() == 0 ? "" : empleado2.getFinAtencion().ToString();
            variables_imprimir[10] = rnd_permanencia == 0 ? "" : rnd_permanencia.ToString();
            variables_imprimir[11] = empleado1.getEstado();
            variables_imprimir[12] = empleado2.getEstado();
            variables_imprimir[13] = cola;
            variables_imprimir[14] = contador_atencion;
            variables_imprimir[15] = redondear(tiempo_permanencia);

            // Si no estamos dentro del rango (hora_desde y X iteraciones) definido en los paramétros | No genere las columnas de la ultima fila | Validacion desde formulario (checkbox)
            if (!iteracciones_cumplidas && reloj > formulario.hora_desde && reloj != formulario.reloj_max && i != maximo_simulacion && formulario.mostrar_columnas_estado)
            {
                // Bucle para saber cuantas columnas mas agregar
                int j = 16;
                for (int k = 0; k < clientes_permanencen_biblioteca.Count; k++)
                {
                    Cliente cliente = clientes_permanencen_biblioteca[k];
                    if (cliente.getEnInstalacion())
                    {
                        variables_imprimir[j] = cliente.getEstado();
                        j++;
                        variables_imprimir[j] = cliente.getHs_llegada();
                        j++;
                        variables_imprimir[j] = cliente.getFin_uso_instalacion();
                        j++;
                        variables_imprimir[j] = cliente.getAccion();
                        j++;
                    }
                    else
                    {
                        j++;
                        j++;
                        j++;
                        j++;
                    }
                }
            }
            

            dataTable.Rows.Add(variables_imprimir);
        }

        public DataTable generar_simulacion()
        {
            generar_dt();
            proxima_llegada = formulario.llegada_personas;

            for (int i = 0; i < maximo_simulacion; i++)
            {
                calcular_iteraciones();

                if (i != 0 && reloj % formulario.llegada_personas == 0)
                {
                    proxima_llegada = calcular_proxima_llegada(proxima_llegada);
                }

                if (evento == "Llegada")
                {
                    simular_llegada(null);
                }
                else if (evento == "Fin uso instalación")
                {
                    simular_fin_uso_instalacion();

                } else
                {
                    simular_fin_atencion();
                }

                cargar_fila(i);

                prox_fin_uso_instalacion = proximo_fin_uso_instalacion();
                reloj = salto_reloj(proxima_llegada, empleado1.getFinAtencion(), empleado2.getFinAtencion(), prox_fin_uso_instalacion);
                evento = calcular_evento(reloj, proxima_llegada, empleado1.getFinAtencion(), empleado2.getFinAtencion(), prox_fin_uso_instalacion);
                rnd_tipo_llegada = 0;
                tipo_llegada = "";
                rnd_tiempo_atencion = 0;
                tiempo_atencion = 0;
                rnd_permanencia = 0;

                if (reloj > formulario.reloj_max)
                {
                    i = maximo_simulacion;
                }
            }
            return dataTable;
        }

        private void simular_llegada(Cliente cliente)
        {
            Cliente cliente_iteraccion;
            if (cliente == null)
            {
                // Incrementa la cantidad de personas que llegaron para asignarle el nro al nombre
                cont_personas_llegada++;

                // Establece a que vino el cliente
                rnd_tipo_llegada = redondear(random.NextDouble());
                tipo_llegada = calcular_tipo_llegada(rnd_tipo_llegada);

                // Se crea el cliente
                cliente_iteraccion = new Cliente(cont_personas_llegada, reloj, tipo_llegada);

                // Agrega una instancia de cliente dentro de la lista de clientes en la biblioteca.
                clientes_llegaron_biblioteca.Add(cliente_iteraccion);
            } else
            {
                cliente_iteraccion = cliente;
            }

            if (empleado1.getEstado().Equals(Empleado.LIBRE))
            {
                atencion_empleado(empleado1, cliente_iteraccion);
            } else if (empleado2.getEstado().Equals(Empleado.LIBRE))
            {
                atencion_empleado(empleado2, cliente_iteraccion);
            } else
            {
                cola++;
                estado = "En espera";
                clientes_llegaron_biblioteca.Find(cli => cli.Equals(cliente_iteraccion)).setEstado(estado);
                clientes_en_cola.Add(cliente_iteraccion);
            }

            // Se agrega el cliente a la lista de clientes que permanencen en la biblioteca
            if (clientes_permanencen_biblioteca.Find(cli => cli.Equals(cliente_iteraccion)) == null)
            {
                clientes_permanencen_biblioteca.Add(cliente_iteraccion);
            }
        }

        private void simular_fin_atencion()
        {
            if (empleado1.getEstado().Equals(Empleado.OCUPADO) && evento.Equals("Fin atencion E1"))
            {
                liberar_empleado(empleado1);
                if (cola > 0)
                {
                    atender_cliente_cola(empleado1);
                }
            }
            if (empleado2.getEstado().Equals(Empleado.OCUPADO) && evento.Equals("Fin atencion E2"))
            {
                liberar_empleado(empleado2);
                if (cola > 0)
                {
                    atender_cliente_cola(empleado2);
                }
            }
        }

        private void atencion_empleado(Empleado empleado, Cliente cliente)
        {
            // Se setea ocupado
            empleado.setOcupado();

            // Asignar cliente a empleado
            empleado.setClienteAtendiendo(cliente);

            // Establecer estado a cliente
            string empleadoCliente = empleado.getNombre();
            estado = "SA " + empleadoCliente;
            clientes_llegaron_biblioteca.Find(cli => cli.Equals(cliente)).setEstado(estado);


            // Calcular tiempo de atencion
            rnd_tiempo_atencion = redondear(random.NextDouble());
            tipo_llegada = clientes_llegaron_biblioteca.Find(cli => cli.Equals(cliente)).getAccion();
            tiempo_atencion = calcular_tiempo_atencion(tipo_llegada, rnd_tiempo_atencion);

            // Setear fin de atencion a empleado
            empleado.setFinAtencion(calcular_fin_atencion(reloj, tiempo_atencion));

            // Acumular tiempo de permanencia a cargar en fin de uso
            acumTiempoPorCargar(tiempo_atencion, empleadoCliente);
        }

        private void acumTiempoPorCargar(double tiempo_atencion, string empleado )
        {
            //acum por empleado
            if (empleado == "E1") {
                tiempoAtencionPorCargarE1 += tiempo_atencion;
            } else
            {
                tiempoAtencionPorCargarE2 += tiempo_atencion;
            }
        }

        private void liberar_empleado(Empleado empleado)
        {
            // Obtiene el empleado actual a liberar
            string empleadoALiberar = empleado.getNombre();

            // Obtiene el cliente atendido
            Cliente cliente_atendido = empleado.getClienteAtendiendo();

            // Establece si el cliente usará la instalacion (en el caso de pedir libro)
            calcular_cliente_usa_instalacion(cliente_atendido);

            // Incrementar acumulador de atencion
            contador_atencion++;

            // Se libera el empleado y se limpia el atributo fin atencion
            empleado.setLibre();
            empleado.setFinAtencion(0);

            // Validar que empleado atendio el cliente y sumar el tiempo de permanencia correspondiente
            acumTiempoPermanencia(empleadoALiberar);
        }

        private void acumTiempoPermanencia(string empleado)
        {
            if (empleado == "E1")
            {
                tiempo_permanencia += tiempoAtencionPorCargarE1;
                tiempoAtencionPorCargarE1 = 0;
            }
            else
            {
                tiempo_permanencia += tiempoAtencionPorCargarE2;
                tiempoAtencionPorCargarE2 = 0;
            }
        }

        private void simular_fin_uso_instalacion()
        {
 
            prox_cliente_fin_uso_instalacion.setHs_llegada(reloj.ToString());
            prox_cliente_fin_uso_instalacion.setFin_uso_instalacion("");
            prox_cliente_fin_uso_instalacion.setAccion("Devolucion");
            simular_llegada(prox_cliente_fin_uso_instalacion);
            prox_cliente_fin_uso_instalacion = null;
        }

        private void atender_cliente_cola(Empleado empleado)
        {
            // Obtiene el cliente primero en la cola
            Cliente cliente_decola = clientes_en_cola[0];

            // Calcula el tiempo en cola
            tiempo_permanencia += reloj - double.Parse(cliente_decola.getHs_llegada());

            // Lo tiene que atender el empleado
            atencion_empleado(empleado, cliente_decola);

            // Se reduce el tamaño de la cola, y se elimina el cliente que esta siendo atendido
            cola--;
            clientes_en_cola.Remove(cliente_decola);
        }

       
        private void calcular_cliente_usa_instalacion(Cliente cliente)
        {
            if (cliente.getAccion().Equals("Pedido") && !cliente.getPidioLibro() && (cliente.getEstado() == "SA E1" || cliente.getEstado() == "SA E2")) 
            {
                // Significa que el cliente hizo un pedido y se realiza el random para determinar si se queda.
                rnd_permanencia = redondear(random.NextDouble());
                if (calcular_probabilidad_permanencia(rnd_permanencia))
                {
                    clientes_llegaron_biblioteca.Find(cli => cli.Equals(cliente)).setEstado(Cliente.LEYENDO);
                    clientes_llegaron_biblioteca.Find(cli => cli.Equals(cliente)).setFin_uso_instalacion((reloj + formulario.tiempo_uso_instalacion).ToString());
                    cliente.setPidioLibro(true);
                    // verificar si influye en la carga del 
                    tiempo_permanencia += formulario.tiempo_uso_instalacion;
                }
                else
                {
                    // El cliente no se queda a leer. Se elimina de la lista de clientes que permanencen en biblioteca
                    cliente.salio_instalacion();
                }
            }
            else
            {
                // El cliente fue a devolver o consultar. Se elimina de la lista de clientes que permanencen en biblioteca
                cliente.salio_instalacion();
            }
        }
 
        private void agregar_columnas_persona(List<Cliente> clientes)
        {
            if (formulario.mostrar_columnas_estado)
            {
                foreach (Cliente cliente in clientes)
                {
                    string persona = cliente.getNombre();
                    if (!dataTable.Columns.Contains("Estado (" + persona + ")"))
                    {
                        DataColumn column_estado = new DataColumn("Estado (" + persona + ")");
                        dataTable.Columns.Add(column_estado);
                    }
                    if (!dataTable.Columns.Contains("Estado (" + persona + ")"))
                    {
                        DataColumn column_estado = new DataColumn("Estado (" + persona + ")");
                        dataTable.Columns.Add(column_estado);
                    }
                    if (!dataTable.Columns.Contains("Estado (" + persona + ")"))
                    {
                        DataColumn column_estado = new DataColumn("Estado (" + persona + ")");
                        dataTable.Columns.Add(column_estado);
                    }
                    if (!dataTable.Columns.Contains("Estado (" + persona + ")"))
                    {
                        DataColumn column_estado = new DataColumn("Estado (" + persona + ")");
                        dataTable.Columns.Add(column_estado);
                    }
                    if (!dataTable.Columns.Contains("Estado (" + persona + ")"))
                    {
                        DataColumn column_estado = new DataColumn("Estado (" + persona + ")");
                        dataTable.Columns.Add(column_estado);
                    }



                    if (!dataTable.Columns.Contains("Hs llegada (" + persona + ")"))
                    {
                        DataColumn column_hs_llegada = new DataColumn("Hs llegada (" + persona + ")");
                        dataTable.Columns.Add(column_hs_llegada);
                    }

                    if (!dataTable.Columns.Contains("Fin uso instalacion (" + persona + ")"))
                    {
                        DataColumn column_fin_uso_inst = new DataColumn("Fin uso instalacion (" + persona + ")");
                        dataTable.Columns.Add(column_fin_uso_inst);

                    }

                    if (!dataTable.Columns.Contains("Accion (" + persona + ")"))
                    {
                        DataColumn column_accion = new DataColumn("Accion (" + persona + ")");
                        dataTable.Columns.Add(column_accion);
                    }
                }
            }
        }

        private double proximo_fin_uso_instalacion()
        {
            double min = NUMERO_GRANDE;
            foreach (Cliente cliente in clientes_permanencen_biblioteca) {
                if (cliente.getFin_uso_instalacion() != null && cliente.getFin_uso_instalacion() != "" && double.Parse(cliente.getFin_uso_instalacion()) < min)
                {
                    min = double.Parse(cliente.getFin_uso_instalacion());
                    prox_cliente_fin_uso_instalacion = cliente;
                }
            }
            return min;
        }

        private double salto_reloj(double proxima_llegada, double fin_atencion1, double fin_atencion2, double fin_uso_instalacion)
        {
            // Calcula cual será el proximo salto que hará el reloj. Siempre debe saltar al evento más proximo.
            fin_atencion1 = fin_atencion1 == 0 ? NUMERO_GRANDE : fin_atencion1;
            fin_atencion2 = fin_atencion2 == 0 ? NUMERO_GRANDE : fin_atencion2;
            fin_uso_instalacion = fin_uso_instalacion == 0 ? NUMERO_GRANDE : fin_uso_instalacion;
            return Math.Min(proxima_llegada, Math.Min(fin_uso_instalacion, Math.Min(fin_atencion1, fin_atencion2)));
        }

        private string calcular_evento(double proximo_reloj, double proxima_llegada, double fin_atencion1, double fin_atencion2, double fin_uso_instalacion)
        {
            string proximo_evento = "";
            if (proximo_reloj == proxima_llegada)
            {
                proximo_evento = "Llegada";
            }
            if (proximo_reloj == fin_atencion1)
            {
                proximo_evento = "Fin atencion E1";
            }
            if (proximo_reloj == fin_atencion2)
            {
                proximo_evento = "Fin atencion E2";
            }
            if (proximo_reloj == fin_uso_instalacion)
            {
                proximo_evento = "Fin uso instalación";
            }
            return proximo_evento;
        }

        private double calcular_proxima_llegada(double proxima_llegada)
        {
            return proxima_llegada + formulario.llegada_personas;
        }

        private string calcular_tipo_llegada(double random_tipo_llegada)
        {
            // Evento	    P()	    P(ac)
            // Pedido       0,45    0,45
            // Devolocion   0,45    0,9
            // Consulta     0,1     1
            random_tipo_llegada = random_tipo_llegada == 0 ? 0.01 : random_tipo_llegada;
            if (random_tipo_llegada >= 0 && random_tipo_llegada <= formulario.prob_pedido)
            {
                return "Pedido";
            }
            else if (random_tipo_llegada >= formulario.prob_pedido + 0.01 && random_tipo_llegada <= formulario.prob_pedido + formulario.prob_devolucion)
            {
                return "Devolucion";
            }
            else
            {
                return "Consulta";
            }
        }

        private double calcular_tiempo_atencion(string tipo_atencion, double random)
        {
            // Depende del tipo de atencion
            // Pedido -> EXP-(6)  | Siempre es 6        | LN(1-RND)/(-LAMBDA)
            // Consulta -> U(2;5) | a y b pueden variar | (b-a)*RND+a
            // Devolucion -> U(1.5;2.5) | a y b fijos   | (b-a)*RND+a
            double tiempo_atencion_calculado = 0;
            switch (tipo_atencion)
            {
                case "Pedido":
                    tiempo_atencion_calculado = atencion_pedido(random);
                    break;
                case "Devolucion":
                    tiempo_atencion_calculado = atencion_devolucion(random);
                    break;
                case "Consulta":
                    tiempo_atencion_calculado = atencion_consulta(random);
                    break;
            }

            return redondear(tiempo_atencion_calculado);
        }

        // lo llama calcular_tiempo_atencion()
        private double atencion_pedido(double random)
        {
            // Pedido -> EXP-(6)  | Siempre es 6 | LN(1-RND)/(-LAMBDA)
            double lambda = 0.1666666667;
            return Math.Log(1 - random) / -lambda;
        }

        // lo llama calcular_tiempo_atencion()
        private double atencion_devolucion(double random)
        {
            // Devolucion -> U(1.5;2.5) | a y b fijos   | (b-a)*RND+a
            return (2.5 - 1.5) * random + 1.5;
        }

        // lo llama calcular_tiempo_atencion()
        private double atencion_consulta(double random)
        {
            return (formulario.consulta_max - formulario.consulta_min) * random + formulario.consulta_min;
        }


        private double calcular_fin_atencion(double reloj, double tiempo_atencion)
        {
            // Calcula cuanto tiempo dura la atencion: reloj + tiempo_atencion
            return reloj + tiempo_atencion;
        }

        private bool calcular_probabilidad_permanencia(double random)
        {
            if (random >= 0 && random <= formulario.porc_retiran_biblo)
            {
                return false;
            };
            return true;
        }

        private double redondear(double value)
        {
            return Math.Truncate(value * 100) / 100;
        }

    }
}
