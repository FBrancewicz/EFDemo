using EFDemo.Data;
using EFDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PeopleContext _context;

       
        public IndexModel(ILogger<IndexModel> logger,PeopleContext context )
        {
            _logger = logger;
            _context = context;
        }

        public IList<Person> People { get; set; }
        public void OnGet()
        {
            People = _context.Person.ToList();
        }
    }
}
