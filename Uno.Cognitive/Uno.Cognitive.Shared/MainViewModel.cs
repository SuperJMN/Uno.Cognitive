using System.Collections.Generic;
using System.Linq;
using ReactiveUI;

namespace Uno.Cognitive
{
    public class MainViewModel : ReactiveObject
    {
        private SectionViewModel selectedSection;

        public MainViewModel()
        {
            Sections = new List<SectionViewModel>
            {
                new ImageLoadingViewModel() {Name = "Image Loading"},
            };

            SelectedSection = Sections.First();
        }

        public List<SectionViewModel> Sections { get; }

        public SectionViewModel SelectedSection
        {
            get => selectedSection;
            set => this.RaiseAndSetIfChanged(ref selectedSection, value);
        }
    }
}