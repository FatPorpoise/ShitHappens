namespace ShitHappens.View
{
    partial class CardControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.InsideColor = new System.Windows.Forms.Panel();
            this.distressLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.InsideColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // InsideColor
            // 
            this.InsideColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.InsideColor.Controls.Add(this.distressLabel);
            this.InsideColor.Controls.Add(this.valueLabel);
            this.InsideColor.Controls.Add(this.descriptionLabel);
            this.InsideColor.Location = new System.Drawing.Point(2, 2);
            this.InsideColor.MaximumSize = new System.Drawing.Size(156, 236);
            this.InsideColor.MinimumSize = new System.Drawing.Size(156, 236);
            this.InsideColor.Name = "InsideColor";
            this.InsideColor.Size = new System.Drawing.Size(156, 236);
            this.InsideColor.TabIndex = 0;
            // 
            // distressLabel
            // 
            this.distressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.distressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(205)))), ((int)(((byte)(72)))));
            this.distressLabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.distressLabel.ForeColor = System.Drawing.Color.Black;
            this.distressLabel.Location = new System.Drawing.Point(4, 192);
            this.distressLabel.MaximumSize = new System.Drawing.Size(90, 40);
            this.distressLabel.MinimumSize = new System.Drawing.Size(90, 40);
            this.distressLabel.Name = "distressLabel";
            this.distressLabel.Size = new System.Drawing.Size(90, 40);
            this.distressLabel.TabIndex = 1;
            this.distressLabel.Text = "Misery index:";
            this.distressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueLabel
            // 
            this.valueLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.valueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(205)))), ((int)(((byte)(72)))));
            this.valueLabel.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valueLabel.ForeColor = System.Drawing.Color.Black;
            this.valueLabel.Location = new System.Drawing.Point(81, 192);
            this.valueLabel.MaximumSize = new System.Drawing.Size(71, 40);
            this.valueLabel.MinimumSize = new System.Drawing.Size(71, 40);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(71, 40);
            this.valueLabel.TabIndex = 2;
            this.valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(205)))), ((int)(((byte)(72)))));
            this.descriptionLabel.Location = new System.Drawing.Point(2, 2);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.descriptionLabel.MaximumSize = new System.Drawing.Size(156, 190);
            this.descriptionLabel.MinimumSize = new System.Drawing.Size(156, 190);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(156, 190);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(205)))), ((int)(((byte)(72)))));
            this.Controls.Add(this.InsideColor);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(160, 240);
            this.MinimumSize = new System.Drawing.Size(160, 240);
            this.Name = "CardControl";
            this.Size = new System.Drawing.Size(160, 240);
            this.InsideColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel InsideColor;
        private Label descriptionLabel;
        private Label distressLabel;
        private Label valueLabel;
    }
}
