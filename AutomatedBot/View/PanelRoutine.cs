using AutomatedBot.Control;
using AutomatedBot.Control.Data;
using AutomatedBot.Engine.Model;
using AutomatedBot.Model;
using KlusterG.AutoGui;
using KlusterG.AutoGui.InternalKeys;
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
            Dictionary<string, string> initialValues =
                JsonConvert.DeserializeObject<Dictionary<string, string>>(JsonDb.GetParamInicialization(_routine.Name));

            List<Routine> routines = JsonDb.GetAllRoutines();

            cbbRoutineTimeout.Items.Add("-");

            foreach (Routine routine in routines)
            {
                cbbRoutineTimeout.Items.Add(routine.Name);
            }

            #region cbbValueInput and cbbConditionalKey
            cbbValueInput.Items.Add("-");

            cbbConditionKeyOne.Items.Add("-");
            cbbConditionKeyTwo.Items.Add("-");

            foreach (var item in initialValues)
            {
                cbbValueInput.Items.Add(item.Key);
                cbbConditionKeyOne.Items.Add(item.Key);
                cbbConditionKeyTwo.Items.Add(item.Key);
            }
            #endregion

            #region cbbKey
            cbbKeyOne.Items.Clear();
            cbbKeyTwo.Items.Clear();
            cbbKeyThree.Items.Clear();

            cbbKeyOne.Items.AddRange(Lists.Keys);
            cbbKeyTwo.Items.AddRange(Lists.Keys);
            cbbKeyThree.Items.AddRange(Lists.Keys);
            #endregion

            #region cbbOperator
            cbbOperatorOne.Items.AddRange(Lists.Operators);
            cbbOperatorTwo.Items.AddRange(Lists.Operators);
            #endregion

            #region cbbLogicalOperator
            cbbLogicalOperatorOne.Items.AddRange(Lists.Expression);
            #endregion

            #region cbbFunction
            cbbFunction.Items.Clear();

            foreach (var function in Lists.Functions)
            {
                cbbFunction.Items.Add(function.Item2);
            }
            #endregion

            UpdateWindow();
        }

        private void UpdateWindow()
        {
            _routine = JsonDb.GetRoutine(_routine.Name);

            lblRoutineName.Text = _routine.Name;

            cbbRoutineTimeout.SelectedIndex = 0;

            JsonDb.DeleteTempFile(NameTemp);

            Random random = new Random();

            NameTemp = "";

            for (int i = 0; i < 10; i++)
            {
                NameTemp += random.NextInt64(0, 9).ToString();
            }

            JsonDb.CreateTempFile(NameTemp);

            lstAllStages.Items.Clear();

            cbbNextStageTrue.Items.Clear();
            cbbNextStageFalse.Items.Clear();

            lstAllStages.Items.Add("-");

            cbbNextStageTrue.Items.Add("-");
            cbbNextStageFalse.Items.Add("-");

            List<Stage> stages = JsonDb.GetAllStages(_routine.Name);

            foreach (var stage in stages)
            {
                lstAllStages.Items.Add(stage.Name);
            }

            foreach (var stage in stages)
            {
                cbbNextStageTrue.Items.Add(stage.Name);
                cbbNextStageFalse.Items.Add(stage.Name);
            }

            #region Set All Default
            txtPosX.Value = 0;
            txtPosY.Value = 0;

            txtR.Value = 0;
            txtG.Value = 0;
            txtB.Value = 0;
            txtA.Value = 0;

            cbbFunction.SelectedIndex = 0;

            ckbMoveMouse.Checked = false;
            ckbSimpleClick.Checked = false;

            txtWait.Value = 0;

            cbbKeyOne.SelectedIndex = 0;
            cbbKeyTwo.SelectedIndex = 0;
            cbbKeyThree.SelectedIndex = 0;

            txtWrite.Text = "";
            cbbValueInput.SelectedIndex = 0;

            cbbConditionKeyOne.SelectedIndex = 0;
            cbbConditionKeyTwo.SelectedIndex = 0;
            cbbOperatorOne.SelectedIndex = 0;
            cbbOperatorTwo.SelectedIndex = 0;
            txtValueOne.Text = "";
            txtValueTwo.Text = "";
            cbbLogicalOperatorOne.SelectedIndex = 0;

            cbbNextStageTrue.SelectedIndex = 0;
            cbbNextStageFalse.SelectedIndex = 0;

            txtStageName.Text = "";
            txtComments.Text = "";
            #endregion

            txtWrite.Enabled = false;
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
                    txtTimeout.Enabled = false;
                    txtTimeout.Value = 30;
                    cbbRoutineTimeout.Enabled = false;
                    cbbRoutineTimeout.SelectedIndex = 0;
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
                    txtTimeout.Enabled = false;
                    txtTimeout.Value = 30;
                    cbbRoutineTimeout.Enabled = false;
                    cbbRoutineTimeout.SelectedIndex = 0;
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
                    txtTimeout.Enabled = false;
                    txtTimeout.Value = 30;
                    cbbRoutineTimeout.Enabled = false;
                    cbbRoutineTimeout.SelectedIndex = 0;
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
                    txtTimeout.Enabled = false;
                    txtTimeout.Value = 30;
                    cbbRoutineTimeout.Enabled = false;
                    cbbRoutineTimeout.SelectedIndex = 0;
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
                    txtTimeout.Enabled = false;
                    txtTimeout.Value = 30;
                    cbbRoutineTimeout.Enabled = false;
                    cbbRoutineTimeout.SelectedIndex = 0;
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
                    txtTimeout.Enabled = false;
                    txtTimeout.Value = 30;
                    cbbRoutineTimeout.Enabled = false;
                    cbbRoutineTimeout.SelectedIndex = 0;
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
                    txtTimeout.Enabled = false;
                    txtTimeout.Value = 30;
                    cbbRoutineTimeout.Enabled = false;
                    cbbRoutineTimeout.SelectedIndex = 0;
                    break;

                case 7:
                    txtR.Enabled = true;
                    txtG.Enabled = true;
                    txtB.Enabled = true;
                    txtA.Enabled = true;
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
                    txtTimeout.Enabled = true;
                    cbbRoutineTimeout.Enabled = true;
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
                    pnlCondition.Enabled = false;
                    btnColorCondition.Enabled = true;
                    cbbValueInput.Enabled = false;
                    cbbValueInput.SelectedIndex = 0;
                    cbbNextStageTrue.Enabled = false;
                    cbbNextStageFalse.Enabled = false;
                    txtTimeout.Enabled = true;
                    cbbRoutineTimeout.Enabled = true;
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
                    txtTimeout.Enabled = false;
                    txtTimeout.Value = 30;
                    cbbRoutineTimeout.Enabled = false;
                    cbbRoutineTimeout.SelectedIndex = 0;
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
                    txtTimeout.Enabled = false;
                    txtTimeout.Value = 30;
                    cbbRoutineTimeout.Enabled = false;
                    cbbRoutineTimeout.SelectedIndex = 0;
                    break;
            }
        }

        private void ValueInputChanged(object sender, EventArgs e)
        {
            if (cbbValueInput.SelectedIndex > 0)
            {
                txtWrite.ReadOnly = true;
                txtWrite.Text = "?" + cbbValueInput.SelectedItem;
            }
            else
            {
                txtWrite.ReadOnly = false;
                txtWrite.Text = "";
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

            int index = lstAllStages.SelectedIndex >= 0 ? lstAllStages.SelectedIndex : -1;

            StructureStage ss = new StructureStage(_routine, txtStageName.Text, txtComments.Text, int.Parse(txtPosX.Text),
                        int.Parse(txtPosY.Text), ckbMoveMouse.Checked, int.Parse(txtWait.Text), index);

            switch (cbbFunction.SelectedIndex)
            {
                case 0:
                    ss.SimpleClick(ckbSimpleClick.Checked);
                    break;

                case 1:
                    ss.RightClick();
                    break;

                case 2:
                    ss.DoubleClick();
                    break;

                case 3:
                    ss.Write(ckbSimpleClick.Checked, txtWrite.Text);
                    break;

                case 4:
                    ss.ClickKey(ckbSimpleClick.Checked, cbbKeyOne.SelectedIndex, cbbKeyTwo.SelectedIndex, 
                        cbbKeyThree.SelectedIndex);
                    break;

                case 5:
                    ss.PressKey(ckbSimpleClick.Checked, cbbKeyOne.SelectedIndex, cbbKeyTwo.SelectedIndex,
                        cbbKeyThree.SelectedIndex);
                    break;

                case 6:
                    ss.ReleaseKey(ckbSimpleClick.Checked, cbbKeyOne.SelectedIndex, cbbKeyTwo.SelectedIndex,
                        cbbKeyThree.SelectedIndex);
                    break;

                case 7:
                    PixelColor pc = new PixelColor();
                    pc.R = byte.Parse(txtR.Value.ToString());
                    pc.G = byte.Parse(txtG.Value.ToString());
                    pc.B = byte.Parse(txtB.Value.ToString());
                    pc.A = byte.Parse(txtA.Value.ToString());

                    ss.WaitColor(pc, int.Parse(txtTimeout.Value.ToString()), cbbRoutineTimeout.SelectedItem.ToString());
                    break;

                case 8:
                    List<WaitColorsCondition> waitColors = new List<WaitColorsCondition>();

                    var response = JsonDb.ReadTempFile(NameTemp);

                    if (response.Item1)
                    {
                        waitColors = JsonConvert.DeserializeObject<List<WaitColorsCondition>>(response.Item2);

                        ss.WaitColorCondition(waitColors, int.Parse(txtTimeout.Value.ToString()), 
                            cbbRoutineTimeout.SelectedItem.ToString());
                    }
                    else
                    {
                        success = false;
                        alert = $"Erro eu recuperar informações sobre a condição das cores.\nArquivo temporario {NameTemp}.temp";
                    }

                    break;

                case 9:
                    List<Condition> conditions = new List<Condition>();

                    if (ckbConditionOne.Checked && cbbConditionKeyOne.SelectedIndex > 0)
                    {
                        conditions.Add(new Condition()
                        {
                            Key = cbbConditionKeyOne.SelectedItem.ToString(),
                            Operator = cbbOperatorOne.SelectedIndex,
                            Value = txtValueOne.Text,
                            LogicalOperator = cbbLogicalOperatorOne.SelectedIndex,
                        });

                        if (ckbConditionTwo.Checked)
                        {
                            if (cbbConditionKeyTwo.SelectedIndex > 0)
                            {
                                conditions.Add(new Condition()
                                {
                                    Key = cbbConditionKeyTwo.SelectedItem.ToString(),
                                    Operator = cbbOperatorTwo.SelectedIndex,
                                    Value = txtValueTwo.Text,
                                });

                                ss.Condition(conditions, cbbNextStageTrue.SelectedItem.ToString(), cbbNextStageFalse.SelectedItem.ToString());
                            }
                            else
                            {
                                success = false;
                                alert = "Todos os valores para condição ativa devem ser peenchidos";
                            }
                        }
                        else
                        {
                            ss.Condition(conditions, cbbNextStageTrue.SelectedItem.ToString(), cbbNextStageFalse.SelectedItem.ToString());
                        }
                    }
                    else
                    {
                        success = false;
                        alert = "Todos os valores para condição ativa devem ser peenchidos";
                    }

                    break;

                case 10:
                    ss.CommandLine(txtWrite.Text);
                    break;
            }

            if (success)
            {
                UpdateWindow();
            }
            else
            {
                MessageBox.Show($"{alert}", "Não foi Possível Salvar", MessageBoxButtons.OK);
            }
        }

        private void RemoveStage(object sender, EventArgs e)
        {
            if (lstAllStages.SelectedIndex > 0)
            {
                bool verify = JsonDb.RemoveStage(_routine.Name, _routine.FileName, lstAllStages.SelectedItem.ToString());

                if (!verify) MessageBox.Show("Houve um erro ao remover essa etapa", "Não Removido", MessageBoxButtons.OK);

                UpdateWindow();
            }
            else
            {
                MessageBox.Show("Selecione a etapa a ser removida", "Não Removido", MessageBoxButtons.OK);
            }
        }

        private void EditStage(object sender, EventArgs e)
        {
            if (lstAllStages.SelectedIndex > 0)
            {
                Stage stage = JsonDb.GetStage(_routine.Name, lstAllStages.SelectedItem.ToString());

                UpdateWindow();

                JsonDb.WriteTempFile(NameTemp, JsonConvert.SerializeObject(stage.ColorsCondition));

                txtTimeout.Value = stage.Timeout.Timeout;

                int timeoutIndex = stage.Timeout.RoutineTimeout == null ? 0 : cbbRoutineTimeout.FindStringExact(stage.Timeout.RoutineTimeout);
                cbbRoutineTimeout.SelectedIndex = timeoutIndex;

                txtPosX.Value = stage.Procedure.Mouse.X;
                txtPosY.Value = stage.Procedure.Mouse.Y;

                txtR.Value = stage.PColor.R;
                txtG.Value = stage.PColor.G;
                txtB.Value = stage.PColor.B;
                txtA.Value = stage.PColor.A;

                cbbFunction.SelectedIndex = cbbFunction.FindStringExact(ConvertFunction(stage.Function));

                ckbMoveMouse.Checked = stage.Procedure.Mouse.Move;
                ckbSimpleClick.Checked = stage.Procedure.Mouse.Action == MouseAction.Click ? true : false;

                txtWait.Value = int.Parse(stage.Procedure.Wait.ToString());

                if (stage.Procedure.Keyboard != null)
                {
                    cbbKeyOne.SelectedIndex = cbbKeyOne.FindStringExact(ConvertKey(stage.Procedure.Keyboard.PrimaryKey));
                    cbbKeyTwo.SelectedIndex = cbbKeyTwo.FindStringExact(ConvertKey(stage.Procedure.Keyboard.SecondaryKey));
                    cbbKeyThree.SelectedIndex = cbbKeyThree.FindStringExact(ConvertKey(stage.Procedure.Keyboard.TertiaryKey));

                    txtWrite.Text = stage.Procedure.Keyboard.Text;
                }
                else
                {
                    txtWrite.Text = stage.CommandLine;
                }

                cbbValueInput.SelectedIndex = 0;

                if (stage.Conditions.Count > 0)
                {
                    cbbConditionKeyOne.SelectedIndex = cbbConditionKeyOne.FindStringExact(stage.Conditions[0].Key);
                    cbbOperatorOne.SelectedIndex = stage.Conditions[0].Operator;
                    txtValueOne.Text = stage.Conditions[0].Value;
                    cbbLogicalOperatorOne.SelectedIndex = stage.Conditions[0].LogicalOperator;

                    if (stage.Conditions.Count > 1)
                    {
                        cbbConditionKeyTwo.SelectedIndex = cbbConditionKeyTwo.FindStringExact(stage.Conditions[1].Key);
                        cbbOperatorTwo.SelectedIndex = stage.Conditions[1].Operator;
                        txtValueTwo.Text = stage.Conditions[1].Value;
                    }
                }

                cbbNextStageTrue.SelectedIndex = cbbNextStageTrue.FindStringExact(stage.NextStageTrue);
                cbbNextStageFalse.SelectedIndex = cbbNextStageFalse.FindStringExact(stage.NextStageFalse);

                txtStageName.Text = stage.Name;
                txtComments.Text = stage.Comment;
            }
            else
            {
                MessageBox.Show("Selecione a etapa a ser editada", "Sem Ação", MessageBoxButtons.OK);
            }
        }

        public string ConvertFunction(string value)
        {
            if (value == "SimpleClick") return "Sem Ação";
            if (value == "RightClick") return "Clique Direito";
            if (value == "DoubleClick") return "Clique Duplo";
            if (value == "Write") return "Escrever";
            if (value == "ClickKey") return "Clicar tecla";
            if (value == "PressKey") return "Pressionar tecla";
            if (value == "ReleaseKey") return "Soltar tecla";
            if (value == "WaitColor") return "Verif. cor e aguardar";
            if (value == "WaitColorCondition") return "Verif. cor e chamar rotina";
            if (value == "Condition") return "Condição";
            if (value == "CommandLine") return "Linha de Comando";

            return "Sem Ação";
        }

        private string ConvertKey(KKeys value)
        {
            if (value == KKeys.None) return "-";
            if (value == KKeys.Ctrl) return "CTRL";
            if (value == KKeys.Shift) return "SHIFT";
            if (value == KKeys.Tab) return "TAB";
            if (value == KKeys.Caps) return "CAPSLOCK";
            if (value == KKeys.Alt) return "ALT";
            if (value == KKeys.Win) return "WIN";
            if (value == KKeys.Esc) return "ESC";
            if (value == KKeys.Backspace) return "BACKSPACE";
            if (value == KKeys.Enter) return "ENTER";
            if (value == KKeys.Space) return "SPACE";
            if (value == KKeys.ArrowUp) return "ARROW UP";
            if (value == KKeys.ArrowDown) return "ARROW DOWN";
            if (value == KKeys.ArrowLeft) return "ARROW LEFT";
            if (value == KKeys.ArrowRight) return "ARROW RIGHT";
            if (value == KKeys.A) return "A";
            if (value == KKeys.B) return "B";
            if (value == KKeys.C) return "C";
            if (value == KKeys.D) return "D";
            if (value == KKeys.E) return "E";
            if (value == KKeys.F) return "F";
            if (value == KKeys.G) return "G";
            if (value == KKeys.H) return "H";
            if (value == KKeys.I) return "I";
            if (value == KKeys.J) return "J";
            if (value == KKeys.K) return "K";
            if (value == KKeys.L) return "L";
            if (value == KKeys.M) return "M";
            if (value == KKeys.N) return "N";
            if (value == KKeys.O) return "O";
            if (value == KKeys.P) return "P";
            if (value == KKeys.Q) return "Q";
            if (value == KKeys.R) return "R";
            if (value == KKeys.S) return "S";
            if (value == KKeys.T) return "T";
            if (value == KKeys.U) return "U";
            if (value == KKeys.V) return "V";
            if (value == KKeys.W) return "W";
            if (value == KKeys.X) return "X";
            if (value == KKeys.Y) return "Y";
            if (value == KKeys.Z) return "Z";
            if (value == KKeys.One) return "1";
            if (value == KKeys.Two) return "2";
            if (value == KKeys.Three) return "3";
            if (value == KKeys.Four) return "4";
            if (value == KKeys.Five) return "5";
            if (value == KKeys.Six) return "6";
            if (value == KKeys.Seven) return "7";
            if (value == KKeys.Eight) return "8";
            if (value == KKeys.Nine) return "9";
            if (value == KKeys.Zero) return "0";
            if (value == KKeys.KeyPadOne) return "Keypad 1";
            if (value == KKeys.KeyPadTwo) return "Keypad 2";
            if (value == KKeys.KeyPadThree) return "Keypad 3";
            if (value == KKeys.KeyPadFour) return "Keypad 4";
            if (value == KKeys.KeyPadFive) return "Keypad 5";
            if (value == KKeys.KeyPadSix) return "Keypad 6";
            if (value == KKeys.KeyPadSeven) return "Keypad 7";
            if (value == KKeys.KeyPadEight) return "Keypad 8";
            if (value == KKeys.KeyPadNine) return "Keypad 9";
            if (value == KKeys.KeyPadZero) return "Keypad 0";

            return "-";
        }

        private void ClearPanel(object sender, EventArgs e)
        {
            UpdateWindow();
        }
    }
}
