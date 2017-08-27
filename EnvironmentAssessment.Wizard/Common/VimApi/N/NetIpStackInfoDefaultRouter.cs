using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class NetIpStackInfoDefaultRouter : DynamicData
	{
		protected string _ipAddress;
		protected string _device;
		protected DateTime _lifetime;
		protected string _preference;
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
		public string Device
		{
			get
			{
				return this._device;
			}
			set
			{
				this._device = value;
			}
		}
		public DateTime Lifetime
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
		public string Preference
		{
			get
			{
				return this._preference;
			}
			set
			{
				this._preference = value;
			}
		}
	}
}
