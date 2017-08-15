namespace frequenSee.Models
{
    using System.Collections.Generic;
    using System.Text;

    public class WordFrequencyResultSet
    {
        private StringBuilder Cache { get; set; } = new StringBuilder();

        public SortedDictionary<string, CategoryWordFrequency> WordDictionary { get; set; } = new SortedDictionary<string, CategoryWordFrequency>();

        public ContentSource Source { get; set; } = new ContentSource();

        public void AppendSymbolToCache(char symbol)
        {
            this.Cache.Append(symbol.ToString());
        }

        public void ResetCache()
        {
            this.Cache = new StringBuilder();
        }

        public string CachOut()
        {
            return this.Cache.ToString();
        }
    }
}
