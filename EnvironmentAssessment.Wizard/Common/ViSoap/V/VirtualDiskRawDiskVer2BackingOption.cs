namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualDiskRawDiskVer2BackingOption : VirtualDeviceDeviceBackingOption
	{
		protected ChoiceOption _descriptorFileNameExtensions;
		protected bool _uuid;
		public ChoiceOption DescriptorFileNameExtensions
		{
			get
			{
				return this._descriptorFileNameExtensions;
			}
			set
			{
				this._descriptorFileNameExtensions = value;
			}
		}
		public bool Uuid
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
	}
}
