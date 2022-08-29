using System.ComponentModel;

namespace HotPlateBurger
{
    partial class AllFrame
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.widget1 = new HotPlateBurger.Widget();
            this.widget2 = new HotPlateBurger.Widget();
            this.widget3 = new HotPlateBurger.Widget();
            this.widget4 = new HotPlateBurger.Widget();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.Controls.Add(this.widget1);
            this.flowLayoutPanel1.Controls.Add(this.widget2);
            this.flowLayoutPanel1.Controls.Add(this.widget3);
            this.flowLayoutPanel1.Controls.Add(this.widget4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(729, 479);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // widget1
            // 
            this.widget1.BackColor = System.Drawing.Color.Coral;
            this.widget1.Location = new System.Drawing.Point(20, 20);
            this.widget1.Margin = new System.Windows.Forms.Padding(20);
            this.widget1.Name = "widget1";
            this.widget1.Size = new System.Drawing.Size(300, 352);
            this.widget1.TabIndex = 0;
            // 
            // widget2
            // 
            this.widget2.BackColor = System.Drawing.Color.Coral;
            this.widget2.Location = new System.Drawing.Point(360, 20);
            this.widget2.Margin = new System.Windows.Forms.Padding(20);
            this.widget2.Name = "widget2";
            this.widget2.Size = new System.Drawing.Size(300, 352);
            this.widget2.TabIndex = 1;
            // 
            // widget3
            // 
            this.widget3.BackColor = System.Drawing.Color.Coral;
            this.widget3.Location = new System.Drawing.Point(20, 412);
            this.widget3.Margin = new System.Windows.Forms.Padding(20);
            this.widget3.Name = "widget3";
            this.widget3.Size = new System.Drawing.Size(300, 352);
            this.widget3.TabIndex = 2;
            // 
            // widget4
            // 
            this.widget4.BackColor = System.Drawing.Color.Coral;
            this.widget4.Location = new System.Drawing.Point(360, 412);
            this.widget4.Margin = new System.Windows.Forms.Padding(20);
            this.widget4.Name = "widget4";
            this.widget4.Size = new System.Drawing.Size(300, 352);
            this.widget4.TabIndex = 3;
            // 
            // AllFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(729, 479);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "AllFrame";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private HotPlateBurger.Widget widget1;
        private HotPlateBurger.Widget widget2;
        private HotPlateBurger.Widget widget3;
        private HotPlateBurger.Widget widget4;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        #endregion
    }
}