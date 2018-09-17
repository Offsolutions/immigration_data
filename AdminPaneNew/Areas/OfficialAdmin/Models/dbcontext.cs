using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AdminPaneNew.Areas.OfficialAdmin.Models
{
    public class dbcontext:DbContext
    {
        public dbcontext():base("dbcontext")
        {
           // Database.SetInitializer<dbcontext>(new CreateDatabaseIfNotExists<dbcontext>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<dbcontext, AdminPaneNew.Migrations.Configuration>("dbcontext"));
        }

        public System.Data.Entity.DbSet<AdminPaneNew.Areas.OfficialAdmin.Models.Contact> Contacts { get; set; }

        public System.Data.Entity.DbSet<AdminPaneNew.Areas.OfficialAdmin.Models.Account> Accounts { get; set; }

        public System.Data.Entity.DbSet<AdminPaneNew.Areas.OfficialAdmin.Models.StudentReg> StudentRegs { get; set; }

        public System.Data.Entity.DbSet<AdminPaneNew.Areas.OfficialAdmin.Models.fees> fees { get; set; }

        public System.Data.Entity.DbSet<AdminPaneNew.Areas.OfficialAdmin.Models.SingleFee> SingleFees { get; set; }

    }
}