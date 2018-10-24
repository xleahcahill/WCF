namespace LeahCahill_AssignmentTwo_WCF
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
            this.addBookButton = new System.Windows.Forms.Button();
            this.itemlistBox = new System.Windows.Forms.ListBox();
            this.Book = new System.Windows.Forms.Label();
            this.Basket = new System.Windows.Forms.Label();
            this.calcuate = new System.Windows.Forms.Button();
            this.totaltextbox = new System.Windows.Forms.TextBox();
            this.addCDbutton = new System.Windows.Forms.Button();
            this.CDlabel = new System.Windows.Forms.Label();
            this.price2 = new System.Windows.Forms.Label();
            this.price1 = new System.Windows.Forms.Label();
            this.priceList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.noitem = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Registerbutton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLoginusername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Checkoutbutton = new System.Windows.Forms.Button();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.passwordregistertext = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.passwordlogintextbox = new System.Windows.Forms.TextBox();
            this.dvdbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.calcTotalwithDelivery = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.finaltotal = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(352, 137);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(75, 23);
            this.addBookButton.TabIndex = 0;
            this.addBookButton.Text = "Add";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // itemlistBox
            // 
            this.itemlistBox.FormattingEnabled = true;
            this.itemlistBox.Location = new System.Drawing.Point(630, 127);
            this.itemlistBox.Name = "itemlistBox";
            this.itemlistBox.Size = new System.Drawing.Size(82, 212);
            this.itemlistBox.TabIndex = 2;
            this.itemlistBox.SelectedIndexChanged += new System.EventHandler(this.itemlistBox_SelectedIndexChanged);
            // 
            // Book
            // 
            this.Book.AutoSize = true;
            this.Book.Location = new System.Drawing.Point(349, 118);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(32, 13);
            this.Book.TabIndex = 3;
            this.Book.Text = "Book";
            // 
            // Basket
            // 
            this.Basket.AutoSize = true;
            this.Basket.Location = new System.Drawing.Point(650, 111);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(30, 13);
            this.Basket.TabIndex = 4;
            this.Basket.Text = "Item ";
            // 
            // calcuate
            // 
            this.calcuate.Location = new System.Drawing.Point(718, 341);
            this.calcuate.Name = "calcuate";
            this.calcuate.Size = new System.Drawing.Size(82, 34);
            this.calcuate.TabIndex = 5;
            this.calcuate.Text = "Calcuate subtotal";
            this.calcuate.UseVisualStyleBackColor = true;
            this.calcuate.Click += new System.EventHandler(this.calcuate_Click);
            // 
            // totaltextbox
            // 
            this.totaltextbox.Location = new System.Drawing.Point(630, 338);
            this.totaltextbox.Name = "totaltextbox";
            this.totaltextbox.Size = new System.Drawing.Size(21, 20);
            this.totaltextbox.TabIndex = 6;
            this.totaltextbox.TextChanged += new System.EventHandler(this.totaltextbox_TextChanged);
            // 
            // addCDbutton
            // 
            this.addCDbutton.Location = new System.Drawing.Point(480, 137);
            this.addCDbutton.Name = "addCDbutton";
            this.addCDbutton.Size = new System.Drawing.Size(75, 23);
            this.addCDbutton.TabIndex = 7;
            this.addCDbutton.Text = "Add";
            this.addCDbutton.UseVisualStyleBackColor = true;
            this.addCDbutton.Click += new System.EventHandler(this.addCDbutton_Click);
            // 
            // CDlabel
            // 
            this.CDlabel.AutoSize = true;
            this.CDlabel.Location = new System.Drawing.Point(477, 118);
            this.CDlabel.Name = "CDlabel";
            this.CDlabel.Size = new System.Drawing.Size(22, 13);
            this.CDlabel.TabIndex = 8;
            this.CDlabel.Text = "CD";
            // 
            // price2
            // 
            this.price2.AutoSize = true;
            this.price2.Location = new System.Drawing.Point(530, 118);
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(25, 13);
            this.price2.TabIndex = 10;
            this.price2.Text = "£15";
            // 
            // price1
            // 
            this.price1.AutoSize = true;
            this.price1.Location = new System.Drawing.Point(402, 118);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(25, 13);
            this.price1.TabIndex = 11;
            this.price1.Text = "£10";
            // 
            // priceList
            // 
            this.priceList.FormattingEnabled = true;
            this.priceList.Location = new System.Drawing.Point(718, 127);
            this.priceList.Name = "priceList";
            this.priceList.Size = new System.Drawing.Size(82, 212);
            this.priceList.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(739, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(689, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Basket";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(767, 380);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(16, 13);
            this.total.TabIndex = 15;
            this.total.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Items:";
            // 
            // noitem
            // 
            this.noitem.AutoSize = true;
            this.noitem.Location = new System.Drawing.Point(607, 341);
            this.noitem.Name = "noitem";
            this.noitem.Size = new System.Drawing.Size(0, 13);
            this.noitem.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(893, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(80, 72);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(172, 20);
            this.textBoxUsername.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Sign up:";
            // 
            // Registerbutton
            // 
            this.Registerbutton.Location = new System.Drawing.Point(177, 137);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.Size = new System.Drawing.Size(75, 23);
            this.Registerbutton.TabIndex = 22;
            this.Registerbutton.Text = "Register";
            this.Registerbutton.UseVisualStyleBackColor = true;
            this.Registerbutton.Click += new System.EventHandler(this.Registerbutton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox3.Location = new System.Drawing.Point(12, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(251, 190);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox4.Location = new System.Drawing.Point(12, 248);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(251, 171);
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox5.Location = new System.Drawing.Point(319, 21);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(491, 380);
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Already signed up? Log in:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Username:";
            // 
            // textBoxLoginusername
            // 
            this.textBoxLoginusername.Location = new System.Drawing.Point(87, 303);
            this.textBoxLoginusername.Name = "textBoxLoginusername";
            this.textBoxLoginusername.Size = new System.Drawing.Size(165, 20);
            this.textBoxLoginusername.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(752, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "£";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox6.Location = new System.Drawing.Point(817, 338);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(207, 63);
            this.pictureBox6.TabIndex = 30;
            this.pictureBox6.TabStop = false;
            // 
            // Checkoutbutton
            // 
            this.Checkoutbutton.Location = new System.Drawing.Point(836, 349);
            this.Checkoutbutton.Name = "Checkoutbutton";
            this.Checkoutbutton.Size = new System.Drawing.Size(168, 42);
            this.Checkoutbutton.TabIndex = 31;
            this.Checkoutbutton.Text = "Checkout";
            this.Checkoutbutton.UseVisualStyleBackColor = true;
            this.Checkoutbutton.Click += new System.EventHandler(this.Checkoutbutton_Click);
            // 
            // Loginbutton
            // 
            this.Loginbutton.Location = new System.Drawing.Point(177, 370);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(75, 23);
            this.Loginbutton.TabIndex = 33;
            this.Loginbutton.Text = "Log in";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // passwordregistertext
            // 
            this.passwordregistertext.Location = new System.Drawing.Point(80, 111);
            this.passwordregistertext.Name = "passwordregistertext";
            this.passwordregistertext.PasswordChar = '•';
            this.passwordregistertext.Size = new System.Drawing.Size(172, 20);
            this.passwordregistertext.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Password:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 344);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Password:";
            // 
            // passwordlogintextbox
            // 
            this.passwordlogintextbox.Location = new System.Drawing.Point(87, 344);
            this.passwordlogintextbox.Name = "passwordlogintextbox";
            this.passwordlogintextbox.PasswordChar = '•';
            this.passwordlogintextbox.Size = new System.Drawing.Size(165, 20);
            this.passwordlogintextbox.TabIndex = 37;
            // 
            // dvdbutton
            // 
            this.dvdbutton.Location = new System.Drawing.Point(480, 212);
            this.dvdbutton.Name = "dvdbutton";
            this.dvdbutton.Size = new System.Drawing.Size(75, 23);
            this.dvdbutton.TabIndex = 38;
            this.dvdbutton.Text = "Add";
            this.dvdbutton.UseVisualStyleBackColor = true;
            this.dvdbutton.Click += new System.EventHandler(this.dvdbutton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(352, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(481, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "DVD";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(530, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "£8";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(402, 196);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "£20";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(349, 196);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Lamp";
            // 
            // calcTotalwithDelivery
            // 
            this.calcTotalwithDelivery.Location = new System.Drawing.Point(836, 219);
            this.calcTotalwithDelivery.Name = "calcTotalwithDelivery";
            this.calcTotalwithDelivery.Size = new System.Drawing.Size(168, 41);
            this.calcTotalwithDelivery.TabIndex = 47;
            this.calcTotalwithDelivery.Text = "Calcuate Total with postage";
            this.calcTotalwithDelivery.UseVisualStyleBackColor = true;
            this.calcTotalwithDelivery.Click += new System.EventHandler(this.calcTotalwithDelivery_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(816, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 298);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // finaltotal
            // 
            this.finaltotal.AutoSize = true;
            this.finaltotal.Location = new System.Drawing.Point(960, 275);
            this.finaltotal.Name = "finaltotal";
            this.finaltotal.Size = new System.Drawing.Size(16, 13);
            this.finaltotal.TabIndex = 49;
            this.finaltotal.Text = "...";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(944, 275);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 50;
            this.label17.Text = "£";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(840, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Our Delivery Charges";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(840, 177);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 54;
            this.label20.Text = "> £150";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(840, 147);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 13);
            this.label21.TabIndex = 55;
            this.label21.Text = "£100 - £149.99";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(840, 118);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 13);
            this.label22.TabIndex = 56;
            this.label22.Text = "£50 - £99";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(840, 88);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 13);
            this.label23.TabIndex = 57;
            this.label23.Text = "< £50";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(979, 88);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 13);
            this.label18.TabIndex = 58;
            this.label18.Text = "£6";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(979, 118);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 13);
            this.label19.TabIndex = 59;
            this.label19.Text = "£4";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(979, 147);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(19, 13);
            this.label24.TabIndex = 60;
            this.label24.Text = "£2";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(979, 177);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(28, 13);
            this.label25.TabIndex = 61;
            this.label25.Text = "Free";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 21);
            this.button1.TabIndex = 62;
            this.button1.Text = "Read Password back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.finaltotal);
            this.Controls.Add(this.calcTotalwithDelivery);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dvdbutton);
            this.Controls.Add(this.passwordlogintextbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.passwordregistertext);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.Checkoutbutton);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxLoginusername);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Registerbutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.noitem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceList);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.price2);
            this.Controls.Add(this.CDlabel);
            this.Controls.Add(this.addCDbutton);
            this.Controls.Add(this.totaltextbox);
            this.Controls.Add(this.calcuate);
            this.Controls.Add(this.Basket);
            this.Controls.Add(this.Book);
            this.Controls.Add(this.itemlistBox);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.ListBox itemlistBox;
        private System.Windows.Forms.Label Book;
        private System.Windows.Forms.Label Basket;
        private System.Windows.Forms.Button calcuate;
        private System.Windows.Forms.TextBox totaltextbox;
        private System.Windows.Forms.Button addCDbutton;
        private System.Windows.Forms.Label CDlabel;
        private System.Windows.Forms.Label price2;
        private System.Windows.Forms.Label price1;
        private System.Windows.Forms.ListBox priceList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label noitem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Registerbutton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxLoginusername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button Checkoutbutton;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.TextBox passwordregistertext;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox passwordlogintextbox;
        private System.Windows.Forms.Button dvdbutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button calcTotalwithDelivery;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label finaltotal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button button1;
    }
}

