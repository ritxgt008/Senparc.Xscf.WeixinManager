﻿using Microsoft.EntityFrameworkCore;
using Senparc.Scf.XscfBase;
using Senparc.Scf.XscfBase.Database;
using Senparc.Xscf.WeixinManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Senparc.Xscf.WeixinManager
{
    public class WeixinSenparcEntities : XscfDatabaseDbContext
    {
        public DbSet<MpAccount> MpAccounts { get; set; }

        public WeixinSenparcEntities(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        public override IXscfDatabase XscfDatabaseRegister => new Register();
    }
}
