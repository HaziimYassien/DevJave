using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SnaptStories6.Models;

namespace SnaptStories6.Data
{
    public class SnaptStories6Context : DbContext
    {
        public SnaptStories6Context (DbContextOptions<SnaptStories6Context> options)
            : base(options)
        {
        }

        public DbSet<SnaptStories6.Models.author> author { get; set; } = default!;
        public DbSet<SnaptStories6.Models.ShortStory> ShortStory { get; set; } = default!;
    }
}
