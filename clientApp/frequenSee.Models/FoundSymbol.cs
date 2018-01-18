using frequenSee.Common.Interfaces;

namespace frequenSee.Models
{
    public class FoundSymbol : IModelBase
    {
        public FoundSymbol(int id, string symbol)
        {
            this.SymbolId = id;
            this.Symbol = symbol;
        }

        public int SymbolId { get; set; }

        public string Symbol { get; set; }
    }
}
