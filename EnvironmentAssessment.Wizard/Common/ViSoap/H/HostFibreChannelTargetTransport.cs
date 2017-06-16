namespace EnvironmentAssessment.Common.VISoap
{
    public class HostFibreChannelTargetTransport : HostTargetTransport
	{
		protected long _portWorldWideName;
		protected long _nodeWorldWideName;
		public long PortWorldWideName
		{
			get
			{
				return this._portWorldWideName;
			}
			set
			{
				this._portWorldWideName = value;
			}
		}
		public long NodeWorldWideName
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
