namespace Ejercicio_1
{
    partial class Cocinar
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
            this.bTcocina = new System.Windows.Forms.Button();
            this.bTreponer = new System.Windows.Forms.Button();
            this.bTcocinar = new System.Windows.Forms.Button();
            this.bTcerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lBconversacion = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bTcocina
            // 
            this.bTcocina.Location = new System.Drawing.Point(12, 49);
            this.bTcocina.Name = "bTcocina";
            this.bTcocina.Size = new System.Drawing.Size(97, 52);
            this.bTcocina.TabIndex = 0;
            this.bTcocina.Text = "Iniciar Cocina";
            this.bTcocina.UseVisualStyleBackColor = true;
            this.bTcocina.Click += new System.EventHandler(this.bTcocina_Click);
            // 
            // bTreponer
            // 
            this.bTreponer.Location = new System.Drawing.Point(12, 107);
            this.bTreponer.Name = "bTreponer";
            this.bTreponer.Size = new System.Drawing.Size(97, 52);
            this.bTreponer.TabIndex = 1;
            this.bTreponer.Text = "Reponer Ingredientes";
            this.bTreponer.UseVisualStyleBackColor = true;
            this.bTreponer.Click += new System.EventHandler(this.bTreponer_Click);
            // 
            // bTcocinar
            // 
            this.bTcocinar.Location = new System.Drawing.Point(12, 161);
            this.bTcocinar.Name = "bTcocinar";
            this.bTcocinar.Size = new System.Drawing.Size(97, 52);
            this.bTcocinar.TabIndex = 2;
            this.bTcocinar.Text = "Cocinar";
            this.bTcocinar.UseVisualStyleBackColor = true;
            this.bTcocinar.Click += new System.EventHandler(this.bTcocinar_Click);
            // 
            // bTcerrar
            // 
            this.bTcerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bTcerrar.Location = new System.Drawing.Point(12, 219);
            this.bTcerrar.Name = "bTcerrar";
            this.bTcerrar.Size = new System.Drawing.Size(97, 52);
            this.bTcerrar.TabIndex = 3;
            this.bTcerrar.Text = "Cerrar";
            this.bTcerrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Conversacion de Ana con el ser misterioso";
            // 
            // lBconversacion
            // 
            this.lBconversacion.FormattingEnabled = true;
            this.lBconversacion.Location = new System.Drawing.Point(115, 49);
            this.lBconversacion.Name = "lBconversacion";
            this.lBconversacion.Size = new System.Drawing.Size(417, 225);
            this.lBconversacion.TabIndex = 5;
            // 
            // Cocinar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 471);
            this.Controls.Add(this.lBconversacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bTcerrar);
            this.Controls.Add(this.bTcocinar);
            this.Controls.Add(this.bTreponer);
            this.Controls.Add(this.bTcocina);
            this.Name = "Cocinar";
            this.Text = "Cocinar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bTcocina;
        private System.Windows.Forms.Button bTreponer;
        private System.Windows.Forms.Button bTcocinar;
        private System.Windows.Forms.Button bTcerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lBconversacion;
    }
}

