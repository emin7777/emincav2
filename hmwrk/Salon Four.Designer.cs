namespace letsCinema
{
    partial class Salon_Four
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
            this.SalonName4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SalonName4
            // 
            this.SalonName4.AutoSize = true;
            this.SalonName4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalonName4.Location = new System.Drawing.Point(361, 19);
            this.SalonName4.Name = "SalonName4";
            this.SalonName4.Size = new System.Drawing.Size(66, 24);
            this.SalonName4.TabIndex = 0;
            this.SalonName4.Text = "label1";
            // 
            // Salon_Four
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalonName4);
            this.Name = "Salon_Four";
            this.Text = "Salon_Four";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label SalonName4;
    }
}