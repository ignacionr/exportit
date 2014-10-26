namespace exportit
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        JobSpecification job = new JobSpecification();
        private string jobFile;
        public MainForm()
        {
            InitializeComponent();
            ConfigurePropertySheets();
        }

        private void ConfigurePropertySheets()
        {
            new IJobConfigurator[] { this.sourceSelection1, this.sourceFormatConfiguration1 }.ToList().ForEach(jc => jc.Job = job);
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                this.jobFile = this.openFileDialog1.FileName;
                using (var s = File.OpenRead(this.jobFile))
                {
                    var fmtr = new BinaryFormatter();
                    job = (JobSpecification)fmtr.Deserialize(s);
                    this.ConfigurePropertySheets();
                }
            }
        }

        private void saveasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                this.jobFile = this.saveFileDialog1.FileName;
                DoSave();
            }
        }

        private void DoSave()
        {
            using (var s = File.OpenWrite(this.jobFile))
            {
                var fmtr = new BinaryFormatter();
                fmtr.Serialize(s, this.job);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.jobFile))
            {
                this.saveasToolStripMenuItem_Click(sender, e);
            }
            else
            {
                this.DoSave();
            }
        }

        private void exiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
