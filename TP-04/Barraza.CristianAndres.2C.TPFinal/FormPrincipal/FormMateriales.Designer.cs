
namespace FormFabrica
{
    partial class FormMateriales
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
            this.richBoxMateriales = new System.Windows.Forms.RichTextBox();
            this.lblMateriales = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richBoxMateriales
            // 
            this.richBoxMateriales.BackColor = System.Drawing.SystemColors.Menu;
            this.richBoxMateriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.richBoxMateriales.Location = new System.Drawing.Point(43, 80);
            this.richBoxMateriales.Name = "richBoxMateriales";
            this.richBoxMateriales.ReadOnly = true;
            this.richBoxMateriales.Size = new System.Drawing.Size(652, 376);
            this.richBoxMateriales.TabIndex = 0;
            this.richBoxMateriales.Text = "";
            this.richBoxMateriales.TextChanged += new System.EventHandler(this.richBoxMateriales_TextChanged);
            // 
            // lblMateriales
            // 
            this.lblMateriales.AutoSize = true;
            this.lblMateriales.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMateriales.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateriales.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMateriales.Location = new System.Drawing.Point(121, 29);
            this.lblMateriales.Name = "lblMateriales";
            this.lblMateriales.Size = new System.Drawing.Size(518, 36);
            this.lblMateriales.TabIndex = 1;
            this.lblMateriales.Text = "Stock de Accesorios y Materiales de Producción";
            // 
            // FormMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(723, 485);
            this.Controls.Add(this.lblMateriales);
            this.Controls.Add(this.richBoxMateriales);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMateriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Materiales";
            this.Load += new System.EventHandler(this.FormMateriales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richBoxMateriales;
        private System.Windows.Forms.Label lblMateriales;
    }
}