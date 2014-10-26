namespace exportit
{
    using System;
    using Sources;

    [Serializable]
    public class JobSpecification
    {
        public SourceSpecification Source;

        public SourceFormatSpecification Format { get; set; }
    }
}
