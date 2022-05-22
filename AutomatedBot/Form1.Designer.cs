namespace AutomatedBot
{
    partial class Index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exceçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.execuçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivosTemporariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstRoutine = new System.Windows.Forms.ListBox();
            this.btnAddRoutine = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rotinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exceçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.executarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivosTemporariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.limparToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicialToolStripMenuItem,
            this.execuçãoToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicialToolStripMenuItem
            // 
            this.inicialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotinaToolStripMenuItem,
            this.timeoutToolStripMenuItem,
            this.exceçãoToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.inicialToolStripMenuItem.Name = "inicialToolStripMenuItem";
            this.inicialToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.inicialToolStripMenuItem.Text = "Inicial";
            // 
            // rotinaToolStripMenuItem
            // 
            this.rotinaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem2,
            this.listarToolStripMenuItem});
            this.rotinaToolStripMenuItem.Name = "rotinaToolStripMenuItem";
            this.rotinaToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.rotinaToolStripMenuItem.Text = "Rotina";
            // 
            // adicionarToolStripMenuItem2
            // 
            this.adicionarToolStripMenuItem2.Name = "adicionarToolStripMenuItem2";
            this.adicionarToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.adicionarToolStripMenuItem2.Text = "Adicionar";
            this.adicionarToolStripMenuItem2.Click += new System.EventHandler(this.OpenAddRoutine);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.ListAllRoutines);
            // 
            // timeoutToolStripMenuItem
            // 
            this.timeoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem3,
            this.listarToolStripMenuItem1});
            this.timeoutToolStripMenuItem.Name = "timeoutToolStripMenuItem";
            this.timeoutToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.timeoutToolStripMenuItem.Text = "Timeout";
            // 
            // adicionarToolStripMenuItem3
            // 
            this.adicionarToolStripMenuItem3.Name = "adicionarToolStripMenuItem3";
            this.adicionarToolStripMenuItem3.Size = new System.Drawing.Size(125, 22);
            this.adicionarToolStripMenuItem3.Text = "Adicionar";
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.listarToolStripMenuItem1.Text = "Listar";
            // 
            // exceçãoToolStripMenuItem
            // 
            this.exceçãoToolStripMenuItem.Name = "exceçãoToolStripMenuItem";
            this.exceçãoToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.exceçãoToolStripMenuItem.Text = "Exceção";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(115, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // execuçãoToolStripMenuItem
            // 
            this.execuçãoToolStripMenuItem.Name = "execuçãoToolStripMenuItem";
            this.execuçãoToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.execuçãoToolStripMenuItem.Text = "Execução";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosTemporariosToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // arquivosTemporariosToolStripMenuItem
            // 
            this.arquivosTemporariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limparToolStripMenuItem});
            this.arquivosTemporariosToolStripMenuItem.Name = "arquivosTemporariosToolStripMenuItem";
            this.arquivosTemporariosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.arquivosTemporariosToolStripMenuItem.Text = "Arquivos Temporarios";
            // 
            // limparToolStripMenuItem
            // 
            this.limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            this.limparToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.limparToolStripMenuItem.Text = "Limpar";
            this.limparToolStripMenuItem.Click += new System.EventHandler(this.ClearTempFiles);
            // 
            // lstRoutine
            // 
            this.lstRoutine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstRoutine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstRoutine.ForeColor = System.Drawing.Color.White;
            this.lstRoutine.FormattingEnabled = true;
            this.lstRoutine.ItemHeight = 15;
            this.lstRoutine.Location = new System.Drawing.Point(12, 75);
            this.lstRoutine.Name = "lstRoutine";
            this.lstRoutine.Size = new System.Drawing.Size(206, 572);
            this.lstRoutine.TabIndex = 1;
            // 
            // btnAddRoutine
            // 
            this.btnAddRoutine.Location = new System.Drawing.Point(92, 46);
            this.btnAddRoutine.Name = "btnAddRoutine";
            this.btnAddRoutine.Size = new System.Drawing.Size(126, 23);
            this.btnAddRoutine.TabIndex = 2;
            this.btnAddRoutine.Text = "Adicionar Rotina";
            this.btnAddRoutine.UseVisualStyleBackColor = true;
            this.btnAddRoutine.Click += new System.EventHandler(this.OpenAddRoutine);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotinasToolStripMenuItem,
            this.exceçõesToolStripMenuItem,
            this.toolStripSeparator2,
            this.executarToolStripMenuItem,
            this.toolStripSeparator3,
            this.arquivosTemporariosToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(190, 104);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // rotinasToolStripMenuItem
            // 
            this.rotinasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.listarToolStripMenuItem2});
            this.rotinasToolStripMenuItem.Name = "rotinasToolStripMenuItem";
            this.rotinasToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.rotinasToolStripMenuItem.Text = "Rotina";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.OpenAddRoutine);
            // 
            // listarToolStripMenuItem2
            // 
            this.listarToolStripMenuItem2.Name = "listarToolStripMenuItem2";
            this.listarToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.listarToolStripMenuItem2.Text = "Listar";
            this.listarToolStripMenuItem2.Click += new System.EventHandler(this.ListAllRoutines);
            // 
            // exceçõesToolStripMenuItem
            // 
            this.exceçõesToolStripMenuItem.Name = "exceçõesToolStripMenuItem";
            this.exceçõesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.exceçõesToolStripMenuItem.Text = "Exceção";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(116, 6);
            // 
            // executarToolStripMenuItem
            // 
            this.executarToolStripMenuItem.Name = "executarToolStripMenuItem";
            this.executarToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.executarToolStripMenuItem.Text = "Executar";
            // 
            // arquivosTemporariosToolStripMenuItem1
            // 
            this.arquivosTemporariosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limparToolStripMenuItem1});
            this.arquivosTemporariosToolStripMenuItem1.Name = "arquivosTemporariosToolStripMenuItem1";
            this.arquivosTemporariosToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.arquivosTemporariosToolStripMenuItem1.Text = "Arquivos Temporarios";
            // 
            // limparToolStripMenuItem1
            // 
            this.limparToolStripMenuItem1.Name = "limparToolStripMenuItem1";
            this.limparToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.limparToolStripMenuItem1.Text = "Limpar";
            this.limparToolStripMenuItem1.Click += new System.EventHandler(this.ClearTempFiles);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(186, 6);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnAddRoutine);
            this.Controls.Add(this.lstRoutine);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automated Bot";
            this.Load += new System.EventHandler(this.Index_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicialToolStripMenuItem;
        private ToolStripMenuItem rotinaToolStripMenuItem;
        private ToolStripMenuItem timeoutToolStripMenuItem;
        private ToolStripMenuItem exceçãoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem execuçãoToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ListBox lstRoutine;
        private Button btnAddRoutine;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem rotinasToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem2;
        private ToolStripMenuItem exceçõesToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem2;
        private ToolStripMenuItem adicionarToolStripMenuItem3;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem executarToolStripMenuItem;
        private ToolStripMenuItem arquivosTemporariosToolStripMenuItem;
        private ToolStripMenuItem limparToolStripMenuItem;
        private ToolStripMenuItem arquivosTemporariosToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem limparToolStripMenuItem1;
    }
}