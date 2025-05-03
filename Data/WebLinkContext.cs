using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebLink.Models;

namespace WebLink.Data
{
    public class WebLinkContext : DbContext
    {
        public WebLinkContext (DbContextOptions<WebLinkContext> options)
            : base(options)
        {
        }

        public DbSet<WebLink.Models.Item> Item { get; set; } = default!;
    }
}
