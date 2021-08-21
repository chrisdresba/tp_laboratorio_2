
namespace FormFabrica
{
    partial class FormClasica
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
            this.lblTituloClasica = new System.Windows.Forms.Label();
            this.lblModeloClasica = new System.Windows.Forms.Label();
            this.txtBoxModeloClasica = new System.Windows.Forms.TextBox();
            this.lblColorClasica = new System.Windows.Forms.Label();
            this.cmbBoxColorClasica = new System.Windows.Forms.ComboBox();
            this.checkBoxEqClasica = new System.Windows.Forms.CheckBox();
            this.btnCargarClasica = new System.Windows.Forms.Button();
            this.pictureBoxClasica = new System.Windows.Forms.PictureBox();
            this.lblErrorModeloClasica = new System.Windows.Forms.Label();
            this.lblErrorColorClasica = new System.Windows.Forms.Label();
            this.lblErrorClavijasClasica = new System.Windows.Forms.Label();
            this.lblErrorEncordadoClasica = new System.Windows.Forms.Label();
            this.cmbBoxEncordadoClasica = new System.Windows.Forms.ComboBox();
            this.cmbBoxClavijasClasica = new System.Windows.Forms.ComboBox();
            this.lblClavijasClasica = new System.Windows.Forms.Label();
            this.lblEncordadoClasica = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClasica)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloClasica
            // 
            this.lblTituloClasica.AutoSize = true;
            this.lblTituloClasica.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloClasica.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTituloClasica.Location = new System.Drawing.Point(65, 23);
            this.lblTituloClasica.Name = "lblTituloClasica";
            this.lblTituloClasica.Size = new System.Drawing.Size(211, 19);
            this.lblTituloClasica.TabIndex = 0;
            this.lblTituloClasica.Text = "Ensamblado Guitarra Clasica";
            // 
            // lblModeloClasica
            // 
            this.lblModeloClasica.AutoSize = true;
            this.lblModeloClasica.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblModeloClasica.Location = new System.Drawing.Point(65, 69);
            this.lblModeloClasica.Name = "lblModeloClasica";
            this.lblModeloClasica.Size = new System.Drawing.Size(42, 13);
            this.lblModeloClasica.TabIndex = 1;
            this.lblModeloClasica.Text = "Modelo";
            // 
            // txtBoxModeloClasica
            // 
            this.txtBoxModeloClasica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxModeloClasica.Location = new System.Drawing.Point(65, 88);
            this.txtBoxModeloClasica.Name = "txtBoxModeloClasica";
            this.txtBoxModeloClasica.Size = new System.Drawing.Size(124, 22);
            this.txtBoxModeloClasica.TabIndex = 2;
            // 
            // lblColorClasica
            // 
            this.lblColorClasica.AutoSize = true;
            this.lblColorClasica.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblColorClasica.Location = new System.Drawing.Point(65, 142);
            this.lblColorClasica.Name = "lblColorClasica";
            this.lblColorClasica.Size = new System.Drawing.Size(106, 13);
            this.lblColorClasica.TabIndex = 3;
            this.lblColorClasica.Text = "Color del Instrumento";
            // 
            // cmbBoxColorClasica
            // 
            this.cmbBoxColorClasica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxColorClasica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cmbBoxColorClasica.FormattingEnabled = true;
            this.cmbBoxColorClasica.Items.AddRange(new object[] {
            "Natural",
            "Negro",
            "Verde",
            "Azul",
            "Rojo"});
            this.cmbBoxColorClasica.Location = new System.Drawing.Point(65, 169);
            this.cmbBoxColorClasica.Name = "cmbBoxColorClasica";
            this.cmbBoxColorClasica.Size = new System.Drawing.Size(121, 23);
            this.cmbBoxColorClasica.TabIndex = 4;
            // 
            // checkBoxEqClasica
            // 
            this.checkBoxEqClasica.AutoSize = true;
            this.checkBoxEqClasica.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxEqClasica.Location = new System.Drawing.Point(65, 340);
            this.checkBoxEqClasica.Name = "checkBoxEqClasica";
            this.checkBoxEqClasica.Size = new System.Drawing.Size(118, 17);
            this.checkBoxEqClasica.TabIndex = 7;
            this.checkBoxEqClasica.Text = "Incluye Ecualizador";
            this.checkBoxEqClasica.UseVisualStyleBackColor = true;
            // 
            // btnCargarClasica
            // 
            this.btnCargarClasica.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarClasica.Location = new System.Drawing.Point(65, 416);
            this.btnCargarClasica.Name = "btnCargarClasica";
            this.btnCargarClasica.Size = new System.Drawing.Size(136, 30);
            this.btnCargarClasica.TabIndex = 8;
            this.btnCargarClasica.Text = "Cargar Clasica";
            this.btnCargarClasica.UseVisualStyleBackColor = true;
            this.btnCargarClasica.Click += new System.EventHandler(this.btnCargarClasica_Click);
            // 
            // pictureBoxClasica
            // 
            this.pictureBoxClasica.Image = global::FormFabrica.Properties.Resources.guitarClassic;
            this.pictureBoxClasica.Location = new System.Drawing.Point(430, 38);
            this.pictureBoxClasica.Name = "pictureBoxClasica";
            this.pictureBoxClasica.Size = new System.Drawing.Size(294, 408);
            this.pictureBoxClasica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClasica.TabIndex = 9;
            this.pictureBoxClasica.TabStop = false;
            // 
            // lblErrorModeloClasica
            // 
            this.lblErrorModeloClasica.AutoSize = true;
            this.lblErrorModeloClasica.ForeColor = System.Drawing.Color.Red;
            this.lblErrorModeloClasica.Location = new System.Drawing.Point(45, 93);
            this.lblErrorModeloClasica.Name = "lblErrorModeloClasica";
            this.lblErrorModeloClasica.Size = new System.Drawing.Size(14, 13);
            this.lblErrorModeloClasica.TabIndex = 11;
            this.lblErrorModeloClasica.Text = "X";
            // 
            // lblErrorColorClasica
            // 
            this.lblErrorColorClasica.AutoSize = true;
            this.lblErrorColorClasica.ForeColor = System.Drawing.Color.Red;
            this.lblErrorColorClasica.Location = new System.Drawing.Point(45, 174);
            this.lblErrorColorClasica.Name = "lblErrorColorClasica";
            this.lblErrorColorClasica.Size = new System.Drawing.Size(14, 13);
            this.lblErrorColorClasica.TabIndex = 12;
            this.lblErrorColorClasica.Text = "X";
            // 
            // lblErrorClavijasClasica
            // 
            this.lblErrorClavijasClasica.AutoSize = true;
            this.lblErrorClavijasClasica.ForeColor = System.Drawing.Color.Red;
            this.lblErrorClavijasClasica.Location = new System.Drawing.Point(45, 234);
            this.lblErrorClavijasClasica.Name = "lblErrorClavijasClasica";
            this.lblErrorClavijasClasica.Size = new System.Drawing.Size(14, 13);
            this.lblErrorClavijasClasica.TabIndex = 13;
            this.lblErrorClavijasClasica.Text = "X";
            // 
            // lblErrorEncordadoClasica
            // 
            this.lblErrorEncordadoClasica.AutoSize = true;
            this.lblErrorEncordadoClasica.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEncordadoClasica.Location = new System.Drawing.Point(45, 290);
            this.lblErrorEncordadoClasica.Name = "lblErrorEncordadoClasica";
            this.lblErrorEncordadoClasica.Size = new System.Drawing.Size(14, 13);
            this.lblErrorEncordadoClasica.TabIndex = 14;
            this.lblErrorEncordadoClasica.Text = "X";
            // 
            // cmbBoxEncordadoClasica
            // 
            this.cmbBoxEncordadoClasica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxEncordadoClasica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cmbBoxEncordadoClasica.FormattingEnabled = true;
            this.cmbBoxEncordadoClasica.Items.AddRange(new object[] {
            "Daddario",
            "ErnieBall"});
            this.cmbBoxEncordadoClasica.Location = new System.Drawing.Point(65, 285);
            this.cmbBoxEncordadoClasica.Name = "cmbBoxEncordadoClasica";
            this.cmbBoxEncordadoClasica.Size = new System.Drawing.Size(121, 23);
            this.cmbBoxEncordadoClasica.TabIndex = 15;
            // 
            // cmbBoxClavijasClasica
            // 
            this.cmbBoxClavijasClasica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxClavijasClasica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cmbBoxClavijasClasica.FormattingEnabled = true;
            this.cmbBoxClavijasClasica.Items.AddRange(new object[] {
            "Nacional",
            "Importado"});
            this.cmbBoxClavijasClasica.Location = new System.Drawing.Point(65, 231);
            this.cmbBoxClavijasClasica.Name = "cmbBoxClavijasClasica";
            this.cmbBoxClavijasClasica.Size = new System.Drawing.Size(121, 23);
            this.cmbBoxClavijasClasica.TabIndex = 16;
            // 
            // lblClavijasClasica
            // 
            this.lblClavijasClasica.AutoSize = true;
            this.lblClavijasClasica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblClavijasClasica.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblClavijasClasica.Location = new System.Drawing.Point(65, 212);
            this.lblClavijasClasica.Name = "lblClavijasClasica";
            this.lblClavijasClasica.Size = new System.Drawing.Size(43, 13);
            this.lblClavijasClasica.TabIndex = 17;
            this.lblClavijasClasica.Text = "Clavijas";
            // 
            // lblEncordadoClasica
            // 
            this.lblEncordadoClasica.AutoSize = true;
            this.lblEncordadoClasica.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEncordadoClasica.Location = new System.Drawing.Point(66, 269);
            this.lblEncordadoClasica.Name = "lblEncordadoClasica";
            this.lblEncordadoClasica.Size = new System.Drawing.Size(59, 13);
            this.lblEncordadoClasica.TabIndex = 18;
            this.lblEncordadoClasica.Text = "Encordado";
            // 
            // FormClasica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(723, 485);
            this.Controls.Add(this.lblEncordadoClasica);
            this.Controls.Add(this.lblClavijasClasica);
            this.Controls.Add(this.cmbBoxClavijasClasica);
            this.Controls.Add(this.cmbBoxEncordadoClasica);
            this.Controls.Add(this.lblErrorEncordadoClasica);
            this.Controls.Add(this.lblErrorClavijasClasica);
            this.Controls.Add(this.lblErrorColorClasica);
            this.Controls.Add(this.lblErrorModeloClasica);
            this.Controls.Add(this.pictureBoxClasica);
            this.Controls.Add(this.btnCargarClasica);
            this.Controls.Add(this.checkBoxEqClasica);
            this.Controls.Add(this.cmbBoxColorClasica);
            this.Controls.Add(this.lblColorClasica);
            this.Controls.Add(this.txtBoxModeloClasica);
            this.Controls.Add(this.lblModeloClasica);
            this.Controls.Add(this.lblTituloClasica);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClasica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producción Guitarra Clasica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClasica_FormClosing);
            this.Load += new System.EventHandler(this.FormClasica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClasica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloClasica;
        private System.Windows.Forms.Label lblModeloClasica;
        private System.Windows.Forms.TextBox txtBoxModeloClasica;
        private System.Windows.Forms.Label lblColorClasica;
        private System.Windows.Forms.ComboBox cmbBoxColorClasica;
        private System.Windows.Forms.CheckBox checkBoxEqClasica;
        private System.Windows.Forms.Button btnCargarClasica;
        private System.Windows.Forms.PictureBox pictureBoxClasica;
        private System.Windows.Forms.Label lblErrorModeloClasica;
        private System.Windows.Forms.Label lblErrorColorClasica;
        private System.Windows.Forms.Label lblErrorClavijasClasica;
        private System.Windows.Forms.Label lblErrorEncordadoClasica;
        private System.Windows.Forms.ComboBox cmbBoxEncordadoClasica;
        private System.Windows.Forms.ComboBox cmbBoxClavijasClasica;
        private System.Windows.Forms.Label lblClavijasClasica;
        private System.Windows.Forms.Label lblEncordadoClasica;
    }
}