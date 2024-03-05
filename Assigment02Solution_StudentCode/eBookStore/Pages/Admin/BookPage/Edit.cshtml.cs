using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using eBookStore.UrlAPI;
using Newtonsoft.Json;
using System.Text;

namespace eBookStore.Pages.Admin.BookPage
{
    public class EditModel : PageModel
    {     
        public EditModel()
        {          
        }

        [BindProperty]
        public Book Book { get; set; } = default!;
        public int? BookId { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            BookId = id;
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync((PathAPI.GETBOOKBYID + "/" + id).ToString());
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    Book = JsonConvert.DeserializeObject<Book>(jsonString);
                    if (Book == null)
                    {
                        return NotFound();
                    }
                }
            }
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            using (var httpClient = new HttpClient())
            {
                var jsonContent = JsonConvert.SerializeObject(Book);
                var stringContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await httpClient.PutAsync((PathAPI.UPDATEBOOK + "/" +Book.Bookid).ToString(), stringContent);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToPage("./Index");
                    // Xử lý khi thành công
                }
            }

            return RedirectToPage("./Index");
        }
    }
}
