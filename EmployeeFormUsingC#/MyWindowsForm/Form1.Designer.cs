namespace MyWindowsForm
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
            this.tblEmployee = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.DgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvNickName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvQualfctn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvTown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tblEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tblEmployee
            // 
            this.tblEmployee.ColumnCount = 7;
            this.tblEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tblEmployee.Controls.Add(this.dataGridView, 6, 1);
            this.tblEmployee.Controls.Add(this.btnDelete, 5, 3);
            this.tblEmployee.Controls.Add(this.btnSave, 4, 3);
            this.tblEmployee.Controls.Add(this.btnAdd, 3, 3);
            this.tblEmployee.Controls.Add(this.btnClear, 0, 3);
            this.tblEmployee.Controls.Add(this.btnRefresh, 1, 3);
            this.tblEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblEmployee.Location = new System.Drawing.Point(0, 0);
            this.tblEmployee.Name = "tblEmployee";
            this.tblEmployee.RowCount = 4;
            this.tblEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tblEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tblEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblEmployee.Size = new System.Drawing.Size(1098, 447);
            this.tblEmployee.TabIndex = 0;
            this.tblEmployee.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvId,
            this.DgvFirstName,
            this.DgvLastName,
            this.DgvNickName,
            this.DgvQualfctn,
            this.DgvCountry,
            this.DgvState,
            this.DgvTown,
            this.DgvStreet,
            this.DgvAddress});
            this.tblEmployee.SetColumnSpan(this.dataGridView, 6);
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1086, 411);
            this.dataGridView.TabIndex = 33;
            this.dataGridView.AllowUserToAddRowsChanged += new System.EventHandler(this.dataGridView_AllowUserToAddRowsChanged);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick_1);
            this.dataGridView.NewRowNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_NewRowNeeded);
            this.dataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridView_RowsAdded);
            // 
            // DgvId
            // 
            this.DgvId.HeaderText = "Id";
            this.DgvId.Name = "DgvId";
            this.DgvId.ReadOnly = true;
            // 
            // DgvFirstName
            // 
            this.DgvFirstName.HeaderText = "First Name";
            this.DgvFirstName.Name = "DgvFirstName";
            // 
            // DgvLastName
            // 
            this.DgvLastName.HeaderText = "Last Name";
            this.DgvLastName.Name = "DgvLastName";
            // 
            // DgvNickName
            // 
            this.DgvNickName.HeaderText = "Nick Name";
            this.DgvNickName.Name = "DgvNickName";
            // 
            // DgvQualfctn
            // 
            this.DgvQualfctn.HeaderText = "Qualification";
            this.DgvQualfctn.Name = "DgvQualfctn";
            // 
            // DgvCountry
            // 
            this.DgvCountry.HeaderText = "Country";
            this.DgvCountry.Name = "DgvCountry";
            // 
            // DgvState
            // 
            this.DgvState.HeaderText = "State";
            this.DgvState.Name = "DgvState";
            // 
            // DgvTown
            // 
            this.DgvTown.HeaderText = "Town";
            this.DgvTown.Name = "DgvTown";
            // 
            // DgvStreet
            // 
            this.DgvStreet.HeaderText = "Street";
            this.DgvStreet.Name = "DgvStreet";
            // 
            // DgvAddress
            // 
            this.DgvAddress.HeaderText = "Address";
            this.DgvAddress.Name = "DgvAddress";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(913, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 23);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete Rows";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(731, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 23);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save Data";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(549, 420);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 23);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "Add Rows";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.No;
            this.btnClear.Location = new System.Drawing.Point(3, 420);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(176, 23);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(185, 420);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(176, 23);
            this.btnRefresh.TabIndex = 38;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 447);
            this.Controls.Add(this.tblEmployee);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Employee App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tblEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tblEmployee;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvNickName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvQualfctn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvState;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvTown;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvStreet;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvAddress;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;
    }
}

