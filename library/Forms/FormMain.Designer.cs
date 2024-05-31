namespace library.Forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.mExit = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pUser = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.mUserManagement = new System.Windows.Forms.Button();
            this.pBorrow = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.mBorrow = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.pLibrarian = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.mLibrarian = new System.Windows.Forms.Button();
            this.pBook = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.mBook = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.mCustomerSub = new System.Windows.Forms.Panel();
            this.mcustomertype = new System.Windows.Forms.Button();
            this.mcustomerlist = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.mCustomers = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel14.SuspendLayout();
            this.pUser.SuspendLayout();
            this.pBorrow.SuspendLayout();
            this.pLibrarian.SuspendLayout();
            this.pBook.SuspendLayout();
            this.mCustomerSub.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pnMain);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(253, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 740);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(847, 740);
            this.pnMain.TabIndex = 5;
            this.pnMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMain_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 13F);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(277, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customers";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.panel21);
            this.panel3.Controls.Add(this.panel14);
            this.panel3.Controls.Add(this.pUser);
            this.panel3.Controls.Add(this.pBorrow);
            this.panel3.Controls.Add(this.panel15);
            this.panel3.Controls.Add(this.panel13);
            this.panel3.Controls.Add(this.pLibrarian);
            this.panel3.Controls.Add(this.pBook);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.mCustomerSub);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 740);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel21.Controls.Add(this.panel22);
            this.panel21.Controls.Add(this.mExit);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel21.Location = new System.Drawing.Point(0, 680);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(253, 56);
            this.panel21.TabIndex = 21;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.DarkCyan;
            this.panel22.Location = new System.Drawing.Point(243, 0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(10, 56);
            this.panel22.TabIndex = 5;
            // 
            // mExit
            // 
            this.mExit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.mExit.FlatAppearance.BorderSize = 0;
            this.mExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mExit.Font = new System.Drawing.Font("Poppins", 13F);
            this.mExit.ForeColor = System.Drawing.Color.Navy;
            this.mExit.Image = ((System.Drawing.Image)(resources.GetObject("mExit.Image")));
            this.mExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mExit.Location = new System.Drawing.Point(0, 0);
            this.mExit.Name = "mExit";
            this.mExit.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.mExit.Size = new System.Drawing.Size(253, 56);
            this.mExit.TabIndex = 4;
            this.mExit.Text = "        Exit";
            this.mExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mExit.UseVisualStyleBackColor = false;
            this.mExit.Click += new System.EventHandler(this.mExit_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel14.Controls.Add(this.panel20);
            this.panel14.Controls.Add(this.button1);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 624);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(253, 56);
            this.panel14.TabIndex = 20;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.DarkCyan;
            this.panel20.Location = new System.Drawing.Point(243, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(10, 56);
            this.panel20.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins", 13F);
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(253, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "        Logout";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pUser
            // 
            this.pUser.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pUser.Controls.Add(this.panel19);
            this.pUser.Controls.Add(this.mUserManagement);
            this.pUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pUser.Location = new System.Drawing.Point(0, 568);
            this.pUser.Name = "pUser";
            this.pUser.Size = new System.Drawing.Size(253, 56);
            this.pUser.TabIndex = 19;
            this.pUser.Visible = false;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.DarkCyan;
            this.panel19.Location = new System.Drawing.Point(243, 0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(10, 56);
            this.panel19.TabIndex = 5;
            // 
            // mUserManagement
            // 
            this.mUserManagement.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mUserManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.mUserManagement.FlatAppearance.BorderSize = 0;
            this.mUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mUserManagement.Font = new System.Drawing.Font("Poppins", 13F);
            this.mUserManagement.ForeColor = System.Drawing.Color.Navy;
            this.mUserManagement.Image = ((System.Drawing.Image)(resources.GetObject("mUserManagement.Image")));
            this.mUserManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mUserManagement.Location = new System.Drawing.Point(0, 0);
            this.mUserManagement.Name = "mUserManagement";
            this.mUserManagement.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.mUserManagement.Size = new System.Drawing.Size(253, 56);
            this.mUserManagement.TabIndex = 4;
            this.mUserManagement.Text = "       User Management";
            this.mUserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mUserManagement.UseVisualStyleBackColor = false;
            this.mUserManagement.Click += new System.EventHandler(this.mUserManagement_Click);
            // 
            // pBorrow
            // 
            this.pBorrow.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pBorrow.Controls.Add(this.panel17);
            this.pBorrow.Controls.Add(this.mBorrow);
            this.pBorrow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBorrow.Location = new System.Drawing.Point(0, 512);
            this.pBorrow.Name = "pBorrow";
            this.pBorrow.Size = new System.Drawing.Size(253, 56);
            this.pBorrow.TabIndex = 18;
            this.pBorrow.Visible = false;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.DarkCyan;
            this.panel17.Location = new System.Drawing.Point(243, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(10, 56);
            this.panel17.TabIndex = 5;
            // 
            // mBorrow
            // 
            this.mBorrow.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mBorrow.Dock = System.Windows.Forms.DockStyle.Top;
            this.mBorrow.FlatAppearance.BorderSize = 0;
            this.mBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mBorrow.Font = new System.Drawing.Font("Poppins", 13F);
            this.mBorrow.ForeColor = System.Drawing.Color.Navy;
            this.mBorrow.Image = ((System.Drawing.Image)(resources.GetObject("mBorrow.Image")));
            this.mBorrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mBorrow.Location = new System.Drawing.Point(0, 0);
            this.mBorrow.Name = "mBorrow";
            this.mBorrow.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.mBorrow.Size = new System.Drawing.Size(253, 56);
            this.mBorrow.TabIndex = 4;
            this.mBorrow.Text = "        Borrow";
            this.mBorrow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mBorrow.UseVisualStyleBackColor = false;
            this.mBorrow.Click += new System.EventHandler(this.mBorrow_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.DarkCyan;
            this.panel15.Location = new System.Drawing.Point(243, 681);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(10, 56);
            this.panel15.TabIndex = 16;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkCyan;
            this.panel13.Location = new System.Drawing.Point(243, 532);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(10, 56);
            this.panel13.TabIndex = 12;
            // 
            // pLibrarian
            // 
            this.pLibrarian.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pLibrarian.Controls.Add(this.panel11);
            this.pLibrarian.Controls.Add(this.mLibrarian);
            this.pLibrarian.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLibrarian.Location = new System.Drawing.Point(0, 456);
            this.pLibrarian.Name = "pLibrarian";
            this.pLibrarian.Size = new System.Drawing.Size(253, 56);
            this.pLibrarian.TabIndex = 10;
            this.pLibrarian.Visible = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DarkCyan;
            this.panel11.Location = new System.Drawing.Point(243, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(10, 56);
            this.panel11.TabIndex = 5;
            // 
            // mLibrarian
            // 
            this.mLibrarian.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mLibrarian.Dock = System.Windows.Forms.DockStyle.Top;
            this.mLibrarian.FlatAppearance.BorderSize = 0;
            this.mLibrarian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mLibrarian.Font = new System.Drawing.Font("Poppins", 13F);
            this.mLibrarian.ForeColor = System.Drawing.Color.Navy;
            this.mLibrarian.Image = ((System.Drawing.Image)(resources.GetObject("mLibrarian.Image")));
            this.mLibrarian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mLibrarian.Location = new System.Drawing.Point(0, 0);
            this.mLibrarian.Name = "mLibrarian";
            this.mLibrarian.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.mLibrarian.Size = new System.Drawing.Size(253, 56);
            this.mLibrarian.TabIndex = 4;
            this.mLibrarian.Text = "        Librarian";
            this.mLibrarian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mLibrarian.UseVisualStyleBackColor = false;
            this.mLibrarian.Click += new System.EventHandler(this.mLibrarian_Click);
            // 
            // pBook
            // 
            this.pBook.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pBook.Controls.Add(this.panel9);
            this.pBook.Controls.Add(this.mBook);
            this.pBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBook.Location = new System.Drawing.Point(0, 400);
            this.pBook.Name = "pBook";
            this.pBook.Size = new System.Drawing.Size(253, 56);
            this.pBook.TabIndex = 9;
            this.pBook.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkCyan;
            this.panel9.Location = new System.Drawing.Point(243, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 56);
            this.panel9.TabIndex = 5;
            // 
            // mBook
            // 
            this.mBook.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.mBook.FlatAppearance.BorderSize = 0;
            this.mBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mBook.Font = new System.Drawing.Font("Poppins", 13F);
            this.mBook.ForeColor = System.Drawing.Color.Navy;
            this.mBook.Image = ((System.Drawing.Image)(resources.GetObject("mBook.Image")));
            this.mBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mBook.Location = new System.Drawing.Point(0, 0);
            this.mBook.Name = "mBook";
            this.mBook.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.mBook.Size = new System.Drawing.Size(253, 56);
            this.mBook.TabIndex = 4;
            this.mBook.Text = "        Books";
            this.mBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mBook.UseVisualStyleBackColor = false;
            this.mBook.Click += new System.EventHandler(this.mBook_Click);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(253, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(844, 25);
            this.panel5.TabIndex = 0;
            // 
            // mCustomerSub
            // 
            this.mCustomerSub.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mCustomerSub.Controls.Add(this.mcustomertype);
            this.mCustomerSub.Controls.Add(this.mcustomerlist);
            this.mCustomerSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.mCustomerSub.Location = new System.Drawing.Point(0, 282);
            this.mCustomerSub.Name = "mCustomerSub";
            this.mCustomerSub.Size = new System.Drawing.Size(253, 118);
            this.mCustomerSub.TabIndex = 8;
            // 
            // mcustomertype
            // 
            this.mcustomertype.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mcustomertype.Dock = System.Windows.Forms.DockStyle.Top;
            this.mcustomertype.FlatAppearance.BorderSize = 0;
            this.mcustomertype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mcustomertype.Font = new System.Drawing.Font("Poppins", 13F);
            this.mcustomertype.ForeColor = System.Drawing.Color.Navy;
            this.mcustomertype.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mcustomertype.Location = new System.Drawing.Point(0, 56);
            this.mcustomertype.Name = "mcustomertype";
            this.mcustomertype.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.mcustomertype.Size = new System.Drawing.Size(253, 56);
            this.mcustomertype.TabIndex = 7;
            this.mcustomertype.Text = "          Customer Type";
            this.mcustomertype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mcustomertype.UseVisualStyleBackColor = false;
            this.mcustomertype.Visible = false;
            this.mcustomertype.Click += new System.EventHandler(this.mcustomertype_Click);
            // 
            // mcustomerlist
            // 
            this.mcustomerlist.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mcustomerlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.mcustomerlist.FlatAppearance.BorderSize = 0;
            this.mcustomerlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mcustomerlist.Font = new System.Drawing.Font("Poppins", 13F);
            this.mcustomerlist.ForeColor = System.Drawing.Color.Navy;
            this.mcustomerlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mcustomerlist.Location = new System.Drawing.Point(0, 0);
            this.mcustomerlist.Name = "mcustomerlist";
            this.mcustomerlist.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.mcustomerlist.Size = new System.Drawing.Size(253, 56);
            this.mcustomerlist.TabIndex = 6;
            this.mcustomerlist.Text = "          Customer List";
            this.mcustomerlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mcustomerlist.UseVisualStyleBackColor = false;
            this.mcustomerlist.Visible = false;
            this.mcustomerlist.Click += new System.EventHandler(this.customerlist_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.mCustomers);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 226);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(253, 56);
            this.panel4.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkCyan;
            this.panel7.Location = new System.Drawing.Point(243, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 56);
            this.panel7.TabIndex = 5;
            // 
            // mCustomers
            // 
            this.mCustomers.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mCustomers.FlatAppearance.BorderSize = 0;
            this.mCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mCustomers.Font = new System.Drawing.Font("Poppins", 13F);
            this.mCustomers.ForeColor = System.Drawing.Color.Navy;
            this.mCustomers.Image = ((System.Drawing.Image)(resources.GetObject("mCustomers.Image")));
            this.mCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mCustomers.Location = new System.Drawing.Point(-3, 0);
            this.mCustomers.Name = "mCustomers";
            this.mCustomers.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.mCustomers.Size = new System.Drawing.Size(256, 56);
            this.mCustomers.TabIndex = 4;
            this.mCustomers.Text = "        Customers";
            this.mCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mCustomers.UseVisualStyleBackColor = false;
            this.mCustomers.Click += new System.EventHandler(this.mCustomers_Click_1);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(253, 226);
            this.panel8.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 16F);
            this.label2.Location = new System.Drawing.Point(48, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Library MS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 740);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.pUser.ResumeLayout(false);
            this.pBorrow.ResumeLayout(false);
            this.pLibrarian.ResumeLayout(false);
            this.pBook.ResumeLayout(false);
            this.mCustomerSub.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel mCustomerSub;
        private System.Windows.Forms.Button customerType;
        private System.Windows.Forms.Button mcustomerlist;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button mCustomers;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel pLibrarian;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button mLibrarian;
        private System.Windows.Forms.Panel pBook;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button mBook;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pBorrow;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button mBorrow;
        private System.Windows.Forms.Panel pUser;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Button mUserManagement;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Button mExit;
        private System.Windows.Forms.Button mcustomertype;
        private System.Windows.Forms.Panel panel7;
    }
}