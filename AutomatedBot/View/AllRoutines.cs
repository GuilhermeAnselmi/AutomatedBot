using AutomatedBot.Control.Data;
using AutomatedBot.Engine.Model;

namespace AutomatedBot.View
{
    public partial class AllRoutines : Form
    {
        public AllRoutines()
        {
            InitializeComponent();
        }

        private void AllRoutines_Load(object sender, EventArgs e)
        {
            lstAllRoutines.Items.Clear();

            List<Routine> routines = new List<Routine>();

            routines = JsonDb.GetAllRoutines();

            foreach (Routine routine in routines)
            {
                lstAllRoutines.Items.Add(routine.Name);
            }
        }

        private void OpenRoutine(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new PanelRoutine(JsonDb.GetRoutine(lstAllRoutines.SelectedItem.ToString()));
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void OpenParamInicialization(object sender, EventArgs e)
        {
            Form form = new ParamInicialization(JsonDb.GetRoutine(lstAllRoutines.SelectedItem.ToString()));
            form.Show();
            form.Closed += (s, args) => this.Enabled = true;
            form.BringToFront();
            form.TopMost = true;
            this.Enabled = false;
        }

        private void SelectedRoutine(object sender, EventArgs e)
        {
            if (lstAllRoutines.SelectedItems.Count < 1)
            {
                btnOpenRoutine.Enabled = false;
                btnParamInicialization.Enabled = false;
            }
            else if (lstAllRoutines.SelectedItems.Count == 1)
            {
                btnOpenRoutine.Enabled = true;
                btnParamInicialization.Enabled = true;
            }
            else if (lstAllRoutines.SelectedItems.Count > 1)
            {
                btnOpenRoutine.Enabled = false;
                btnParamInicialization.Enabled = false;

                MessageBox.Show("Pode selecionar apenas 1 item", "Erro", MessageBoxButtons.OK);
            }
        }
    }
}
