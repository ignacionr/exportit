namespace exportit
{
    partial class SourceSelection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboSourceTypes = new System.Windows.Forms.ComboBox();
            this.pnlEditorContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // comboSourceTypes
            // 
            this.comboSourceTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboSourceTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSourceTypes.FormattingEnabled = true;
            this.comboSourceTypes.Location = new System.Drawing.Point(0, 0);
            this.comboSourceTypes.Name = "comboSourceTypes";
            this.comboSourceTypes.Size = new System.Drawing.Size(489, 21);
            this.comboSourceTypes.TabIndex = 0;
            this.comboSourceTypes.SelectedValueChanged += new System.EventHandler(this.comboSourceTypes_SelectedValueChanged);
            // 
            // pnlEditorContainer
            // 
            this.pnlEditorContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditorContainer.Location = new System.Drawing.Point(0, 21);
            this.pnlEditorContainer.Name = "pnlEditorContainer";
            this.pnlEditorContainer.Size = new System.Drawing.Size(489, 332);
            this.pnlEditorContainer.TabIndex = 1;
            // 
            // SourceSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlEditorContainer);
            this.Controls.Add(this.comboSourceTypes);
            this.Name = "SourceSelection";
            this.Size = new System.Drawing.Size(489, 353);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSourceTypes;
        private System.Windows.Forms.Panel pnlEditorContainer;
    }
}
