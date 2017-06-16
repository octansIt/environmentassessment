using System;
namespace EnvironmentAssessment.Common.VISoap
{
	public class NetIpConfigInfoIpAddress : DynamicData
	{
		protected string _ipAddress;
		protected int _prefixLength;
		protected string _origin;
		protected string _state;
		protected DateTime? _lifetime;
		public string IpAddress
		{
			get
			{
				return this._ipAddress;
			}
			set
			{
				this._ipAddress = value;
			}
		}
		public int PrefixLength
		{
			get
			{
				return this._prefixLength;
			}
			set
			{
				this._prefixLength = value;
			}
		}
		public string Origin
		{
			get
			{
				return this._origin;
			}
			set
			{
				this._origin = value;
			}
		}
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}
		public DateTime? Lifetime
		{
			get
			{
				return this._lifetime;
			}
			set
			{
				this._lifetime = value;
			}
		}
	}
}
