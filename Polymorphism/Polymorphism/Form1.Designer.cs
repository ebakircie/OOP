
namespace YZL5155_Polymorphism
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
            this.btnNokia = new System.Windows.Forms.Button();
            this.btnSamsung = new System.Windows.Forms.Button();
            this.btnIphone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNokia
            // 
            this.btnNokia.Location = new System.Drawing.Point(123, 28);
            this.btnNokia.Name = "btnNokia";
            this.btnNokia.Size = new System.Drawing.Size(177, 60);
            this.btnNokia.TabIndex = 0;
            this.btnNokia.Text = "Nokia";
            this.btnNokia.UseVisualStyleBackColor = true;
            this.btnNokia.Click += new System.EventHandler(this.btnNokia_Click);
            // 
            // btnSamsung
            // 
            this.btnSamsung.Location = new System.Drawing.Point(123, 94);
            this.btnSamsung.Name = "btnSamsung";
            this.btnSamsung.Size = new System.Drawing.Size(177, 60);
            this.btnSamsung.TabIndex = 0;
            this.btnSamsung.Text = "Samsung";
            this.btnSamsung.UseVisualStyleBackColor = true;
            this.btnSamsung.Click += new System.EventHandler(this.btnSamsung_Click);
            // 
            // btnIphone
            // 
            this.btnIphone.Location = new System.Drawing.Point(123, 160);
            this.btnIphone.Name = "btnIphone";
            this.btnIphone.Size = new System.Drawing.Size(177, 60);
            this.btnIphone.TabIndex = 0;
            this.btnIphone.Text = "Iphone";
            this.btnIphone.UseVisualStyleBackColor = true;
            this.btnIphone.Click += new System.EventHandler(this.btnIphone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 324);
            this.Controls.Add(this.btnSamsung);
            this.Controls.Add(this.btnIphone);
            this.Controls.Add(this.btnNokia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNokia;
        private System.Windows.Forms.Button btnSamsung;
        private System.Windows.Forms.Button btnIphone;
    }
}

