namespace MainApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadForm(Object Form)
        {
            if (this.panelContainer.Controls.Count > 0)
                this.panelContainer.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(f);
            this.panelContainer.Tag = f;
            f.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTNMENU_Click(object sender, EventArgs e)
        {
            if (MENUPANEL.Width == 222)
            {
                MENUPANEL.Width = 50;
            }
            else
            {
                MENUPANEL.Width = 222;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MENUPANEL.Width = 50;
            LoadForm(new DASHBOARD());
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            if (MENUPANEL.Width == 222)
            {
                LoadForm(new DASHBOARD());
            }

        }

        private void BTNPRODUCT_Click(object sender, EventArgs e)
        {
            if (MENUPANEL.Width == 222)
            {
                LoadForm(new PRODUCT());
            }
        }

        private void BTNORDER_Click(object sender, EventArgs e)
        {
            if (MENUPANEL.Width == 222)
            {
                LoadForm(new ORDER());
            }
        }

        private void BTNSALES_Click(object sender, EventArgs e)
        {
            if (MENUPANEL.Width == 222)
            {
                LoadForm(new SALES());
            }
        }

        private void BTNLOGOUT_Click(object sender, EventArgs e)
        {
            if (MENUPANEL.Width == 222)
            {
                /*LoadForm(new DASHBOARD()); diri i change ra nimno sa login form*/

            }
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelContainer_Paint_2(object sender, PaintEventArgs e)
        {

        }
    }
}
