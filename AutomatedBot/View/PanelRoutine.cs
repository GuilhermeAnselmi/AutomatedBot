using AutomatedBot.Engine.Model;
using AutomatedBot.Model;
using KlusterG.AutoGui;

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

            cbbFunction.Items.Clear();

            foreach (var function in Lists.Functions)
            {
                cbbFunction.Items.Add(function.Item2);
            }

            cbbKeyOne.Items.Clear();
            cbbKeyTwo.Items.Clear();
            cbbKeyThree.Items.Clear();

            cbbKeyOne.Items.AddRange(Lists.Keys);
            cbbKeyTwo.Items.AddRange(Lists.Keys);
            cbbKeyThree.Items.AddRange(Lists.Keys);

            cbbOperatorOne.Items.AddRange(Lists.Operators);
            cbbOperatorTwo.Items.AddRange(Lists.Operators);
            cbbOperatorThree.Items.AddRange(Lists.Operators);
            cbbOperatorFour.Items.AddRange(Lists.Operators);

            cbbExpressionOne.Items.AddRange(Lists.Expression);
            cbbExpressionTwo.Items.AddRange(Lists.Expression);
            cbbExpressionThree.Items.AddRange(Lists.Expression);

            cbbFunction.SelectedIndex = 0;

            cbbKeyOne.SelectedIndex = 0;
            cbbKeyTwo.SelectedIndex = 0;
            cbbKeyThree.SelectedIndex = 0;

            cbbOperatorOne.SelectedIndex = 0;
            cbbOperatorTwo.SelectedIndex = 0;
            cbbOperatorThree.SelectedIndex = 0;
            cbbOperatorFour.SelectedIndex = 0;

            cbbExpressionOne.SelectedIndex = 0;
            cbbExpressionTwo.SelectedIndex = 0;
            cbbExpressionThree.SelectedIndex = 0;
        }

        private void Done(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetValues(object sender, EventArgs e)
        {
            lblGetValue.Visible = true;

            MessageBox.Show("Pressione K para gravar posição\nPressione O para voltar", "Pegar Valores do Cursor", MessageBoxButtons.OK);

            while (true)
            {
                if (Exec.GetKeyPress().Item2 == "K")
                {
                    break;
                }
            }

            Mouse mouse = Exec.GetCursorPosition();

            txtPosX.Text = mouse.X.ToString();
            txtPosY.Text = mouse.Y.ToString();

            txtR.Text = Exec.GetPixelColor(mouse.X, mouse.Y).R.ToString();
            txtG.Text = Exec.GetPixelColor(mouse.X, mouse.Y).G.ToString();
            txtB.Text = Exec.GetPixelColor(mouse.X, mouse.Y).B.ToString();
            txtA.Text = Exec.GetPixelColor(mouse.X, mouse.Y).A.ToString();

            lblGetValue.Visible = false;
        }

        private void OpenColorCondition(object sender, EventArgs e)
        {
            Form form = new ColorCondition();
            form.Show();
            form.Closed += (s, args) => this.Enabled = true;
            form.BringToFront();
            form.TopMost = true;
            this.Enabled = false;
        }

        private async Task ReadKeyboardKeys()
        {
            while (true)
            {
                if (Exec.GetKeyPress().Item2 == "K")
                {
                    break;
                }
            }

            txtPosX.Text = Exec.GetCursorPosition().X.ToString();
            txtPosY.Text = Exec.GetCursorPosition().Y.ToString();
        }

        private void ItemChanged(object sender, EventArgs e)
        {
            switch (cbbFunction.SelectedIndex)
            {
                case 0:
                    txtR.Enabled = false;
                    txtG.Enabled = false;
                    txtB.Enabled = false;
                    txtA.Enabled = false;
                    ckbSimpleClick.Enabled = true;
                    txtWrite.Enabled = false;
                    txtWrite.Text = "";
                    cbbKeyOne.Enabled = false;
                    cbbKeyOne.SelectedIndex = 0;
                    cbbKeyTwo.Enabled = false;
                    cbbKeyTwo.SelectedIndex = 0;
                    cbbKeyThree.Enabled = false;
                    cbbKeyThree.SelectedIndex = 0;
                    pnlCondition.Enabled = false;
                    btnColorCondition.Enabled = false;
                    break;

                case 1:
                    txtR.Enabled = false;
                    txtG.Enabled = false;
                    txtB.Enabled = false;
                    txtA.Enabled = false;
                    ckbSimpleClick.Enabled = false;
                    ckbSimpleClick.Checked = false;
                    txtWrite.Enabled = false;
                    txtWrite.Text = "";
                    cbbKeyOne.Enabled = false;
                    cbbKeyOne.SelectedIndex = 0;
                    cbbKeyTwo.Enabled = false;
                    cbbKeyTwo.SelectedIndex = 0;
                    cbbKeyThree.Enabled = false;
                    cbbKeyThree.SelectedIndex = 0;
                    pnlCondition.Enabled = false;
                    btnColorCondition.Enabled = false;
                    break;

                case 2:
                    txtR.Enabled = false;
                    txtG.Enabled = false;
                    txtB.Enabled = false;
                    txtA.Enabled = false;
                    ckbSimpleClick.Enabled = true;
                    txtWrite.Enabled = true;
                    cbbKeyOne.Enabled = false;
                    cbbKeyOne.SelectedIndex = 0;
                    cbbKeyTwo.Enabled = false;
                    cbbKeyTwo.SelectedIndex = 0;
                    cbbKeyThree.Enabled = false;
                    cbbKeyThree.SelectedIndex = 0;
                    pnlCondition.Enabled = false;
                    btnColorCondition.Enabled = false;
                    break;

                case 3:
                    txtR.Enabled = false;
                    txtG.Enabled = false;
                    txtB.Enabled = false;
                    txtA.Enabled = false;
                    ckbSimpleClick.Enabled = true;
                    txtWrite.Enabled = false;
                    txtWrite.Text = "";
                    cbbKeyOne.Enabled = true;
                    cbbKeyTwo.Enabled = true;
                    cbbKeyThree.Enabled = true;
                    pnlCondition.Enabled = false;
                    btnColorCondition.Enabled = false;
                    break;

                case 4:
                    txtR.Enabled = false;
                    txtG.Enabled = false;
                    txtB.Enabled = false;
                    txtA.Enabled = false;
                    ckbSimpleClick.Enabled = true;
                    txtWrite.Enabled = false;
                    txtWrite.Text = "";
                    cbbKeyOne.Enabled = true;
                    cbbKeyTwo.Enabled = true;
                    cbbKeyThree.Enabled = true;
                    pnlCondition.Enabled = false;
                    btnColorCondition.Enabled = false;
                    break;

                case 5:
                    txtR.Enabled = false;
                    txtG.Enabled = false;
                    txtB.Enabled = false;
                    txtA.Enabled = false;
                    ckbSimpleClick.Enabled = true;
                    txtWrite.Enabled = false;
                    txtWrite.Text = "";
                    cbbKeyOne.Enabled = true;
                    cbbKeyTwo.Enabled = true;
                    cbbKeyThree.Enabled = true;
                    pnlCondition.Enabled = false;
                    btnColorCondition.Enabled = false;
                    break;

                case 6:
                    txtR.Enabled = true;
                    txtG.Enabled = true;
                    txtB.Enabled = true;
                    txtA.Enabled = true;
                    ckbSimpleClick.Enabled = false;
                    ckbSimpleClick.Checked = false;
                    txtWrite.Enabled = false;
                    cbbKeyOne.Enabled = false;
                    cbbKeyOne.SelectedIndex = 0;
                    cbbKeyTwo.Enabled = false;
                    cbbKeyTwo.SelectedIndex = 0;
                    cbbKeyThree.Enabled = false;
                    cbbKeyThree.SelectedIndex = 0;
                    pnlCondition.Enabled = false;
                    btnColorCondition.Enabled = false;
                    break;

                case 7:
                    txtR.Enabled = false;
                    txtG.Enabled = false;
                    txtB.Enabled = false;
                    txtA.Enabled = false;
                    ckbSimpleClick.Enabled = false;
                    ckbSimpleClick.Checked = false;
                    txtWrite.Enabled = false;
                    cbbKeyOne.Enabled = false;
                    cbbKeyOne.SelectedIndex = 0;
                    cbbKeyTwo.Enabled = false;
                    cbbKeyTwo.SelectedIndex = 0;
                    cbbKeyThree.Enabled = false;
                    cbbKeyThree.SelectedIndex = 0;
                    pnlCondition.Enabled = false;
                    btnColorCondition.Enabled = true;
                    break;

                case 8:
                    txtR.Enabled = false;
                    txtG.Enabled = false;
                    txtB.Enabled = false;
                    txtA.Enabled = false;
                    ckbSimpleClick.Enabled = false;
                    ckbSimpleClick.Checked = false;
                    txtWrite.Enabled = false;
                    txtWrite.Text = "";
                    cbbKeyOne.Enabled = false;
                    cbbKeyOne.SelectedIndex = 0;
                    cbbKeyTwo.Enabled = false;
                    cbbKeyTwo.SelectedIndex = 0;
                    cbbKeyThree.Enabled = false;
                    cbbKeyThree.SelectedIndex = 0;
                    pnlCondition.Enabled = true;
                    btnColorCondition.Enabled = false;
                    break;
            }
        }
    }
}
