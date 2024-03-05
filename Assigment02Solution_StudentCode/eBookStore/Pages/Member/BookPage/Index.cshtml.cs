using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using Newtonsoft.Json;
using eBookStore.UrlAPI;

namespace eBookStore.Pages.Member.BookPage
{
    public class IndexModel : PageModel
    {
        //private readonly BusinessObject.Models.ApplicationDbContext _context;

        public IndexModel()
        {
            
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(PathAPI.GETALLBOOKS);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    Book = JsonConvert.DeserializeObject<IList<Book>>(jsonString);
                }
            }
        }

        [BindProperty(SupportsGet = true)]
        public string SearchTitle { get; set; }

        [BindProperty(SupportsGet = true)]
        public decimal? MinPrice { get; set; }

        [BindProperty(SupportsGet = true)]
        public decimal? MaxPrice { get; set; }

        public async Task OnPostAsync()
        {
            var PATH = PathAPI.FILTERBOOKODATA;
            if (!string.IsNullOrEmpty(SearchTitle))
            {
                PATH += PathAPI.BOOK_FILTER_TITLE + " and " + PathAPI.BOOK_FILTER_PRICE;
                PATH = PATH.Replace("TITLE", SearchTitle);
            }
            else
            {
                PATH += PathAPI.BOOK_FILTER_PRICE;
            }
            if (MinPrice == null)
            {
                PATH = PATH.Replace("Min", "0");
            }
            else
            {
                PATH = PATH.Replace("Min", MinPrice.ToString());
            }
            if (MaxPrice == null)
            {
                PATH = PATH.Replace("Max", int.MaxValue.ToString());
            }
            else
            {
                PATH = PATH.Replace("Max", MaxPrice.ToString());
            }

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(PATH);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    Book = JsonConvert.DeserializeObject<IList<Book>>(jsonString);
                }
            }
        }
    }
}

