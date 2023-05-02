namespace Portfolio.Models
{
    public abstract class PartialBase
    {
        public bool Show { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string CTAText { get; set; }
        public string CTAUrl { get; set; }
        public bool ShowCTA { get; set; }

        public PartialBase(IConfiguration _configuration, string partial_name)
        {
            Title = _configuration.GetValue<string>("Settings:" + partial_name + ":Title");
            SubTitle = _configuration.GetValue<string>("Settings:" + partial_name + ":SubTitle");
            CTAText = _configuration.GetValue<string>("Settings:" + partial_name + ":CTA:Text");
            CTAUrl = _configuration.GetValue<string>("Settings:" + partial_name + ":CTA:Url");
            ShowCTA = _configuration.GetValue<bool>("Settings:" + partial_name + ":CTA:Show");
            Show = _configuration.GetValue<bool>("Settings:" + partial_name + ":Show");
        }
    }

    public class MastheadViewModel : PartialBase
    {
        public MastheadViewModel(IConfiguration _configuration) : base(_configuration, "Masthead") { }
    }

    public class AboutViewModel : PartialBase
    {
        public AboutViewModel(IConfiguration _configuration) : base(_configuration, "About") { }
    }
}
