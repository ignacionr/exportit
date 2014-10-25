using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using exportit.Sources;

namespace exportit.UI
{
    public partial class FileSystemConfiguration : UserControl
    {
        private FileSystemSpecification _value;

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
                this._value = value;
                this.textLocation.Text = value.Folder;
                this.textPattern.Text = value.Pattern;
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
    }
}
