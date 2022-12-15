namespace FileChecksum.WindowsForms
{
    internal record ChecksumRecord
    {
        internal DateTime CreatedAt { get; }
        internal string FileName { get; }
        internal string Checksum { get; }

        internal ChecksumRecord(DateTime createdAt, string fileName, string checksum)
        {
            CreatedAt = createdAt;
            FileName = fileName;
            Checksum = checksum;
        }

        public override string ToString()
        {
            return CreatedAt.ToString() + '|' + FileName + '|' + Checksum;
        }
    }
}
