namespace WindowsFormsApp1
{
    partial class FormVaiAllaRiga
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
            this.components = new System.ComponentModel.Container();
            this.btnVaiA = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.lblNumeroRiga = new System.Windows.Forms.Label();
            this.txtNumeroRiga = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVaiA
            // 
            this.btnVaiA.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnVaiA.Location = new System.Drawing.Point(22, 51);
            this.btnVaiA.Name = "btnVaiA";
            this.btnVaiA.Size = new System.Drawing.Size(102, 44);
            this.btnVaiA.TabIndex = 0;
            this.btnVaiA.Text = "Vai a";
            this.btnVaiA.UseVisualStyleBackColor = true;
            this.btnVaiA.Click += new System.EventHandler(this.btnVaiA_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnulla.Location = new System.Drawing.Point(130, 51);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(103, 44);
            this.btnAnnulla.TabIndex = 1;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // lblNumeroRiga
            // 
            this.lblNumeroRiga.AutoSize = true;
            this.lblNumeroRiga.Location = new System.Drawing.Point(13, 13);
            this.lblNumeroRiga.Name = "lblNumeroRiga";
            this.lblNumeroRiga.Size = new System.Drawing.Size(66, 13);
            this.lblNumeroRiga.TabIndex = 2;
            this.lblNumeroRiga.Text = "NumeroRiga";
            // 
            // txtNumeroRiga
            // 
            this.txtNumeroRiga.Location = new System.Drawing.Point(85, 13);
            this.txtNumeroRiga.Name = "txtNumeroRiga";
            this.txtNumeroRiga.Size = new System.Drawing.Size(148, 20);
            this.txtNumeroRiga.TabIndex = 3;
            this.txtNumeroRiga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroRiga_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormVaiAllaRiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 107);
            this.Controls.Add(this.txtNumeroRiga);
            this.Controls.Add(this.lblNumeroRiga);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnVaiA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormVaiAllaRiga";
            this.Text = "FormVaiAllaRiga";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVaiAllaRiga_FormClosing);
            this.Load += new System.EventHandler(this.FormVaiAllaRiga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVaiA;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Label lblNumeroRiga;
        private System.Windows.Forms.TextBox txtNumeroRiga;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}