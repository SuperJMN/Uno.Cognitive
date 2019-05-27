using ReactiveUI;

namespace Uno.Cognitive
{
    public class ImageLoadingViewModel : SectionViewModel
    {
        private string imageUrl;

        public string ImageUrl
        {
            get => imageUrl;
            set => this.RaiseAndSetIfChanged(ref imageUrl, value);
        }
    }
}