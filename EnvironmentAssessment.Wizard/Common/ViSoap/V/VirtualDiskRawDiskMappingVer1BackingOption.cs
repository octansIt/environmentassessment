namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualDiskRawDiskMappingVer1BackingOption : VirtualDeviceDeviceBackingOption
	{
		protected ChoiceOption _descriptorFileNameExtensions;
		protected ChoiceOption _compatibilityMode;
		protected ChoiceOption _diskMode;
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
		public ChoiceOption CompatibilityMode
		{
			get
			{
				return this._compatibilityMode;
			}
			set
			{
				this._compatibilityMode = value;
			}
		}
		public ChoiceOption DiskMode
		{
			get
			{
				return this._diskMode;
			}
			set
			{
				this._diskMode = value;
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
