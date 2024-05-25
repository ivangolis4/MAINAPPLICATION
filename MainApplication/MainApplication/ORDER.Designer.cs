namespace MainApplication
{
    partial class ORDER
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
            BTNPROCESSING = new Button();
            BTNDELIVERED = new Button();
            BTNSHIPPING = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(BTNPROCESSING);
            panel1.Controls.Add(BTNDELIVERED);
            panel1.Controls.Add(BTNSHIPPING);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 50);
            panel1.TabIndex = 0;
            // 
            // BTNPROCESSING
            // 
            BTNPROCESSING.Anchor = AnchorStyles.Top;
            BTNPROCESSING.FlatStyle = FlatStyle.Flat;
            BTNPROCESSING.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNPROCESSING.ForeColor = SystemColors.ButtonHighlight;
            BTNPROCESSING.Location = new Point(155, 4);
            BTNPROCESSING.Name = "BTNPROCESSING";
            BTNPROCESSING.Size = new Size(177, 43);
            BTNPROCESSING.TabIndex = 6;
            BTNPROCESSING.Text = "PROCESSING";
            BTNPROCESSING.UseVisualStyleBackColor = true;
            // 
            // BTNDELIVERED
            // 
            BTNDELIVERED.Anchor = AnchorStyles.Top;
            BTNDELIVERED.FlatStyle = FlatStyle.Flat;
            BTNDELIVERED.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNDELIVERED.ForeColor = SystemColors.ButtonHighlight;
            BTNDELIVERED.Location = new Point(602, 4);
            BTNDELIVERED.Name = "BTNDELIVERED";
            BTNDELIVERED.Size = new Size(177, 43);
            BTNDELIVERED.TabIndex = 5;
            BTNDELIVERED.Text = "DELIVERED";
            BTNDELIVERED.UseVisualStyleBackColor = true;
            // 
            // BTNSHIPPING
            // 
            BTNSHIPPING.Anchor = AnchorStyles.Top;
            BTNSHIPPING.FlatStyle = FlatStyle.Flat;
            BTNSHIPPING.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNSHIPPING.ForeColor = SystemColors.ButtonHighlight;
            BTNSHIPPING.Location = new Point(397, 4);
            BTNSHIPPING.Name = "BTNSHIPPING";
            BTNSHIPPING.Size = new Size(177, 43);
            BTNSHIPPING.TabIndex = 4;
            BTNSHIPPING.Text = "SHIPPING";
            BTNSHIPPING.UseVisualStyleBackColor = true;
            // 
            // ORDER
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 533);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ORDER";
            Text = "ORDER";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BTNPROCESSING;
        private Button BTNDELIVERED;
        private Button BTNSHIPPING;
    }
}