namespace EnvironmentAssessment.Common.VimApi
{
	public class HostProfileManagerHostToConfigSpecMap : DynamicData
	{
		protected ManagedObjectReference _host;
		protected AnswerFileCreateSpec _configSpec;
		protected HostProfileManagerHostToConfigSpecMap_LinkedView _linkedView;
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
		public AnswerFileCreateSpec ConfigSpec
		{
			get
			{
				return this._configSpec;
			}
			set
			{
				this._configSpec = value;
			}
		}
		public HostProfileManagerHostToConfigSpecMap_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
