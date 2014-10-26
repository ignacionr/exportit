namespace exportit.Sources
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [Serializable]
    public class CSVFormatSpecification: SourceFormatSpecification
    {
        public override System.Windows.Forms.Control CreateEditor(byte[] sample)
        {
            throw new NotImplementedException();
        }
    }
}
