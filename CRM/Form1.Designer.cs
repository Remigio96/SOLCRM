namespace CRM
{
    partial class Form1
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
            this.btnProbarConexion = new System.Windows.Forms.Button();
            this.btnInsertarRegistro = new System.Windows.Forms.Button();
            this.btnActualizarRegistro = new System.Windows.Forms.Button();
            this.btnEliminarRegistro = new System.Windows.Forms.Button();
            this.lblIngreseRut = new System.Windows.Forms.Label();
            this.rut = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.men = new System.Windows.Forms.Label();
            this.rut2 = new System.Windows.Forms.Label();
            this.clave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbarConexion.Location = new System.Drawing.Point(24, 47);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(207, 33);
            this.btnProbarConexion.TabIndex = 0;
            this.btnProbarConexion.Text = "Probar Conexión";
            this.btnProbarConexion.UseVisualStyleBackColor = true;
            this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click);
            // 
            // btnInsertarRegistro
            // 
            this.btnInsertarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarRegistro.Location = new System.Drawing.Point(24, 105);
            this.btnInsertarRegistro.Name = "btnInsertarRegistro";
            this.btnInsertarRegistro.Size = new System.Drawing.Size(207, 33);
            this.btnInsertarRegistro.TabIndex = 1;
            this.btnInsertarRegistro.Text = "Insertar Registro";
            this.btnInsertarRegistro.UseVisualStyleBackColor = true;
            this.btnInsertarRegistro.Click += new System.EventHandler(this.btnInsertarRegistro_Click);
            // 
            // btnActualizarRegistro
            // 
            this.btnActualizarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarRegistro.Location = new System.Drawing.Point(24, 162);
            this.btnActualizarRegistro.Name = "btnActualizarRegistro";
            this.btnActualizarRegistro.Size = new System.Drawing.Size(207, 33);
            this.btnActualizarRegistro.TabIndex = 2;
            this.btnActualizarRegistro.Text = "Actualizar Registro";
            this.btnActualizarRegistro.UseVisualStyleBackColor = true;
            this.btnActualizarRegistro.Click += new System.EventHandler(this.btnActualizarRegistro_Click);
            // 
            // btnEliminarRegistro
            // 
            this.btnEliminarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRegistro.Location = new System.Drawing.Point(24, 215);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Size = new System.Drawing.Size(207, 33);
            this.btnEliminarRegistro.TabIndex = 3;
            this.btnEliminarRegistro.Text = "Eliminar Registro";
            this.btnEliminarRegistro.UseVisualStyleBackColor = true;
            this.btnEliminarRegistro.Click += new System.EventHandler(this.btnEliminarRegistro_Click);
            // 
            // lblIngreseRut
            // 
            this.lblIngreseRut.AutoSize = true;
            this.lblIngreseRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseRut.Location = new System.Drawing.Point(249, 47);
            this.lblIngreseRut.Name = "lblIngreseRut";
            this.lblIngreseRut.Size = new System.Drawing.Size(97, 20);
            this.lblIngreseRut.TabIndex = 4;
            this.lblIngreseRut.Text = "Ingrese Rut:";
            // 
            // rut
            // 
            this.rut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rut.Location = new System.Drawing.Point(352, 40);
            this.rut.Name = "rut";
            this.rut.Size = new System.Drawing.Size(207, 31);
            this.rut.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(565, 40);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 33);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // men
            // 
            this.men.AutoSize = true;
            this.men.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.men.Location = new System.Drawing.Point(348, 92);
            this.men.Name = "men";
            this.men.Size = new System.Drawing.Size(25, 20);
            this.men.TabIndex = 7;
            this.men.Text = "(*)";
            // 
            // rut2
            // 
            this.rut2.AutoSize = true;
            this.rut2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rut2.Location = new System.Drawing.Point(249, 105);
            this.rut2.Name = "rut2";
            this.rut2.Size = new System.Drawing.Size(37, 20);
            this.rut2.TabIndex = 8;
            this.rut2.Text = ".......";
            // 
            // clave
            // 
            this.clave.AutoSize = true;
            this.clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clave.Location = new System.Drawing.Point(249, 162);
            this.clave.Name = "clave";
            this.clave.Size = new System.Drawing.Size(37, 20);
            this.clave.TabIndex = 9;
            this.clave.Text = ".......";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 299);
            this.Controls.Add(this.clave);
            this.Controls.Add(this.rut2);
            this.Controls.Add(this.men);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.rut);
            this.Controls.Add(this.lblIngreseRut);
            this.Controls.Add(this.btnEliminarRegistro);
            this.Controls.Add(this.btnActualizarRegistro);
            this.Controls.Add(this.btnInsertarRegistro);
            this.Controls.Add(this.btnProbarConexion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProbarConexion;
        private System.Windows.Forms.Button btnInsertarRegistro;
        private System.Windows.Forms.Button btnActualizarRegistro;
        private System.Windows.Forms.Button btnEliminarRegistro;
        private System.Windows.Forms.Label lblIngreseRut;
        private System.Windows.Forms.TextBox rut;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label men;
        private System.Windows.Forms.Label rut2;
        private System.Windows.Forms.Label clave;
    }
}

