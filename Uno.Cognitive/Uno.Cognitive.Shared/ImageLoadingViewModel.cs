using ReactiveUI;

namespace Uno.Cognitive
{
    public class ImageLoadingViewModel : SectionViewModel
    {
        public ImageLoadingViewModel()
        {
            ImageUrl = "http://orig04.deviantart.net/e05a/f/2016/356/7/7/another_classic_sonic_render_by_alsyouri2001-dasito3.png";
        }

        private string imageUrl;

        public string ImageUrl
        {
            get => imageUrl;
            set => this.RaiseAndSetIfChanged(ref imageUrl, value);
        }
    }
}