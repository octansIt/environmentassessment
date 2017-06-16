namespace EnvironmentAssessment.Common.VISoap
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
