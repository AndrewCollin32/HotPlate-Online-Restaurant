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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(234, 518);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // allButton
            // 
            this.allButton.BackColor = System.Drawing.Color.SandyBrown;
            this.allButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allButton.FlatAppearance.BorderSize = 0;
            this.allButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.burgerButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.burgerButton.Location = new System.Drawing.Point(0, 68);
            this.burgerButton.Margin = new System.Windows.Forms.Padding(0);
            this.burgerButton.Name = "burgerButton";
            this.burgerButton.Size = new System.Drawing.Size(234, 68);
            this.burgerButton.TabIndex = 1;
            this.burgerButton.Text = "Burgers";
            this.burgerButton.UseVisualStyleBackColor = true;
            this.burgerButton.Click += new System.EventHandler(this.burgerButton_Click);
            // 
            // chickenButton
            // 
            this.chickenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chickenButton.FlatAppearance.BorderSize = 0;
            this.chickenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chickenButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chickenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chickenButton.Location = new System.Drawing.Point(0, 136);
            this.chickenButton.Margin = new System.Windows.Forms.Padding(0);
            this.chickenButton.Name = "chickenButton";
            this.chickenButton.Size = new System.Drawing.Size(234, 68);
            this.chickenButton.TabIndex = 2;
            this.chickenButton.Text = "Chicken";
            this.chickenButton.UseVisualStyleBackColor = true;
            // 
            // sidesButton
            // 
            this.sidesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sidesButton.FlatAppearance.BorderSize = 0;
            this.sidesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidesButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidesButton.Location = new System.Drawing.Point(0, 204);
            this.sidesButton.Margin = new System.Windows.Forms.Padding(0);
            this.sidesButton.Name = "sidesButton";
            this.sidesButton.Size = new System.Drawing.Size(234, 68);
            this.sidesButton.TabIndex = 3;
            this.sidesButton.Text = "Sides";
            this.sidesButton.UseVisualStyleBackColor = true;
            // 
            // drinkButton
            // 
            this.drinkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drinkButton.FlatAppearance.BorderSize = 0;
            this.drinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drinkButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.drinkButton.Location = new System.Drawing.Point(0, 272);
            this.drinkButton.Margin = new System.Windows.Forms.Padding(0);
            this.drinkButton.Name = "drinkButton";
            this.drinkButton.Size = new System.Drawing.Size(234, 68);
            this.drinkButton.TabIndex = 4;
            this.drinkButton.Text = "Drinks";
            this.drinkButton.UseVisualStyleBackColor = true;
            // 
            // dessertsButton
            // 
            this.dessertsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dessertsButton.FlatAppearance.BorderSize = 0;
            this.dessertsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dessertsButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dessertsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dessertsButton.Location = new System.Drawing.Point(0, 340);
            this.dessertsButton.Margin = new System.Windows.Forms.Padding(0);
            this.dessertsButton.Name = "dessertsButton";
            this.dessertsButton.Size = new System.Drawing.Size(234, 68);
            this.dessertsButton.TabIndex = 5;
            this.dessertsButton.Text = "Desserts";
            this.dessertsButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 458);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 518);
            this.panel1.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.PictureBox pictureBox1;

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