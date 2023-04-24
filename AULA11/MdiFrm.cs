namespace AULA11
{
    public partial class MdiFrm : Form
    {
        Agenda? AgendaForm;
        CEP? CEPForm;
        public MdiFrm()
        {
            InitializeComponent();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CEPForm == null)
            {
                CEPForm = new CEP();
                CEPForm.MdiParent = this;
                CEPForm.WindowState = FormWindowState.Maximized;
                CEPForm.Show();
            }
            else
            {
                CEPForm.Activate();
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Sobre SobreForm = new Sobre();
            SobreForm.ShowDialog();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AgendaForm == null)
            {
                AgendaForm = new Agenda();
                AgendaForm.MdiParent = this;
                AgendaForm.WindowState = FormWindowState.Maximized;
                AgendaForm.Show();
            }
            else
            {
                AgendaForm.Activate();
            }
        }
    }
}