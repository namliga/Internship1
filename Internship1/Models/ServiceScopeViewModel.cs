namespace Internship1.Models
{
    public class ServiceScopeViewModel
    {
        public string Eyebrow { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string HighlightedTitle { get; set; } = string.Empty;

        public string TitleSuffix { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public List<ServiceScopeItemViewModel> Items { get; set; } = [];
    }

    public class ServiceScopeItemViewModel
    {
        public int Number { get; set; }

        public string Label { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}