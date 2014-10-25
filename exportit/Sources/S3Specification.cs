namespace exportit.Sources
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class S3Specification: SourceSpecification
    {
        public override System.Windows.Forms.Control CreateEditor()
        {
            return new S3Configuration();
        }

        public override Task ProcessContents(Action<System.IO.Stream> doWithContents)
        {
            throw new NotImplementedException();
        }
    }
}
