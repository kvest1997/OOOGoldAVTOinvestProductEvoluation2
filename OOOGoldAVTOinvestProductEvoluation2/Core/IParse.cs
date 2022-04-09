using AngleSharp.Html.Dom;

namespace OOOGoldAVTOinvestProductEvoluation2.Core
{
    interface IParse<T> where T: class
    {
        T Parse(IHtmlDocument documetn);
    }
}
