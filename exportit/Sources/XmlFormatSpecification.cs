namespace exportit.Sources
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using exportit.UI;

    [Serializable]
    public class XmlFormatSpecification: SourceFormatSpecification
    {
        public override System.Windows.Forms.Control CreateEditor(byte[] sample)
        {
            var editor = new XmlFormatConfiguration()
            {
                Format = this,
                Sample = sample,
            };
            return editor;
        }
    }
}
