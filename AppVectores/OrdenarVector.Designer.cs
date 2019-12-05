namespace AppVectores
{
    partial class OrdenarVector
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstOrdenado = new System.Windows.Forms.ListBox();
            this.txtTamanio = new System.Windows.Forms.TextBox();
            this.lstOriginal = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(600, 39);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(122, 45);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(600, 100);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 45);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Números aleatorios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstOrdenado
            // 
            this.lstOrdenado.FormattingEnabled = true;
            this.lstOrdenado.Location = new System.Drawing.Point(304, 113);
            this.lstOrdenado.Name = "lstOrdenado";
            this.lstOrdenado.Size = new System.Drawing.Size(242, 277);
            this.lstOrdenado.TabIndex = 6;
            // 
            // txtTamanio
            // 
            this.txtTamanio.Location = new System.Drawing.Point(253, 39);
            this.txtTamanio.Name = "txtTamanio";
            this.txtTamanio.Size = new System.Drawing.Size(152, 20);
            this.txtTamanio.TabIndex = 7;
            this.txtTamanio.Text = "20";
            // 
            // lstOriginal
            // 
            this.lstOriginal.FormattingEnabled = true;
            this.lstOriginal.Location = new System.Drawing.Point(12, 113);
            this.lstOriginal.Name = "lstOriginal";
            this.lstOriginal.Size = new System.Drawing.Size(242, 277);
            this.lstOriginal.TabIndex = 8;
            // 
            // OrdenarVector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstOriginal);
            this.Controls.Add(this.txtTamanio);
            this.Controls.Add(this.lstOrdenado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerar);
            this.Name = "OrdenarVector";
            this.Text = "OrdenarVector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstOrdenado;
        private System.Windows.Forms.TextBox txtTamanio;
        private System.Windows.Forms.ListBox lstOriginal;
    }
}