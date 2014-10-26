using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace exportit.UI
{
    public partial class XmlFormatConfiguration : UserControl
    {
        private XmlDocument document;
        public XmlFormatConfiguration()
        {
            InitializeComponent();
        }

        public Sources.XmlFormatSpecification Format { get; set; }

        public byte[] Sample
        {
            set
            {
                var index = 0;
                var count = value.Length;
                // use past the encoding marker
                if (value[0] == 239 && value[1] == 187 && value[2] == 191)
                {
                    index += 3;
                    count -= 3;
                }
                var text = Encoding.UTF8.GetString(value, index, count);
                this.document = new XmlDocument();
                this.document.LoadXml(text);
                this.webBrowser1.DocumentText = this.document.OuterXml;
            }
        }
    }
}
