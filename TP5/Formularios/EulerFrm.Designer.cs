namespace TP5.Formularios
{
    partial class EulerFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEuler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEuler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEuler
            // 
            this.dgvEuler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEuler.Location = new System.Drawing.Point(30, 12);
            this.dgvEuler.Name = "dgvEuler";
            this.dgvEuler.Size = new System.Drawing.Size(585, 357);
            this.dgvEuler.TabIndex = 0;
            // 
            // EulerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 384);
            this.Controls.Add(this.dgvEuler);
            this.Name = "EulerFrm";
            this.Text = "EulerFrm";
            this.Load += new System.EventHandler(this.EulerFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEuler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEuler;
    }
}