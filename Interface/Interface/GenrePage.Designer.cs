namespace YLZ5155_Interface_1
{
    partial class GenrePage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpCreateGenre = new System.Windows.Forms.GroupBox();
            this.txtCreateName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateGenre = new System.Windows.Forms.Button();
            this.grpFind = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpCreateGenre.SuspendLayout();
            this.grpFind.SuspendLayout();
            this.grpUpdate.SuspendLayout();
            this.grpDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1155, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // grpCreateGenre
            // 
            this.grpCreateGenre.Controls.Add(this.btnCreateGenre);
            this.grpCreateGenre.Controls.Add(this.label1);
            this.grpCreateGenre.Controls.Add(this.txtCreateName);
            this.grpCreateGenre.Location = new System.Drawing.Point(13, 13);
            this.grpCreateGenre.Name = "grpCreateGenre";
            this.grpCreateGenre.Size = new System.Drawing.Size(172, 100);
            this.grpCreateGenre.TabIndex = 1;
            this.grpCreateGenre.TabStop = false;
            this.grpCreateGenre.Text = "Create Genre";
            // 
            // txtCreateName
            // 
            this.txtCreateName.Location = new System.Drawing.Point(58, 19);
            this.txtCreateName.Name = "txtCreateName";
            this.txtCreateName.Size = new System.Drawing.Size(100, 20);
            this.txtCreateName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // btnCreateGenre
            // 
            this.btnCreateGenre.Location = new System.Drawing.Point(83, 45);
            this.btnCreateGenre.Name = "btnCreateGenre";
            this.btnCreateGenre.Size = new System.Drawing.Size(75, 23);
            this.btnCreateGenre.TabIndex = 2;
            this.btnCreateGenre.Text = "Create";
            this.btnCreateGenre.UseVisualStyleBackColor = true;
            this.btnCreateGenre.Click += new System.EventHandler(this.btnCreateGenre_Click);
            // 
            // grpFind
            // 
            this.grpFind.Controls.Add(this.btnFind);
            this.grpFind.Controls.Add(this.label2);
            this.grpFind.Controls.Add(this.txtFind);
            this.grpFind.Location = new System.Drawing.Point(211, 13);
            this.grpFind.Name = "grpFind";
            this.grpFind.Size = new System.Drawing.Size(172, 53);
            this.grpFind.TabIndex = 1;
            this.grpFind.TabStop = false;
            this.grpFind.Text = "Find Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(38, 18);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(47, 20);
            this.txtFind.TabIndex = 0;
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.btnUpdate);
            this.grpUpdate.Controls.Add(this.label3);
            this.grpUpdate.Controls.Add(this.txtUpdateName);
            this.grpUpdate.Location = new System.Drawing.Point(211, 72);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(172, 81);
            this.grpUpdate.TabIndex = 1;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Update Genre";
            this.grpUpdate.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(58, 19);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(108, 20);
            this.txtUpdateName.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(91, 16);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(91, 45);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpDelete
            // 
            this.grpDelete.Controls.Add(this.label4);
            this.grpDelete.Controls.Add(this.txtDelete);
            this.grpDelete.Controls.Add(this.btnDelete);
            this.grpDelete.Location = new System.Drawing.Point(416, 29);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Size = new System.Drawing.Size(200, 52);
            this.grpDelete.TabIndex = 2;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "Delete Genre";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(88, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(38, 20);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(44, 20);
            this.txtDelete.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Id";
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(22, 178);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(75, 23);
            this.btnGetAll.TabIndex = 3;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // GenrePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 515);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.grpDelete);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.grpFind);
            this.Controls.Add(this.grpCreateGenre);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GenrePage";
            this.Text = "GenrePage";
            this.Load += new System.EventHandler(this.GenrePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpCreateGenre.ResumeLayout(false);
            this.grpCreateGenre.PerformLayout();
            this.grpFind.ResumeLayout(false);
            this.grpFind.PerformLayout();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpCreateGenre;
        private System.Windows.Forms.Button btnCreateGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCreateName;
        private System.Windows.Forms.GroupBox grpFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Button btnGetAll;
    }
}