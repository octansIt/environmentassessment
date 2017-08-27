namespace EnvironmentAssessment.Common.VimApi
{
	public class ConnectedIso : OvfExport
	{
		protected VirtualCdrom _cdrom;
		protected string _filename;
		public VirtualCdrom Cdrom
		{
			get
			{
				return this._cdrom;
			}
			set
			{
				this._cdrom = value;
			}
		}
		public string Filename
		{
			get
			{
				return this._filename;
			}
			set
			{
				this._filename = value;
			}
		}
	}
}
