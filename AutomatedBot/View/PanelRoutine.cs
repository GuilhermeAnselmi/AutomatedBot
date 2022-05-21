using AutomatedBot.Control;
using AutomatedBot.Control.Data;
using AutomatedBot.Engine.Model;
using AutomatedBot.Model;
using KlusterG.AutoGui;
using Newtonsoft.Json;

namespace AutomatedBot.View
{
    public partial class PanelRoutine : Form
    {
        private Routine _routine;
        private string NameTemp;

        public PanelRoutine(Routine routine = null)
        {
            InitializeComponent();

            _routine = routine == null ? new Routine() : routine;
            NameTemp = null;
        }

        private void PanelRoutine_Load(object sender, EventArgs e)
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                NameTemp += random.NextInt64(0, 9).ToString();
            }

            JsonDb.CreateTempFile(NameTemp);

            lblRoutineName.Text = _routine.Name;

            lstAllStages.Items.Add("-");

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

            cbbLogicalOperatorOne.Items.AddRange(Lists.Expression);

            cbbValueInput.Items.Add("-");

            cbbNextStageTrue.Items.Add("-");
            cbbNextStageFalse.Items.Add("-");

            cbbFunction.SelectedIndex = 0;

            cbbKeyOne.SelectedIndex = 0;
            cbbKeyTwo.SelectedIndex = 0;
            cbbKeyThree.SelectedIndex = 0;

            cbbOperatorOne.SelectedIndex = 0;
            cbbOperatorTwo.SelectedIndex = 0;

            cbbLogicalOperatorOne.SelectedIndex = 0;

            cbbValueInput.SelectedIndex = 0;

            cbbNextStageTrue.SelectedIndex = 0;
            cbbNextStageFalse.SelectedIndex = 0;

            txtWrite.Enabled = false;

            UpdateWindow();
        }

        private void UpdateWindow()
        {

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
            Form form = new ColorCondition(NameTemp);
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
                    cbbValueInput.Enabled = false;
                    cbbValueInput.SelectedIndex = 0;
                    cbbNextStageTrue.Enabled = false;
                    cbbNextStageFalse.Enabled = false;
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
                    cbbValueInput.Enabled = false;
                    cbbValueInput.SelectedIndex = 0;
                    cbbNextStageTrue.Enabled = false;
                    cbbNextStageFalse.Enabled = false;
                    break;

                case 2:
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
                    cbbValueInput.Enabled = false;
                    cbbValueInput.SelectedIndex = 0;
                    cbbNextStageTrue.Enabled = false;
                    cbbNextStageFalse.Enabled = false;
                    break;

                case 3:
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
                    cbbValueInput.Enabled = true;
                    cbbNextStageTrue.Enabled = false;
                    cbbNextStageFalse.Enabled = false;
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
                    cbbValueInput.Enabled = false;
                    cbbValueInput.SelectedIndex = 0;
                    cbbNextStageTrue.Enabled = false;
                    cbbNextStageFalse.Enabled = false;
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
                    cbbValueInput.Enabled = false;
                    cbbValueInput.SelectedIndex = 0;
                    cbbNextStageTrue.Enabled = false;
                    cbbNextStageFalse.Enabled = false;
                    break;

                case 6:
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
                    cbbValueInput.Enabled = false;
                    cbbValueInput.SelectedIndex = 0;
                    cbbNextStageTrue.Enabled = false;
                    cbbNextStageFalse.Enabled = false;
                    break;

                case 7:
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
                    cbbValueInput.Enabled = false;
                    cbbValueInput.SelectedIndex = 0;
                    cbbNextStageTrue.Enabled = false;
                    cbbNextStageFalse.Enabled = false;
                    break;

                case 8:
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
                    cbbValueInput.Enabled = false;
                    cbbValueInput.SelectedIndex = 0;
                    cbbNextStageTrue.Enabled = false;
                    cbbNextStageFalse.Enabled = false;
                    break;

                case 9:
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
                    cbbValueInput.Enabled = false;
                    cbbValueInput.SelectedIndex = 0;
                    cbbNextStageTrue.Enabled = true;
                    cbbNextStageFalse.Enabled = true;
                    break;

                case 10:
                    txtR.Enabled = false;
                    txtG.Enabled = false;
                    txtB.Enabled = false;
                    txtA.Enabled = false;
                    ckbSimpleClick.Enabled = false;
                    ckbSimpleClick.Checked = false;
                    txtWrite.Enabled = true;
                    cbbKeyOne.Enabled = false;
                    cbbKeyOne.SelectedIndex = 0;
                    cbbKeyTwo.Enabled = false;
                    cbbKeyTwo.SelectedIndex = 0;
                    cbbKeyThree.Enabled = false;
                    cbbKeyThree.SelectedIndex = 0;
                    pnlCondition.Enabled = false;
                    btnColorCondition.Enabled = false;
                    cbbValueInput.Enabled = true;
                    cbbNextStageTrue.Enabled = false;
                    cbbNextStageFalse.Enabled = false;
                    break;
            }
        }

        private void ValueInputChanged(object sender, EventArgs e)
        {
            if (cbbValueInput.SelectedIndex > 0)
            {
                txtWrite.Enabled = false;
                txtWrite.Text = "";
            }
            else
            {
                txtWrite.Enabled = true;
            }
        }

        private void UnselectedList(object sender, EventArgs e)
        {
            lstAllStages.ClearSelected();
        }

        private void SaveStage(object sender, EventArgs e)
        {
            if (txtStageName.Text != "")
            {
                bool next = true;

                if (_routine.Stage != null && _routine.Stage.Where(x => x.Name == txtStageName.Text).Any())
                {
                    var res = MessageBox.Show("Uma etapa com o mesmo nome já existe. Gostaria de sobreescreve-la?", "Etapa Existente", MessageBoxButtons.YesNo);

                    next = res.ToString() == "Yes" ? true : false;
                }
                
                if (next) ConstructStage();
            }
            else
            {
                MessageBox.Show("O nome da etapa deve ser preenchido", "Não Salvo!", MessageBoxButtons.OK);
            }
        }

        private void ConstructStage()
        {
            bool success = true;
            string alert = "";

            StructureStage ss = new StructureStage(txtStageName.Text, txtComments.Text, int.Parse(txtPosX.Text),
                        int.Parse(txtPosY.Text), ckbMoveMouse.Checked);

            switch (cbbFunction.SelectedIndex)
            {
                case 0:
                    ss.SimpleClick(ckbSimpleClick.Checked, int.Parse(txtWait.Text));
                    break;

                case 1:
                    ss.RightClick(int.Parse(txtWait.Text));
                    break;

                case 2:
                    ss.DoubleClick(int.Parse(txtWait.Text));
                    break;

                case 3:
                    ss.Write(ckbSimpleClick.Checked, txtWrite.Text, int.Parse(txtWait.Text));
                    break;

                case 4:
                    ss.ClickKey(ckbSimpleClick.Checked, cbbKeyOne.SelectedIndex, cbbKeyTwo.SelectedIndex, 
                        cbbKeyThree.SelectedIndex, int.Parse(txtWait.Text));
                    break;

                case 5:
                    ss.PressKey(ckbSimpleClick.Checked, cbbKeyOne.SelectedIndex, cbbKeyTwo.SelectedIndex,
                        cbbKeyThree.SelectedIndex, int.Parse(txtWait.Text));
                    break;

                case 6:
                    ss.ReleaseKey(ckbSimpleClick.Checked, cbbKeyOne.SelectedIndex, cbbKeyTwo.SelectedIndex,
                        cbbKeyThree.SelectedIndex, int.Parse(txtWait.Text));
                    break;

                case 7:
                    PixelColor pc = new PixelColor();
                    pc.R = byte.Parse(txtR.Value.ToString());
                    pc.G = byte.Parse(txtG.Value.ToString());
                    pc.B = byte.Parse(txtB.Value.ToString());
                    pc.A = byte.Parse(txtA.Value.ToString());

                    ss.WaitColor(pc, int.Parse(txtWait.Text));
                    break;

                case 8:
                    List<WaitColorsCondition> waitColors = new List<WaitColorsCondition>();

                    var response = JsonDb.ReadTempFile(NameTemp);

                    if (response.Item1)
                    {
                        waitColors = JsonConvert.DeserializeObject<List<WaitColorsCondition>>(response.Item2);

                        ss.WaitColorCondition(waitColors, int.Parse(txtWait.Text));
                    }
                    else
                    {
                        success = false;
                        alert = $"Erro eu recuperar informações sobre a condição das cores.\nArquivo temporario {NameTemp}.temp";
                    }

                    break;

                case 9:
                    List<Condition> conditions = new List<Condition>();

                    if (ckbConditionOne.Checked && cbbConditionKeyOne.SelectedText != "" && 
                        cbbOperatorOne.SelectedText != "" && txtValueOne.Text != "" && 
                        cbbLogicalOperatorOne.SelectedText != "")
                    {
                        conditions.Add(new Condition()
                        {
                            Key = cbbConditionKeyOne.SelectedText,
                            Operator = cbbOperatorOne.SelectedText,
                            Value = txtValueOne.Text,
                            LogicalOperator = cbbLogicalOperatorOne.SelectedText,
                        });

                        if (ckbConditionTwo.Checked)
                        {
                            if (cbbConditionKeyOne.SelectedText != "" && cbbOperatorOne.SelectedText != "" &&
                                txtValueOne.Text != "" && cbbLogicalOperatorOne.SelectedText != "")
                            {
                                conditions.Add(new Condition()
                                {
                                    Key = cbbConditionKeyTwo.SelectedText,
                                    Operator = cbbOperatorTwo.SelectedText,
                                    Value = txtValueTwo.Text,
                                });

                                ss.Condition(conditions, cbbNextStageTrue.SelectedText, int.Parse(txtWait.Text));
                            }
                            else
                            {
                                success = false;
                                alert = "Todos os valores para condição ativa devem ser peenchidos";
                            }
                        }
                        else
                        {
                            ss.Condition(conditions, cbbNextStageTrue.SelectedText, int.Parse(txtWait.Text));
                        }
                    }
                    else
                    {
                        success = false;
                        alert = "Todos os valores para condição ativa devem ser peenchidos";
                    }

                    break;

                case 10:
                    ss.CommandLine(txtWrite.Text, int.Parse(txtWait.Text));
                    break;
            }

            if (success)
            {

            }
            else
            {
                MessageBox.Show($"{alert}", "Não foi Possível Salvar", MessageBoxButtons.OK);
            }
        }
    }
}
