using System.ComponentModel;

namespace HotPlateBurger
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.allButton = new System.Windows.Forms.Button();
            this.burgerButton = new System.Windows.Forms.Button();
            this.chickenButton = new System.Windows.Forms.Button();
            this.sidesButton = new System.Windows.Forms.Button();
            this.drinkButton = new System.Windows.Forms.Button();
            this.dessertsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Coral;
            this.flowLayoutPanel1.Controls.Add(this.allButton);
            this.flowLayoutPanel1.Controls.Add(this.burgerButton);
            this.flowLayoutPanel1.Controls.Add(this.chickenButton);
            this.flowLayoutPanel1.Controls.Add(this.sidesButton);
            this.flowLayoutPanel1.Controls.Add(this.drinkButton);
            this.flowLayoutPanel1.Controls.Add(this.dessertsButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(234, 415);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // allButton
            // 
            this.allButton.BackColor = System.Drawing.Color.SandyBrown;
            this.allButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allButton.FlatAppearance.BorderSize = 0;
            this.allButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.allButton.Location = new System.Drawing.Point(0, 0);
            this.allButton.Margin = new System.Windows.Forms.Padding(0);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(234, 68);
            this.allButton.TabIndex = 0;
            this.allButton.Text = "All";
            this.allButton.UseVisualStyleBackColor = false;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // burgerButton
            // 
            this.burgerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.burgerButton.FlatAppearance.BorderSize = 0;
            this.burgerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.burgerButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.burgerButton.Location = new System.Drawing.Point(0, 68);
            this.burgerButton.Margin = new System.Windows.Forms.Padding(0);
            this.burgerButton.Name = "burgerButton";
            this.burgerButton.Size = new System.Drawing.Size(234, 68);
            this.burgerButton.TabIndex = 1;
            this.burgerButton.Text = "Beef Burgers";
            this.burgerButton.UseVisualStyleBackColor = true;
            this.burgerButton.Click += new System.EventHandler(this.burgerButton_Click);
            // 
            // chickenButton
            // 
            this.chickenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chickenButton.FlatAppearance.BorderSize = 0;
            this.chickenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chickenButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chickenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.chickenButton.Location = new System.Drawing.Point(0, 136);
            this.chickenButton.Margin = new System.Windows.Forms.Padding(0);
            this.chickenButton.Name = "chickenButton";
            this.chickenButton.Size = new System.Drawing.Size(234, 68);
            this.chickenButton.TabIndex = 2;
            this.chickenButton.Text = "Chicken";
            this.chickenButton.UseVisualStyleBackColor = true;
            this.chickenButton.Click += new System.EventHandler(this.chickenButton_Click);
            // 
            // sidesButton
            // 
            this.sidesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sidesButton.FlatAppearance.BorderSize = 0;
            this.sidesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidesButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.sidesButton.Location = new System.Drawing.Point(0, 204);
            this.sidesButton.Margin = new System.Windows.Forms.Padding(0);
            this.sidesButton.Name = "sidesButton";
            this.sidesButton.Size = new System.Drawing.Size(234, 68);
            this.sidesButton.TabIndex = 3;
            this.sidesButton.Text = "Sides";
            this.sidesButton.UseVisualStyleBackColor = true;
            this.sidesButton.Click += new System.EventHandler(this.sidesButton_Click);
            // 
            // drinkButton
            // 
            this.drinkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drinkButton.FlatAppearance.BorderSize = 0;
            this.drinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drinkButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.drinkButton.Location = new System.Drawing.Point(0, 272);
            this.drinkButton.Margin = new System.Windows.Forms.Padding(0);
            this.drinkButton.Name = "drinkButton";
            this.drinkButton.Size = new System.Drawing.Size(234, 68);
            this.drinkButton.TabIndex = 4;
            this.drinkButton.Text = "Drinks and Shakes";
            this.drinkButton.UseVisualStyleBackColor = true;
            this.drinkButton.Click += new System.EventHandler(this.drinkButton_Click);
            // 
            // dessertsButton
            // 
            this.dessertsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dessertsButton.FlatAppearance.BorderSize = 0;
            this.dessertsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dessertsButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dessertsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dessertsButton.Location = new System.Drawing.Point(0, 340);
            this.dessertsButton.Margin = new System.Windows.Forms.Padding(0);
            this.dessertsButton.Name = "dessertsButton";
            this.dessertsButton.Size = new System.Drawing.Size(234, 68);
            this.dessertsButton.TabIndex = 5;
            this.dessertsButton.Text = "Desserts";
            this.dessertsButton.UseVisualStyleBackColor = true;
            this.dessertsButton.Click += new System.EventHandler(this.dessertsButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.19658F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.80342F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.totalLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 415);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(234, 103);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.shoppingCartIcon_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.totalLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.totalLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.White;
            this.totalLabel.Location = new System.Drawing.Point(75, 35);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(150, 33);
            this.totalLabel.TabIndex = 1;
            this.totalLabel.Text = "Total: $0";
            this.totalLabel.Click += new System.EventHandler(this.totalLabel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 518);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Coral;
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 518);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(234, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 518);
            this.panel2.TabIndex = 2;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DashBoard";
            this.Size = new System.Drawing.Size(979, 518);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.Label totalLabel;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button burgerButton;
        private System.Windows.Forms.Button chickenButton;
        private System.Windows.Forms.Button sidesButton;
        private System.Windows.Forms.Button drinkButton;
        private System.Windows.Forms.Button dessertsButton;

        private System.Windows.Forms.Button allButton;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        #endregion
    }
}