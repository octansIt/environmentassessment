using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class ExpiredFeatureLicense : NotEnoughLicenses
	{
		protected string _feature;
		protected int _count;
		protected DateTime _expirationDate;
		public string Feature
		{
			get
			{
				return this._feature;
			}
			set
			{
				this._feature = value;
			}
		}
		public int Count
		{
			get
			{
				return this._count;
			}
			set
			{
				this._count = value;
			}
		}
		public DateTime ExpirationDate
		{
			get
			{
				return this._expirationDate;
			}
			set
			{
				this._expirationDate = value;
			}
		}
	}
}
