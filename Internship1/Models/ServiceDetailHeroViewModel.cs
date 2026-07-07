namespace Internship1.Models
{
    public class ServiceDetailHeroViewModel
    {
        public string Eyebrow { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string HighlightedTitle { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string PrimaryButtonText { get; set; } = string.Empty;

        public string PanelLabel { get; set; } = string.Empty;

        public string PanelTitle { get; set; } = string.Empty;

        public List<ServiceDetailHeroItemViewModel> PanelItems { get; set; } = [];
    }

    public class ServiceDetailHeroItemViewModel
    {
        public int Number { get; set; }

        public string Text { get; set; } = string.Empty;
    }
}