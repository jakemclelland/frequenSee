using frequenSee.Common.Interfaces;

namespace frequenSee.Models
{
    public class FoundWord : IModelBase
    {
        public FoundWord(int id, string text)
        {
            this.WordId = id;
            this.Text = text;
        }

        public int WordId { get; set; }

        public string Text { get; set; }
    }
}
