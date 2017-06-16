namespace EnvironmentAssessment.Common.VISoap
{
    public class HostScsiTopology : DynamicData
	{
		protected HostScsiTopologyInterface[] _adapter;
		public HostScsiTopologyInterface[] Adapter
		{
			get
			{
				return this._adapter;
			}
			set
			{
				this._adapter = value;
			}
		}
	}
}
