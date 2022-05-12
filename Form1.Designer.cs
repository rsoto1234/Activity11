namespace WinFormsApp10
{
    partial class Form1
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
            this.btnRollDice = new System.Windows.Forms.Button();
            this.lblDice1 = new System.Windows.Forms.Label();
            this.lblDice2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // btnRollDice
            //
            this.btnRollDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollDice.Location = new System.Drawing.Point(21, 47);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(103, 72);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            //
            // lblDice1
            //
            this.lblDice1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice1.ForeColor = System.Drawing.Color.White;
            this.lblDice1.Location = new System.Drawing.Point(158, 56);
            this.lblDice1.Name = "lblDice1";
            this.lblDice1.Size = new System.Drawing.Size(66, 46);
            this.lblDice1.TabIndex = 1;
            this.lblDice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblDice2
            //
            this.lblDice2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice2.ForeColor = System.Drawing.Color.White;
            this.lblDice2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblDice2.Location = new System.Drawing.Point(261, 56);
            this.lblDice2.Name = "lblDice2";
            this.lblDice2.Size = new System.Drawing.Size(66, 46);
            this.lblDice2.TabIndex = 2;
            this.lblDice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(357, 166);
            this.Controls.Add(this.lblDice2);
            this.Controls.Add(this.lblDice1);
            this.Controls.Add(this.btnRollDice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Label lblDice1;
        private System.Windows.Forms.Label lblDice2;
    }
}