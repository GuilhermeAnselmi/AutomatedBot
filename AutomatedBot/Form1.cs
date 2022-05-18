namespace AutomatedBot
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void OpenAddRoutine(object sender, EventArgs e)
        {
            //this.Hide();
            //Form form = new AddRoutine();
            //form.Closed += (s, args) => this.Close();
            //form.Show();

            Form form = new View.AddRoutine();
            form.Show();
            form.Closed += (s, args) => this.Enabled = true;
            form.BringToFront();
            form.TopMost = true;
            this.Enabled = false;
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
             
        }
    }
}