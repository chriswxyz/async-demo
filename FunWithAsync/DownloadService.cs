using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace FunWithAsync
{
    public class DownloadService
    {
        private WebClient _blockingClient;
        private HttpClient _asyncClient;

        public DownloadService()
        {
            _blockingClient = new WebClient();
            _asyncClient = new HttpClient();
        }

        public string GetSite(string site)
        {
            //Performs IO in a synchronous manner, freezing the UI.
            return _blockingClient.DownloadString(site);
        }

        public async Task<string> GetSiteAsync(string site)
        {
            //Starts asynchronous IO by delegating to lower level constructs
            //(all of which are naturally async).
            //No thread is blocked while this is being retrieved.
            return await _asyncClient.GetStringAsync(site);
        }
    }
}