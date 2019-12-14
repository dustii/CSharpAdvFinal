namespace CSharpAdvFinal
{
    partial class DspPlanes
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
            this.DisplayPlane = new System.Windows.Forms.ListBox();
            this.DspPlane = new System.Windows.Forms.Button();
            this.deathstarDataSet1 = new CSharpAdvFinal.DeathstarDataSet();
            this.airplaneTableAdapter1 = new CSharpAdvFinal.DeathstarDataSetTableAdapters.AIRPLANETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.deathstarDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayPlane
            // 
            this.DisplayPlane.FormattingEnabled = true;
            this.DisplayPlane.HorizontalScrollbar = true;
            this.DisplayPlane.Location = new System.Drawing.Point(12, 6);
            this.DisplayPlane.Name = "DisplayPlane";
            this.DisplayPlane.ScrollAlwaysVisible = true;
            this.DisplayPlane.Size = new System.Drawing.Size(635, 394);
            this.DisplayPlane.TabIndex = 0;
            // 
            // DspPlane
            // 
            this.DspPlane.Location = new System.Drawing.Point(653, 123);
            this.DspPlane.Name = "DspPlane";
            this.DspPlane.Size = new System.Drawing.Size(155, 62);
            this.DspPlane.TabIndex = 2;
            this.DspPlane.Text = "Display Plane";
            this.DspPlane.UseVisualStyleBackColor = true;
            this.DspPlane.Click += new System.EventHandler(this.DspPlane_Click);
            // 
            // deathstarDataSet1
            // 
            this.deathstarDataSet1.DataSetName = "DeathstarDataSet";
            this.deathstarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airplaneTableAdapter1
            // 
            this.airplaneTableAdapter1.ClearBeforeFill = true;
            // 
            // DspPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 415);
            this.Controls.Add(this.DspPlane);
            this.Controls.Add(this.DisplayPlane);
            this.Name = "DspPlanes";
            this.Text = "DspPlanes";
            ((System.ComponentModel.ISupportInitialize)(this.deathstarDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DisplayPlane;
        private System.Windows.Forms.Button DspPlane;
        private DeathstarDataSet deathstarDataSet1;
        private DeathstarDataSetTableAdapters.AIRPLANETableAdapter airplaneTableAdapter1;
    }
}