namespace EjPanalAbejas
{
    partial class Panal
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbEntradas = new System.Windows.Forms.GroupBox();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.lblLado = new System.Windows.Forms.Label();
            this.grbProcesos = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbEntradas.SuspendLayout();
            this.grbProcesos.SuspendLayout();
            this.grbCanvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(11, 28);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(1032, 453);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // grbEntradas
            // 
            this.grbEntradas.Controls.Add(this.txtLado);
            this.grbEntradas.Controls.Add(this.lblLado);
            this.grbEntradas.Location = new System.Drawing.Point(30, 557);
            this.grbEntradas.Name = "grbEntradas";
            this.grbEntradas.Size = new System.Drawing.Size(336, 75);
            this.grbEntradas.TabIndex = 1;
            this.grbEntradas.TabStop = false;
            this.grbEntradas.Text = "Entradas";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(122, 36);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(100, 22);
            this.txtLado.TabIndex = 1;
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(28, 33);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(41, 16);
            this.lblLado.TabIndex = 0;
            this.lblLado.Text = "Lado:";
            // 
            // grbProcesos
            // 
            this.grbProcesos.Controls.Add(this.btnSalir);
            this.grbProcesos.Controls.Add(this.btnLimpiar);
            this.grbProcesos.Controls.Add(this.btnGraficar);
            this.grbProcesos.Location = new System.Drawing.Point(641, 546);
            this.grbProcesos.Name = "grbProcesos";
            this.grbProcesos.Size = new System.Drawing.Size(347, 86);
            this.grbProcesos.TabIndex = 2;
            this.grbProcesos.TabStop = false;
            this.grbProcesos.Text = "Procesos";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(237, 38);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(130, 38);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(16, 38);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(75, 23);
            this.btnGraficar.TabIndex = 0;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Location = new System.Drawing.Point(4, 5);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Size = new System.Drawing.Size(1058, 512);
            this.grbCanvas.TabIndex = 0;
            this.grbCanvas.TabStop = false;
            this.grbCanvas.Text = "Canvas";
            // 
            // Panal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 674);
            this.Controls.Add(this.grbProcesos);
            this.Controls.Add(this.grbEntradas);
            this.Controls.Add(this.grbCanvas);
            this.Name = "Panal";
            this.Text = "Panal";
            this.Load += new System.EventHandler(this.Panal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbEntradas.ResumeLayout(false);
            this.grbEntradas.PerformLayout();
            this.grbProcesos.ResumeLayout(false);
            this.grbCanvas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox grbEntradas;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.GroupBox grbProcesos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.GroupBox grbCanvas;
    }
}