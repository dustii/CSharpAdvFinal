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
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.deathstarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.btnGetTask.Location = new System.Drawing.Point(44, 49);
            this.btnGetTask.Name = "btnGetTask";
            this.btnGetTask.Size = new System.Drawing.Size(111, 23);
            this.btnGetTask.TabIndex = 1;
            this.btnGetTask.Text = "&Display Task";
            this.btnGetTask.UseVisualStyleBackColor = true;
            this.btnGetTask.Click += new System.EventHandler(this.btnGetTask_Click);
            // 
            // txtWorkOrder
            // 
            this.txtWorkOrder.Location = new System.Drawing.Point(95, 13);
            this.txtWorkOrder.Name = "txtWorkOrder";
            this.txtWorkOrder.Size = new System.Drawing.Size(99, 20);
            this.txtWorkOrder.TabIndex = 0;
            this.txtWorkOrder.TextChanged += new System.EventHandler(this.txtWorkOrder_TextChanged);
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(14, 78);
            this.txtTask.Multiline = true;
            this.txtTask.Name = "txtTask";
            this.txtTask.ReadOnly = true;
            this.txtTask.Size = new System.Drawing.Size(180, 55);
            this.txtTask.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "&Work Order ID:";
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecord.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAddRecord.Location = new System.Drawing.Point(0, 0);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(203, 64);
            this.btnAddRecord.TabIndex = 4;
            this.btnAddRecord.Text = "Add a new work order";
            this.btnAddRecord.UseVisualStyleBackColor = false;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnGetTask);
            this.splitContainer1.Panel1.Controls.Add(this.txtWorkOrder);
            this.splitContainer1.Panel1.Controls.Add(this.txtTask);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnAddRecord);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(205, 222);
            this.splitContainer1.SplitterDistance = 152;
            this.splitContainer1.TabIndex = 5;
            // 
            // DspWorkOrderTask
            // 
            this.AcceptButton = this.btnGetTask;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 244);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DspWorkOrderTask";
            this.Text = "Task";
            ((System.ComponentModel.ISupportInitialize)(this.deathstarDataSet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DeathstarDataSet deathstarDataSet;
        private System.Windows.Forms.Button btnGetTask;
        private System.Windows.Forms.TextBox txtWorkOrder;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}