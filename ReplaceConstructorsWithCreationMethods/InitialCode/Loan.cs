using System;

namespace ReplaceConstructorsWithCreationMethods.InitialCode
{
	public class Loan
	{
		private double _commitment;
		readonly double _outstanding;
		readonly int _riskRating;
		readonly DateTime _maturity;
		readonly DateTime _expiry;
		readonly CapitalStrategy _capitalStrategy;

		public Loan(double commitment, int riskRating, DateTime maturity)
			: this(commitment, 0.00, riskRating, maturity, DateTime.MinValue)
		{

		}

		public Loan(double commitment, int riskRating,
					DateTime maturity, DateTime expiry)
			: this(commitment, 0.00, riskRating, maturity, expiry)
		{

		}

		public Loan(double commitment, double outstanding, int riskRating,
					DateTime maturity, DateTime expiry)
			: this(null, commitment, outstanding, riskRating, maturity, expiry)
		{

		}

		public Loan(CapitalStrategy capitalStrategy, double commitment,
					int riskRating, DateTime maturity, DateTime expiry)
			: this(capitalStrategy, commitment,
				   0.00, riskRating, maturity, expiry)
		{

		}

		public Loan(CapitalStrategy capitalStrategy, double commitment,
					double outstanding, int riskRating, DateTime maturity,
					DateTime expiry)
		{
			this._commitment = commitment;
			this._outstanding = outstanding;
			this._riskRating = riskRating;
			this._maturity = maturity;
			this._expiry = expiry;
			this._capitalStrategy = capitalStrategy;

			if (capitalStrategy == null)
			{
				if (expiry == DateTime.MinValue)
					this._capitalStrategy = new CapitalStrategyTermLoan();
				else if (maturity == DateTime.MinValue)
					this._capitalStrategy = new CapitalStrategyRevolver();
				else
					this._capitalStrategy = new CapitalStrategyRCTL();
			}
		}
	}
}