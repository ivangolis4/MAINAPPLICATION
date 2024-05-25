namespace MainApplication
{
    partial class SALES
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
            BTNTOTALSALES = new Button();
            BTNHISTORY = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(BTNTOTALSALES);
            panel1.Controls.Add(BTNHISTORY);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 50);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // BTNTOTALSALES
            // 
            BTNTOTALSALES.Anchor = AnchorStyles.Top;
            BTNTOTALSALES.FlatStyle = FlatStyle.Flat;
            BTNTOTALSALES.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNTOTALSALES.ForeColor = SystemColors.ButtonHighlight;
            BTNTOTALSALES.Location = new Point(258, 4);
            BTNTOTALSALES.Name = "BTNTOTALSALES";
            BTNTOTALSALES.Size = new Size(177, 43);
            BTNTOTALSALES.TabIndex = 8;
            BTNTOTALSALES.Text = "TOTAL SALES";
            BTNTOTALSALES.UseVisualStyleBackColor = true;
            // 
            // BTNHISTORY
            // 
            BTNHISTORY.Anchor = AnchorStyles.Top;
            BTNHISTORY.FlatStyle = FlatStyle.Flat;
            BTNHISTORY.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNHISTORY.ForeColor = SystemColors.ButtonHighlight;
            BTNHISTORY.Location = new Point(500, 4);
            BTNHISTORY.Name = "BTNHISTORY";
            BTNHISTORY.Size = new Size(177, 43);
            BTNHISTORY.TabIndex = 7;
            BTNHISTORY.Text = "HISTORY";
            BTNHISTORY.UseVisualStyleBackColor = true;
            // 
            // SALES
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 533);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SALES";
            Text = "SALES";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BTNTOTALSALES;
        private Button BTNHISTORY;
    }
}