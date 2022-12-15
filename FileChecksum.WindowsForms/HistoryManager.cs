namespace FileChecksum.WindowsForms
{
    internal static class HistoryManager
    {
        private static readonly string PATH;
        private static List<ChecksumRecord> _checksumRecords;

        static HistoryManager()
        {
            PATH = Directory.GetCurrentDirectory() + "/history/history.txt";
            _checksumRecords = new List<ChecksumRecord>();
        }

        public static IEnumerable<ChecksumRecord> GetRecords()
        {
            return _checksumRecords;
        }

        internal static void Initialize()
        {
            if (!Directory.Exists("/history")) Directory.CreateDirectory("history");

            if (!File.Exists(PATH)) File.WriteAllText(PATH, string.Empty);
            else
            {
                var records = File.ReadAllLines(PATH);

                foreach (var record in records)
                {
                    var splittedRecord = record.Split('|');

                    AddRecord(
                        createdAt: DateTime.Parse(splittedRecord[0]),
                        fileName: splittedRecord[1],
                        checksum: splittedRecord[2]);
                }

                SortRecords();
            }
        }

        internal static void AddRecord(DateTime createdAt, string fileName, string checksum)
        {
            _checksumRecords.Add(new ChecksumRecord(createdAt, fileName, checksum));
        }

        internal static void SortRecords()
        {
            _checksumRecords = _checksumRecords.OrderByDescending(record => record.CreatedAt).ToList();
        }

        internal static void SaveRecords()
        {
            var strings = _checksumRecords.Select(record => record.ToString());

            File.WriteAllLines(PATH, strings);
        }
    }
}
