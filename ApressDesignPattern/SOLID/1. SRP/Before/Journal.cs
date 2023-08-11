namespace ApressDesignPattern.SOLID.SRP.Before
{
    internal class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;

        public void AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }
        public void Save(string filename, bool overwrite = false)
        {
            File.WriteAllText(filename, ToString());
        }
    }
}
