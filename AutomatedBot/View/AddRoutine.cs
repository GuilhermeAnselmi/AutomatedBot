using AutomatedBot.Control.Data;

namespace AutomatedBot.View
{
    public partial class AddRoutine : Form
    {
        public AddRoutine()
        {
            InitializeComponent();
        }

        private void Add(object sender, EventArgs e)
        {
            var response = JsonDb.Create(txtName.Text);

            if (response.Item1)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(response.Item2, "Não Criado", MessageBoxButtons.OK);
            }
        }

        private void Done(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
