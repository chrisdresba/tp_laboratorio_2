
namespace FormFabrica
{
    partial class FormProductos
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
            this.richBoxProductos = new System.Windows.Forms.RichTextBox();
            this.lblProductos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richBoxProductos
            // 
            this.richBoxProductos.BackColor = System.Drawing.SystemColors.Menu;
            this.richBoxProductos.Location = new System.Drawing.Point(31, 105);
            this.richBoxProductos.Name = "richBoxProductos";
            this.richBoxProductos.Size = new System.Drawing.Size(662, 353);
            this.richBoxProductos.TabIndex = 0;
            this.richBoxProductos.Text = "";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProductos.Location = new System.Drawing.Point(225, 36);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(256, 36);
            this.lblProductos.TabIndex = 1;
            this.lblProductos.Text = "Stock de Instrumentos";
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(723, 485);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.richBoxProductos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Productos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richBoxProductos;
        private System.Windows.Forms.Label lblProductos;
    }
}