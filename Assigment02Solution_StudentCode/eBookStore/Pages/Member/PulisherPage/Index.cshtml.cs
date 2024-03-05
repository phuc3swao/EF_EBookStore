using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using eBookStore.UrlAPI;
using Newtonsoft.Json;

namespace eBookStore.Pages.Member.PulisherPage
{
    public class IndexModel : PageModel
    {
        public IndexModel()
        {
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(PathAPI.GETALLPULISHER);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    Publisher = JsonConvert.DeserializeObject<IList<Publisher>>(jsonString);
                }
            }
        }
    }
}
