using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class HostIpConfigIpV6Address : DynamicData
	{
		protected string _ipAddress;
		protected int _prefixLength;
		protected string _origin;
		protected string _dadState;
		protected DateTime? _lifetime;
		protected string _operation;
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
		public string DadState
		{
			get
			{
				return this._dadState;
			}
			set
			{
				this._dadState = value;
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
		public string Operation
		{
			get
			{
				return this._operation;
			}
			set
			{
				this._operation = value;
			}
		}
	}
}
