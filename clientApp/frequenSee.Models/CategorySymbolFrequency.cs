namespace frequenSee.Models
{
    public class CategorySymbolFrequency
    {
        public CategorySymbolFrequency(int id, FoundSymbol foundSymbol, int hits)
        {
            this.FrequencyId = id;
            this.FoundSymbol = foundSymbol;
            this.Hits = hits;
        }

        public int FrequencyId { get; set; }

        public FoundSymbol FoundSymbol { get; set; }

        public int Hits { get; set; }
    }
}
