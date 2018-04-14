using frequenSee.Data.Interfaces;

namespace frequenSee.Models
{
    public class CategorySymbolFrequency : ICategorySymbolFrequency
    {
        public CategorySymbolFrequency(int id, FoundSymbol foundSymbol, int hits)
        {
            this.FrequencyId = id;
            this.FoundSymbol = foundSymbol;
            this.Hits = hits;
        }

        public int FrequencyId { get; set; }

        public FoundSymbol FoundSymbol { get; set; }

        public int? FoundSymbolId
        {
            get
            {
                return FoundSymbol?.SymbolId;
            }
        }

        public string DisplayText
        {
            get
            {
                return FoundSymbol?.Symbol;
            }
        }

        public int Hits { get; set; }
    }
}
