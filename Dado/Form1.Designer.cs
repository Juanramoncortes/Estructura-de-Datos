namespace Dado
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
            this.btnLanzar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.btnLanzar2 = new System.Windows.Forms.Button();
            this.btnlan3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLanzar
            // 
            this.btnLanzar.Location = new System.Drawing.Point(107, 96);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(87, 32);
            this.btnLanzar.TabIndex = 0;
            this.btnLanzar.Text = "Lanzar";
            this.btnLanzar.UseVisualStyleBackColor = true;
            this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dado";
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(84, 148);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDatos.Size = new System.Drawing.Size(355, 322);
            this.txtDatos.TabIndex = 2;
            // 
            // btnLanzar2
            // 
            this.btnLanzar2.Location = new System.Drawing.Point(237, 96);
            this.btnLanzar2.Name = "btnLanzar2";
            this.btnLanzar2.Size = new System.Drawing.Size(87, 32);
            this.btnLanzar2.TabIndex = 3;
            this.btnLanzar2.Text = "Lanzar2";
            this.btnLanzar2.UseVisualStyleBackColor = true;
            this.btnLanzar2.Click += new System.EventHandler(this.btnLanzar2_Click);
            // 
            // btnlan3
            // 
            this.btnlan3.Location = new System.Drawing.Point(352, 96);
            this.btnlan3.Name = "btnlan3";
            this.btnlan3.Size = new System.Drawing.Size(87, 32);
            this.btnlan3.TabIndex = 4;
            this.btnlan3.Text = "Lanzar3";
            this.btnlan3.UseVisualStyleBackColor = true;
            this.btnlan3.Click += new System.EventHandler(this.btnlan3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 482);
            this.Controls.Add(this.btnlan3);
            this.Controls.Add(this.btnLanzar2);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLanzar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLanzar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Button btnLanzar2;
        private System.Windows.Forms.Button btnlan3;
    }
}

