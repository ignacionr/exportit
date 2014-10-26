namespace exportit.UI
{
    partial class SourceFormatConfiguration
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
            this.comboFormats = new System.Windows.Forms.ComboBox();
            this.panelFormatOptions = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // comboFormats
            // 
            this.comboFormats.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFormats.FormattingEnabled = true;
            this.comboFormats.Location = new System.Drawing.Point(0, 0);
            this.comboFormats.Name = "comboFormats";
            this.comboFormats.Size = new System.Drawing.Size(368, 21);
            this.comboFormats.TabIndex = 0;
            this.comboFormats.SelectedValueChanged += new System.EventHandler(this.comboFormats_SelectedValueChanged);
            // 
            // panelFormatOptions
            // 
            this.panelFormatOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormatOptions.Location = new System.Drawing.Point(0, 21);
            this.panelFormatOptions.Name = "panelFormatOptions";
            this.panelFormatOptions.Size = new System.Drawing.Size(368, 228);
            this.panelFormatOptions.TabIndex = 1;
            // 
            // SourceFormatConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelFormatOptions);
            this.Controls.Add(this.comboFormats);
            this.Name = "SourceFormatConfiguration";
            this.Size = new System.Drawing.Size(368, 249);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboFormats;
        private System.Windows.Forms.Panel panelFormatOptions;
    }
}
