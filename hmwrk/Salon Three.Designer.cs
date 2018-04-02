namespace letsCinema
{
    partial class Salon_Three
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
            this.SalonName3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SalonName3
            // 
            this.SalonName3.AutoSize = true;
            this.SalonName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalonName3.Location = new System.Drawing.Point(342, 25);
            this.SalonName3.Name = "SalonName3";
            this.SalonName3.Size = new System.Drawing.Size(66, 24);
            this.SalonName3.TabIndex = 0;
            this.SalonName3.Text = "label1";
            // 
            // Salon_Three
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalonName3);
            this.Name = "Salon_Three";
            this.Text = "Salon_Three";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label SalonName3;
    }
}