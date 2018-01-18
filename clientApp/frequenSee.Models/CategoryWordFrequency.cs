using frequenSee.Common.Interfaces;

namespace frequenSee.Models
{
    public class CategoryWordFrequency : IModelBase
    {
        public CategoryWordFrequency(int id, FoundWord foundWord, int hits)
        {
            this.FrequencyId = id;
            this.FoundWord = foundWord;
            this.Hits = hits;
        }

        public int FrequencyId { get; set; }

        public FoundWord FoundWord { get; set; }

        public int Hits { get; set; }
    }
}
