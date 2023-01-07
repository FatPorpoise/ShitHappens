namespace ShitHappens.View
{
    partial class GameForm
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
            this.playerCardsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.playerTurnLabel = new System.Windows.Forms.Label();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.playerNameLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.playerNameLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerCardsLayout
            // 
            this.playerCardsLayout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerCardsLayout.AutoSize = true;
            this.playerCardsLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playerCardsLayout.Location = new System.Drawing.Point(469, 323);
            this.playerCardsLayout.Margin = new System.Windows.Forms.Padding(0);
            this.playerCardsLayout.Name = "playerCardsLayout";
            this.playerCardsLayout.Size = new System.Drawing.Size(0, 0);
            this.playerCardsLayout.TabIndex = 0;
            this.playerCardsLayout.Resize += new System.EventHandler(this.playerCardsLayout_Resize);
            // 
            // playerTurnLabel
            // 
            this.playerTurnLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerTurnLabel.AutoSize = true;
            this.playerTurnLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerTurnLabel.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerTurnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(205)))), ((int)(((byte)(72)))));
            this.playerTurnLabel.Location = new System.Drawing.Point(3, 0);
            this.playerTurnLabel.Name = "playerTurnLabel";
            this.playerTurnLabel.Size = new System.Drawing.Size(205, 43);
            this.playerTurnLabel.TabIndex = 1;
            this.playerTurnLabel.Text = "Current player:";
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerNameLabel.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(205)))), ((int)(((byte)(72)))));
            this.playerNameLabel.Location = new System.Drawing.Point(214, 0);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(0, 43);
            this.playerNameLabel.TabIndex = 2;
            // 
            // playerNameLayout
            // 
            this.playerNameLayout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playerNameLayout.AutoSize = true;
            this.playerNameLayout.Controls.Add(this.playerTurnLabel);
            this.playerNameLayout.Controls.Add(this.playerNameLabel);
            this.playerNameLayout.Location = new System.Drawing.Point(309, 12);
            this.playerNameLayout.Name = "playerNameLayout";
            this.playerNameLayout.Size = new System.Drawing.Size(217, 49);
            this.playerNameLayout.TabIndex = 3;
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(205)))), ((int)(((byte)(72)))));
            this.MenuButton.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuButton.Location = new System.Drawing.Point(23, 20);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(116, 35);
            this.MenuButton.TabIndex = 5;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(205)))), ((int)(((byte)(72)))));
            this.saveButton.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(161, 20);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(116, 35);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 601);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.playerCardsLayout);
            this.Controls.Add(this.playerNameLayout);
            this.Name = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.playerNameLayout.ResumeLayout(false);
            this.playerNameLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel playerCardsLayout;
        private Label playerTurnLabel;
        private Label playerNameLabel;
        private FlowLayoutPanel playerNameLayout;
        private Button MenuButton;
        private Button saveButton;
    }
}