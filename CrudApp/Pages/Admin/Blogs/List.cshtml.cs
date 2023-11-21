using CrudApp.Data;
using CrudApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrudApp.Pages.Admin.Blogs
{
    public class ListModel : PageModel
    {
        private readonly CrudAppDbContext crudAppDbContext;
        public ListModel(CrudAppDbContext crudAppDbContext)
        {
            this.crudAppDbContext = crudAppDbContext;
        }
        public List<BlogPost> BlogPosts { get; set; }
        public void OnGet()
        {
            BlogPosts = crudAppDbContext.BlogPosts.ToList();
        }

        public IActionResult OnPostDelete(Guid Id)
        {
            var ExistingBlogPost = crudAppDbContext.BlogPosts.Find(Id);
            if (ExistingBlogPost != null)
            {
                crudAppDbContext.BlogPosts.Remove(ExistingBlogPost);
                crudAppDbContext.SaveChanges();

            }
            return RedirectToPage("/Admin/Blogs/List");
        }
    }
}
