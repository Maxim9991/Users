
namespace Users
{
    partial class Form1
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
            this.DGV_AspNetRoles = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNormalizedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColConcurrencyStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AspNetUsers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNormalizedUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhoneNumbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AspNetUserRoles = new System.Windows.Forms.DataGridView();
            this.ColUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRolesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.cBoxAdd = new System.Windows.Forms.CheckBox();
            this.cBoxDel = new System.Windows.Forms.CheckBox();
            this.cBoxEdit = new System.Windows.Forms.CheckBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnAction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AspNetRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AspNetUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AspNetUserRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_AspNetRoles
            // 
            this.DGV_AspNetRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_AspNetRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColName,
            this.ColNormalizedName,
            this.ColConcurrencyStamp});
            this.DGV_AspNetRoles.Location = new System.Drawing.Point(12, 61);
            this.DGV_AspNetRoles.Name = "DGV_AspNetRoles";
            this.DGV_AspNetRoles.RowTemplate.Height = 25;
            this.DGV_AspNetRoles.Size = new System.Drawing.Size(479, 281);
            this.DGV_AspNetRoles.TabIndex = 0;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColId.Width = 35;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            // 
            // ColNormalizedName
            // 
            this.ColNormalizedName.HeaderText = "Normalized Name";
            this.ColNormalizedName.Name = "ColNormalizedName";
            this.ColNormalizedName.Width = 150;
            // 
            // ColConcurrencyStamp
            // 
            this.ColConcurrencyStamp.HeaderText = "Concurrency Stamp";
            this.ColConcurrencyStamp.Name = "ColConcurrencyStamp";
            this.ColConcurrencyStamp.Width = 150;
            // 
            // DGV_AspNetUsers
            // 
            this.DGV_AspNetUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_AspNetUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ColUserName,
            this.ColNormalizedUserName,
            this.ColEmail,
            this.ColPhoneNumbers});
            this.DGV_AspNetUsers.Location = new System.Drawing.Point(12, 61);
            this.DGV_AspNetUsers.Name = "DGV_AspNetUsers";
            this.DGV_AspNetUsers.RowTemplate.Height = 25;
            this.DGV_AspNetUsers.Size = new System.Drawing.Size(479, 281);
            this.DGV_AspNetUsers.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 35;
            // 
            // ColUserName
            // 
            this.ColUserName.HeaderText = "User Name";
            this.ColUserName.Name = "ColUserName";
            // 
            // ColNormalizedUserName
            // 
            this.ColNormalizedUserName.HeaderText = "Normalized User Name";
            this.ColNormalizedUserName.Name = "ColNormalizedUserName";
            // 
            // ColEmail
            // 
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.Name = "ColEmail";
            // 
            // ColPhoneNumbers
            // 
            this.ColPhoneNumbers.HeaderText = "Phone Number";
            this.ColPhoneNumbers.Name = "ColPhoneNumbers";
            // 
            // DGV_AspNetUserRoles
            // 
            this.DGV_AspNetUserRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_AspNetUserRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColUserID,
            this.ColRolesID});
            this.DGV_AspNetUserRoles.Location = new System.Drawing.Point(12, 61);
            this.DGV_AspNetUserRoles.Name = "DGV_AspNetUserRoles";
            this.DGV_AspNetUserRoles.RowTemplate.Height = 25;
            this.DGV_AspNetUserRoles.Size = new System.Drawing.Size(243, 281);
            this.DGV_AspNetUserRoles.TabIndex = 2;
            // 
            // ColUserID
            // 
            this.ColUserID.HeaderText = "User_Id";
            this.ColUserID.Name = "ColUserID";
            // 
            // ColRolesID
            // 
            this.ColRolesID.HeaderText = "Roles_Id";
            this.ColRolesID.Name = "ColRolesID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AspNetRoles",
            "AspNetUsers",
            "AspNetUserRoles"});
            this.comboBox1.Location = new System.Drawing.Point(12, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTable.Location = new System.Drawing.Point(12, 9);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(64, 20);
            this.lblTable.TabIndex = 4;
            this.lblTable.Text = "Таблиці";
            this.lblTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBoxAdd
            // 
            this.cBoxAdd.AutoSize = true;
            this.cBoxAdd.Location = new System.Drawing.Point(181, 34);
            this.cBoxAdd.Name = "cBoxAdd";
            this.cBoxAdd.Size = new System.Drawing.Size(65, 19);
            this.cBoxAdd.TabIndex = 5;
            this.cBoxAdd.Text = "Додати";
            this.cBoxAdd.UseVisualStyleBackColor = true;
            this.cBoxAdd.CheckedChanged += new System.EventHandler(this.cBoxAdd_CheckedChanged);
            // 
            // cBoxDel
            // 
            this.cBoxDel.AutoSize = true;
            this.cBoxDel.Location = new System.Drawing.Point(252, 34);
            this.cBoxDel.Name = "cBoxDel";
            this.cBoxDel.Size = new System.Drawing.Size(78, 19);
            this.cBoxDel.TabIndex = 6;
            this.cBoxDel.Text = "Видалити";
            this.cBoxDel.UseVisualStyleBackColor = true;
            this.cBoxDel.CheckedChanged += new System.EventHandler(this.cBoxDel_CheckedChanged);
            // 
            // cBoxEdit
            // 
            this.cBoxEdit.AutoSize = true;
            this.cBoxEdit.Location = new System.Drawing.Point(336, 34);
            this.cBoxEdit.Name = "cBoxEdit";
            this.cBoxEdit.Size = new System.Drawing.Size(86, 19);
            this.cBoxEdit.TabIndex = 7;
            this.cBoxEdit.Text = "Редагувати";
            this.cBoxEdit.UseVisualStyleBackColor = true;
            this.cBoxEdit.CheckedChanged += new System.EventHandler(this.cBoxEdit_CheckedChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(507, 71);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(13, 15);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(507, 100);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(13, 15);
            this.lbl2.TabIndex = 9;
            this.lbl2.Text = "2";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(507, 129);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(13, 15);
            this.lbl3.TabIndex = 10;
            this.lbl3.Text = "3";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(507, 158);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(13, 15);
            this.lbl4.TabIndex = 11;
            this.lbl4.Text = "4";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(507, 187);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(13, 15);
            this.lbl5.TabIndex = 12;
            this.lbl5.Text = "5";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(645, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 23);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(645, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 23);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(645, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 23);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(645, 155);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(143, 23);
            this.textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(645, 184);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(143, 23);
            this.textBox5.TabIndex = 17;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(713, 39);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 23);
            this.btnAction.TabIndex = 18;
            this.btnAction.Text = "ОК";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cBoxEdit);
            this.Controls.Add(this.cBoxDel);
            this.Controls.Add(this.cBoxAdd);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DGV_AspNetUserRoles);
            this.Controls.Add(this.DGV_AspNetUsers);
            this.Controls.Add(this.DGV_AspNetRoles);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AspNetRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AspNetUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AspNetUserRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_AspNetRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNormalizedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColConcurrencyStamp;
        private System.Windows.Forms.DataGridView DGV_AspNetUsers;
        private System.Windows.Forms.DataGridView DGV_AspNetUserRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNormalizedUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhoneNumbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRolesID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.CheckBox cBoxAdd;
        private System.Windows.Forms.CheckBox cBoxDel;
        private System.Windows.Forms.CheckBox cBoxEdit;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnAction;
    }
}

