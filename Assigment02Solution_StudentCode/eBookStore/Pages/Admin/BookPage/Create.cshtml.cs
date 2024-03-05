using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BusinessObject.Models;
using Newtonsoft.Json;
using eBookStore.UrlAPI;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace eBookStore.Pages.Admin.BookPage
{
    public class CreateModel : PageModel
    {
        //private readonly BusinessObject.Models.ApplicationDbContext _context;

        //public CreateModel(BusinessObject.Models.ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        public async Task<IActionResult> OnGet()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(PathAPI.GETALLPULISHER);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    IList<Publisher> pulishers = JsonConvert.DeserializeObject<IList<Publisher>>(jsonString);
                    ViewData["Pub_id"] = new SelectList(pulishers, "Pub_id", "Publisher_name");
                }
            }
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; } = default!;
        public IList<Book> Books { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(PathAPI.GETALLBOOKS);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    Books = JsonConvert.DeserializeObject<IList<Book>>(jsonString);
                }
            }
            if (!ModelState.IsValid || Books == null || Book == null)
            {
                return Page();
            }

            using (var httpClient = new HttpClient())
            {
                var jsonContent = JsonConvert.SerializeObject(Book);
                var stringContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(PathAPI.CREATEBOOOK, stringContent);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToPage("./Index");
                    // Xử lý khi thành công
                }
            }
            //_context.Books.Add(Book);
            //await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
