using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestingModels
{
    public class RawTransactions
    {        
        public int Id { get; set; }
        public string TransactionDTime { get; set; }
        public string TransactionType { get; set; }
        public string ShareCount { get; set; }
        public string SharePrice { get; set; }
        public string FundName { get; set; }
        public string InvestorName { get; set; }
        public string SalesRepresentativeName { get; set; }
    }

    public class Trade
    {
        public enum enumType
        {
            Buy, Sell
        }

        public int Id { get; set; }
        public DateTime TradeDTime { get; set; }
        public enumType TradeType { get; set; }
        public decimal ShareCount { get; set; }
        public decimal SharePrice { get; set; }

        public virtual Fund Fund { get; set; }
        public virtual Salesperson Salesperson { get; set; }
        public virtual Investor Investor { get; set; }
    }

    public class Fund
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Trade> Trades { get; set; }

        public Fund()
        {
            Trades = new List<Trade>();
        }
    }

    public class Salesperson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Trade> Trades { get; set; }

        public Salesperson()
        {
            Trades = new List<Trade>();
        }
    }

    public class Investor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Trade> Trades { get; set; }

        public Investor()
        {
            Trades = new List<Trade>();
        }
    }
}
