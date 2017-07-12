using System;

namespace ReplaceConstructorsWithCreationMethods.MyWork
{
	public class Loan
	{
		private double _commitment;
		private readonly double _outstanding;
		private readonly int _riskRating;
		private readonly DateTime? _maturity;
		private readonly DateTime? _expiry;
		private readonly CapitalStrategy _capitalStrategy;

		public Loan(CapitalStrategy capitalStrategy, double commitment,
					double outstanding, int riskRating,
                    DateTime? maturity, DateTime? expiry)
		{
			this._commitment = commitment;
			this._outstanding = outstanding;
			this._riskRating = riskRating;
			this._maturity = maturity;
			this._expiry = expiry;
			this._capitalStrategy = capitalStrategy;
		}

		public CapitalStrategy CapitalStrategy
		{
			get
			{
				return _capitalStrategy;
			}
		}

		public static Loan CreateTermLoan(double commitment, int riskRating, DateTime? maturity)
		{
			Loan loan = new Loan(new CapitalStrategyTermLoan(), commitment, 0.00, riskRating, maturity, null);
			return loan;
		}

		public static Loan CreateRevolverLoan(double commitment, int riskRating, DateTime? maturity, DateTime? expiry)
		{
			Loan loan = new Loan(new CapitalStrategyRevolver(), commitment, 0.00, riskRating, maturity, expiry);
			return loan;
		}

		public static Loan CreateRCTLLoan(double commitment, double outstanding, int riskRating, DateTime? maturity, DateTime? expiry)
		{
			Loan loan = new Loan(new CapitalStrategyRCTL(), commitment, outstanding, riskRating, maturity, expiry);
			return loan;
		}
	}
}