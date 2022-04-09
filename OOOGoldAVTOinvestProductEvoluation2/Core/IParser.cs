using AngleSharp.Html.Dom;

namespace OOOGoldAVTOinvestProductEvoluation2.Core
{
    interface IParser<T> where T: class
    {
        T Parser(IHtmlDocument documetn);
    }
}
