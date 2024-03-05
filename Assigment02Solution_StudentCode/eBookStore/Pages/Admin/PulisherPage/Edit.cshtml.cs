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

namespace eBookStore.Pages.Admin.PulisherPage
{
    public class EditModel : PageModel
    {
        public EditModel()
        {
        }

        [BindProperty]
        public Publisher Publisher { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync((PathAPI.GETPULISHERBYID + "/" + id).ToString());
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    Publisher = JsonConvert.DeserializeObject<Publisher>(jsonString);
                    if (Publisher == null)
                    {
                        return NotFound();
                    }
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
                var jsonContent = JsonConvert.SerializeObject(Publisher);
                var stringContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await httpClient.PutAsync((PathAPI.UPDATEPULISHER + "/" + Publisher.Pub_id).ToString(), stringContent);
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
