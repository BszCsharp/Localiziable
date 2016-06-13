namespace Localiziable
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAnr = new System.Windows.Forms.TextBox();
            this.textBoxMenge = new System.Windows.Forms.TextBox();
            this.textBoxKnr = new System.Windows.Forms.TextBox();
            this.textBoxDatum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBoxAnr
            // 
            resources.ApplyResources(this.textBoxAnr, "textBoxAnr");
            this.textBoxAnr.Name = "textBoxAnr";
            // 
            // textBoxMenge
            // 
            resources.ApplyResources(this.textBoxMenge, "textBoxMenge");
            this.textBoxMenge.Name = "textBoxMenge";
            // 
            // textBoxKnr
            // 
            resources.ApplyResources(this.textBoxKnr, "textBoxKnr");
            this.textBoxKnr.Name = "textBoxKnr";
            // 
            // textBoxDatum
            // 
            resources.ApplyResources(this.textBoxDatum, "textBoxDatum");
            this.textBoxDatum.Name = "textBoxDatum";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxDatum);
            this.Controls.Add(this.textBoxKnr);
            this.Controls.Add(this.textBoxMenge);
            this.Controls.Add(this.textBoxAnr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAnr;
        private System.Windows.Forms.TextBox textBoxMenge;
        private System.Windows.Forms.TextBox textBoxKnr;
        private System.Windows.Forms.TextBox textBoxDatum;
    }
}

