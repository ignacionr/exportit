namespace exportit
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    [Serializable]
    abstract public class SourceSpecification
    {
        public static Type[] AllTypes
        {
            get
            {
                return AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes()).Where(t => !t.IsAbstract && typeof(SourceSpecification).IsAssignableFrom(t)).ToArray();
            }
        }

        public abstract Control CreateEditor();

        public abstract Task ProcessContents(Action<Stream> doWithContents, int limit);
    }
}
