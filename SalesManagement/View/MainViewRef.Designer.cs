namespace View
{
    partial class MainViewRef
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
            this.menuLeft = new System.Windows.Forms.Panel();
            this.menuTop = new System.Windows.Forms.Panel();
            this.contentView = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnMobileMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuLeft.SuspendLayout();
            this.menuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMobileMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuLeft
            // 
            this.menuLeft.BackColor = System.Drawing.Color.SteelBlue;
            this.menuLeft.Controls.Add(this.pictureBox1);
            this.menuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuLeft.Location = new System.Drawing.Point(0, 0);
            this.menuLeft.Name = "menuLeft";
            this.menuLeft.Size = new System.Drawing.Size(250, 650);
            this.menuLeft.TabIndex = 0;
            // 
            // menuTop
            // 
            this.menuTop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuTop.Controls.Add(this.btnMinimize);
            this.menuTop.Controls.Add(this.btnExit);
            this.menuTop.Controls.Add(this.btnMobileMenu);
            this.menuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuTop.Location = new System.Drawing.Point(250, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(1050, 50);
            this.menuTop.TabIndex = 1;
            // 
            // contentView
            // 
            this.contentView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentView.Location = new System.Drawing.Point(250, 50);
            this.contentView.Name = "contentView";
            this.contentView.Size = new System.Drawing.Size(1050, 600);
            this.contentView.TabIndex = 2;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::View.Properties.Resources.icon_minimizar;
            this.btnMinimize.Location = new System.Drawing.Point(976, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::View.Properties.Resources.logout;
            this.btnExit.Location = new System.Drawing.Point(1012, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMobileMenu
            // 
            this.btnMobileMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMobileMenu.Image = global::View.Properties.Resources.Mobile_Menu_Icon;
            this.btnMobileMenu.Location = new System.Drawing.Point(6, 6);
            this.btnMobileMenu.Name = "btnMobileMenu";
            this.btnMobileMenu.Size = new System.Drawing.Size(35, 35);
            this.btnMobileMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMobileMenu.TabIndex = 0;
            this.btnMobileMenu.TabStop = false;
            this.btnMobileMenu.Click += new System.EventHandler(this.btnMobileMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::View.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainViewRef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.contentView);
            this.Controls.Add(this.menuTop);
            this.Controls.Add(this.menuLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainViewRef";
            this.Text = "MainViewRef";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuLeft.ResumeLayout(false);
            this.menuTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMobileMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuLeft;
        private System.Windows.Forms.Panel menuTop;
        private System.Windows.Forms.PictureBox btnMobileMenu;
        private System.Windows.Forms.Panel contentView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnMinimize;
    }
}