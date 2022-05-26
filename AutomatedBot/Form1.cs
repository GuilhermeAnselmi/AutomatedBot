using AutomatedBot.Control.Data;
using AutomatedBot.Engine.Model;

namespace AutomatedBot
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            UpdateWindow();
        }

        private void UpdateWindow()
        {
            this.Enabled = true;

            lstRoutine.Items.Clear();

            List<Routine> routines = new List<Routine>();

            routines = JsonDb.GetAllRoutines();

            foreach (Routine routine in routines)
            {
                lstRoutine.Items.Add(routine.Name);
            }
        }

        private void OpenAddRoutine(object sender, EventArgs e)
        {
            Form form = new View.AddRoutine();
            form.Show();
            form.Closed += (s, args) => UpdateWindow();
            form.BringToFront();
            form.TopMost = true;
            this.Enabled = false;
        }

        private void btnRemoveRoutine_Click(object sender, EventArgs e)
        {
            if (lstRoutine.SelectedItem != null)
            {
                Routine routine = JsonDb.GetRoutine(lstRoutine.SelectedItem.ToString());

                var approve = MessageBox.Show($"Tem certeza que deseja excluir a rotina \"{routine.Name}\"? Essa ação não poderá ser desfeita", 
                    "Excluir?", MessageBoxButtons.YesNo);

                if (approve.ToString() == "Yes")
                {
                    bool verify = JsonDb.RemoveRoutine(routine.FileName);

                    if (verify)
                    {
                        MessageBox.Show("Rotina excluida com sucesso", "Sucesso!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Houve um erro ao Excluir a rotina: Rotina não encontrada ou falha ao tentar exclui-la", "Rotina não encontrada", MessageBoxButtons.OK);
                    }
                }

                UpdateWindow();
            }
            else
            {
                MessageBox.Show("Selecione uma rotina para excluir", "Item Não Selecionado", MessageBoxButtons.OK);
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
             
        }

        private void ListAllRoutines(object sender, EventArgs e)
        {
            //this.Hide();
            //Form form = new AddRoutine();
            //form.Closed += (s, args) => this.Close();
            //form.Show();

            this.Hide();
            Form form = new View.AllRoutines();
            form.Closed += (s, args) => this.Show();
            form.Show();
        }

        private void ClearTempFiles(object sender, EventArgs e)
        {
            bool result = JsonDb.ClearTempFiles();

            if (result)
            {
                MessageBox.Show("Arquivos temporarios removidos", "Sucesso!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Arquivos temporarios não encontrados", "Não Encontrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JsonDb.ClearTempFiles();

            this.Close();
        }
    }
}