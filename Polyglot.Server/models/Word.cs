using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Polyglot.Server.models
{
    public class Word
    {
        public string PolishTranslation { get; set; }
        public Language Language { get; set; }
        public string Translation { get; set; }
    }

    public class WordItem
    {
        public int Id { get; set; }
        public Word Word { get; set; }
        public int Priority {  get; set; }
        public bool NeedToBeStudied { get; set; }
        //need to be learned
        //set priority
    }
}
