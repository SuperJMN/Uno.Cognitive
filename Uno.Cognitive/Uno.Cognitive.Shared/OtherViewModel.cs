using ReactiveUI;

namespace Uno.Cognitive
{
    public class OtherViewModel : SectionViewModel
    {
        public OtherViewModel()
        {
            ImageUrl = "http:\\otro";
        }

        private string imageUrl;

        public string ImageUrl
        {
            get => imageUrl;
            set => this.RaiseAndSetIfChanged(ref imageUrl, value);
        }
    }
}