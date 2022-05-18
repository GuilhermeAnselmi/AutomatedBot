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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtPosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWait)).BeginInit();
            this.SuspendLayout();
            // 
            // lstAllStages
            // 
            this.lstAllStages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstAllStages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAllStages.ForeColor = System.Drawing.Color.White;
            this.lstAllStages.FormattingEnabled = true;
            this.lstAllStages.ItemHeight = 15;
            this.lstAllStages.Location = new System.Drawing.Point(794, 12);
            this.lstAllStages.Name = "lstAllStages";
            this.lstAllStages.Size = new System.Drawing.Size(178, 632);
            this.lstAllStages.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(130, 12);
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
            this.label5.Location = new System.Drawing.Point(225, 104);
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
            this.label6.Location = new System.Drawing.Point(315, 104);
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
            this.label7.Location = new System.Drawing.Point(405, 104);
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
            this.label8.Location = new System.Drawing.Point(495, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "A";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(12, 166);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 19);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Mover Mouse";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtPosX
            // 
            this.txtPosX.Location = new System.Drawing.Point(12, 122);
            this.txtPosX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(84, 23);
            this.txtPosX.TabIndex = 16;
            // 
            // txtPosY
            // 
            this.txtPosY.Location = new System.Drawing.Point(102, 122);
            this.txtPosY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(84, 23);
            this.txtPosY.TabIndex = 17;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(225, 122);
            this.txtR.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(84, 23);
            this.txtR.TabIndex = 18;
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(315, 122);
            this.txtG.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(84, 23);
            this.txtG.TabIndex = 19;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(405, 122);
            this.txtB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(84, 23);
            this.txtB.TabIndex = 20;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(495, 122);
            this.txtA.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(84, 23);
            this.txtA.TabIndex = 21;
            // 
            // txtWait
            // 
            this.txtWait.Location = new System.Drawing.Point(12, 242);
            this.txtWait.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtWait.Name = "txtWait";
            this.txtWait.Size = new System.Drawing.Size(84, 23);
            this.txtWait.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Aguardar";
            // 
            // btnGetAllValues
            // 
            this.btnGetAllValues.Location = new System.Drawing.Point(478, 163);
            this.btnGetAllValues.Name = "btnGetAllValues";
            this.btnGetAllValues.Size = new System.Drawing.Size(101, 23);
            this.btnGetAllValues.TabIndex = 24;
            this.btnGetAllValues.Text = "Pegar Valores";
            this.btnGetAllValues.UseVisualStyleBackColor = true;
            // 
            // cbbFunction
            // 
            this.cbbFunction.FormattingEnabled = true;
            this.cbbFunction.Location = new System.Drawing.Point(225, 242);
            this.cbbFunction.Name = "cbbFunction";
            this.cbbFunction.Size = new System.Drawing.Size(174, 23);
            this.cbbFunction.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(225, 224);
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
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(12, 621);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(132, 23);
            this.btnDone.TabIndex = 28;
            this.btnDone.Text = "Voltar";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.Done);
            // 
            // PanelRoutine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
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
            this.Controls.Add(this.checkBox1);
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
        private CheckBox checkBox1;
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
    }
}