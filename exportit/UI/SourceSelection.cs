namespace exportit
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class SourceSelection : UserControl, IJobConfigurator
    {
        private Control editor;
        public SourceSelection()
        {
            InitializeComponent();
            this.comboSourceTypes.Items.AddRange(SourceSpecification.AllTypes);
        }

        Type SelectedType
        {
            get
            {
                return (Type)this.comboSourceTypes.SelectedItem;
            }
        }

        private void comboSourceTypes_SelectedValueChanged(object sender, EventArgs e)
        {
            this.Job.Source = (SourceSpecification)this.SelectedType.GetConstructor(Type.EmptyTypes).Invoke(null);
            this.pnlEditorContainer.Controls.Clear();
            if (editor != null)
            {
                editor.Dispose();
                this.editor = null;
            }
            this.editor = this.Job.Source.CreateEditor();
            editor.Dock = DockStyle.Fill;
            this.pnlEditorContainer.Controls.Add(editor);
        }

        public JobSpecification Job { get; set; }
    }
}
