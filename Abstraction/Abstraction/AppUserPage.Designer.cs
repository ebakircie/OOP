
namespace YZL5155_Abstract_3
{
    partial class AppUserPage
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
            this.grpCreate = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cmbCreateRole = new System.Windows.Forms.ComboBox();
            this.txtCreateLastName = new System.Windows.Forms.TextBox();
            this.txtCreateFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbUpdateRole = new System.Windows.Forms.ComboBox();
            this.txtUpdateLastName = new System.Windows.Forms.TextBox();
            this.txtFindById = new System.Windows.Forms.TextBox();
            this.txtUpdateFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grpFindByRole = new System.Windows.Forms.GroupBox();
            this.cmbFindByRole = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFindByRole = new System.Windows.Forms.Button();
            this.grpCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpUpdate.SuspendLayout();
            this.grpDelete.SuspendLayout();
            this.grpFindByRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCreate
            // 
            this.grpCreate.Controls.Add(this.btnCreate);
            this.grpCreate.Controls.Add(this.cmbCreateRole);
            this.grpCreate.Controls.Add(this.txtCreateLastName);
            this.grpCreate.Controls.Add(this.txtCreateFirstName);
            this.grpCreate.Controls.Add(this.label3);
            this.grpCreate.Controls.Add(this.label2);
            this.grpCreate.Controls.Add(this.label1);
            this.grpCreate.Location = new System.Drawing.Point(12, 12);
            this.grpCreate.Name = "grpCreate";
            this.grpCreate.Size = new System.Drawing.Size(344, 238);
            this.grpCreate.TabIndex = 0;
            this.grpCreate.TabStop = false;
            this.grpCreate.Text = "Create User";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(239, 168);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(81, 34);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cmbCreateRole
            // 
            this.cmbCreateRole.FormattingEnabled = true;
            this.cmbCreateRole.Location = new System.Drawing.Point(149, 123);
            this.cmbCreateRole.Name = "cmbCreateRole";
            this.cmbCreateRole.Size = new System.Drawing.Size(172, 28);
            this.cmbCreateRole.TabIndex = 3;
            // 
            // txtCreateLastName
            // 
            this.txtCreateLastName.Location = new System.Drawing.Point(148, 82);
            this.txtCreateLastName.Name = "txtCreateLastName";
            this.txtCreateLastName.Size = new System.Drawing.Size(172, 26);
            this.txtCreateLastName.TabIndex = 2;
            // 
            // txtCreateFirstName
            // 
            this.txtCreateFirstName.Location = new System.Drawing.Point(149, 39);
            this.txtCreateFirstName.Name = "txtCreateFirstName";
            this.txtCreateFirstName.Size = new System.Drawing.Size(172, 26);
            this.txtCreateFirstName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Choose a Role:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1028, 410);
            this.dataGridView1.TabIndex = 1;
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.button2);
            this.grpUpdate.Controls.Add(this.btnFind);
            this.grpUpdate.Controls.Add(this.btnUpdate);
            this.grpUpdate.Controls.Add(this.cmbUpdateRole);
            this.grpUpdate.Controls.Add(this.txtUpdateLastName);
            this.grpUpdate.Controls.Add(this.txtFindById);
            this.grpUpdate.Controls.Add(this.txtUpdateFirstName);
            this.grpUpdate.Controls.Add(this.label4);
            this.grpUpdate.Controls.Add(this.label7);
            this.grpUpdate.Controls.Add(this.label5);
            this.grpUpdate.Controls.Add(this.label6);
            this.grpUpdate.Location = new System.Drawing.Point(362, 12);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(344, 238);
            this.grpUpdate.TabIndex = 0;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Update User";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(221, 39);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(102, 26);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(220, 197);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 26);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbUpdateRole
            // 
            this.cmbUpdateRole.FormattingEnabled = true;
            this.cmbUpdateRole.Location = new System.Drawing.Point(151, 163);
            this.cmbUpdateRole.Name = "cmbUpdateRole";
            this.cmbUpdateRole.Size = new System.Drawing.Size(172, 28);
            this.cmbUpdateRole.TabIndex = 3;
            this.cmbUpdateRole.Click += new System.EventHandler(this.cmbUpdateRole_Click);
            // 
            // txtUpdateLastName
            // 
            this.txtUpdateLastName.Location = new System.Drawing.Point(150, 122);
            this.txtUpdateLastName.Name = "txtUpdateLastName";
            this.txtUpdateLastName.Size = new System.Drawing.Size(172, 26);
            this.txtUpdateLastName.TabIndex = 2;
            // 
            // txtFindById
            // 
            this.txtFindById.Location = new System.Drawing.Point(150, 39);
            this.txtFindById.Name = "txtFindById";
            this.txtFindById.Size = new System.Drawing.Size(64, 26);
            this.txtFindById.TabIndex = 2;
            // 
            // txtUpdateFirstName
            // 
            this.txtUpdateFirstName.Location = new System.Drawing.Point(151, 79);
            this.txtUpdateFirstName.Name = "txtUpdateFirstName";
            this.txtUpdateFirstName.Size = new System.Drawing.Size(172, 26);
            this.txtUpdateFirstName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Choose a Role:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "First Name:";
            // 
            // grpDelete
            // 
            this.grpDelete.Controls.Add(this.btnDelete);
            this.grpDelete.Controls.Add(this.txtDelete);
            this.grpDelete.Controls.Add(this.label9);
            this.grpDelete.Location = new System.Drawing.Point(712, 12);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Size = new System.Drawing.Size(328, 84);
            this.grpDelete.TabIndex = 0;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "Delete User";
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(79, 36);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(85, 26);
            this.txtDelete.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Id:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(170, 36);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 26);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // grpFindByRole
            // 
            this.grpFindByRole.Controls.Add(this.btnFindByRole);
            this.grpFindByRole.Controls.Add(this.label8);
            this.grpFindByRole.Controls.Add(this.cmbFindByRole);
            this.grpFindByRole.Location = new System.Drawing.Point(712, 102);
            this.grpFindByRole.Name = "grpFindByRole";
            this.grpFindByRole.Size = new System.Drawing.Size(328, 101);
            this.grpFindByRole.TabIndex = 0;
            this.grpFindByRole.TabStop = false;
            this.grpFindByRole.Text = "Find By Role";
            // 
            // cmbFindByRole
            // 
            this.cmbFindByRole.FormattingEnabled = true;
            this.cmbFindByRole.Location = new System.Drawing.Point(24, 57);
            this.cmbFindByRole.Name = "cmbFindByRole";
            this.cmbFindByRole.Size = new System.Drawing.Size(172, 28);
            this.cmbFindByRole.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Choose a Role:";
            // 
            // btnFindByRole
            // 
            this.btnFindByRole.Location = new System.Drawing.Point(202, 56);
            this.btnFindByRole.Name = "btnFindByRole";
            this.btnFindByRole.Size = new System.Drawing.Size(89, 28);
            this.btnFindByRole.TabIndex = 3;
            this.btnFindByRole.Text = "Get";
            this.btnFindByRole.UseVisualStyleBackColor = true;
            this.btnFindByRole.Click += new System.EventHandler(this.btnFindByRole_Click);
            // 
            // AppUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 728);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpFindByRole);
            this.Controls.Add(this.grpDelete);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.grpCreate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AppUserPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AppUserPage_Load);
            this.grpCreate.ResumeLayout(false);
            this.grpCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            this.grpFindByRole.ResumeLayout(false);
            this.grpFindByRole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cmbCreateRole;
        private System.Windows.Forms.TextBox txtCreateLastName;
        private System.Windows.Forms.TextBox txtCreateFirstName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbUpdateRole;
        private System.Windows.Forms.TextBox txtUpdateLastName;
        private System.Windows.Forms.TextBox txtFindById;
        private System.Windows.Forms.TextBox txtUpdateFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpFindByRole;
        private System.Windows.Forms.Button btnFindByRole;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbFindByRole;
    }
}

