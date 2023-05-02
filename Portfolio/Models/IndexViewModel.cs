namespace Portfolio.Models
{
    public class IndexViewModel
    {
        public MastheadViewModel Masthead { get; set; }
        public AboutViewModel About { get; set; }
        public bool ShowServices { get; set; } = true;
        public bool ShowPortfolio { get; set; } = true;
        public bool ShowCallToAction { get; set; } = true;
        public bool ShowContact { get; set; } = true;

        public IndexViewModel(IConfiguration configuration)
        {
            Masthead = new MastheadViewModel(configuration);
            About = new AboutViewModel(configuration);
        }
    }
}
