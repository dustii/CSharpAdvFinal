namespace CSharpAdvFinal
{
    partial class DWAddARecord
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWrkOrdID = new System.Windows.Forms.TextBox();
            this.cbxPlaneNo = new System.Windows.Forms.ComboBox();
            this.aIRPLANEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deathstarDataSet = new CSharpAdvFinal.DeathstarDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.aIRPLANETableAdapter = new CSharpAdvFinal.DeathstarDataSetTableAdapters.AIRPLANETableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTaskID = new System.Windows.Forms.ComboBox();
            this.tASKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tASKSTableAdapter = new CSharpAdvFinal.DeathstarDataSetTableAdapters.TASKSTableAdapter();
            this.dteStart = new System.Windows.Forms.DateTimePicker();
            this.dteEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numCost = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPLANEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deathstarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Work Order ID:";
            // 
            // txtWrkOrdID
            // 
            this.txtWrkOrdID.Location = new System.Drawing.Point(122, 6);
            this.txtWrkOrdID.Name = "txtWrkOrdID";
            this.txtWrkOrdID.Size = new System.Drawing.Size(121, 20);
            this.txtWrkOrdID.TabIndex = 1;
            // 
            // cbxPlaneNo
            // 
            this.cbxPlaneNo.CausesValidation = false;
            this.cbxPlaneNo.DataSource = this.aIRPLANEBindingSource;
            this.cbxPlaneNo.DisplayMember = "PLANENO";
            this.cbxPlaneNo.FormattingEnabled = true;
            this.cbxPlaneNo.Location = new System.Drawing.Point(122, 32);
            this.cbxPlaneNo.Name = "cbxPlaneNo";
            this.cbxPlaneNo.Size = new System.Drawing.Size(121, 21);
            this.cbxPlaneNo.TabIndex = 2;
            this.cbxPlaneNo.SelectionChangeCommitted += new System.EventHandler(this.cbxPlaneNo_SelectionChangeCommitted);
            // 
            // aIRPLANEBindingSource
            // 
            this.aIRPLANEBindingSource.DataMember = "AIRPLANE";
            this.aIRPLANEBindingSource.DataSource = this.deathstarDataSet;
            // 
            // deathstarDataSet
            // 
            this.deathstarDataSet.DataSetName = "DeathstarDataSet";
            this.deathstarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Plane Number:";
            // 
            // aIRPLANETableAdapter
            // 
            this.aIRPLANETableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Task ID:";
            // 
            // cbxTaskID
            // 
            this.cbxTaskID.CausesValidation = false;
            this.cbxTaskID.FormattingEnabled = true;
            this.cbxTaskID.Location = new System.Drawing.Point(122, 59);
            this.cbxTaskID.Name = "cbxTaskID";
            this.cbxTaskID.Size = new System.Drawing.Size(121, 21);
            this.cbxTaskID.TabIndex = 4;
            // 
            // tASKSBindingSource
            // 
            this.tASKSBindingSource.DataMember = "TASKS";
            this.tASKSBindingSource.DataSource = this.deathstarDataSet;
            // 
            // tASKSTableAdapter
            // 
            this.tASKSTableAdapter.ClearBeforeFill = true;
            // 
            // dteStart
            // 
            this.dteStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteStart.Location = new System.Drawing.Point(122, 87);
            this.dteStart.Name = "dteStart";
            this.dteStart.Size = new System.Drawing.Size(121, 20);
            this.dteStart.TabIndex = 6;
            // 
            // dteEnd
            // 
            this.dteEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteEnd.Location = new System.Drawing.Point(122, 113);
            this.dteEnd.Name = "dteEnd";
            this.dteEnd.ShowCheckBox = true;
            this.dteEnd.Size = new System.Drawing.Size(121, 20);
            this.dteEnd.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Start Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "End Date:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(122, 139);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(121, 20);
            this.txtStatus.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Status:";
            // 
            // numCost
            // 
            this.numCost.DecimalPlaces = 2;
            this.numCost.Location = new System.Drawing.Point(122, 166);
            this.numCost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCost.Name = "numCost";
            this.numCost.Size = new System.Drawing.Size(120, 20);
            this.numCost.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Parts and Labor Costs:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Labor Hours:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(122, 194);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 14;
            // 
            // btnInsert
            // 
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInsert.Location = new System.Drawing.Point(79, 232);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(102, 38);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "Insert Record";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // DWAddARecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 282);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dteEnd);
            this.Controls.Add(this.dteStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxTaskID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxPlaneNo);
            this.Controls.Add(this.txtWrkOrdID);
            this.Controls.Add(this.label1);
            this.Name = "DWAddARecord";
            this.Text = "DWAddARecord";
            this.Load += new System.EventHandler(this.DWAddARecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aIRPLANEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deathstarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWrkOrdID;
        private System.Windows.Forms.Label label2;
        private DeathstarDataSet deathstarDataSet;
        private System.Windows.Forms.BindingSource aIRPLANEBindingSource;
        private DeathstarDataSetTableAdapters.AIRPLANETableAdapter aIRPLANETableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTaskID;
        private System.Windows.Forms.BindingSource tASKSBindingSource;
        private DeathstarDataSetTableAdapters.TASKSTableAdapter tASKSTableAdapter;
        private System.Windows.Forms.DateTimePicker dteStart;
        private System.Windows.Forms.DateTimePicker dteEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ComboBox cbxPlaneNo;
    }
}