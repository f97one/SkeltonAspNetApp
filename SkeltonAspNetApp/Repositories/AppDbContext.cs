using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SkeltonAspNetApp.Repositories
{
    /// <summary>
    /// Entity Framework Code First のDbContext
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// 接続文字列の名前を引数にとるコンストラクタ.
        /// </summary>
        public　AppDbContext() : base("DefaultContext") { }

        // TODO: DbSet のプロパティを定義する


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}