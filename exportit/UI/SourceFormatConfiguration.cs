namespace exportit.UI
{
    using System;
    using System.Windows.Forms;
    using Sources;

    public partial class SourceFormatConfiguration : UserControl, IJobConfigurator
    {
        public SourceFormatConfiguration()
        {
            InitializeComponent();
            this.comboFormats.Items.AddRange(SourceFormatSpecification.AllTypes);
        }

        public JobSpecification Job {get;set;}

        private async void comboFormats_SelectedValueChanged(object sender, EventArgs e)
        {
            var formatType = (Type)this.comboFormats.SelectedItem;
            if (formatType != null)
            {
                this.Job.Format = (SourceFormatSpecification)formatType.GetConstructor(Type.EmptyTypes).Invoke(null);
                var sample = new byte[32000];
                await this.Job.Source.ProcessContents(s => Array.Resize(ref sample, s.Read(sample, 0, sample.Length)), 1);
                var editor = this.Job.Format.CreateEditor(sample);
                editor.Dock = DockStyle.Fill;
                this.panelFormatOptions.Controls.Clear();
                this.panelFormatOptions.Controls.Add(editor);
            }
        }
    }
}
