namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDeviceConfigSpecBackingSpec : DynamicData
	{
		protected VirtualDeviceConfigSpecBackingSpec _parent;
		protected CryptoSpec _crypto;
		public VirtualDeviceConfigSpecBackingSpec Parent
		{
			get
			{
				return this._parent;
			}
			set
			{
				this._parent = value;
			}
		}
		public CryptoSpec Crypto
		{
			get
			{
				return this._crypto;
			}
			set
			{
				this._crypto = value;
			}
		}
	}
}
