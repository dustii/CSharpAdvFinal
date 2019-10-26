namespace CSharpAdvFinal
{
    partial class Form1
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
            this.btnDspTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDspTask
            // 
            this.btnDspTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDspTask.Location = new System.Drawing.Point(12, 12);
            this.btnDspTask.Name = "btnDspTask";
            this.btnDspTask.Size = new System.Drawing.Size(121, 81);
            this.btnDspTask.TabIndex = 0;
            this.btnDspTask.Text = "View work order task descriptions.";
            this.btnDspTask.UseVisualStyleBackColor = true;
            this.btnDspTask.Click += new System.EventHandler(this.btnDspTask_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 106);
            this.Controls.Add(this.btnDspTask);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDspTask;
    }
}

