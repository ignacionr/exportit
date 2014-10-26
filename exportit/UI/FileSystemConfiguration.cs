namespace exportit.UI
{
    using System;
    using System.Windows.Forms;
    using exportit.Sources;

    public partial class FileSystemConfiguration : UserControl
    {
        private FileSystemSpecification _value;
        private bool _frozen;

        public FileSystemConfiguration()
        {
            InitializeComponent();
        }

        public FileSystemSpecification Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._frozen = true;
                this._value = value;
                this.textLocation.Text = value.Folder;
                this.textPattern.Text = value.Pattern;
                this._frozen = false;
            }
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.textLocation.Text = 
                    this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void textLocation_TextChanged(object sender, EventArgs e)
        {
            if (!this._frozen) this.Commit();
        }

        private void Commit()
        {
            this.Value.Folder = this.textLocation.Text;
            this.Value.Pattern = this.textPattern.Text;
        }
    }
}
