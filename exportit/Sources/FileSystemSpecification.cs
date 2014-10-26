namespace exportit.Sources
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using exportit.UI;

    [Serializable]
    public class FileSystemSpecification: SourceSpecification
    {
        public override System.Windows.Forms.Control CreateEditor()
        {
            var editor = new FileSystemConfiguration()
            {
                Value = this
            };
            return editor;
        }

        public string Folder { get; set; }

        public string Pattern { get; set; }

        public override Task ProcessContents(Action<System.IO.Stream> doWithContents, int limit)
        {
            return Task.Run(() =>
            {
                Directory.GetFiles(this.Folder, this.Pattern)
                    .Take(limit)
                    .AsParallel()
                    .ForAll(fileName =>
                    {
                        using (var str = File.OpenRead(fileName))
                        {
                            doWithContents(str);
                        }
                    });
            });
        }
    }
}
