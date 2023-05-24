namespace WinFormsApp3
{
    partial class Blackjack_Meny
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Välkommen = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Inst = new System.Windows.Forms.Button();
            this.button_Vinnare = new System.Windows.Forms.Button();
            this.button_Avslut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Välkommen
            // 
            this.label_Välkommen.AutoSize = true;
            this.label_Välkommen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Välkommen.Location = new System.Drawing.Point(95, 28);
            this.label_Välkommen.Name = "label_Välkommen";
            this.label_Välkommen.Size = new System.Drawing.Size(276, 32);
            this.label_Välkommen.TabIndex = 0;
            this.label_Välkommen.Text = "Välkommen till Blackjack";
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(150, 84);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(154, 23);
            this.button_Start.TabIndex = 1;
            this.button_Start.Text = "Starta Spelet";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Inst
            // 
            this.button_Inst.Location = new System.Drawing.Point(150, 113);
            this.button_Inst.Name = "button_Inst";
            this.button_Inst.Size = new System.Drawing.Size(154, 23);
            this.button_Inst.TabIndex = 2;
            this.button_Inst.Text = "Inställningar";
            this.button_Inst.UseVisualStyleBackColor = true;
            // 
            // button_Vinnare
            // 
            this.button_Vinnare.Location = new System.Drawing.Point(150, 142);
            this.button_Vinnare.Name = "button_Vinnare";
            this.button_Vinnare.Size = new System.Drawing.Size(154, 23);
            this.button_Vinnare.TabIndex = 3;
            this.button_Vinnare.Text = "Vinnarstatistik";
            this.button_Vinnare.UseVisualStyleBackColor = true;
            // 
            // button_Avslut
            // 
            this.button_Avslut.Location = new System.Drawing.Point(150, 171);
            this.button_Avslut.Name = "button_Avslut";
            this.button_Avslut.Size = new System.Drawing.Size(154, 23);
            this.button_Avslut.TabIndex = 4;
            this.button_Avslut.Text = "Avsluta";
            this.button_Avslut.UseVisualStyleBackColor = true;
            // 
            // Blackjack_Meny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 326);
            this.Controls.Add(this.button_Avslut);
            this.Controls.Add(this.button_Vinnare);
            this.Controls.Add(this.button_Inst);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label_Välkommen);
            this.Name = "Blackjack_Meny";
            this.Text = "Blackjack - Meny";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Välkommen;
        private Button button_Start;
        private Button button_Inst;
        private Button button_Vinnare;
        private Button button_Avslut;
    }
}