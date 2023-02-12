﻿using System;

namespace ChainConstructors.MyWork
{
    public class Loan
    {
        private readonly CapitalStrategy _strategy;
        private float _notional;
        private float _outstanding;
        private int _rating;
        private DateTime _expiry;
        private DateTime? _maturity;

        public Loan(float notional, float outstanding, int rating, DateTime expiry): 
	        this(new TermROC(), notional, outstanding, rating, expiry, null)
        {

        }

        public Loan(float notional, float outstanding, int rating, DateTime expiry, DateTime? maturity) :
	        this(new RevolvingTermROC(), notional, outstanding, rating, expiry, maturity)
        {

        }

        public Loan(CapitalStrategy strategy, float notional, float outstanding, 
                    int rating, DateTime expiry, DateTime? maturity)
        {
            this._strategy = strategy;
            this._notional = notional;
            this._outstanding = outstanding;
            this._rating = rating;
            this._expiry = expiry;
            this._maturity = maturity;
        }

		public CapitalStrategy CapitalStrategy
		{
			get
			{
				return _strategy;
			}
		}

		private float CalculateOutstandingBalance(float balance)
		{

			this._rating = 9;
			return 0.0f;
		}
		
    }
}