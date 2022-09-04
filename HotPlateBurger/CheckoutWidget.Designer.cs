using System.ComponentModel;
using System.Drawing;
using HotPlateBurger.Properties;

namespace HotPlateBurger
{
    partial class CheckoutWidget
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.widgetTitle = new System.Windows.Forms.Label();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.widgetSize = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.widgetTitle);
            this.panel1.Controls.Add(this.picturebox);
            this.panel1.Controls.Add(this.widgetSize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 100);
            this.panel1.TabIndex = 0;
            // 
            // widgetTitle
            // 
            this.widgetTitle.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widgetTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.widgetTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.widgetTitle.Location = new System.Drawing.Point(120, 16);
            this.widgetTitle.Name = "widgetTitle";
            this.widgetTitle.Size = new System.Drawing.Size(151, 67);
            this.widgetTitle.TabIndex = 2;
            this.widgetTitle.Text = "Double Cheese Burger";
            this.widgetTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picturebox
            // 
            this.picturebox.Image = global::HotPlateBurger.Properties.Resources.bbqCheeseBurger;
            this.picturebox.Location = new System.Drawing.Point(44, 16);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(74, 67);
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox.TabIndex = 1;
            this.picturebox.TabStop = false;
            // 
            // widgetSize
            // 
            this.widgetSize.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widgetSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.widgetSize.Location = new System.Drawing.Point(3, 29);
            this.widgetSize.Name = "widgetSize";
            this.widgetSize.Size = new System.Drawing.Size(44, 43);
            this.widgetSize.TabIndex = 0;
            this.widgetSize.Text = "3x";
            this.widgetSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(281, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(49, 100);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // CheckoutWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.Name = "CheckoutWidget";
            this.Size = new System.Drawing.Size(330, 100);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label widgetTitle;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.PictureBox picturebox;

        private System.Windows.Forms.Label widgetSize;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}