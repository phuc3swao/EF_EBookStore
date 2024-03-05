using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using eBookStore.UrlAPI;
using Newtonsoft.Json;

namespace eBookStore.Pages.Admin.AuthorPage
{
    public class IndexModel : PageModel
    {
        public IndexModel()
        {
        }

        public IList<Author> Author { get; set; } = default!;

        public async Task OnGetAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(PathAPI.AUTHOR);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    Author = JsonConvert.DeserializeObject<IList<Author>>(jsonString);
                }
            }
        }
    }
}
