
namespace ACTIVIDAD
{
    partial class frmACTIVIDAD
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.casilla1 = new System.Windows.Forms.CheckBox();
            this.casilla2 = new System.Windows.Forms.CheckBox();
            this.casilla3 = new System.Windows.Forms.CheckBox();
            this.casilla4 = new System.Windows.Forms.CheckBox();
            this.casilla5 = new System.Windows.Forms.CheckBox();
            this.casilla6 = new System.Windows.Forms.CheckBox();
            this.casilla7 = new System.Windows.Forms.CheckBox();
            this.casilla8 = new System.Windows.Forms.CheckBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un entero";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(204, 43);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.casilla8);
            this.groupBox1.Controls.Add(this.casilla7);
            this.groupBox1.Controls.Add(this.casilla6);
            this.groupBox1.Controls.Add(this.casilla5);
            this.groupBox1.Controls.Add(this.casilla4);
            this.groupBox1.Controls.Add(this.casilla3);
            this.groupBox1.Controls.Add(this.casilla2);
            this.groupBox1.Controls.Add(this.casilla1);
            this.groupBox1.Location = new System.Drawing.Point(76, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 83);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equivalente a Binario";
            // 
            // casilla1
            // 
            this.casilla1.AutoSize = true;
            this.casilla1.Location = new System.Drawing.Point(18, 35);
            this.casilla1.Name = "casilla1";
            this.casilla1.Size = new System.Drawing.Size(15, 14);
            this.casilla1.TabIndex = 0;
            this.casilla1.UseVisualStyleBackColor = true;
            // 
            // casilla2
            // 
            this.casilla2.AutoSize = true;
            this.casilla2.Location = new System.Drawing.Point(55, 35);
            this.casilla2.Name = "casilla2";
            this.casilla2.Size = new System.Drawing.Size(15, 14);
            this.casilla2.TabIndex = 1;
            this.casilla2.UseVisualStyleBackColor = true;
            // 
            // casilla3
            // 
            this.casilla3.AutoSize = true;
            this.casilla3.Location = new System.Drawing.Point(90, 35);
            this.casilla3.Name = "casilla3";
            this.casilla3.Size = new System.Drawing.Size(15, 14);
            this.casilla3.TabIndex = 2;
            this.casilla3.UseVisualStyleBackColor = true;
            // 
            // casilla4
            // 
            this.casilla4.AutoSize = true;
            this.casilla4.Location = new System.Drawing.Point(128, 35);
            this.casilla4.Name = "casilla4";
            this.casilla4.Size = new System.Drawing.Size(15, 14);
            this.casilla4.TabIndex = 3;
            this.casilla4.UseVisualStyleBackColor = true;
            // 
            // casilla5
            // 
            this.casilla5.AutoSize = true;
            this.casilla5.Location = new System.Drawing.Point(165, 35);
            this.casilla5.Name = "casilla5";
            this.casilla5.Size = new System.Drawing.Size(15, 14);
            this.casilla5.TabIndex = 4;
            this.casilla5.UseVisualStyleBackColor = true;
            // 
            // casilla6
            // 
            this.casilla6.AutoSize = true;
            this.casilla6.Location = new System.Drawing.Point(201, 35);
            this.casilla6.Name = "casilla6";
            this.casilla6.Size = new System.Drawing.Size(15, 14);
            this.casilla6.TabIndex = 5;
            this.casilla6.UseVisualStyleBackColor = true;
            // 
            // casilla7
            // 
            this.casilla7.AutoSize = true;
            this.casilla7.Location = new System.Drawing.Point(241, 34);
            this.casilla7.Name = "casilla7";
            this.casilla7.Size = new System.Drawing.Size(15, 14);
            this.casilla7.TabIndex = 6;
            this.casilla7.UseVisualStyleBackColor = true;
            this.casilla7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // casilla8
            // 
            this.casilla8.AutoSize = true;
            this.casilla8.Location = new System.Drawing.Point(280, 35);
            this.casilla8.Name = "casilla8";
            this.casilla8.Size = new System.Drawing.Size(15, 14);
            this.casilla8.TabIndex = 7;
            this.casilla8.UseVisualStyleBackColor = true;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(76, 281);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(90, 44);
            this.btnProcesar.TabIndex = 3;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // frmACTIVIDAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "frmACTIVIDAD";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox casilla6;
        private System.Windows.Forms.CheckBox casilla5;
        private System.Windows.Forms.CheckBox casilla4;
        private System.Windows.Forms.CheckBox casilla3;
        private System.Windows.Forms.CheckBox casilla2;
        private System.Windows.Forms.CheckBox casilla1;
        private System.Windows.Forms.CheckBox casilla7;
        private System.Windows.Forms.CheckBox casilla8;
        private System.Windows.Forms.Button btnProcesar;
    }
}

