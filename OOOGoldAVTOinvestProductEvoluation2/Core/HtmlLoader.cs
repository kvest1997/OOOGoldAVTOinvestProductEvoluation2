using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OOOGoldAVTOinvestProductEvoluation2.Core
{
    class HtmlLoader
    {
        readonly string url;
        readonly HttpClient client;

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            url = $"{settings.BaseUrl}/{settings.Prefix}/";

        }

        public async Task<string> GetSourceByPageId(int id)
        {
            var currentUrl = url.Replace("{Current.Id}", id.ToString());
            var response = await client.GetAsync(currentUrl);
            string source = null;
            
            if(response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }

            return source;
        }
    }
}
