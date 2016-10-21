namespace AddDocs_RS_GUI
{
    partial class CustomPropertyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.uxCustomProperty_DataGrid = new System.Windows.Forms.DataGridView();
            this.uxSubmit_Button = new System.Windows.Forms.Button();
            this.uxCustPropName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxCustPropValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uxCustomProperty_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxCustomProperty_DataGrid
            // 
            this.uxCustomProperty_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxCustomProperty_DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uxCustPropName,
            this.uxCustPropValue});
            this.uxCustomProperty_DataGrid.Location = new System.Drawing.Point(12, 12);
            this.uxCustomProperty_DataGrid.Name = "uxCustomProperty_DataGrid";
            this.uxCustomProperty_DataGrid.Size = new System.Drawing.Size(486, 266);
            this.uxCustomProperty_DataGrid.TabIndex = 1;
            // 
            // uxSubmit_Button
            // 
            this.uxSubmit_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxSubmit_Button.Location = new System.Drawing.Point(423, 284);
            this.uxSubmit_Button.Name = "uxSubmit_Button";
            this.uxSubmit_Button.Size = new System.Drawing.Size(75, 23);
            this.uxSubmit_Button.TabIndex = 2;
            this.uxSubmit_Button.Text = "Submit";
            this.uxSubmit_Button.UseVisualStyleBackColor = true;
            this.uxSubmit_Button.Click += new System.EventHandler(this.uxSubmit_Button_Click);
            // 
            // uxCustPropName
            // 
            this.uxCustPropName.HeaderText = "Property Name";
            this.uxCustPropName.Name = "uxCustPropName";
            this.uxCustPropName.ReadOnly = true;
            this.uxCustPropName.Width = 150;
            // 
            // uxCustPropValue
            // 
            this.uxCustPropValue.HeaderText = "Property Value";
            this.uxCustPropValue.Name = "uxCustPropValue";
            this.uxCustPropValue.Width = 285;
            // 
            // CustomPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 319);
            this.Controls.Add(this.uxSubmit_Button);
            this.Controls.Add(this.uxCustomProperty_DataGrid);
            this.Name = "CustomPropertyForm";
            this.Text = "CustomPropertyForm";
            this.Load += new System.EventHandler(this.CustomPropertyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxCustomProperty_DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView uxCustomProperty_DataGrid;
        private System.Windows.Forms.Button uxSubmit_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxCustPropName;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxCustPropValue;
    }
}