namespace library.Forms
{
    partial class FormUserManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnApplyPermission = new System.Windows.Forms.Button();
            this.pnPermission = new System.Windows.Forms.Panel();
            this.BorrowCreate = new System.Windows.Forms.CheckBox();
            this.BorrowModify = new System.Windows.Forms.CheckBox();
            this.BorrowDelete = new System.Windows.Forms.CheckBox();
            this.BorrowView = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BookCreate = new System.Windows.Forms.CheckBox();
            this.BookModify = new System.Windows.Forms.CheckBox();
            this.BookDelete = new System.Windows.Forms.CheckBox();
            this.BookView = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LibrarianCreate = new System.Windows.Forms.CheckBox();
            this.LibrarainModify = new System.Windows.Forms.CheckBox();
            this.LibrarianDelete = new System.Windows.Forms.CheckBox();
            this.LibrarianView = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomerTypeCreate = new System.Windows.Forms.CheckBox();
            this.CustomerTypeModify = new System.Windows.Forms.CheckBox();
            this.CustomerTypeDelete = new System.Windows.Forms.CheckBox();
            this.CustomerTypeView = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerCreate = new System.Windows.Forms.CheckBox();
            this.CustomerModify = new System.Windows.Forms.CheckBox();
            this.CustomerDelete = new System.Windows.Forms.CheckBox();
            this.CustomerView = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnPermission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 58);
            this.panel1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 16F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 48);
            this.label7.TabIndex = 32;
            this.label7.Text = "User Management";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1036, 57);
            this.panel3.TabIndex = 43;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(16, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 40);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(148, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 40);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(285, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(105, 40);
            this.btnNew.TabIndex = 37;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSelectAll);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnClearAll);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btnApplyPermission);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 564);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(602, 54);
            this.panel2.TabIndex = 19;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.BackColor = System.Drawing.Color.Black;
            this.btnSelectAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectAll.FlatAppearance.BorderSize = 0;
            this.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectAll.Font = new System.Drawing.Font("Poppins", 13F);
            this.btnSelectAll.ForeColor = System.Drawing.Color.White;
            this.btnSelectAll.Location = new System.Drawing.Point(108, 5);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(138, 44);
            this.btnSelectAll.TabIndex = 10;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = false;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(246, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 44);
            this.panel4.TabIndex = 8;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.Black;
            this.btnClearAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearAll.FlatAppearance.BorderSize = 0;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Poppins", 13F);
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Location = new System.Drawing.Point(256, 5);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(138, 44);
            this.btnClearAll.TabIndex = 7;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(394, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 44);
            this.panel5.TabIndex = 6;
            // 
            // btnApplyPermission
            // 
            this.btnApplyPermission.BackColor = System.Drawing.Color.Black;
            this.btnApplyPermission.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnApplyPermission.FlatAppearance.BorderSize = 0;
            this.btnApplyPermission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyPermission.Font = new System.Drawing.Font("Nokora", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyPermission.ForeColor = System.Drawing.Color.White;
            this.btnApplyPermission.Location = new System.Drawing.Point(404, 5);
            this.btnApplyPermission.Name = "btnApplyPermission";
            this.btnApplyPermission.Size = new System.Drawing.Size(193, 44);
            this.btnApplyPermission.TabIndex = 6;
            this.btnApplyPermission.Text = "ApplyPermission";
            this.btnApplyPermission.UseVisualStyleBackColor = false;
            this.btnApplyPermission.Click += new System.EventHandler(this.btnApplyPermission_Click);
            // 
            // pnPermission
            // 
            this.pnPermission.Controls.Add(this.BorrowCreate);
            this.pnPermission.Controls.Add(this.BorrowModify);
            this.pnPermission.Controls.Add(this.BorrowDelete);
            this.pnPermission.Controls.Add(this.BorrowView);
            this.pnPermission.Controls.Add(this.label1);
            this.pnPermission.Controls.Add(this.BookCreate);
            this.pnPermission.Controls.Add(this.BookModify);
            this.pnPermission.Controls.Add(this.BookDelete);
            this.pnPermission.Controls.Add(this.BookView);
            this.pnPermission.Controls.Add(this.label6);
            this.pnPermission.Controls.Add(this.LibrarianCreate);
            this.pnPermission.Controls.Add(this.LibrarainModify);
            this.pnPermission.Controls.Add(this.LibrarianDelete);
            this.pnPermission.Controls.Add(this.LibrarianView);
            this.pnPermission.Controls.Add(this.label5);
            this.pnPermission.Controls.Add(this.panel2);
            this.pnPermission.Controls.Add(this.CustomerTypeCreate);
            this.pnPermission.Controls.Add(this.CustomerTypeModify);
            this.pnPermission.Controls.Add(this.CustomerTypeDelete);
            this.pnPermission.Controls.Add(this.CustomerTypeView);
            this.pnPermission.Controls.Add(this.label4);
            this.pnPermission.Controls.Add(this.CustomerCreate);
            this.pnPermission.Controls.Add(this.CustomerModify);
            this.pnPermission.Controls.Add(this.CustomerDelete);
            this.pnPermission.Controls.Add(this.CustomerView);
            this.pnPermission.Controls.Add(this.label3);
            this.pnPermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPermission.Location = new System.Drawing.Point(434, 115);
            this.pnPermission.Name = "pnPermission";
            this.pnPermission.Size = new System.Drawing.Size(602, 618);
            this.pnPermission.TabIndex = 45;
            // 
            // BorrowCreate
            // 
            this.BorrowCreate.AutoSize = true;
            this.BorrowCreate.Font = new System.Drawing.Font("Poppins", 13F);
            this.BorrowCreate.Location = new System.Drawing.Point(191, 468);
            this.BorrowCreate.Name = "BorrowCreate";
            this.BorrowCreate.Size = new System.Drawing.Size(115, 43);
            this.BorrowCreate.TabIndex = 34;
            this.BorrowCreate.Text = "Create";
            this.BorrowCreate.UseVisualStyleBackColor = true;
            // 
            // BorrowModify
            // 
            this.BorrowModify.AutoSize = true;
            this.BorrowModify.Font = new System.Drawing.Font("Poppins", 13F);
            this.BorrowModify.Location = new System.Drawing.Point(345, 468);
            this.BorrowModify.Name = "BorrowModify";
            this.BorrowModify.Size = new System.Drawing.Size(111, 43);
            this.BorrowModify.TabIndex = 33;
            this.BorrowModify.Text = "Modify";
            this.BorrowModify.UseVisualStyleBackColor = true;
            // 
            // BorrowDelete
            // 
            this.BorrowDelete.AutoSize = true;
            this.BorrowDelete.Font = new System.Drawing.Font("Poppins", 13F);
            this.BorrowDelete.Location = new System.Drawing.Point(470, 468);
            this.BorrowDelete.Name = "BorrowDelete";
            this.BorrowDelete.Size = new System.Drawing.Size(110, 43);
            this.BorrowDelete.TabIndex = 32;
            this.BorrowDelete.Text = "Delete";
            this.BorrowDelete.UseVisualStyleBackColor = true;
            // 
            // BorrowView
            // 
            this.BorrowView.AutoSize = true;
            this.BorrowView.Font = new System.Drawing.Font("Poppins", 13F);
            this.BorrowView.Location = new System.Drawing.Point(65, 468);
            this.BorrowView.Name = "BorrowView";
            this.BorrowView.Size = new System.Drawing.Size(91, 43);
            this.BorrowView.TabIndex = 31;
            this.BorrowView.Text = "View";
            this.BorrowView.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 13F);
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(62, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 39);
            this.label1.TabIndex = 30;
            this.label1.Text = "Borrow";
            // 
            // BookCreate
            // 
            this.BookCreate.AutoSize = true;
            this.BookCreate.Font = new System.Drawing.Font("Poppins", 13F);
            this.BookCreate.Location = new System.Drawing.Point(191, 353);
            this.BookCreate.Name = "BookCreate";
            this.BookCreate.Size = new System.Drawing.Size(115, 43);
            this.BookCreate.TabIndex = 29;
            this.BookCreate.Text = "Create";
            this.BookCreate.UseVisualStyleBackColor = true;
            // 
            // BookModify
            // 
            this.BookModify.AutoSize = true;
            this.BookModify.Font = new System.Drawing.Font("Poppins", 13F);
            this.BookModify.Location = new System.Drawing.Point(348, 353);
            this.BookModify.Name = "BookModify";
            this.BookModify.Size = new System.Drawing.Size(111, 43);
            this.BookModify.TabIndex = 28;
            this.BookModify.Text = "Modify";
            this.BookModify.UseVisualStyleBackColor = true;
            // 
            // BookDelete
            // 
            this.BookDelete.AutoSize = true;
            this.BookDelete.Font = new System.Drawing.Font("Poppins", 13F);
            this.BookDelete.Location = new System.Drawing.Point(473, 353);
            this.BookDelete.Name = "BookDelete";
            this.BookDelete.Size = new System.Drawing.Size(110, 43);
            this.BookDelete.TabIndex = 27;
            this.BookDelete.Text = "Delete";
            this.BookDelete.UseVisualStyleBackColor = true;
            // 
            // BookView
            // 
            this.BookView.AutoSize = true;
            this.BookView.Font = new System.Drawing.Font("Poppins", 13F);
            this.BookView.Location = new System.Drawing.Point(65, 353);
            this.BookView.Name = "BookView";
            this.BookView.Size = new System.Drawing.Size(91, 43);
            this.BookView.TabIndex = 26;
            this.BookView.Text = "View";
            this.BookView.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 13F);
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(60, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 39);
            this.label6.TabIndex = 25;
            this.label6.Text = "Books";
            // 
            // LibrarianCreate
            // 
            this.LibrarianCreate.AutoSize = true;
            this.LibrarianCreate.Font = new System.Drawing.Font("Poppins", 13F);
            this.LibrarianCreate.Location = new System.Drawing.Point(191, 248);
            this.LibrarianCreate.Name = "LibrarianCreate";
            this.LibrarianCreate.Size = new System.Drawing.Size(115, 43);
            this.LibrarianCreate.TabIndex = 24;
            this.LibrarianCreate.Text = "Create";
            this.LibrarianCreate.UseVisualStyleBackColor = true;
            // 
            // LibrarainModify
            // 
            this.LibrarainModify.AutoSize = true;
            this.LibrarainModify.Font = new System.Drawing.Font("Poppins", 13F);
            this.LibrarainModify.Location = new System.Drawing.Point(348, 248);
            this.LibrarainModify.Name = "LibrarainModify";
            this.LibrarainModify.Size = new System.Drawing.Size(111, 43);
            this.LibrarainModify.TabIndex = 23;
            this.LibrarainModify.Text = "Modify";
            this.LibrarainModify.UseVisualStyleBackColor = true;
            // 
            // LibrarianDelete
            // 
            this.LibrarianDelete.AutoSize = true;
            this.LibrarianDelete.Font = new System.Drawing.Font("Poppins", 13F);
            this.LibrarianDelete.Location = new System.Drawing.Point(473, 248);
            this.LibrarianDelete.Name = "LibrarianDelete";
            this.LibrarianDelete.Size = new System.Drawing.Size(110, 43);
            this.LibrarianDelete.TabIndex = 22;
            this.LibrarianDelete.Text = "Delete";
            this.LibrarianDelete.UseVisualStyleBackColor = true;
            // 
            // LibrarianView
            // 
            this.LibrarianView.AutoSize = true;
            this.LibrarianView.Font = new System.Drawing.Font("Poppins", 13F);
            this.LibrarianView.Location = new System.Drawing.Point(65, 248);
            this.LibrarianView.Name = "LibrarianView";
            this.LibrarianView.Size = new System.Drawing.Size(91, 43);
            this.LibrarianView.TabIndex = 21;
            this.LibrarianView.Text = "View";
            this.LibrarianView.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 13F);
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(62, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 39);
            this.label5.TabIndex = 20;
            this.label5.Text = "Librarian";
            // 
            // CustomerTypeCreate
            // 
            this.CustomerTypeCreate.AutoSize = true;
            this.CustomerTypeCreate.Font = new System.Drawing.Font("Poppins", 13F);
            this.CustomerTypeCreate.Location = new System.Drawing.Point(191, 143);
            this.CustomerTypeCreate.Name = "CustomerTypeCreate";
            this.CustomerTypeCreate.Size = new System.Drawing.Size(115, 43);
            this.CustomerTypeCreate.TabIndex = 9;
            this.CustomerTypeCreate.Text = "Create";
            this.CustomerTypeCreate.UseVisualStyleBackColor = true;
            // 
            // CustomerTypeModify
            // 
            this.CustomerTypeModify.AutoSize = true;
            this.CustomerTypeModify.Font = new System.Drawing.Font("Poppins", 13F);
            this.CustomerTypeModify.Location = new System.Drawing.Point(358, 143);
            this.CustomerTypeModify.Name = "CustomerTypeModify";
            this.CustomerTypeModify.Size = new System.Drawing.Size(111, 43);
            this.CustomerTypeModify.TabIndex = 8;
            this.CustomerTypeModify.Text = "Modify";
            this.CustomerTypeModify.UseVisualStyleBackColor = true;
            // 
            // CustomerTypeDelete
            // 
            this.CustomerTypeDelete.AutoSize = true;
            this.CustomerTypeDelete.Font = new System.Drawing.Font("Poppins", 13F);
            this.CustomerTypeDelete.Location = new System.Drawing.Point(483, 143);
            this.CustomerTypeDelete.Name = "CustomerTypeDelete";
            this.CustomerTypeDelete.Size = new System.Drawing.Size(110, 43);
            this.CustomerTypeDelete.TabIndex = 7;
            this.CustomerTypeDelete.Text = "Delete";
            this.CustomerTypeDelete.UseVisualStyleBackColor = true;
            // 
            // CustomerTypeView
            // 
            this.CustomerTypeView.AutoSize = true;
            this.CustomerTypeView.Font = new System.Drawing.Font("Poppins", 13F);
            this.CustomerTypeView.Location = new System.Drawing.Point(65, 143);
            this.CustomerTypeView.Name = "CustomerTypeView";
            this.CustomerTypeView.Size = new System.Drawing.Size(91, 43);
            this.CustomerTypeView.TabIndex = 6;
            this.CustomerTypeView.Text = "View";
            this.CustomerTypeView.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 13F);
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(60, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "Customer Type";
            // 
            // CustomerCreate
            // 
            this.CustomerCreate.AutoSize = true;
            this.CustomerCreate.Font = new System.Drawing.Font("Poppins", 13F);
            this.CustomerCreate.Location = new System.Drawing.Point(191, 49);
            this.CustomerCreate.Name = "CustomerCreate";
            this.CustomerCreate.Size = new System.Drawing.Size(115, 43);
            this.CustomerCreate.TabIndex = 4;
            this.CustomerCreate.Text = "Create";
            this.CustomerCreate.UseVisualStyleBackColor = true;
            // 
            // CustomerModify
            // 
            this.CustomerModify.AutoSize = true;
            this.CustomerModify.Font = new System.Drawing.Font("Poppins", 13F);
            this.CustomerModify.Location = new System.Drawing.Point(345, 49);
            this.CustomerModify.Name = "CustomerModify";
            this.CustomerModify.Size = new System.Drawing.Size(111, 43);
            this.CustomerModify.TabIndex = 3;
            this.CustomerModify.Text = "Modify";
            this.CustomerModify.UseVisualStyleBackColor = true;
            // 
            // CustomerDelete
            // 
            this.CustomerDelete.AutoSize = true;
            this.CustomerDelete.Font = new System.Drawing.Font("Poppins", 13F);
            this.CustomerDelete.Location = new System.Drawing.Point(470, 49);
            this.CustomerDelete.Name = "CustomerDelete";
            this.CustomerDelete.Size = new System.Drawing.Size(110, 43);
            this.CustomerDelete.TabIndex = 2;
            this.CustomerDelete.Text = "Delete";
            this.CustomerDelete.UseVisualStyleBackColor = true;
            // 
            // CustomerView
            // 
            this.CustomerView.AutoSize = true;
            this.CustomerView.Font = new System.Drawing.Font("Poppins", 13F);
            this.CustomerView.Location = new System.Drawing.Point(65, 49);
            this.CustomerView.Name = "CustomerView";
            this.CustomerView.Size = new System.Drawing.Size(91, 43);
            this.CustomerView.TabIndex = 1;
            this.CustomerView.Text = "View";
            this.CustomerView.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 13F);
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(62, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer Center";
            // 
            // dgUsers
            // 
            this.dgUsers.AllowUserToAddRows = false;
            this.dgUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.dgUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgUsers.Location = new System.Drawing.Point(0, 115);
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.ReadOnly = true;
            this.dgUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgUsers.RowHeadersVisible = false;
            this.dgUsers.RowHeadersWidth = 51;
            this.dgUsers.RowTemplate.Height = 30;
            this.dgUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsers.Size = new System.Drawing.Size(434, 618);
            this.dgUsers.TabIndex = 44;
            this.dgUsers.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgUsers_CellPainting);
            this.dgUsers.SelectionChanged += new System.EventHandler(this.dgUsers_SelectionChanged);
            // 
            // FormUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 733);
            this.Controls.Add(this.pnPermission);
            this.Controls.Add(this.dgUsers);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FormUserManagement";
            this.Text = "FormUserManagement";
            this.Load += new System.EventHandler(this.FormUserManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnPermission.ResumeLayout(false);
            this.pnPermission.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnApplyPermission;
        private System.Windows.Forms.Panel pnPermission;
        private System.Windows.Forms.CheckBox BorrowCreate;
        private System.Windows.Forms.CheckBox BorrowModify;
        private System.Windows.Forms.CheckBox BorrowDelete;
        private System.Windows.Forms.CheckBox BorrowView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox BookCreate;
        private System.Windows.Forms.CheckBox BookModify;
        private System.Windows.Forms.CheckBox BookDelete;
        private System.Windows.Forms.CheckBox BookView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox LibrarianCreate;
        private System.Windows.Forms.CheckBox LibrarainModify;
        private System.Windows.Forms.CheckBox LibrarianDelete;
        private System.Windows.Forms.CheckBox LibrarianView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CustomerTypeCreate;
        private System.Windows.Forms.CheckBox CustomerTypeModify;
        private System.Windows.Forms.CheckBox CustomerTypeDelete;
        private System.Windows.Forms.CheckBox CustomerTypeView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CustomerCreate;
        private System.Windows.Forms.CheckBox CustomerModify;
        private System.Windows.Forms.CheckBox CustomerDelete;
        private System.Windows.Forms.CheckBox CustomerView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.Button btnUpdate;
    }
}