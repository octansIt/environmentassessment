namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsApplyOperationFaultFaultOnObject : DynamicData
	{
		protected string _objectId;
		protected string _type;
		protected LocalizedMethodFault _fault;
		public string ObjectId
		{
			get
			{
				return this._objectId;
			}
			set
			{
				this._objectId = value;
			}
		}
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
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
	}
}
