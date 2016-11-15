# SmartPaging
Simple library to implement pagination in .NET

```
Install-Package SmartPaging
```  

## Usage

After a `.OrderBy()` you can use the extension method `.GetPage()` passing the `PagingOptions` and that's all.  
  
Bellow a sample  

```csharp
using Run.Models;
using SmartPaging;
using System.Linq;
using System.Web.Mvc;

namespace Run.Controllers
{
    public class HomeController : Controller
    {
        private const int DEFAULT_PAGE_SIZE = 10;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contacts(int page = 1, int pageSize = DEFAULT_PAGE_SIZE)
        {
            // Create the PagingOptions object
            var pagingOptions = new PagingOptions
            {
                Page = page,
                PageSize = pageSize
            };

            // Generating a sample list to show
            var items = Enumerable.Range(1, 42)
                .Select(s => new Contact
                {
                    Id = s,
                    Name = $"Name {s}",
                    Description = $"Description {s}"
                })
                .ToList();

            // From full list, get the page
            var pageResult = items
                .OrderBy(o => o.Id) // Order the list to paginate
                .GetPage(pagingOptions) // Get page with PagingOptions before created
                .ToList();

            var pagedResult = new PagedResult<Contact>
            {
                Items = pageResult, // Items of a one page
                Count = items.Count // Total of items from full list
            };

            return Json(pagedResult, JsonRequestBehavior.AllowGet);
        }
    }
}
```
  
The front end needs to send the page number and the page size, or just the page number, to get the next page.  
  
Danke   
