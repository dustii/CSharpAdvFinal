namespace CSharpAdvFinal
{
    partial class DspWorkOrderTask
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
            this.deathstarDataSet = new CSharpAdvFinal.DeathstarDataSet();
            this.btnGetTask = new System.Windows.Forms.Button();
            this.txtWorkOrder = new System.Windows.Forms.TextBox();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deathstarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // deathstarDataSet
            // 
            this.deathstarDataSet.DataSetName = "DeathstarDataSet";
            this.deathstarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGetTask
            // 
            this.btnGetTask.Enabled = false;
            this.btnGetTask.Location = new System.Drawing.Point(48, 50);
            this.btnGetTask.Name = "btnGetTask";
            this.btnGetTask.Size = new System.Drawing.Size(111, 23);
            this.btnGetTask.TabIndex = 1;
            this.btnGetTask.Text = "&Display Task";
            this.btnGetTask.UseVisualStyleBackColor = true;
            this.btnGetTask.Click += new System.EventHandler(this.btnGetTask_Click);
            // 
            // txtWorkOrder
            // 
            this.txtWorkOrder.Location = new System.Drawing.Point(96, 18);
            this.txtWorkOrder.Name = "txtWorkOrder";
            this.txtWorkOrder.Size = new System.Drawing.Size(99, 20);
            this.txtWorkOrder.TabIndex = 0;
            this.txtWorkOrder.TextChanged += new System.EventHandler(this.txtWorkOrder_TextChanged);
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(15, 79);
            this.txtTask.Multiline = true;
            this.txtTask.Name = "txtTask";
            this.txtTask.ReadOnly = true;
            this.txtTask.Size = new System.Drawing.Size(180, 55);
            this.txtTask.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "&Work Order ID:";
            // 
            // DspWorkOrderTask
            // 
            this.AcceptButton = this.btnGetTask;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 153);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.txtWorkOrder);
            this.Controls.Add(this.btnGetTask);
            this.Name = "DspWorkOrderTask";
            this.Text = "Task";
            ((System.ComponentModel.ISupportInitialize)(this.deathstarDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DeathstarDataSet deathstarDataSet;
        private System.Windows.Forms.Button btnGetTask;
        private System.Windows.Forms.TextBox txtWorkOrder;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Label label1;
    }
}