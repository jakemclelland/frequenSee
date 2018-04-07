namespace frequenSee.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class WordFrequencyResultSet
    {
        private StringBuilder Cache { get; set; } = new StringBuilder(100);

        public SortedDictionary<string, CategoryWordFrequency> WordDictionary { get; set; } = new SortedDictionary<string, CategoryWordFrequency>();

        public ContentSource Source { get; set; } = new ContentSource();

        public DateTime ProcessDate { get; private set; } = DateTime.Now;

        // TODO: Move these methods out of the model!!!
        public void AppendSymbolToCache(char symbol)
        {
            this.Cache.Append(symbol.ToString());
        }

        public void ResetCache(int size = 100)
        {
            this.Cache = new StringBuilder(size);
        }

        public string CachOut()
        {
            return this.Cache.ToString();
        }
    }
}
