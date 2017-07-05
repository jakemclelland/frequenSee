namespace frequenSee.Models
{
    public class CategorySymbolFrequency
    {
        public int FrequencyId { get; set; }

        public FoundSymbol Symbol { get; set; }

        public int Hits { get; set; }
    }
}
