namespace EnvironmentAssessment.Common.VISoap
{
    public class HostMultipathInfo : DynamicData
	{
		protected HostMultipathInfoLogicalUnit[] _lun;
		public HostMultipathInfoLogicalUnit[] Lun
		{
			get
			{
				return this._lun;
			}
			set
			{
				this._lun = value;
			}
		}
	}
}
