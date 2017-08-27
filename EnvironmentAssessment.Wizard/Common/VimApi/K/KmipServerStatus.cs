namespace EnvironmentAssessment.Common.VimApi
{
	public class KmipServerStatus : DynamicData
	{
		protected KeyProviderId _clusterId;
		protected string _name;
		protected ManagedEntityStatus _status;
		protected string _description;
		public KeyProviderId ClusterId
		{
			get
			{
				return this._clusterId;
			}
			set
			{
				this._clusterId = value;
			}
		}
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public ManagedEntityStatus Status
		{
			get
			{
				return this._status;
			}
			set
			{
				this._status = value;
			}
		}
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
	}
}
