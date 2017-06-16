namespace EnvironmentAssessment.Common.VISoap
{
    public class HostNetworkResourceRuntime : DynamicData
	{
		protected HostPnicNetworkResourceInfo[] _pnicResourceInfo;
		public HostPnicNetworkResourceInfo[] PnicResourceInfo
		{
			get
			{
				return this._pnicResourceInfo;
			}
			set
			{
				this._pnicResourceInfo = value;
			}
		}
	}
}
