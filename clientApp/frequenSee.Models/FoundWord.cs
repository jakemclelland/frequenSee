using frequenSee.Data.Interfaces;

namespace frequenSee.Models
{
    public class FoundWord : IFoundWord
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
