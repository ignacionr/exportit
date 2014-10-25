using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exportit
{
    public partial class MainForm : Form
    {
        JobSpecification job = new JobSpecification();
        public MainForm()
        {
            InitializeComponent();
            new IJobConfigurator[]{this.sourceSelection1}.ToList().ForEach(jc => jc.Job = job);
        }
    }
}
