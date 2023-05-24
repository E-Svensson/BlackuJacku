namespace WinFormsApp3
{
    partial class Blackjack_Spel
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
            this.button_Hit = new System.Windows.Forms.Button();
            this.button_Stand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Hit
            // 
            this.button_Hit.Location = new System.Drawing.Point(113, 189);
            this.button_Hit.Name = "button_Hit";
            this.button_Hit.Size = new System.Drawing.Size(126, 23);
            this.button_Hit.TabIndex = 0;
            this.button_Hit.Text = "Hit";
            this.button_Hit.UseVisualStyleBackColor = true;
            // 
            // button_Stand
            // 
            this.button_Stand.Location = new System.Drawing.Point(245, 189);
            this.button_Stand.Name = "button_Stand";
            this.button_Stand.Size = new System.Drawing.Size(126, 23);
            this.button_Stand.TabIndex = 1;
            this.button_Stand.Text = "Stand";
            this.button_Stand.UseVisualStyleBackColor = true;
            // 
            // Blackjack_Spel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.button_Stand);
            this.Controls.Add(this.button_Hit);
            this.Name = "Blackjack_Spel";
            this.Text = "Blackjack_Spel";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_Hit;
        private Button button_Stand;
    }
}