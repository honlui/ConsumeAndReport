using System;
using System.Collections.Generic;


namespace Investment
{
    public class RawTransactions
    {
        [Key]
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
    }

    public class Salesperson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Trade> Trades { get; set; }
    }

    public class Investor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Trade> Trades { get; set; }
    }
}
