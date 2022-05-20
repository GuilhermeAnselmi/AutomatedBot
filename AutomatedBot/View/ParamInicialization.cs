using AutomatedBot.Engine.Model;

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

        }
    }
}
