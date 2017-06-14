using System;

namespace ReplaceConstructorsWithCreationMethods
{
	public class Loan
	{
		private double commitment;
		readonly double outstanding;
		readonly int riskRating;
		readonly DateTime maturity;
		readonly DateTime expiry;
		readonly CapitalStrategy capitalStrategy;

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
			this.commitment = commitment;
			this.outstanding = outstanding;
			this.riskRating = riskRating;
			this.maturity = maturity;
			this.expiry = expiry;
			this.capitalStrategy = capitalStrategy;

			if (capitalStrategy == null)
			{
				if (expiry == DateTime.MinValue)
					this.capitalStrategy = new CapitalStrategyTermLoan();
				else if (maturity == DateTime.MinValue)
					this.capitalStrategy = new CapitalStrategyRevolver();
				else
					this.capitalStrategy = new CapitalStrategyRCTL();
			}
		}
	}
}