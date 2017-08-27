namespace EnvironmentAssessment.Common.VimApi
{
	public class HostSerialAttachedHba : HostHostBusAdapter
	{
		protected string _nodeWorldWideName;
		public string NodeWorldWideName
		{
			get
			{
				return this._nodeWorldWideName;
			}
			set
			{
				this._nodeWorldWideName = value;
			}
		}
	}
}
