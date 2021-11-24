namespace Sonora_Creativa
{
    partial class Form2
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.BCobro = new System.Windows.Forms.Button();
            this.BVentas = new System.Windows.Forms.Button();
            this.BUsuario = new System.Windows.Forms.Button();
            this.BInventario = new System.Windows.Forms.Button();
            this.ImLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Gold;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(508, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // BCobro
            // 
            this.BCobro.BackColor = System.Drawing.Color.Gold;
            this.BCobro.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.BCobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCobro.Location = new System.Drawing.Point(84, 185);
            this.BCobro.Name = "BCobro";
            this.BCobro.Size = new System.Drawing.Size(200, 100);
            this.BCobro.TabIndex = 3;
            this.BCobro.Text = "Cobro";
            this.BCobro.UseVisualStyleBackColor = false;
            this.BCobro.Click += new System.EventHandler(this.BCobro_Click);
            // 
            // BVentas
            // 
            this.BVentas.BackColor = System.Drawing.Color.Gold;
            this.BVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVentas.Location = new System.Drawing.Point(360, 185);
            this.BVentas.Name = "BVentas";
            this.BVentas.Size = new System.Drawing.Size(200, 100);
            this.BVentas.TabIndex = 4;
            this.BVentas.Text = "Ventas";
            this.BVentas.UseVisualStyleBackColor = false;
            this.BVentas.Click += new System.EventHandler(this.BVentas_Click);
            // 
            // BUsuario
            // 
            this.BUsuario.BackColor = System.Drawing.Color.Gold;
            this.BUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUsuario.Location = new System.Drawing.Point(84, 298);
            this.BUsuario.Name = "BUsuario";
            this.BUsuario.Size = new System.Drawing.Size(200, 100);
            this.BUsuario.TabIndex = 5;
            this.BUsuario.Text = "Usuario";
            this.BUsuario.UseVisualStyleBackColor = false;
            this.BUsuario.Click += new System.EventHandler(this.BUsuario_Click);
            // 
            // BInventario
            // 
            this.BInventario.BackColor = System.Drawing.Color.Gold;
            this.BInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BInventario.Location = new System.Drawing.Point(360, 298);
            this.BInventario.Name = "BInventario";
            this.BInventario.Size = new System.Drawing.Size(200, 100);
            this.BInventario.TabIndex = 6;
            this.BInventario.Text = "Inventario";
            this.BInventario.UseVisualStyleBackColor = false;
            this.BInventario.Click += new System.EventHandler(this.BInventario_Click);
            // 
            // ImLogo
            // 
            this.ImLogo.Image = global::Sonora_Creativa.Properties.Resources.Logo_Sonora_Creativa;
            this.ImLogo.Location = new System.Drawing.Point(28, 12);
            this.ImLogo.Name = "ImLogo";
            this.ImLogo.Size = new System.Drawing.Size(280, 129);
            this.ImLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImLogo.TabIndex = 1;
            this.ImLogo.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.BInventario);
            this.Controls.Add(this.BUsuario);
            this.Controls.Add(this.BVentas);
            this.Controls.Add(this.BCobro);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.ImLogo);
            this.Name = "Form2";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImLogo;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button BCobro;
        private System.Windows.Forms.Button BVentas;
        private System.Windows.Forms.Button BUsuario;
        private System.Windows.Forms.Button BInventario;
    }
}