﻿namespace AutomatedBot.View
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
            this.ckbMoveMouse.Location = new System.Drawing.Point(12, 166);
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
            this.txtWait.Location = new System.Drawing.Point(12, 242);
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
            this.label9.Location = new System.Drawing.Point(12, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Aguardar";
            // 
            // btnGetAllValues
            // 
            this.btnGetAllValues.Location = new System.Drawing.Point(225, 122);
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
            this.cbbFunction.Location = new System.Drawing.Point(225, 242);
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
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
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
            this.ckbSimpleClick.Location = new System.Drawing.Point(12, 191);
            this.ckbSimpleClick.Name = "ckbSimpleClick";
            this.ckbSimpleClick.Size = new System.Drawing.Size(106, 19);
            this.ckbSimpleClick.TabIndex = 9;
            this.ckbSimpleClick.Text = "Clique Simples";
            this.ckbSimpleClick.UseVisualStyleBackColor = true;
            // 
            // txtWrite
            // 
            this.txtWrite.Location = new System.Drawing.Point(12, 315);
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.Size = new System.Drawing.Size(174, 23);
            this.txtWrite.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 53;
            this.label2.Text = "Texto para Escrita";
            // 
            // cbbKeyOne
            // 
            this.cbbKeyOne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKeyOne.FormattingEnabled = true;
            this.cbbKeyOne.Location = new System.Drawing.Point(434, 242);
            this.cbbKeyOne.Name = "cbbKeyOne";
            this.cbbKeyOne.Size = new System.Drawing.Size(106, 23);
            this.cbbKeyOne.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(434, 224);
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
            this.label12.Location = new System.Drawing.Point(558, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 15);
            this.label12.TabIndex = 57;
            this.label12.Text = "Tecla 2";
            // 
            // cbbKeyTwo
            // 
            this.cbbKeyTwo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKeyTwo.FormattingEnabled = true;
            this.cbbKeyTwo.Location = new System.Drawing.Point(558, 242);
            this.cbbKeyTwo.Name = "cbbKeyTwo";
            this.cbbKeyTwo.Size = new System.Drawing.Size(106, 23);
            this.cbbKeyTwo.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(682, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 15);
            this.label13.TabIndex = 59;
            this.label13.Text = "Tecla 3";
            // 
            // cbbKeyThree
            // 
            this.cbbKeyThree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKeyThree.FormattingEnabled = true;
            this.cbbKeyThree.Location = new System.Drawing.Point(682, 242);
            this.cbbKeyThree.Name = "cbbKeyThree";
            this.cbbKeyThree.Size = new System.Drawing.Size(106, 23);
            this.cbbKeyThree.TabIndex = 58;
            // 
            // PanelRoutine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
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
    }
}