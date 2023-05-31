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
            this.Händelse = new System.Windows.Forms.Label();
            this.Din_Poäng = new System.Windows.Forms.Label();
            this.Datorns_Poäng = new System.Windows.Forms.Label();
            this.button_Fortsätt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Hit
            // 
            this.button_Hit.Location = new System.Drawing.Point(57, 223);
            this.button_Hit.Name = "button_Hit";
            this.button_Hit.Size = new System.Drawing.Size(126, 23);
            this.button_Hit.TabIndex = 0;
            this.button_Hit.Text = "Hit";
            this.button_Hit.UseVisualStyleBackColor = true;
            this.button_Hit.Click += new System.EventHandler(this.button_Hit_Click);
            // 
            // button_Stand
            // 
            this.button_Stand.Location = new System.Drawing.Point(204, 223);
            this.button_Stand.Name = "button_Stand";
            this.button_Stand.Size = new System.Drawing.Size(126, 23);
            this.button_Stand.TabIndex = 1;
            this.button_Stand.Text = "Stand";
            this.button_Stand.UseVisualStyleBackColor = true;
            this.button_Stand.Click += new System.EventHandler(this.button_Stand_Click);
            // 
            // Händelse
            // 
            this.Händelse.AutoSize = true;
            this.Händelse.Location = new System.Drawing.Point(171, 84);
            this.Händelse.Name = "Händelse";
            this.Händelse.Size = new System.Drawing.Size(38, 15);
            this.Händelse.TabIndex = 2;
            this.Händelse.Text = "label1";
            // 
            // Din_Poäng
            // 
            this.Din_Poäng.AutoSize = true;
            this.Din_Poäng.Location = new System.Drawing.Point(57, 156);
            this.Din_Poäng.Name = "Din_Poäng";
            this.Din_Poäng.Size = new System.Drawing.Size(71, 15);
            this.Din_Poäng.TabIndex = 3;
            this.Din_Poäng.Text = "Dina poäng:";
            // 
            // Datorns_Poäng
            // 
            this.Datorns_Poäng.AutoSize = true;
            this.Datorns_Poäng.Location = new System.Drawing.Point(57, 128);
            this.Datorns_Poäng.Name = "Datorns_Poäng";
            this.Datorns_Poäng.Size = new System.Drawing.Size(91, 15);
            this.Datorns_Poäng.TabIndex = 4;
            this.Datorns_Poäng.Text = "Datorns poäng: ";
            // 
            // button_Fortsätt
            // 
            this.button_Fortsätt.Location = new System.Drawing.Point(156, 194);
            this.button_Fortsätt.Name = "button_Fortsätt";
            this.button_Fortsätt.Size = new System.Drawing.Size(75, 23);
            this.button_Fortsätt.TabIndex = 5;
            this.button_Fortsätt.Text = "Fortsätt";
            this.button_Fortsätt.UseVisualStyleBackColor = true;
            this.button_Fortsätt.Click += new System.EventHandler(this.button_Fortsätt_Click);
            // 
            // Blackjack_Spel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.button_Fortsätt);
            this.Controls.Add(this.Datorns_Poäng);
            this.Controls.Add(this.Din_Poäng);
            this.Controls.Add(this.Händelse);
            this.Controls.Add(this.button_Stand);
            this.Controls.Add(this.button_Hit);
            this.Name = "Blackjack_Spel";
            this.Text = "Blackjack_Spel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_Hit;
        private Button button_Stand;
        private Label Händelse;
        private Label Din_Poäng;
        private Label Datorns_Poäng;
        private Button button_Fortsätt;
    }
}