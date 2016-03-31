namespace LOCPRO
{
    partial class Form2
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
            this.Specialité = new System.Windows.Forms.ListBox();
            this.Autre = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Specialité
            // 
            this.Specialité.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Specialité.FormattingEnabled = true;
            this.Specialité.Location = new System.Drawing.Point(12, 12);
            this.Specialité.Name = "Specialité";
            this.Specialité.Size = new System.Drawing.Size(456, 446);
            this.Specialité.TabIndex = 0;
            // 
            // Autre
            // 
            this.Autre.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Autre.FormattingEnabled = true;
            this.Autre.Location = new System.Drawing.Point(487, 12);
            this.Autre.Name = "Autre";
            this.Autre.Size = new System.Drawing.Size(439, 446);
            this.Autre.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(307, 464);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(448, 464);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 37);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(928, 504);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Autre);
            this.Controls.Add(this.Specialité);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Specialité;
        private System.Windows.Forms.ListBox Autre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}