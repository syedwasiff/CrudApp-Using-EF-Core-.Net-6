using CrudApp.Data;
using CrudApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrudApp.Pages.Admin.Blogs
{
    public class AddModel : PageModel
    {
        private readonly CrudAppDbContext crudAppDbContext;

        [BindProperty]
        public VMAddBlogPost AddBlogPostRequest { get; set; }

        public AddModel(CrudAppDbContext crudAppDbContext)
        {
            this.crudAppDbContext = crudAppDbContext;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var blogPost = new BlogPost()
            {
                Name = AddBlogPostRequest.Name,
                Age = AddBlogPostRequest.Age,                
                Gender = AddBlogPostRequest.Gender,
                Email = AddBlogPostRequest.Email,
                PhoneNumber = AddBlogPostRequest.PhoneNumber,
                Country = AddBlogPostRequest.Country,
                State = AddBlogPostRequest.State                
            };

            crudAppDbContext.BlogPosts.Add(blogPost);
            crudAppDbContext.SaveChanges();
            return RedirectToPage("/Admin/Blogs/List");
        }
    }
}
