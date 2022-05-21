using AutomatedBot.Control.Data;
using AutomatedBot.Engine.Model;
using Newtonsoft.Json;

namespace AutomatedBot.View
{
    public partial class ParamInicialization : Form
    {
        private Routine _routine;

        public ParamInicialization(Routine routine)
        {
            InitializeComponent();
            _routine = routine;
        }

        private void ParamInicialization_Load(object sender, EventArgs e)
        {
            txtInputJson.Text = JsonDb.GetParamInicialization(_routine.Name);
        }

        private void SaveParamInicialization(object sender, EventArgs e)
        {
            try
            {
                object jsonObj = null;

                jsonObj = JsonConvert.DeserializeObject(txtInputJson.Text);

                var response = JsonDb.SaveParamInicialization(_routine.Name, jsonObj);

                if (response.Item1)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"{response.Item2}", "Erro ao salvar", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Insira um objeto em formato Json válido", "Erro ao salvar", MessageBoxButtons.OK);
            }
        }

        private void Done(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
