namespace CSharpAdvFinal
{
    partial class DspMaintenceLog
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
            this.btnGetLog = new System.Windows.Forms.Button();
            this.txtPlaneNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.airplaneTableAdapter1 = new CSharpAdvFinal.DeathstarDataSetTableAdapters.AIRPLANETableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGetLog
            // 
            this.btnGetLog.Location = new System.Drawing.Point(93, 45);
            this.btnGetLog.Name = "btnGetLog";
            this.btnGetLog.Size = new System.Drawing.Size(111, 23);
            this.btnGetLog.TabIndex = 1;
            this.btnGetLog.Text = "&Display Maintenance Log";
            this.btnGetLog.UseVisualStyleBackColor = true;
            this.btnGetLog.Click += new System.EventHandler(this.btnGetLog_Click);
            // 
            // txtPlaneNum
            // 
            this.txtPlaneNum.Location = new System.Drawing.Point(93, 8);
            this.txtPlaneNum.Name = "txtPlaneNum";
            this.txtPlaneNum.Size = new System.Drawing.Size(186, 20);
            this.txtPlaneNum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "&Plane Number:";
            // 
            // airplaneTableAdapter1
            // 
            this.airplaneTableAdapter1.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 95);
            this.listBox1.TabIndex = 4;
            // 
            // DspMaintenceLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 220);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnGetLog);
            this.Controls.Add(this.txtPlaneNum);
            this.Controls.Add(this.label1);
            this.Name = "DspMaintenceLog";
            this.Text = "DspMaintenceLog";
            this.Load += new System.EventHandler(this.DspMaintenceLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGetLog;
        private System.Windows.Forms.TextBox txtPlaneNum;
        private System.Windows.Forms.Label label1;
        private DeathstarDataSetTableAdapters.AIRPLANETableAdapter airplaneTableAdapter1;
        private System.Windows.Forms.ListBox listBox1;
    }
}