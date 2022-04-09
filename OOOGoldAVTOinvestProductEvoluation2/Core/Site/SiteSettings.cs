

namespace OOOGoldAVTOinvestProductEvoluation2.Core.Site
{
    class SiteSettings : IParserSettings
    {
        static string nameType = "22";
        public string BaseUrl { get; set; } = "https://www.avito.ru/"
        public string Prefix { get; set; } = $"rossiya?q={nameType}";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
        }
}
