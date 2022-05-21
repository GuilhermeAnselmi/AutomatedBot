using AutomatedBot.Control.Data;
using AutomatedBot.Engine.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedBot.View
{
    public partial class ColorCondition : Form
    {
        private string NameTemp;

        public ColorCondition(string nameTemp)
        {
            InitializeComponent();
            NameTemp = nameTemp;
        }

        private void ColorCondition_Load(object sender, EventArgs e)
        {
            var response = JsonDb.ReadTempFile(NameTemp);

            if (response.Item1)
            {
                List<WaitColorsCondition> wcc = JsonConvert.DeserializeObject<List<WaitColorsCondition>>(response.Item2);

                if (wcc != null)
                {
                    if (wcc.Count > 0)
                    {
                        ckbModuleOne.Checked = true;
                        txtXOne.Text = wcc[0].X.ToString();
                        txtYOne.Text = wcc[0].Y.ToString();
                        txtROne.Text = wcc[0].A.ToString();
                        txtGOne.Text = wcc[0].G.ToString();
                        txtBOne.Text = wcc[0].B.ToString();
                        txtAOne.Text = wcc[0].A.ToString();
                        cbbRooutineOne.SelectedText = wcc[0].NextRoutine;
                    }

                    if (wcc.Count > 1)
                    {
                        ckbModuleTwo.Checked = true;
                        txtXTwo.Text = wcc[1].X.ToString();
                        txtYTwo.Text = wcc[1].Y.ToString();
                        txtRTwo.Text = wcc[1].A.ToString();
                        txtGTwo.Text = wcc[1].G.ToString();
                        txtBTwo.Text = wcc[1].B.ToString();
                        txtATwo.Text = wcc[1].A.ToString();
                        cbbRooutineTwo.SelectedText = wcc[1].NextRoutine;
                    }

                    if (wcc.Count > 2)
                    {
                        ckbModuleThree.Checked = true;
                        txtXThree.Text = wcc[2].X.ToString();
                        txtYThree.Text = wcc[2].Y.ToString();
                        txtRThree.Text = wcc[2].A.ToString();
                        txtGThree.Text = wcc[2].G.ToString();
                        txtBThree.Text = wcc[2].B.ToString();
                        txtAThree.Text = wcc[2].A.ToString();
                        cbbRooutineThree.SelectedText = wcc[2].NextRoutine;
                    }
                }
            }
            else
            {
                MessageBox.Show("Arquivo temporario não foi encontrado", "Erro", MessageBoxButtons.OK);
            }
        }

        private void Done(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save(object sender, EventArgs e)
        {
            List<WaitColorsCondition> wcc = new List<WaitColorsCondition>();

            if (ckbModuleOne.Checked)
            {
                wcc.Add(new WaitColorsCondition()
                {
                    X = int.Parse(txtXOne.Text),
                    Y = int.Parse(txtYOne.Text),
                    R = int.Parse(txtROne.Text),
                    G = int.Parse(txtGOne.Text),
                    B = int.Parse(txtBOne.Text),
                    A = int.Parse(txtAOne.Text),
                    NextRoutine = cbbRooutineOne.Text,
                });
            }

            if (ckbModuleTwo.Checked)
            {
                wcc.Add(new WaitColorsCondition()
                {
                    X = int.Parse(txtXTwo.Text),
                    Y = int.Parse(txtYTwo.Text),
                    R = int.Parse(txtRTwo.Text),
                    G = int.Parse(txtGTwo.Text),
                    B = int.Parse(txtBTwo.Text),
                    A = int.Parse(txtATwo.Text),
                    NextRoutine = cbbRooutineTwo.Text,
                });
            }

            if (ckbModuleThree.Checked)
            {
                wcc.Add(new WaitColorsCondition()
                {
                    X = int.Parse(txtXThree.Text),
                    Y = int.Parse(txtYThree.Text),
                    R = int.Parse(txtRThree.Text),
                    G = int.Parse(txtGThree.Text),
                    B = int.Parse(txtBThree.Text),
                    A = int.Parse(txtAThree.Text),
                    NextRoutine = cbbRooutineThree.Text,
                });
            }

            bool verify = JsonDb.WriteTempFile(NameTemp, JsonConvert.SerializeObject(wcc));

            if (verify)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao gravar dados, arquivo temporario não foi encontrado ou está inacessivel", "Erro", MessageBoxButtons.OK);
            }
        }
    }
}
