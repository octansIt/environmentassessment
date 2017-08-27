namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVirtualNicManagerNicTypeSelection : DynamicData
	{
		protected HostVirtualNicConnection _vnic;
		protected string[] _nicType;
		public HostVirtualNicConnection Vnic
		{
			get
			{
				return this._vnic;
			}
			set
			{
				this._vnic = value;
			}
		}
		public string[] NicType
		{
			get
			{
				return this._nicType;
			}
			set
			{
				this._nicType = value;
			}
		}
	}
}
