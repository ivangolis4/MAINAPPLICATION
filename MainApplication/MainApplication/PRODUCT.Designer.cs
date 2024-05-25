namespace MainApplication
{
    partial class PRODUCT
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
            BTNDELETE = new Button();
            BTNCREATE = new Button();
            BTNUPDATE = new Button();
            BTNRETRIEVE = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(BTNDELETE);
            panel1.Controls.Add(BTNCREATE);
            panel1.Controls.Add(BTNUPDATE);
            panel1.Controls.Add(BTNRETRIEVE);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 46);
            panel1.TabIndex = 0;
            // 
            // BTNDELETE
            // 
            BTNDELETE.Anchor = AnchorStyles.Top;
            BTNDELETE.FlatStyle = FlatStyle.Flat;
            BTNDELETE.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNDELETE.ForeColor = SystemColors.ButtonHighlight;
            BTNDELETE.Location = new Point(709, 3);
            BTNDELETE.Name = "BTNDELETE";
            BTNDELETE.Size = new Size(177, 43);
            BTNDELETE.TabIndex = 4;
            BTNDELETE.Text = "DELETE";
            BTNDELETE.UseVisualStyleBackColor = true;
            // 
            // BTNCREATE
            // 
            BTNCREATE.Anchor = AnchorStyles.Top;
            BTNCREATE.FlatStyle = FlatStyle.Flat;
            BTNCREATE.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNCREATE.ForeColor = SystemColors.ButtonHighlight;
            BTNCREATE.Location = new Point(79, 3);
            BTNCREATE.Name = "BTNCREATE";
            BTNCREATE.Size = new Size(177, 43);
            BTNCREATE.TabIndex = 3;
            BTNCREATE.Text = "CREATE";
            BTNCREATE.UseVisualStyleBackColor = true;
            // 
            // BTNUPDATE
            // 
            BTNUPDATE.Anchor = AnchorStyles.Top;
            BTNUPDATE.FlatStyle = FlatStyle.Flat;
            BTNUPDATE.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNUPDATE.ForeColor = SystemColors.ButtonHighlight;
            BTNUPDATE.Location = new Point(526, 3);
            BTNUPDATE.Name = "BTNUPDATE";
            BTNUPDATE.Size = new Size(177, 43);
            BTNUPDATE.TabIndex = 3;
            BTNUPDATE.Text = "UPDATE";
            BTNUPDATE.UseVisualStyleBackColor = true;
            // 
            // BTNRETRIEVE
            // 
            BTNRETRIEVE.Anchor = AnchorStyles.Top;
            BTNRETRIEVE.FlatStyle = FlatStyle.Flat;
            BTNRETRIEVE.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNRETRIEVE.ForeColor = SystemColors.ButtonHighlight;
            BTNRETRIEVE.Location = new Point(321, 3);
            BTNRETRIEVE.Name = "BTNRETRIEVE";
            BTNRETRIEVE.Size = new Size(177, 43);
            BTNRETRIEVE.TabIndex = 2;
            BTNRETRIEVE.Text = "RETRIEVE";
            BTNRETRIEVE.UseVisualStyleBackColor = true;
            // 
            // PRODUCT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 533);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PRODUCT";
            Text = "PRODUCT";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BTNCREATE;
        private Button BTNUPDATE;
        private Button BTNRETRIEVE;
        private Button BTNDELETE;
    }
}