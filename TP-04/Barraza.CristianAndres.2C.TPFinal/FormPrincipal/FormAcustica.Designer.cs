
namespace FormFabrica
{
    partial class FormAcustica
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
            this.checkBoxEqAc = new System.Windows.Forms.CheckBox();
            this.cmbBoxColorAcustica = new System.Windows.Forms.ComboBox();
            this.textBoxAcustica = new System.Windows.Forms.TextBox();
            this.btnCargarAcustica = new System.Windows.Forms.Button();
            this.lblColorAcustica = new System.Windows.Forms.Label();
            this.lblModeloAcustica = new System.Windows.Forms.Label();
            this.lblTituloAcustica = new System.Windows.Forms.Label();
            this.pictureBoxAcustica = new System.Windows.Forms.PictureBox();
            this.lblErrorModeloAcustica = new System.Windows.Forms.Label();
            this.lblErrorColorAcustica = new System.Windows.Forms.Label();
            this.lblErrorClavijasAcustica = new System.Windows.Forms.Label();
            this.lblErrorEncordadoAcustica = new System.Windows.Forms.Label();
            this.lblClavijasAcustica = new System.Windows.Forms.Label();
            this.lblEncordadoAcustica = new System.Windows.Forms.Label();
            this.cmbBoxClavijasAcustica = new System.Windows.Forms.ComboBox();
            this.cmbBoxEncordadoAcustica = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAcustica)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxEqAc
            // 
            this.checkBoxEqAc.AutoSize = true;
            this.checkBoxEqAc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxEqAc.Location = new System.Drawing.Point(65, 340);
            this.checkBoxEqAc.Name = "checkBoxEqAc";
            this.checkBoxEqAc.Size = new System.Drawing.Size(118, 17);
            this.checkBoxEqAc.TabIndex = 5;
            this.checkBoxEqAc.Text = "Incluye Ecualizador";
            this.checkBoxEqAc.UseVisualStyleBackColor = true;
            // 
            // cmbBoxColorAcustica
            // 
            this.cmbBoxColorAcustica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxColorAcustica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cmbBoxColorAcustica.FormattingEnabled = true;
            this.cmbBoxColorAcustica.ItemHeight = 15;
            this.cmbBoxColorAcustica.Items.AddRange(new object[] {
            "Natural",
            "Negro",
            "Verde",
            "Azul",
            "Rojo"});
            this.cmbBoxColorAcustica.Location = new System.Drawing.Point(65, 169);
            this.cmbBoxColorAcustica.Name = "cmbBoxColorAcustica";
            this.cmbBoxColorAcustica.Size = new System.Drawing.Size(121, 23);
            this.cmbBoxColorAcustica.TabIndex = 2;
            // 
            // textBoxAcustica
            // 
            this.textBoxAcustica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAcustica.Location = new System.Drawing.Point(65, 88);
            this.textBoxAcustica.Name = "textBoxAcustica";
            this.textBoxAcustica.Size = new System.Drawing.Size(121, 22);
            this.textBoxAcustica.TabIndex = 1;
            // 
            // btnCargarAcustica
            // 
            this.btnCargarAcustica.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarAcustica.Location = new System.Drawing.Point(65, 415);
            this.btnCargarAcustica.Name = "btnCargarAcustica";
            this.btnCargarAcustica.Size = new System.Drawing.Size(136, 30);
            this.btnCargarAcustica.TabIndex = 6;
            this.btnCargarAcustica.Text = "Cargar Acustica";
            this.btnCargarAcustica.UseVisualStyleBackColor = true;
            this.btnCargarAcustica.Click += new System.EventHandler(this.btnCargarAcustica_Click);
            // 
            // lblColorAcustica
            // 
            this.lblColorAcustica.AutoSize = true;
            this.lblColorAcustica.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblColorAcustica.Location = new System.Drawing.Point(65, 142);
            this.lblColorAcustica.Name = "lblColorAcustica";
            this.lblColorAcustica.Size = new System.Drawing.Size(106, 13);
            this.lblColorAcustica.TabIndex = 8;
            this.lblColorAcustica.Text = "Color del Instrumento";
            // 
            // lblModeloAcustica
            // 
            this.lblModeloAcustica.AutoSize = true;
            this.lblModeloAcustica.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblModeloAcustica.Location = new System.Drawing.Point(65, 69);
            this.lblModeloAcustica.Name = "lblModeloAcustica";
            this.lblModeloAcustica.Size = new System.Drawing.Size(42, 13);
            this.lblModeloAcustica.TabIndex = 7;
            this.lblModeloAcustica.Text = "Modelo";
            // 
            // lblTituloAcustica
            // 
            this.lblTituloAcustica.AutoSize = true;
            this.lblTituloAcustica.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAcustica.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTituloAcustica.Location = new System.Drawing.Point(65, 23);
            this.lblTituloAcustica.Name = "lblTituloAcustica";
            this.lblTituloAcustica.Size = new System.Drawing.Size(221, 19);
            this.lblTituloAcustica.TabIndex = 0;
            this.lblTituloAcustica.Text = "Ensamblado Guitarra Acustica";
            // 
            // pictureBoxAcustica
            // 
            this.pictureBoxAcustica.Image = global::FormFabrica.Properties.Resources.guitarAcoustic;
            this.pictureBoxAcustica.Location = new System.Drawing.Point(430, 38);
            this.pictureBoxAcustica.Name = "pictureBoxAcustica";
            this.pictureBoxAcustica.Size = new System.Drawing.Size(294, 408);
            this.pictureBoxAcustica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAcustica.TabIndex = 8;
            this.pictureBoxAcustica.TabStop = false;
            // 
            // lblErrorModeloAcustica
            // 
            this.lblErrorModeloAcustica.AutoSize = true;
            this.lblErrorModeloAcustica.ForeColor = System.Drawing.Color.Red;
            this.lblErrorModeloAcustica.Location = new System.Drawing.Point(45, 93);
            this.lblErrorModeloAcustica.Name = "lblErrorModeloAcustica";
            this.lblErrorModeloAcustica.Size = new System.Drawing.Size(14, 13);
            this.lblErrorModeloAcustica.TabIndex = 10;
            this.lblErrorModeloAcustica.Text = "X";
            // 
            // lblErrorColorAcustica
            // 
            this.lblErrorColorAcustica.AutoSize = true;
            this.lblErrorColorAcustica.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblErrorColorAcustica.ForeColor = System.Drawing.Color.Red;
            this.lblErrorColorAcustica.Location = new System.Drawing.Point(45, 174);
            this.lblErrorColorAcustica.Name = "lblErrorColorAcustica";
            this.lblErrorColorAcustica.Size = new System.Drawing.Size(14, 13);
            this.lblErrorColorAcustica.TabIndex = 11;
            this.lblErrorColorAcustica.Text = "X";
            // 
            // lblErrorClavijasAcustica
            // 
            this.lblErrorClavijasAcustica.AutoSize = true;
            this.lblErrorClavijasAcustica.ForeColor = System.Drawing.Color.Red;
            this.lblErrorClavijasAcustica.Location = new System.Drawing.Point(45, 238);
            this.lblErrorClavijasAcustica.Name = "lblErrorClavijasAcustica";
            this.lblErrorClavijasAcustica.Size = new System.Drawing.Size(14, 13);
            this.lblErrorClavijasAcustica.TabIndex = 12;
            this.lblErrorClavijasAcustica.Text = "X";
            // 
            // lblErrorEncordadoAcustica
            // 
            this.lblErrorEncordadoAcustica.AutoSize = true;
            this.lblErrorEncordadoAcustica.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEncordadoAcustica.Location = new System.Drawing.Point(45, 297);
            this.lblErrorEncordadoAcustica.Name = "lblErrorEncordadoAcustica";
            this.lblErrorEncordadoAcustica.Size = new System.Drawing.Size(14, 13);
            this.lblErrorEncordadoAcustica.TabIndex = 13;
            this.lblErrorEncordadoAcustica.Text = "X";
            // 
            // lblClavijasAcustica
            // 
            this.lblClavijasAcustica.AutoSize = true;
            this.lblClavijasAcustica.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClavijasAcustica.Location = new System.Drawing.Point(65, 212);
            this.lblClavijasAcustica.Name = "lblClavijasAcustica";
            this.lblClavijasAcustica.Size = new System.Drawing.Size(43, 13);
            this.lblClavijasAcustica.TabIndex = 14;
            this.lblClavijasAcustica.Text = "Clavijas";
            // 
            // lblEncordadoAcustica
            // 
            this.lblEncordadoAcustica.AutoSize = true;
            this.lblEncordadoAcustica.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEncordadoAcustica.Location = new System.Drawing.Point(65, 272);
            this.lblEncordadoAcustica.Name = "lblEncordadoAcustica";
            this.lblEncordadoAcustica.Size = new System.Drawing.Size(59, 13);
            this.lblEncordadoAcustica.TabIndex = 15;
            this.lblEncordadoAcustica.Text = "Encordado";
            // 
            // cmbBoxClavijasAcustica
            // 
            this.cmbBoxClavijasAcustica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxClavijasAcustica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cmbBoxClavijasAcustica.FormattingEnabled = true;
            this.cmbBoxClavijasAcustica.Items.AddRange(new object[] {
            "TresMasTres",
            "TresMasTresVintage"});
            this.cmbBoxClavijasAcustica.Location = new System.Drawing.Point(65, 233);
            this.cmbBoxClavijasAcustica.Name = "cmbBoxClavijasAcustica";
            this.cmbBoxClavijasAcustica.Size = new System.Drawing.Size(121, 23);
            this.cmbBoxClavijasAcustica.TabIndex = 16;
            // 
            // cmbBoxEncordadoAcustica
            // 
            this.cmbBoxEncordadoAcustica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxEncordadoAcustica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cmbBoxEncordadoAcustica.FormattingEnabled = true;
            this.cmbBoxEncordadoAcustica.Items.AddRange(new object[] {
            "Daddario",
            "ErnieBall"});
            this.cmbBoxEncordadoAcustica.Location = new System.Drawing.Point(65, 292);
            this.cmbBoxEncordadoAcustica.Name = "cmbBoxEncordadoAcustica";
            this.cmbBoxEncordadoAcustica.Size = new System.Drawing.Size(121, 23);
            this.cmbBoxEncordadoAcustica.TabIndex = 17;
            // 
            // FormAcustica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(723, 485);
            this.Controls.Add(this.cmbBoxEncordadoAcustica);
            this.Controls.Add(this.cmbBoxClavijasAcustica);
            this.Controls.Add(this.lblEncordadoAcustica);
            this.Controls.Add(this.lblClavijasAcustica);
            this.Controls.Add(this.lblErrorEncordadoAcustica);
            this.Controls.Add(this.lblErrorClavijasAcustica);
            this.Controls.Add(this.lblErrorColorAcustica);
            this.Controls.Add(this.lblErrorModeloAcustica);
            this.Controls.Add(this.lblTituloAcustica);
            this.Controls.Add(this.pictureBoxAcustica);
            this.Controls.Add(this.lblModeloAcustica);
            this.Controls.Add(this.lblColorAcustica);
            this.Controls.Add(this.btnCargarAcustica);
            this.Controls.Add(this.textBoxAcustica);
            this.Controls.Add(this.cmbBoxColorAcustica);
            this.Controls.Add(this.checkBoxEqAc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAcustica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producción Guitarra Acustica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAcustica_FormClosing);
            this.Load += new System.EventHandler(this.FormAcustica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAcustica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEqAc;
        private System.Windows.Forms.ComboBox cmbBoxColorAcustica;
        private System.Windows.Forms.TextBox textBoxAcustica;
        private System.Windows.Forms.Button btnCargarAcustica;
        private System.Windows.Forms.Label lblColorAcustica;
        private System.Windows.Forms.Label lblModeloAcustica;
        private System.Windows.Forms.PictureBox pictureBoxAcustica;
        private System.Windows.Forms.Label lblTituloAcustica;
        private System.Windows.Forms.Label lblErrorModeloAcustica;
        private System.Windows.Forms.Label lblErrorColorAcustica;
        private System.Windows.Forms.Label lblErrorClavijasAcustica;
        private System.Windows.Forms.Label lblErrorEncordadoAcustica;
        private System.Windows.Forms.Label lblClavijasAcustica;
        private System.Windows.Forms.Label lblEncordadoAcustica;
        private System.Windows.Forms.ComboBox cmbBoxClavijasAcustica;
        private System.Windows.Forms.ComboBox cmbBoxEncordadoAcustica;
    }
}