using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Auth.Infrastructure.Configurations
{
      public class AuthContext : DbContext
    {
        public AuthContext(DbContextOptions<AuthContext> options) : base(options) {}

    }

}