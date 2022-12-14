namespace gezen_V2
{
    public partial class Form1 : Form
    {
        public void form_cagýr(Form sehir_ismi)
        {
            sehir_ismi.TopLevel = false;
            sehir_ismi.Dock = DockStyle.Fill;
            sehir_ismi.Show();
            panel_gizli.Controls.Add(sehir_ismi);
        }

        public void form_visible()
        {
            panel_gizli.Controls.Clear();
            button_back.Visible = true;
            panel_gizli.Dock = DockStyle.Fill;
            panel_gizli.Visible = true;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button_ankara_Click(object sender, EventArgs e)
        {
            form_visible();
            Form_ankara ankara = new Form_ankara();
            form_cagýr(ankara);
            
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            panel_gizli.Visible = false;
            button_back.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_istanbul_Click(object sender, EventArgs e)
        {
            form_visible();
            Form_istanbul istanbul=new Form_istanbul();
            form_cagýr(istanbul);
        }

        private void button_izmir_Click(object sender, EventArgs e)
        {
            form_visible();
            Form_izmir izmir=new Form_izmir();
            form_cagýr(izmir);
        }

        private void button_gaziantep_Click(object sender, EventArgs e)
        {
            form_visible();
            Form_gaziantep gaziantep=new Form_gaziantep();
            form_cagýr(gaziantep);
        }

        private void button_kýbrýs_Click(object sender, EventArgs e)
        {
            form_visible();
            Form_kýbrýs kýbrýs = new Form_kýbrýs();
            form_cagýr(kýbrýs);
        }

        private void button_kilis_Click(object sender, EventArgs e)
        {
            form_visible();
            Form_kilis kilis=new Form_kilis();
            form_cagýr(kilis);
        }

        private void button_anamur_Click(object sender, EventArgs e)
        {
            form_visible();
            Form_anamur anamur =new Form_anamur();
            form_cagýr(anamur);
        }

        private void button_ermenek_Click(object sender, EventArgs e)
        {
            form_visible();
            Form_ermenek ermenek=new Form_ermenek();
            form_cagýr(ermenek);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}