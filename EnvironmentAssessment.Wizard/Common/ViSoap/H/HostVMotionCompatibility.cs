namespace EnvironmentAssessment.Common.VISoap
{
    public class HostVMotionCompatibility : DynamicData
	{
		protected ManagedObjectReference _host;
		protected string[] _compatibility;
		protected HostVMotionCompatibility_LinkedView _linkedView;
		public ManagedObjectReference Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public string[] Compatibility
		{
			get
			{
				return this._compatibility;
			}
			set
			{
				this._compatibility = value;
			}
		}
		public HostVMotionCompatibility_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
