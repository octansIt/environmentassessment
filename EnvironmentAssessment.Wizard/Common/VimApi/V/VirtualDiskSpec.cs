namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDiskSpec : DynamicData
	{
		protected string _diskType;
		protected string _adapterType;
		public string DiskType
		{
			get
			{
				return this._diskType;
			}
			set
			{
				this._diskType = value;
			}
		}
		public string AdapterType
		{
			get
			{
				return this._adapterType;
			}
			set
			{
				this._adapterType = value;
			}
		}
	}
}
