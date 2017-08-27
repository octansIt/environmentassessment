namespace EnvironmentAssessment.Common.VimApi
{
	public class FileBackedVirtualDiskSpec : VirtualDiskSpec
	{
		protected long _capacityKb;
		protected VirtualMachineProfileSpec[] _profile;
		protected CryptoSpec _crypto;
		public long CapacityKb
		{
			get
			{
				return this._capacityKb;
			}
			set
			{
				this._capacityKb = value;
			}
		}
		public VirtualMachineProfileSpec[] Profile
		{
			get
			{
				return this._profile;
			}
			set
			{
				this._profile = value;
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
