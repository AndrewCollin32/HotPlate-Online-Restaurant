using System.ComponentModel;

namespace HotPlateBurger
{
    partial class checkoutPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkoutPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.expDateLabel = new System.Windows.Forms.MaskedTextBox();
            this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cardNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.totalLabelString = new System.Windows.Forms.Label();
            this.tipBox = new System.Windows.Forms.ComboBox();
            this.FullNameTextbox = new System.Windows.Forms.TextBox();
            this.creditCardPicture = new System.Windows.Forms.PictureBox();
            this.cwTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.yourTotalLabel = new System.Windows.Forms.Label();
            this.yourOrderLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalLeft = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkoutFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditCardPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.expDateLabel);
            this.panel1.Controls.Add(this.phoneTextBox);
            this.panel1.Controls.Add(this.cardNumberMaskedTextBox);
            this.panel1.Controls.Add(this.totalLabelString);
            this.panel1.Controls.Add(this.tipBox);
            this.panel1.Controls.Add(this.FullNameTextbox);
            this.panel1.Controls.Add(this.creditCardPicture);
            this.panel1.Controls.Add(this.cwTextBox);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.yourTotalLabel);
            this.panel1.Controls.Add(this.yourOrderLabel);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(453, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 738);
            this.panel1.TabIndex = 0;
            // 
            // expDateLabel
            // 
            this.expDateLabel.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expDateLabel.ForeColor = System.Drawing.Color.DimGray;
            this.expDateLabel.Location = new System.Drawing.Point(654, 624);
            this.expDateLabel.Name = "expDateLabel";
            this.expDateLabel.Size = new System.Drawing.Size(165, 33);
            this.expDateLabel.TabIndex = 22;
            this.expDateLabel.Text = "MM/YY";
            this.expDateLabel.Enter += new System.EventHandler(this.expDateLabel_Enter);
            this.expDateLabel.Leave += new System.EventHandler(this.expDateLabel_Leave);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(108, 682);
            this.phoneTextBox.Mask = "000-000-0000";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(270, 33);
            this.phoneTextBox.TabIndex = 21;
            // 
            // cardNumberMaskedTextBox
            // 
            this.cardNumberMaskedTextBox.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNumberMaskedTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.cardNumberMaskedTextBox.Location = new System.Drawing.Point(473, 586);
            this.cardNumberMaskedTextBox.Name = "cardNumberMaskedTextBox";
            this.cardNumberMaskedTextBox.Size = new System.Drawing.Size(346, 33);
            this.cardNumberMaskedTextBox.TabIndex = 20;
            this.cardNumberMaskedTextBox.Text = "Card Number";
            this.cardNumberMaskedTextBox.Enter += new System.EventHandler(this.cardNumberMaskedTextBox_Enter);
            this.cardNumberMaskedTextBox.Leave += new System.EventHandler(this.cardNumberMaskedTextBox_Leave);
            // 
            // totalLabelString
            // 
            this.totalLabelString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalLabelString.Font = new System.Drawing.Font("Yu Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabelString.ForeColor = System.Drawing.Color.White;
            this.totalLabelString.Location = new System.Drawing.Point(15, 408);
            this.totalLabelString.Name = "totalLabelString";
            this.totalLabelString.Size = new System.Drawing.Size(139, 153);
            this.totalLabelString.TabIndex = 19;
            this.totalLabelString.Text = "Total:";
            // 
            // tipBox
            // 
            this.tipBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tipBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipBox.FormattingEnabled = true;
            this.tipBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tipBox.Location = new System.Drawing.Point(109, 597);
            this.tipBox.Name = "tipBox";
            this.tipBox.Size = new System.Drawing.Size(121, 28);
            this.tipBox.TabIndex = 18;
            this.tipBox.SelectedIndexChanged += new System.EventHandler(this.tipBox_SelectedIndexChanged);
            // 
            // FullNameTextbox
            // 
            this.FullNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextbox.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.FullNameTextbox.Location = new System.Drawing.Point(473, 547);
            this.FullNameTextbox.Name = "FullNameTextbox";
            this.FullNameTextbox.Size = new System.Drawing.Size(346, 33);
            this.FullNameTextbox.TabIndex = 17;
            this.FullNameTextbox.Text = "Full Name";
            this.FullNameTextbox.Enter += new System.EventHandler(this.fullNameTextBox_Enter);
            this.FullNameTextbox.Leave += new System.EventHandler(this.fullNameTextBox_Leave);
            // 
            // pictureBox2
            // 
            this.creditCardPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.creditCardPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.creditCardPicture.Location = new System.Drawing.Point(510, 500);
            this.creditCardPicture.Name = "creditCardPicture";
            this.creditCardPicture.Size = new System.Drawing.Size(274, 34);
            this.creditCardPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.creditCardPicture.TabIndex = 16;
            this.creditCardPicture.TabStop = false;
            // 
            // cwTextBox
            // 
            this.cwTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cwTextBox.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cwTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.cwTextBox.Location = new System.Drawing.Point(473, 625);
            this.cwTextBox.MaxLength = 3;
            this.cwTextBox.Name = "cwTextBox";
            this.cwTextBox.Size = new System.Drawing.Size(164, 33);
            this.cwTextBox.TabIndex = 14;
            this.cwTextBox.Text = "CW";
            this.cwTextBox.Enter += new System.EventHandler(this.cwTextBox_Enter);
            this.cwTextBox.Leave += new System.EventHandler(this.cwTextBox_Leave);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Monofonto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(14, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 23);
            this.label15.TabIndex = 13;
            this.label15.Text = "Your Order:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.emailTextBox.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(109, 636);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(270, 33);
            this.emailTextBox.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(15, 685);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 23);
            this.label13.TabIndex = 11;
            this.label13.Text = "Phone";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(15, 641);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 23);
            this.label12.TabIndex = 11;
            this.label12.Text = "Email";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(15, 596);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 23);
            this.label11.TabIndex = 11;
            this.label11.Text = "Tips";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // yourTotalLabel
            // 
            this.yourTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.yourTotalLabel.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourTotalLabel.ForeColor = System.Drawing.Color.White;
            this.yourTotalLabel.Location = new System.Drawing.Point(239, 408);
            this.yourTotalLabel.Name = "yourTotalLabel";
            this.yourTotalLabel.Size = new System.Drawing.Size(139, 153);
            this.yourTotalLabel.TabIndex = 10;
            this.yourTotalLabel.Text = "$37.49";
            this.yourTotalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // yourOrderLabel
            // 
            this.yourOrderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.yourOrderLabel.Font = new System.Drawing.Font("Yu Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourOrderLabel.ForeColor = System.Drawing.Color.White;
            this.yourOrderLabel.Location = new System.Drawing.Point(14, 54);
            this.yourOrderLabel.Name = "yourOrderLabel";
            this.yourOrderLabel.Size = new System.Drawing.Size(364, 324);
            this.yourOrderLabel.TabIndex = 10;
            this.yourOrderLabel.Text = "3 x Cheeseburger $30.29";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.Font = new System.Drawing.Font("Monofonto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Your Total:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(396, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(2, 951);
            this.label8.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2, 786);
            this.label7.TabIndex = 3;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.ForeColor = System.Drawing.Color.White;
            this.addressTextBox.Location = new System.Drawing.Point(401, 430);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(360, 42);
            this.addressTextBox.TabIndex = 7;
            this.addressTextBox.Text = "3738 Middles St Apt #40, San Diego CA 92147";
            this.addressTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.SandyBrown;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(767, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Change";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.changeAddressButton_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(401, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(482, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Monofonto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(396, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(488, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "Payment";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(490, 2);
            this.label3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 2);
            this.label2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(473, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(575, 674);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Place Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.totalLeft);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 657);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 81);
            this.panel2.TabIndex = 1;
            // 
            // totalLeft
            // 
            this.totalLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.totalLeft.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLeft.ForeColor = System.Drawing.Color.Transparent;
            this.totalLeft.Location = new System.Drawing.Point(17, 17);
            this.totalLeft.Name = "totalLeft";
            this.totalLeft.Size = new System.Drawing.Size(286, 51);
            this.totalLeft.TabIndex = 0;
            this.totalLeft.Text = "Total: $40";
            this.totalLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkoutFlowPanel);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(453, 738);
            this.panel3.TabIndex = 2;
            // 
            // checkoutFlowPanel
            // 
            this.checkoutFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.checkoutFlowPanel.Location = new System.Drawing.Point(0, 45);
            this.checkoutFlowPanel.Name = "checkoutFlowPanel";
            this.checkoutFlowPanel.Size = new System.Drawing.Size(453, 612);
            this.checkoutFlowPanel.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.exitButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(453, 45);
            this.panel4.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Coral;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(10, 11);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Back";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // checkoutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "checkoutPage";
            this.Size = new System.Drawing.Size(1337, 738);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditCardPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.MaskedTextBox expDateLabel;

        private System.Windows.Forms.MaskedTextBox phoneTextBox;

        private System.Windows.Forms.MaskedTextBox cardNumberMaskedTextBox;

        public System.Windows.Forms.Label totalLabelString;

        private System.Windows.Forms.ComboBox tipBox;

        private System.Windows.Forms.TextBox FullNameTextbox;

        private System.Windows.Forms.PictureBox creditCardPicture;

        private System.Windows.Forms.TextBox cwTextBox;

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.FlowLayoutPanel checkoutFlowPanel;

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label addressTextBox;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button exitButton;

        private System.Windows.Forms.Panel panel4;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label totalLeft;

        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel panel1;
        
        public System.Windows.Forms.Label yourTotalLabel;
        public System.Windows.Forms.Label yourOrderLabel;

        #endregion
    }
}