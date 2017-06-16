namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualDiskRawDiskVer2BackingInfo : VirtualDeviceDeviceBackingInfo
	{
		protected string _descriptorFileName;
		protected string _uuid;
		protected string _changeId;
		protected string _sharing;
		public string DescriptorFileName
		{
			get
			{
				return this._descriptorFileName;
			}
			set
			{
				this._descriptorFileName = value;
			}
		}
		public string Uuid
		{
			get
			{
				return this._uuid;
			}
			set
			{
				this._uuid = value;
			}
		}
		public string ChangeId
		{
			get
			{
				return this._changeId;
			}
			set
			{
				this._changeId = value;
			}
		}
		public string Sharing
		{
			get
			{
				return this._sharing;
			}
			set
			{
				this._sharing = value;
			}
		}
	}
}
