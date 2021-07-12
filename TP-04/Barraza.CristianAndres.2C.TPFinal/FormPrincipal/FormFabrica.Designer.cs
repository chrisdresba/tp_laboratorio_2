
namespace FormFabrica
{
    partial class FormFabrica
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
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnMateriales = new System.Windows.Forms.Button();
            this.btnGuitarraAcustica = new System.Windows.Forms.Button();
            this.btnGuitarraClasica = new System.Windows.Forms.Button();
            this.btnGuitarraElectrica = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.White;
            this.btnProductos.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Location = new System.Drawing.Point(459, 135);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(200, 50);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnMateriales
            // 
            this.btnMateriales.BackColor = System.Drawing.Color.White;
            this.btnMateriales.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMateriales.Location = new System.Drawing.Point(459, 54);
            this.btnMateriales.Name = "btnMateriales";
            this.btnMateriales.Size = new System.Drawing.Size(200, 50);
            this.btnMateriales.TabIndex = 2;
            this.btnMateriales.Text = "Stock Materiales";
            this.btnMateriales.UseVisualStyleBackColor = false;
            this.btnMateriales.Click += new System.EventHandler(this.btnMateriales_Click);
            // 
            // btnGuitarraAcustica
            // 
            this.btnGuitarraAcustica.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuitarraAcustica.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuitarraAcustica.Location = new System.Drawing.Point(459, 220);
            this.btnGuitarraAcustica.Name = "btnGuitarraAcustica";
            this.btnGuitarraAcustica.Size = new System.Drawing.Size(200, 50);
            this.btnGuitarraAcustica.TabIndex = 3;
            this.btnGuitarraAcustica.Text = "Agregar Acustica";
            this.btnGuitarraAcustica.UseVisualStyleBackColor = false;
            this.btnGuitarraAcustica.Click += new System.EventHandler(this.btnGuitarraAcustica_Click);
            // 
            // btnGuitarraClasica
            // 
            this.btnGuitarraClasica.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuitarraClasica.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuitarraClasica.Location = new System.Drawing.Point(459, 304);
            this.btnGuitarraClasica.Name = "btnGuitarraClasica";
            this.btnGuitarraClasica.Size = new System.Drawing.Size(200, 50);
            this.btnGuitarraClasica.TabIndex = 4;
            this.btnGuitarraClasica.Text = "Agregar Clasica";
            this.btnGuitarraClasica.UseVisualStyleBackColor = false;
            this.btnGuitarraClasica.Click += new System.EventHandler(this.btnGuitarraClasica_Click);
            // 
            // btnGuitarraElectrica
            // 
            this.btnGuitarraElectrica.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuitarraElectrica.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuitarraElectrica.Location = new System.Drawing.Point(459, 384);
            this.btnGuitarraElectrica.Name = "btnGuitarraElectrica";
            this.btnGuitarraElectrica.Size = new System.Drawing.Size(200, 50);
            this.btnGuitarraElectrica.TabIndex = 5;
            this.btnGuitarraElectrica.Text = "Agregar Electrica";
            this.btnGuitarraElectrica.UseVisualStyleBackColor = false;
            this.btnGuitarraElectrica.Click += new System.EventHandler(this.btnGuitarraElectrica_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormFabrica.Properties.Resources.fabrica;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 435);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormFabrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(723, 485);
            this.Controls.Add(this.btnGuitarraElectrica);
            this.Controls.Add(this.btnGuitarraClasica);
            this.Controls.Add(this.btnGuitarraAcustica);
            this.Controls.Add(this.btnMateriales);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFabrica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fabrica de Guitarras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFabrica_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnMateriales;
        private System.Windows.Forms.Button btnGuitarraAcustica;
        private System.Windows.Forms.Button btnGuitarraClasica;
        private System.Windows.Forms.Button btnGuitarraElectrica;
    }
}

