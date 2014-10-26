namespace exportit.Sources
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    [Serializable]
    public abstract class SourceFormatSpecification
    {
        public static Type[] AllTypes
        {
            get
            {
                return AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes()).Where(t => !t.IsAbstract && typeof(SourceFormatSpecification).IsAssignableFrom(t)).ToArray();
            }
        }
        public abstract Control CreateEditor(byte[] sample);
    }
}
