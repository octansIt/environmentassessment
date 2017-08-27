namespace EnvironmentAssessment.Common.VimApi
{
	public class BatchResult : DynamicData
	{
		protected string _result;
		protected string _hostKey;
		protected ManagedObjectReference _ds;
		protected LocalizedMethodFault _fault;
		protected BatchResult_LinkedView _linkedView;
		public string Result
		{
			get
			{
				return this._result;
			}
			set
			{
				this._result = value;
			}
		}
		public string HostKey
		{
			get
			{
				return this._hostKey;
			}
			set
			{
				this._hostKey = value;
			}
		}
		public ManagedObjectReference Ds
		{
			get
			{
				return this._ds;
			}
			set
			{
				this._ds = value;
			}
		}
		public LocalizedMethodFault Fault
		{
			get
			{
				return this._fault;
			}
			set
			{
				this._fault = value;
			}
		}
		public BatchResult_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
