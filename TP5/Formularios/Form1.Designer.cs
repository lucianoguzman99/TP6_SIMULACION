namespace TP5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_simulacion = new System.Windows.Forms.DataGridView();
            this.txt_tiempo_simular = new System.Windows.Forms.MaskedTextBox();
            this.btn_simular = new System.Windows.Forms.Button();
            this.label_tiempo_simular = new System.Windows.Forms.Label();
            this.label_tiempo_consultas = new System.Windows.Forms.Label();
            this.txt_consulta_min = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_consulta_max = new System.Windows.Forms.MaskedTextBox();
            this.label_probabilidad_retirarse = new System.Windows.Forms.Label();
            this.txt_probabilidad_retirarse = new System.Windows.Forms.MaskedTextBox();
            this.label_tiempo_uso_instalacion = new System.Windows.Forms.Label();
            this.txt_tiempo_uso_instalacion = new System.Windows.Forms.MaskedTextBox();
            this.label_titulo = new System.Windows.Forms.Label();
            this.label_subtitulo = new System.Windows.Forms.Label();
            this.label_probabilidad_eventos = new System.Windows.Forms.Label();
            this.label_pedido = new System.Windows.Forms.Label();
            this.label_devolucion = new System.Windows.Forms.Label();
            this.label_consulta = new System.Windows.Forms.Label();
            this.txt_pedido = new System.Windows.Forms.MaskedTextBox();
            this.txt_devolucion = new System.Windows.Forms.MaskedTextBox();
            this.txt_consulta = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_desde = new System.Windows.Forms.Label();
            this.label_iteracciones = new System.Windows.Forms.Label();
            this.txt_desde_hora = new System.Windows.Forms.MaskedTextBox();
            this.txt_iteracciones = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tiempo_llegadas = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkbox_columnas = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_resultado_promedio = new System.Windows.Forms.Label();
            this.kValue = new System.Windows.Forms.TextBox();
            this.hValue = new System.Windows.Forms.TextBox();
            this.kLabel = new System.Windows.Forms.Label();
            this.hLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_simulacion
            // 
            this.dgv_simulacion.AllowUserToAddRows = false;
            this.dgv_simulacion.AllowUserToDeleteRows = false;
            this.dgv_simulacion.AllowUserToResizeColumns = false;
            this.dgv_simulacion.AllowUserToResizeRows = false;
            this.dgv_simulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_simulacion.Location = new System.Drawing.Point(12, 125);
            this.dgv_simulacion.Name = "dgv_simulacion";
            this.dgv_simulacion.Size = new System.Drawing.Size(1447, 696);
            this.dgv_simulacion.TabIndex = 10;
            // 
            // txt_tiempo_simular
            // 
            this.txt_tiempo_simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tiempo_simular.Location = new System.Drawing.Point(244, 65);
            this.txt_tiempo_simular.Name = "txt_tiempo_simular";
            this.txt_tiempo_simular.Size = new System.Drawing.Size(92, 26);
            this.txt_tiempo_simular.TabIndex = 1;
            this.txt_tiempo_simular.Text = "1000";
            // 
            // btn_simular
            // 
            this.btn_simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simular.Location = new System.Drawing.Point(1308, 50);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(151, 55);
            this.btn_simular.TabIndex = 9;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // label_tiempo_simular
            // 
            this.label_tiempo_simular.AutoSize = true;
            this.label_tiempo_simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tiempo_simular.Location = new System.Drawing.Point(63, 68);
            this.label_tiempo_simular.Name = "label_tiempo_simular";
            this.label_tiempo_simular.Size = new System.Drawing.Size(175, 20);
            this.label_tiempo_simular.TabIndex = 3;
            this.label_tiempo_simular.Text = "Tiempo a simular (min.):";
            // 
            // label_tiempo_consultas
            // 
            this.label_tiempo_consultas.AutoSize = true;
            this.label_tiempo_consultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tiempo_consultas.Location = new System.Drawing.Point(12, 93);
            this.label_tiempo_consultas.Name = "label_tiempo_consultas";
            this.label_tiempo_consultas.Size = new System.Drawing.Size(226, 20);
            this.label_tiempo_consultas.TabIndex = 4;
            this.label_tiempo_consultas.Text = "Tiempo de las consultas (min.):";
            // 
            // txt_consulta_min
            // 
            this.txt_consulta_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_consulta_min.Location = new System.Drawing.Point(244, 90);
            this.txt_consulta_min.Name = "txt_consulta_min";
            this.txt_consulta_min.Size = new System.Drawing.Size(29, 26);
            this.txt_consulta_min.TabIndex = 2;
            this.txt_consulta_min.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "a";
            // 
            // txt_consulta_max
            // 
            this.txt_consulta_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_consulta_max.Location = new System.Drawing.Point(303, 90);
            this.txt_consulta_max.Name = "txt_consulta_max";
            this.txt_consulta_max.Size = new System.Drawing.Size(33, 26);
            this.txt_consulta_max.TabIndex = 3;
            this.txt_consulta_max.Text = "5";
            // 
            // label_probabilidad_retirarse
            // 
            this.label_probabilidad_retirarse.AutoSize = true;
            this.label_probabilidad_retirarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_probabilidad_retirarse.Location = new System.Drawing.Point(386, 55);
            this.label_probabilidad_retirarse.Name = "label_probabilidad_retirarse";
            this.label_probabilidad_retirarse.Size = new System.Drawing.Size(212, 20);
            this.label_probabilidad_retirarse.TabIndex = 8;
            this.label_probabilidad_retirarse.Text = "Probabilidad de retirarse (%):";
            // 
            // txt_probabilidad_retirarse
            // 
            this.txt_probabilidad_retirarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_probabilidad_retirarse.Location = new System.Drawing.Point(604, 52);
            this.txt_probabilidad_retirarse.Name = "txt_probabilidad_retirarse";
            this.txt_probabilidad_retirarse.Size = new System.Drawing.Size(33, 26);
            this.txt_probabilidad_retirarse.TabIndex = 4;
            this.txt_probabilidad_retirarse.Text = "60";
            // 
            // label_tiempo_uso_instalacion
            // 
            this.label_tiempo_uso_instalacion.AutoSize = true;
            this.label_tiempo_uso_instalacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tiempo_uso_instalacion.Location = new System.Drawing.Point(359, 90);
            this.label_tiempo_uso_instalacion.Name = "label_tiempo_uso_instalacion";
            this.label_tiempo_uso_instalacion.Size = new System.Drawing.Size(239, 20);
            this.label_tiempo_uso_instalacion.TabIndex = 11;
            this.label_tiempo_uso_instalacion.Text = "Tiempo de uso instalación (min.):";
            // 
            // txt_tiempo_uso_instalacion
            // 
            this.txt_tiempo_uso_instalacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tiempo_uso_instalacion.Location = new System.Drawing.Point(604, 87);
            this.txt_tiempo_uso_instalacion.Name = "txt_tiempo_uso_instalacion";
            this.txt_tiempo_uso_instalacion.Size = new System.Drawing.Size(33, 26);
            this.txt_tiempo_uso_instalacion.TabIndex = 5;
            this.txt_tiempo_uso_instalacion.Text = "30";
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(12, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(261, 25);
            this.label_titulo.TabIndex = 13;
            this.label_titulo.Text = "TP 5 - Simulación colas";
            // 
            // label_subtitulo
            // 
            this.label_subtitulo.AutoSize = true;
            this.label_subtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subtitulo.Location = new System.Drawing.Point(308, 10);
            this.label_subtitulo.Name = "label_subtitulo";
            this.label_subtitulo.Size = new System.Drawing.Size(195, 24);
            this.label_subtitulo.TabIndex = 14;
            this.label_subtitulo.Text = "Grupo 6 - Biblioteca";
            // 
            // label_probabilidad_eventos
            // 
            this.label_probabilidad_eventos.AutoSize = true;
            this.label_probabilidad_eventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_probabilidad_eventos.Location = new System.Drawing.Point(660, 13);
            this.label_probabilidad_eventos.Name = "label_probabilidad_eventos";
            this.label_probabilidad_eventos.Size = new System.Drawing.Size(206, 20);
            this.label_probabilidad_eventos.TabIndex = 15;
            this.label_probabilidad_eventos.Text = "Probabilidad de eventos (%)";
            // 
            // label_pedido
            // 
            this.label_pedido.AutoSize = true;
            this.label_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pedido.Location = new System.Drawing.Point(717, 53);
            this.label_pedido.Name = "label_pedido";
            this.label_pedido.Size = new System.Drawing.Size(58, 20);
            this.label_pedido.TabIndex = 16;
            this.label_pedido.Text = "Pedido";
            // 
            // label_devolucion
            // 
            this.label_devolucion.AutoSize = true;
            this.label_devolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_devolucion.Location = new System.Drawing.Point(688, 74);
            this.label_devolucion.Name = "label_devolucion";
            this.label_devolucion.Size = new System.Drawing.Size(87, 20);
            this.label_devolucion.TabIndex = 17;
            this.label_devolucion.Text = "Devolucion";
            // 
            // label_consulta
            // 
            this.label_consulta.AutoSize = true;
            this.label_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_consulta.Location = new System.Drawing.Point(703, 97);
            this.label_consulta.Name = "label_consulta";
            this.label_consulta.Size = new System.Drawing.Size(72, 20);
            this.label_consulta.TabIndex = 18;
            this.label_consulta.Text = "Consulta";
            // 
            // txt_pedido
            // 
            this.txt_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pedido.Location = new System.Drawing.Point(781, 47);
            this.txt_pedido.Name = "txt_pedido";
            this.txt_pedido.Size = new System.Drawing.Size(33, 26);
            this.txt_pedido.TabIndex = 6;
            this.txt_pedido.Text = "45";
            // 
            // txt_devolucion
            // 
            this.txt_devolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_devolucion.Location = new System.Drawing.Point(781, 71);
            this.txt_devolucion.Name = "txt_devolucion";
            this.txt_devolucion.Size = new System.Drawing.Size(33, 26);
            this.txt_devolucion.TabIndex = 7;
            this.txt_devolucion.Text = "45";
            // 
            // txt_consulta
            // 
            this.txt_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_consulta.Location = new System.Drawing.Point(781, 94);
            this.txt_consulta.Name = "txt_consulta";
            this.txt_consulta.Size = new System.Drawing.Size(33, 26);
            this.txt_consulta.TabIndex = 8;
            this.txt_consulta.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(971, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Vista";
            // 
            // label_desde
            // 
            this.label_desde.AutoSize = true;
            this.label_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_desde.Location = new System.Drawing.Point(893, 50);
            this.label_desde.Name = "label_desde";
            this.label_desde.Size = new System.Drawing.Size(103, 20);
            this.label_desde.TabIndex = 20;
            this.label_desde.Text = "Desde (min.):";
            // 
            // label_iteracciones
            // 
            this.label_iteracciones.AutoSize = true;
            this.label_iteracciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_iteracciones.Location = new System.Drawing.Point(904, 74);
            this.label_iteracciones.Name = "label_iteracciones";
            this.label_iteracciones.Size = new System.Drawing.Size(92, 20);
            this.label_iteracciones.TabIndex = 21;
            this.label_iteracciones.Text = "Iteraciones:";
            // 
            // txt_desde_hora
            // 
            this.txt_desde_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desde_hora.Location = new System.Drawing.Point(1002, 47);
            this.txt_desde_hora.Name = "txt_desde_hora";
            this.txt_desde_hora.Size = new System.Drawing.Size(47, 26);
            this.txt_desde_hora.TabIndex = 22;
            this.txt_desde_hora.Text = "10";
            // 
            // txt_iteracciones
            // 
            this.txt_iteracciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_iteracciones.Location = new System.Drawing.Point(1002, 71);
            this.txt_iteracciones.Name = "txt_iteracciones";
            this.txt_iteracciones.Size = new System.Drawing.Size(72, 26);
            this.txt_iteracciones.TabIndex = 23;
            this.txt_iteracciones.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tiempo entre llegadas (min.):";
            // 
            // txt_tiempo_llegadas
            // 
            this.txt_tiempo_llegadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tiempo_llegadas.Location = new System.Drawing.Point(244, 41);
            this.txt_tiempo_llegadas.Name = "txt_tiempo_llegadas";
            this.txt_tiempo_llegadas.Size = new System.Drawing.Size(92, 26);
            this.txt_tiempo_llegadas.TabIndex = 25;
            this.txt_tiempo_llegadas.Text = "4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(843, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Mostrar columnas de estado";
            // 
            // checkbox_columnas
            // 
            this.checkbox_columnas.AutoSize = true;
            this.checkbox_columnas.Checked = true;
            this.checkbox_columnas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_columnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_columnas.Location = new System.Drawing.Point(1059, 102);
            this.checkbox_columnas.Name = "checkbox_columnas";
            this.checkbox_columnas.Size = new System.Drawing.Size(15, 14);
            this.checkbox_columnas.TabIndex = 27;
            this.checkbox_columnas.UseVisualStyleBackColor = true;
            this.checkbox_columnas.CheckedChanged += new System.EventHandler(this.checkbox_columnas_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1123, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Promedio de permanencia (min.):";
            // 
            // label_resultado_promedio
            // 
            this.label_resultado_promedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_resultado_promedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado_promedio.Location = new System.Drawing.Point(1157, 32);
            this.label_resultado_promedio.Name = "label_resultado_promedio";
            this.label_resultado_promedio.Size = new System.Drawing.Size(145, 63);
            this.label_resultado_promedio.TabIndex = 29;
            this.label_resultado_promedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kValue
            // 
            this.kValue.Location = new System.Drawing.Point(1157, 99);
            this.kValue.Name = "kValue";
            this.kValue.Size = new System.Drawing.Size(50, 20);
            this.kValue.TabIndex = 30;
            this.kValue.TextChanged += new System.EventHandler(this.kValue_TextChanged);
            // 
            // hValue
            // 
            this.hValue.Location = new System.Drawing.Point(1238, 100);
            this.hValue.Name = "hValue";
            this.hValue.Size = new System.Drawing.Size(50, 20);
            this.hValue.TabIndex = 31;
            this.hValue.Text = "0,1";
            this.hValue.TextChanged += new System.EventHandler(this.hValue_TextChanged);
            // 
            // kLabel
            // 
            this.kLabel.AutoSize = true;
            this.kLabel.Location = new System.Drawing.Point(1138, 102);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(13, 13);
            this.kLabel.TabIndex = 32;
            this.kLabel.Text = "k";
            // 
            // hLabel
            // 
            this.hLabel.AutoSize = true;
            this.hLabel.Location = new System.Drawing.Point(1219, 102);
            this.hLabel.Name = "hLabel";
            this.hLabel.Size = new System.Drawing.Size(13, 13);
            this.hLabel.TabIndex = 33;
            this.hLabel.Text = "h";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 749);
            this.Controls.Add(this.hLabel);
            this.Controls.Add(this.kLabel);
            this.Controls.Add(this.hValue);
            this.Controls.Add(this.kValue);
            this.Controls.Add(this.label_resultado_promedio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkbox_columnas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_tiempo_llegadas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_iteracciones);
            this.Controls.Add(this.txt_desde_hora);
            this.Controls.Add(this.label_iteracciones);
            this.Controls.Add(this.label_desde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_consulta);
            this.Controls.Add(this.txt_devolucion);
            this.Controls.Add(this.txt_pedido);
            this.Controls.Add(this.label_consulta);
            this.Controls.Add(this.label_devolucion);
            this.Controls.Add(this.label_pedido);
            this.Controls.Add(this.label_probabilidad_eventos);
            this.Controls.Add(this.label_subtitulo);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.txt_tiempo_uso_instalacion);
            this.Controls.Add(this.label_tiempo_uso_instalacion);
            this.Controls.Add(this.txt_probabilidad_retirarse);
            this.Controls.Add(this.label_probabilidad_retirarse);
            this.Controls.Add(this.txt_consulta_max);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_consulta_min);
            this.Controls.Add(this.label_tiempo_consultas);
            this.Controls.Add(this.label_tiempo_simular);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.txt_tiempo_simular);
            this.Controls.Add(this.dgv_simulacion);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP 5 Simulacion - Grupo 6";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_simulacion;
        private System.Windows.Forms.MaskedTextBox txt_tiempo_simular;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.Label label_tiempo_simular;
        private System.Windows.Forms.Label label_tiempo_consultas;
        private System.Windows.Forms.MaskedTextBox txt_consulta_min;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txt_consulta_max;
        private System.Windows.Forms.Label label_probabilidad_retirarse;
        private System.Windows.Forms.MaskedTextBox txt_probabilidad_retirarse;
        private System.Windows.Forms.Label label_tiempo_uso_instalacion;
        private System.Windows.Forms.MaskedTextBox txt_tiempo_uso_instalacion;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_subtitulo;
        private System.Windows.Forms.Label label_probabilidad_eventos;
        private System.Windows.Forms.Label label_pedido;
        private System.Windows.Forms.Label label_devolucion;
        private System.Windows.Forms.Label label_consulta;
        private System.Windows.Forms.MaskedTextBox txt_pedido;
        private System.Windows.Forms.MaskedTextBox txt_devolucion;
        private System.Windows.Forms.MaskedTextBox txt_consulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_desde;
        private System.Windows.Forms.Label label_iteracciones;
        private System.Windows.Forms.MaskedTextBox txt_desde_hora;
        private System.Windows.Forms.MaskedTextBox txt_iteracciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txt_tiempo_llegadas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkbox_columnas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_resultado_promedio;
        private System.Windows.Forms.TextBox kValue;
        private System.Windows.Forms.TextBox hValue;
        private System.Windows.Forms.Label kLabel;
        private System.Windows.Forms.Label hLabel;
    }
}

