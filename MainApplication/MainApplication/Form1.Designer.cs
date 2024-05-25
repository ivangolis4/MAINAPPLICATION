namespace MainApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MENUPANEL = new Panel();
            BTNLOGOUT = new Button();
            BTNSALES = new Button();
            BTNORDER = new Button();
            BTNPRODUCT = new Button();
            btndashboard = new Button();
            BTNMENU = new Button();
            panelContainer = new Panel();
            MENUPANEL.SuspendLayout();
            SuspendLayout();
            // 
            // MENUPANEL
            // 
            MENUPANEL.BackColor = Color.FromArgb(192, 192, 255);
            MENUPANEL.Controls.Add(BTNLOGOUT);
            MENUPANEL.Controls.Add(BTNSALES);
            MENUPANEL.Controls.Add(BTNORDER);
            MENUPANEL.Controls.Add(BTNPRODUCT);
            MENUPANEL.Controls.Add(btndashboard);
            MENUPANEL.Controls.Add(BTNMENU);
            MENUPANEL.Dock = DockStyle.Left;
            MENUPANEL.ForeColor = SystemColors.ActiveCaption;
            MENUPANEL.Location = new Point(0, 0);
            MENUPANEL.Name = "MENUPANEL";
            MENUPANEL.Size = new Size(50, 511);
            MENUPANEL.TabIndex = 0;
            MENUPANEL.Paint += panel1_Paint;
            // 
            // BTNLOGOUT
            // 
            BTNLOGOUT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNLOGOUT.BackColor = Color.FromArgb(192, 192, 255);
            BTNLOGOUT.FlatStyle = FlatStyle.Flat;
            BTNLOGOUT.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNLOGOUT.ForeColor = SystemColors.ActiveCaptionText;
            BTNLOGOUT.Image = Properties.Resources.image_removebg_preview__1_;
            BTNLOGOUT.ImageAlign = ContentAlignment.MiddleLeft;
            BTNLOGOUT.Location = new Point(0, 280);
            BTNLOGOUT.Name = "BTNLOGOUT";
            BTNLOGOUT.Padding = new Padding(5, 0, 0, 0);
            BTNLOGOUT.Size = new Size(222, 42);
            BTNLOGOUT.TabIndex = 6;
            BTNLOGOUT.Text = "      LOGOUT";
            BTNLOGOUT.UseVisualStyleBackColor = false;
            BTNLOGOUT.Click += BTNLOGOUT_Click;
            // 
            // BTNSALES
            // 
            BTNSALES.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNSALES.BackColor = Color.FromArgb(192, 192, 255);
            BTNSALES.FlatStyle = FlatStyle.Flat;
            BTNSALES.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNSALES.ForeColor = SystemColors.ActiveCaptionText;
            BTNSALES.Image = Properties.Resources.image_removebg_preview__1_;
            BTNSALES.ImageAlign = ContentAlignment.MiddleLeft;
            BTNSALES.Location = new Point(0, 232);
            BTNSALES.Name = "BTNSALES";
            BTNSALES.Padding = new Padding(5, 0, 0, 0);
            BTNSALES.Size = new Size(222, 42);
            BTNSALES.TabIndex = 5;
            BTNSALES.Text = "      SALES";
            BTNSALES.UseVisualStyleBackColor = false;
            BTNSALES.Click += BTNSALES_Click;
            // 
            // BTNORDER
            // 
            BTNORDER.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNORDER.BackColor = Color.FromArgb(192, 192, 255);
            BTNORDER.FlatStyle = FlatStyle.Flat;
            BTNORDER.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNORDER.ForeColor = SystemColors.ActiveCaptionText;
            BTNORDER.Image = Properties.Resources.image_removebg_preview__1_;
            BTNORDER.ImageAlign = ContentAlignment.MiddleLeft;
            BTNORDER.Location = new Point(0, 184);
            BTNORDER.Name = "BTNORDER";
            BTNORDER.Padding = new Padding(5, 0, 0, 0);
            BTNORDER.Size = new Size(222, 42);
            BTNORDER.TabIndex = 4;
            BTNORDER.Text = "      ORDER";
            BTNORDER.UseVisualStyleBackColor = false;
            BTNORDER.Click += BTNORDER_Click;
            // 
            // BTNPRODUCT
            // 
            BTNPRODUCT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNPRODUCT.BackColor = Color.FromArgb(192, 192, 255);
            BTNPRODUCT.FlatStyle = FlatStyle.Flat;
            BTNPRODUCT.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNPRODUCT.ForeColor = SystemColors.ActiveCaptionText;
            BTNPRODUCT.Image = Properties.Resources.image_removebg_preview__1_;
            BTNPRODUCT.ImageAlign = ContentAlignment.MiddleLeft;
            BTNPRODUCT.Location = new Point(1, 136);
            BTNPRODUCT.Name = "BTNPRODUCT";
            BTNPRODUCT.Padding = new Padding(5, 0, 0, 0);
            BTNPRODUCT.Size = new Size(222, 42);
            BTNPRODUCT.TabIndex = 3;
            BTNPRODUCT.Text = "      PRODUCT";
            BTNPRODUCT.UseVisualStyleBackColor = false;
            BTNPRODUCT.Click += BTNPRODUCT_Click;
            // 
            // btndashboard
            // 
            btndashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btndashboard.BackColor = Color.FromArgb(192, 192, 255);
            btndashboard.FlatStyle = FlatStyle.Flat;
            btndashboard.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndashboard.ForeColor = SystemColors.ActiveCaptionText;
            btndashboard.Image = (Image)resources.GetObject("btndashboard.Image");
            btndashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btndashboard.Location = new Point(0, 88);
            btndashboard.Name = "btndashboard";
            btndashboard.Padding = new Padding(5, 0, 0, 0);
            btndashboard.Size = new Size(222, 42);
            btndashboard.TabIndex = 2;
            btndashboard.Text = "      DASHBOARD";
            btndashboard.UseVisualStyleBackColor = false;
            btndashboard.Click += btndashboard_Click;
            // 
            // BTNMENU
            // 
            BTNMENU.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNMENU.BackColor = Color.FromArgb(192, 192, 255);
            BTNMENU.FlatStyle = FlatStyle.Flat;
            BTNMENU.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNMENU.ForeColor = SystemColors.ActiveCaptionText;
            BTNMENU.Image = Properties.Resources.image_removebg_preview__1_;
            BTNMENU.ImageAlign = ContentAlignment.MiddleLeft;
            BTNMENU.Location = new Point(0, 3);
            BTNMENU.Name = "BTNMENU";
            BTNMENU.Padding = new Padding(5, 0, 0, 0);
            BTNMENU.Size = new Size(222, 42);
            BTNMENU.TabIndex = 1;
            BTNMENU.Text = "      MENU";
            BTNMENU.UseVisualStyleBackColor = false;
            BTNMENU.Click += BTNMENU_Click;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(50, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(884, 511);
            panelContainer.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 511);
            Controls.Add(panelContainer);
            Controls.Add(MENUPANEL);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "`E-Commerce Management System`";
            Load += Form1_Load;
            MENUPANEL.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MENUPANEL;
        private Button BTNMENU;
        private Button BTNLOGOUT;
        private Button BTNSALES;
        private Button BTNORDER;
        private Button BTNPRODUCT;
        private Button btndashboard;
        private Panel panelContainer;
    }
}
