﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApplication1.Identity
{
    public class AppDBContext: IdentityDbContext<AppUser>
    {
        public AppDBContext() : base("MyConnectionString") { }
    }
}