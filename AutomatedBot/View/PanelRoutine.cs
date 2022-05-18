using AutomatedBot.Model;

namespace AutomatedBot.View
{
    public partial class PanelRoutine : Form
    {
        private Routine _routine;

        public PanelRoutine(Routine routine = null)
        {
            InitializeComponent();

            _routine = routine == null ? new Routine() : routine;
        }

        private void PanelRoutine_Load(object sender, EventArgs e)
        {
            lblRoutineName.Text = _routine.Name;
        }

        private void Done(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
