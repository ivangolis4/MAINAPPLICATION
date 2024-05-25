namespace MainApplication
{
    partial class DASHBOARD
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
            panel1 = new Panel();
            BTNTOTAL = new Button();
            BTNCANCEL = new Button();
            BTNORDER = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(BTNTOTAL);
            panel1.Controls.Add(BTNCANCEL);
            panel1.Controls.Add(BTNORDER);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 46);
            panel1.TabIndex = 0;
            // 
            // BTNTOTAL
            // 
            BTNTOTAL.Anchor = AnchorStyles.Top;
            BTNTOTAL.FlatStyle = FlatStyle.Flat;
            BTNTOTAL.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNTOTAL.ForeColor = SystemColors.ButtonHighlight;
            BTNTOTAL.Location = new Point(556, 0);
            BTNTOTAL.Name = "BTNTOTAL";
            BTNTOTAL.Size = new Size(177, 43);
            BTNTOTAL.TabIndex = 3;
            BTNTOTAL.Text = "TOTAL";
            BTNTOTAL.UseVisualStyleBackColor = true;
            // 
            // BTNCANCEL
            // 
            BTNCANCEL.Anchor = AnchorStyles.Top;
            BTNCANCEL.FlatStyle = FlatStyle.Flat;
            BTNCANCEL.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNCANCEL.ForeColor = SystemColors.ButtonHighlight;
            BTNCANCEL.Location = new Point(343, 0);
            BTNCANCEL.Name = "BTNCANCEL";
            BTNCANCEL.Size = new Size(177, 43);
            BTNCANCEL.TabIndex = 2;
            BTNCANCEL.Text = "CANCEL";
            BTNCANCEL.UseVisualStyleBackColor = true;
            // 
            // BTNORDER
            // 
            BTNORDER.Anchor = AnchorStyles.Top;
            BTNORDER.FlatStyle = FlatStyle.Flat;
            BTNORDER.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNORDER.ForeColor = SystemColors.ButtonHighlight;
            BTNORDER.Location = new Point(126, 0);
            BTNORDER.Name = "BTNORDER";
            BTNORDER.Size = new Size(177, 43);
            BTNORDER.TabIndex = 1;
            BTNORDER.Text = "ORDER";
            BTNORDER.UseVisualStyleBackColor = true;
            // 
            // DASHBOARD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 533);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DASHBOARD";
            Text = "DASHBOARD";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BTNTOTAL;
        private Button BTNCANCEL;
        private Button BTNORDER;
    }
}