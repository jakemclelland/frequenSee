namespace frequenSee.Models
{
    public class FrequencyResultSet
    {
        public SymbolFrequencyResultSet FoundSymbolFrequencyResultSet { get; set; } = new SymbolFrequencyResultSet();

        public WordFrequencyResultSet FoundWordFrequencyResultSet { get; set; } = new WordFrequencyResultSet();

        public ContentSource Source { get; set; } = new ContentSource();
    }

}
