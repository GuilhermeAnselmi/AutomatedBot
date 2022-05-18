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
            JsonDb json = new JsonDb(txtName.Text);

            json.Create();

            this.Close();
        }

        private void Done(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
