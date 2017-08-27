namespace EnvironmentAssessment.Common.VimApi
{
	public class DiagnosticManagerBundleInfo : DynamicData
	{
		protected ManagedObjectReference _system;
		protected string _url;
		protected DiagnosticManagerBundleInfo_LinkedView _linkedView;
		public ManagedObjectReference System
		{
			get
			{
				return this._system;
			}
			set
			{
				this._system = value;
			}
		}
		public string Url
		{
			get
			{
				return this._url;
			}
			set
			{
				this._url = value;
			}
		}
		public DiagnosticManagerBundleInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
