namespace AutomatedBot.View
{
    partial class AllRoutines
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
            this.lstAllRoutines = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstAllRoutines
            // 
            this.lstAllRoutines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstAllRoutines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstAllRoutines.FormattingEnabled = true;
            this.lstAllRoutines.ItemHeight = 15;
            this.lstAllRoutines.Location = new System.Drawing.Point(12, 17);
            this.lstAllRoutines.Name = "lstAllRoutines";
            this.lstAllRoutines.Size = new System.Drawing.Size(360, 525);
            this.lstAllRoutines.TabIndex = 0;
            // 
            // AllRoutines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.lstAllRoutines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AllRoutines";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todas as Rotinas";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstAllRoutines;
    }
}