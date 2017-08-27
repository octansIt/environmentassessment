namespace EnvironmentAssessment.Common.VimApi
{
	public class HostConnectSpec_LinkedView
	{
		protected Folder _vmFolder;
		public Folder VmFolder
		{
			get
			{
				return this._vmFolder;
			}
			set
			{
				this._vmFolder = value;
			}
		}
	}
}
