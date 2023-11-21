using CrudApp.Data;
using CrudApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrudApp.Pages.Admin.Blogs
{
    public class EditModel : PageModel
    {
        private readonly CrudAppDbContext crudAppDbContext;

        public EditModel(CrudAppDbContext crudAppDbContext)
        {
            this.crudAppDbContext = crudAppDbContext;
        }
        [BindProperty]
        public BlogPost blogPost { get; set; }
        public void OnGet(Guid id)
        {
            blogPost = crudAppDbContext.BlogPosts.Find(id);
        }

        public IActionResult OnPost()
        {
            var existingblogPost = crudAppDbContext.BlogPosts.Find(blogPost.Id);
            if (existingblogPost != null)
            {
                existingblogPost.Name = blogPost.Name;
                existingblogPost.Age = blogPost.Age;
                existingblogPost.Gender = blogPost.Gender;
                existingblogPost.Email = blogPost.Email;
                existingblogPost.PhoneNumber = blogPost.PhoneNumber;
                existingblogPost.Country = blogPost.Country;
                existingblogPost.State = blogPost.State;
            }
            crudAppDbContext.SaveChanges();
            return RedirectToPage("/Admin/Blogs/List");
        }
    }
}
