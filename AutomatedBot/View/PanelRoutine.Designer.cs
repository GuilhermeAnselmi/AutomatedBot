namespace AutomatedBot.View
{
    partial class PanelRoutine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstAllStages = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRoutineName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ckbMoveMouse = new System.Windows.Forms.CheckBox();
            this.txtPosX = new System.Windows.Forms.NumericUpDown();
            this.txtPosY = new System.Windows.Forms.NumericUpDown();
            this.txtR = new System.Windows.Forms.NumericUpDown();
            this.txtG = new System.Windows.Forms.NumericUpDown();
            this.txtB = new System.Windows.Forms.NumericUpDown();
            this.txtA = new System.Windows.Forms.NumericUpDown();
            this.txtWait = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGetAllValues = new System.Windows.Forms.Button();
            this.cbbFunction = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.ckbSimpleClick = new System.Windows.Forms.CheckBox();
            this.txtWrite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbKeyOne = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbKeyTwo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbbKeyThree = new System.Windows.Forms.ComboBox();
            this.lblGetValue = new System.Windows.Forms.Label();
            this.pnlCondition = new System.Windows.Forms.Panel();
            this.ckbConditionTwo = new System.Windows.Forms.CheckBox();
            this.ckbConditionOne = new System.Windows.Forms.CheckBox();
            this.cbbLogicalOperatorOne = new System.Windows.Forms.ComboBox();
            this.txtValueTwo = new System.Windows.Forms.TextBox();
            this.cbbOperatorTwo = new System.Windows.Forms.ComboBox();
            this.cbbConditionKeyTwo = new System.Windows.Forms.ComboBox();
            this.txtValueOne = new System.Windows.Forms.TextBox();
            this.cbbOperatorOne = new System.Windows.Forms.ComboBox();
            this.cbbConditionKeyOne = new System.Windows.Forms.ComboBox();
            this.cbbNextStageTrue = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnColorCondition = new System.Windows.Forms.Button();
            this.txtStageName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbbValueInput = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUnselectedList = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.cbbNextStageFalse = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbbRoutineTimeout = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTimeout = new System.Windows.Forms.NumericUpDown();
            this.btnClearPanel = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.cbbMarkConditional = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWait)).BeginInit();
            this.pnlCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // lstAllStages
            // 
            this.lstAllStages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstAllStages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAllStages.ForeColor = System.Drawing.Color.White;
            this.lstAllStages.FormattingEnabled = true;
            this.lstAllStages.ItemHeight = 15;
            this.lstAllStages.Location = new System.Drawing.Point(794, 42);
            this.lstAllStages.Name = "lstAllStages";
            this.lstAllStages.Size = new System.Drawing.Size(178, 602);
            this.lstAllStages.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Painel de Gerenciamento da Rotina";
            // 
            // lblRoutineName
            // 
            this.lblRoutineName.AutoSize = true;
            this.lblRoutineName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoutineName.ForeColor = System.Drawing.Color.White;
            this.lblRoutineName.Location = new System.Drawing.Point(12, 61);
            this.lblRoutineName.Name = "lblRoutineName";
            this.lblRoutineName.Size = new System.Drawing.Size(74, 30);
            this.lblRoutineName.TabIndex = 2;
            this.lblRoutineName.Text = "NONE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pos X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(102, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pos Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(434, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "R";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(524, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "G";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(614, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(704, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "A";
            // 
            // ckbMoveMouse
            // 
            this.ckbMoveMouse.AutoSize = true;
            this.ckbMoveMouse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbMoveMouse.ForeColor = System.Drawing.Color.White;
            this.ckbMoveMouse.Location = new System.Drawing.Point(12, 180);
            this.ckbMoveMouse.Name = "ckbMoveMouse";
            this.ckbMoveMouse.Size = new System.Drawing.Size(103, 19);
            this.ckbMoveMouse.TabIndex = 8;
            this.ckbMoveMouse.Text = "Mover Mouse";
            this.ckbMoveMouse.UseVisualStyleBackColor = true;
            // 
            // txtPosX
            // 
            this.txtPosX.Location = new System.Drawing.Point(12, 122);
            this.txtPosX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtPosX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(84, 23);
            this.txtPosX.TabIndex = 1;
            // 
            // txtPosY
            // 
            this.txtPosY.Location = new System.Drawing.Point(102, 122);
            this.txtPosY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtPosY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(84, 23);
            this.txtPosY.TabIndex = 2;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(434, 122);
            this.txtR.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(84, 23);
            this.txtR.TabIndex = 4;
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(524, 122);
            this.txtG.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(84, 23);
            this.txtG.TabIndex = 5;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(614, 122);
            this.txtB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(84, 23);
            this.txtB.TabIndex = 6;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(704, 122);
            this.txtA.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(84, 23);
            this.txtA.TabIndex = 7;
            // 
            // txtWait
            // 
            this.txtWait.Location = new System.Drawing.Point(12, 276);
            this.txtWait.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtWait.Name = "txtWait";
            this.txtWait.Size = new System.Drawing.Size(84, 23);
            this.txtWait.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Aguardar";
            // 
            // btnGetAllValues
            // 
            this.btnGetAllValues.Location = new System.Drawing.Point(12, 151);
            this.btnGetAllValues.Name = "btnGetAllValues";
            this.btnGetAllValues.Size = new System.Drawing.Size(174, 23);
            this.btnGetAllValues.TabIndex = 3;
            this.btnGetAllValues.Text = "Pegar Valores";
            this.btnGetAllValues.UseVisualStyleBackColor = true;
            this.btnGetAllValues.Click += new System.EventHandler(this.GetValues);
            // 
            // cbbFunction
            // 
            this.cbbFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFunction.FormattingEnabled = true;
            this.cbbFunction.Location = new System.Drawing.Point(225, 122);
            this.cbbFunction.Name = "cbbFunction";
            this.cbbFunction.Size = new System.Drawing.Size(174, 23);
            this.cbbFunction.TabIndex = 11;
            this.cbbFunction.SelectedValueChanged += new System.EventHandler(this.ItemChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(225, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Função";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(656, 621);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 23);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.SaveStage);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(12, 621);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(132, 23);
            this.btnDone.TabIndex = 50;
            this.btnDone.Text = "Voltar";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.Done);
            // 
            // ckbSimpleClick
            // 
            this.ckbSimpleClick.AutoSize = true;
            this.ckbSimpleClick.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbSimpleClick.ForeColor = System.Drawing.Color.White;
            this.ckbSimpleClick.Location = new System.Drawing.Point(12, 205);
            this.ckbSimpleClick.Name = "ckbSimpleClick";
            this.ckbSimpleClick.Size = new System.Drawing.Size(106, 19);
            this.ckbSimpleClick.TabIndex = 9;
            this.ckbSimpleClick.Text = "Clique Simples";
            this.ckbSimpleClick.UseVisualStyleBackColor = true;
            // 
            // txtWrite
            // 
            this.txtWrite.Enabled = false;
            this.txtWrite.Location = new System.Drawing.Point(225, 239);
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.Size = new System.Drawing.Size(174, 23);
            this.txtWrite.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(225, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 53;
            this.label2.Text = "Texto para Escrita";
            // 
            // cbbKeyOne
            // 
            this.cbbKeyOne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKeyOne.FormattingEnabled = true;
            this.cbbKeyOne.Location = new System.Drawing.Point(434, 264);
            this.cbbKeyOne.Name = "cbbKeyOne";
            this.cbbKeyOne.Size = new System.Drawing.Size(106, 23);
            this.cbbKeyOne.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(434, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 55;
            this.label11.Text = "Tecla 1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(558, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 15);
            this.label12.TabIndex = 57;
            this.label12.Text = "Tecla 2";
            // 
            // cbbKeyTwo
            // 
            this.cbbKeyTwo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKeyTwo.FormattingEnabled = true;
            this.cbbKeyTwo.Location = new System.Drawing.Point(558, 264);
            this.cbbKeyTwo.Name = "cbbKeyTwo";
            this.cbbKeyTwo.Size = new System.Drawing.Size(106, 23);
            this.cbbKeyTwo.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(682, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 15);
            this.label13.TabIndex = 59;
            this.label13.Text = "Tecla 3";
            // 
            // cbbKeyThree
            // 
            this.cbbKeyThree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKeyThree.FormattingEnabled = true;
            this.cbbKeyThree.Location = new System.Drawing.Point(682, 264);
            this.cbbKeyThree.Name = "cbbKeyThree";
            this.cbbKeyThree.Size = new System.Drawing.Size(106, 23);
            this.cbbKeyThree.TabIndex = 58;
            // 
            // lblGetValue
            // 
            this.lblGetValue.AutoSize = true;
            this.lblGetValue.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGetValue.ForeColor = System.Drawing.Color.White;
            this.lblGetValue.Location = new System.Drawing.Point(172, 564);
            this.lblGetValue.Name = "lblGetValue";
            this.lblGetValue.Size = new System.Drawing.Size(457, 80);
            this.lblGetValue.TabIndex = 60;
            this.lblGetValue.Text = "Pressione K para gravar posição\r\nPressione O para voltar";
            this.lblGetValue.Visible = false;
            // 
            // pnlCondition
            // 
            this.pnlCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCondition.Controls.Add(this.ckbConditionTwo);
            this.pnlCondition.Controls.Add(this.ckbConditionOne);
            this.pnlCondition.Controls.Add(this.cbbLogicalOperatorOne);
            this.pnlCondition.Controls.Add(this.txtValueTwo);
            this.pnlCondition.Controls.Add(this.cbbOperatorTwo);
            this.pnlCondition.Controls.Add(this.cbbConditionKeyTwo);
            this.pnlCondition.Controls.Add(this.txtValueOne);
            this.pnlCondition.Controls.Add(this.cbbOperatorOne);
            this.pnlCondition.Controls.Add(this.cbbConditionKeyOne);
            this.pnlCondition.Enabled = false;
            this.pnlCondition.Location = new System.Drawing.Point(331, 337);
            this.pnlCondition.Name = "pnlCondition";
            this.pnlCondition.Size = new System.Drawing.Size(457, 61);
            this.pnlCondition.TabIndex = 61;
            // 
            // ckbConditionTwo
            // 
            this.ckbConditionTwo.AutoSize = true;
            this.ckbConditionTwo.Location = new System.Drawing.Point(5, 37);
            this.ckbConditionTwo.Name = "ckbConditionTwo";
            this.ckbConditionTwo.Size = new System.Drawing.Size(15, 14);
            this.ckbConditionTwo.TabIndex = 15;
            this.ckbConditionTwo.UseVisualStyleBackColor = true;
            // 
            // ckbConditionOne
            // 
            this.ckbConditionOne.AutoSize = true;
            this.ckbConditionOne.Checked = true;
            this.ckbConditionOne.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbConditionOne.Enabled = false;
            this.ckbConditionOne.Location = new System.Drawing.Point(5, 8);
            this.ckbConditionOne.Name = "ckbConditionOne";
            this.ckbConditionOne.Size = new System.Drawing.Size(15, 14);
            this.ckbConditionOne.TabIndex = 14;
            this.ckbConditionOne.UseVisualStyleBackColor = true;
            // 
            // cbbLogicalOperatorOne
            // 
            this.cbbLogicalOperatorOne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLogicalOperatorOne.FormattingEnabled = true;
            this.cbbLogicalOperatorOne.Location = new System.Drawing.Point(378, 4);
            this.cbbLogicalOperatorOne.Name = "cbbLogicalOperatorOne";
            this.cbbLogicalOperatorOne.Size = new System.Drawing.Size(72, 23);
            this.cbbLogicalOperatorOne.TabIndex = 12;
            // 
            // txtValueTwo
            // 
            this.txtValueTwo.Location = new System.Drawing.Point(272, 33);
            this.txtValueTwo.Name = "txtValueTwo";
            this.txtValueTwo.Size = new System.Drawing.Size(100, 23);
            this.txtValueTwo.TabIndex = 5;
            // 
            // cbbOperatorTwo
            // 
            this.cbbOperatorTwo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbOperatorTwo.FormattingEnabled = true;
            this.cbbOperatorTwo.Location = new System.Drawing.Point(153, 33);
            this.cbbOperatorTwo.Name = "cbbOperatorTwo";
            this.cbbOperatorTwo.Size = new System.Drawing.Size(113, 23);
            this.cbbOperatorTwo.TabIndex = 4;
            // 
            // cbbConditionKeyTwo
            // 
            this.cbbConditionKeyTwo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbConditionKeyTwo.FormattingEnabled = true;
            this.cbbConditionKeyTwo.Location = new System.Drawing.Point(26, 33);
            this.cbbConditionKeyTwo.Name = "cbbConditionKeyTwo";
            this.cbbConditionKeyTwo.Size = new System.Drawing.Size(121, 23);
            this.cbbConditionKeyTwo.TabIndex = 3;
            // 
            // txtValueOne
            // 
            this.txtValueOne.Location = new System.Drawing.Point(272, 4);
            this.txtValueOne.Name = "txtValueOne";
            this.txtValueOne.Size = new System.Drawing.Size(100, 23);
            this.txtValueOne.TabIndex = 2;
            // 
            // cbbOperatorOne
            // 
            this.cbbOperatorOne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbOperatorOne.FormattingEnabled = true;
            this.cbbOperatorOne.Location = new System.Drawing.Point(153, 4);
            this.cbbOperatorOne.Name = "cbbOperatorOne";
            this.cbbOperatorOne.Size = new System.Drawing.Size(113, 23);
            this.cbbOperatorOne.TabIndex = 1;
            // 
            // cbbConditionKeyOne
            // 
            this.cbbConditionKeyOne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbConditionKeyOne.FormattingEnabled = true;
            this.cbbConditionKeyOne.Location = new System.Drawing.Point(26, 4);
            this.cbbConditionKeyOne.Name = "cbbConditionKeyOne";
            this.cbbConditionKeyOne.Size = new System.Drawing.Size(121, 23);
            this.cbbConditionKeyOne.TabIndex = 0;
            // 
            // cbbNextStageTrue
            // 
            this.cbbNextStageTrue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNextStageTrue.Enabled = false;
            this.cbbNextStageTrue.FormattingEnabled = true;
            this.cbbNextStageTrue.Location = new System.Drawing.Point(614, 434);
            this.cbbNextStageTrue.Name = "cbbNextStageTrue";
            this.cbbNextStageTrue.Size = new System.Drawing.Size(174, 23);
            this.cbbNextStageTrue.TabIndex = 62;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(615, 416);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 15);
            this.label14.TabIndex = 63;
            this.label14.Text = "Se for verdadeiro";
            // 
            // btnColorCondition
            // 
            this.btnColorCondition.Enabled = false;
            this.btnColorCondition.Location = new System.Drawing.Point(225, 151);
            this.btnColorCondition.Name = "btnColorCondition";
            this.btnColorCondition.Size = new System.Drawing.Size(174, 23);
            this.btnColorCondition.TabIndex = 64;
            this.btnColorCondition.Text = "Definir Regras da Condição";
            this.btnColorCondition.UseVisualStyleBackColor = true;
            this.btnColorCondition.Click += new System.EventHandler(this.OpenColorCondition);
            // 
            // txtStageName
            // 
            this.txtStageName.Location = new System.Drawing.Point(12, 493);
            this.txtStageName.Name = "txtStageName";
            this.txtStageName.Size = new System.Drawing.Size(174, 23);
            this.txtStageName.TabIndex = 65;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(12, 475);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 15);
            this.label15.TabIndex = 66;
            this.label15.Text = "Nome da Etapa";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(192, 493);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(592, 52);
            this.txtComments.TabIndex = 67;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(192, 475);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 15);
            this.label16.TabIndex = 68;
            this.label16.Text = "Comentário";
            // 
            // cbbValueInput
            // 
            this.cbbValueInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbValueInput.Enabled = false;
            this.cbbValueInput.FormattingEnabled = true;
            this.cbbValueInput.Location = new System.Drawing.Point(225, 286);
            this.cbbValueInput.Name = "cbbValueInput";
            this.cbbValueInput.Size = new System.Drawing.Size(158, 23);
            this.cbbValueInput.TabIndex = 69;
            this.cbbValueInput.SelectedValueChanged += new System.EventHandler(this.ValueInputChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(225, 268);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 15);
            this.label17.TabIndex = 70;
            this.label17.Text = "Valor de Entrada";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(794, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 23);
            this.btnEdit.TabIndex = 71;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.EditStage);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(907, 13);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(65, 23);
            this.btnRemove.TabIndex = 72;
            this.btnRemove.Text = "Excluir";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.RemoveStage);
            // 
            // btnUnselectedList
            // 
            this.btnUnselectedList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUnselectedList.Location = new System.Drawing.Point(756, 42);
            this.btnUnselectedList.Name = "btnUnselectedList";
            this.btnUnselectedList.Size = new System.Drawing.Size(32, 30);
            this.btnUnselectedList.TabIndex = 73;
            this.btnUnselectedList.Text = "-";
            this.btnUnselectedList.UseVisualStyleBackColor = true;
            this.btnUnselectedList.Click += new System.EventHandler(this.UnselectedList);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(332, 416);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 15);
            this.label18.TabIndex = 75;
            this.label18.Text = "Se for falso";
            // 
            // cbbNextStageFalse
            // 
            this.cbbNextStageFalse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNextStageFalse.Enabled = false;
            this.cbbNextStageFalse.FormattingEnabled = true;
            this.cbbNextStageFalse.Location = new System.Drawing.Point(331, 434);
            this.cbbNextStageFalse.Name = "cbbNextStageFalse";
            this.cbbNextStageFalse.Size = new System.Drawing.Size(174, 23);
            this.cbbNextStageFalse.TabIndex = 74;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(12, 357);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 15);
            this.label19.TabIndex = 77;
            this.label19.Text = "Rotina de Timeout";
            // 
            // cbbRoutineTimeout
            // 
            this.cbbRoutineTimeout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoutineTimeout.Enabled = false;
            this.cbbRoutineTimeout.FormattingEnabled = true;
            this.cbbRoutineTimeout.Location = new System.Drawing.Point(12, 375);
            this.cbbRoutineTimeout.Name = "cbbRoutineTimeout";
            this.cbbRoutineTimeout.Size = new System.Drawing.Size(158, 23);
            this.cbbRoutineTimeout.TabIndex = 76;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(12, 313);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(122, 15);
            this.label20.TabIndex = 79;
            this.label20.Text = "Tempo para Timeout";
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(12, 331);
            this.txtTimeout.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(84, 23);
            this.txtTimeout.TabIndex = 78;
            this.txtTimeout.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // btnClearPanel
            // 
            this.btnClearPanel.Location = new System.Drawing.Point(12, 580);
            this.btnClearPanel.Name = "btnClearPanel";
            this.btnClearPanel.Size = new System.Drawing.Size(132, 23);
            this.btnClearPanel.TabIndex = 80;
            this.btnClearPanel.Text = "Limpar Painel";
            this.btnClearPanel.UseVisualStyleBackColor = true;
            this.btnClearPanel.Click += new System.EventHandler(this.ClearPanel);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(12, 416);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(145, 15);
            this.label21.TabIndex = 82;
            this.label21.Text = "Marcar como condicional";
            // 
            // cbbMarkConditional
            // 
            this.cbbMarkConditional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMarkConditional.Enabled = false;
            this.cbbMarkConditional.FormattingEnabled = true;
            this.cbbMarkConditional.Location = new System.Drawing.Point(12, 434);
            this.cbbMarkConditional.Name = "cbbMarkConditional";
            this.cbbMarkConditional.Size = new System.Drawing.Size(158, 23);
            this.cbbMarkConditional.TabIndex = 81;
            // 
            // PanelRoutine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cbbMarkConditional);
            this.Controls.Add(this.btnClearPanel);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtTimeout);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cbbRoutineTimeout);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbbNextStageFalse);
            this.Controls.Add(this.btnUnselectedList);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbbValueInput);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtStageName);
            this.Controls.Add(this.btnColorCondition);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbbNextStageTrue);
            this.Controls.Add(this.pnlCondition);
            this.Controls.Add(this.lblGetValue);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbbKeyThree);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbbKeyTwo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbbKeyOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWrite);
            this.Controls.Add(this.ckbSimpleClick);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbbFunction);
            this.Controls.Add(this.btnGetAllValues);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtWait);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txtPosY);
            this.Controls.Add(this.txtPosX);
            this.Controls.Add(this.ckbMoveMouse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRoutineName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAllStages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PanelRoutine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel de Gerencimento da Rotina";
            this.Load += new System.EventHandler(this.PanelRoutine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWait)).EndInit();
            this.pnlCondition.ResumeLayout(false);
            this.pnlCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstAllStages;
        private Label label1;
        private Label lblRoutineName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private CheckBox ckbMoveMouse;
        private NumericUpDown txtPosX;
        private NumericUpDown txtPosY;
        private NumericUpDown txtR;
        private NumericUpDown txtG;
        private NumericUpDown txtB;
        private NumericUpDown txtA;
        private NumericUpDown txtWait;
        private Label label9;
        private Button btnGetAllValues;
        private ComboBox cbbFunction;
        private Label label10;
        private Button btnSave;
        private Button btnDone;
        private CheckBox ckbSimpleClick;
        private TextBox txtWrite;
        private Label label2;
        private ComboBox cbbKeyOne;
        private Label label11;
        private Label label12;
        private ComboBox cbbKeyTwo;
        private Label label13;
        private ComboBox cbbKeyThree;
        private Label lblGetValue;
        private Panel pnlCondition;
        private ComboBox cbbOperatorOne;
        private ComboBox cbbConditionKeyOne;
        private TextBox txtValueOne;
        private TextBox txtValueTwo;
        private ComboBox cbbOperatorTwo;
        private ComboBox cbbConditionKeyTwo;
        private ComboBox cbbLogicalOperatorOne;
        private ComboBox cbbNextStageTrue;
        private Label label14;
        private Button btnColorCondition;
        private TextBox txtStageName;
        private Label label15;
        private TextBox txtComments;
        private Label label16;
        private ComboBox cbbValueInput;
        private Label label17;
        private Button btnEdit;
        private Button btnRemove;
        private Button btnUnselectedList;
        private CheckBox ckbConditionTwo;
        private CheckBox ckbConditionOne;
        private Label label18;
        private ComboBox cbbNextStageFalse;
        private Label label19;
        private ComboBox cbbRoutineTimeout;
        private Label label20;
        private NumericUpDown txtTimeout;
        private Button btnClearPanel;
        private Label label21;
        private ComboBox cbbMarkConditional;
    }
}