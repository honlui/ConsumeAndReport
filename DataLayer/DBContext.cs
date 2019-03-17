using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestingModels;

namespace DataLayer
{
    public partial class InvestmentDBContext : DbContext
    {
        public InvestmentDBContext()
            : base("Name=Investment")//this is the connection string name
        {
        }

        public DbSet<RawTransactions> RawTransactions { get; set; }
        public DbSet<Trade> Trades { get; set; }
        public DbSet<Fund> Funds { get; set; }
        public DbSet<Salesperson> Salespeople { get; set; }
        public DbSet<Investor> Investors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // TODO: add Foreign Key constraints here...

            modelBuilder.Configurations.Add(new FundConfig());
            //modelBuilder.Configurations.Add(new SalespersonConfig());
            //modelBuilder.Configurations.Add(new InvestorConfig());
            //modelBuilder.Configurations.Add(new TradeConfig());
        }

        static InvestmentDBContext()
        {            
            // TODO: code first is fast, but add safeguards to avoid dropping tables in production...

            Database.SetInitializer<InvestmentDBContext>(new CreateDatabaseIfNotExists<InvestmentDBContext>()); 
            //Database.SetInitializer<InvestmentDBContext>(new DropCreateDatabaseAlways<InvestmentDBContext>); 
            //Database.SetInitializer<InvestmentDBContext>(new DropCreateDatabaseIfModelChanges<InvestmentDBContext>);
        }
    }
}
