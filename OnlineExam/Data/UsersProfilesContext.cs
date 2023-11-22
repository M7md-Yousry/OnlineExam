using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UsersProfiles.Models;

namespace UsersProfile.Data
{
    public class UsersProfilesContext : DbContext
    {
        public UsersProfilesContext (DbContextOptions<UsersProfilesContext> options)
            : base(options)
        {
        }

        public DbSet<UsersProfiles.Models.Profiles> Profiles { get; set; } = default!;
    }
}
