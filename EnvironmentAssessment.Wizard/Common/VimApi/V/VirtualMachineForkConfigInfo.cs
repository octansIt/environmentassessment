namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineForkConfigInfo : DynamicData
	{
		protected bool? _parentEnabled;
		protected string _childForkGroupId;
		protected string _parentForkGroupId;
		protected string _childType;
		public bool? ParentEnabled
		{
			get
			{
				return this._parentEnabled;
			}
			set
			{
				this._parentEnabled = value;
			}
		}
		public string ChildForkGroupId
		{
			get
			{
				return this._childForkGroupId;
			}
			set
			{
				this._childForkGroupId = value;
			}
		}
		public string ParentForkGroupId
		{
			get
			{
				return this._parentForkGroupId;
			}
			set
			{
				this._parentForkGroupId = value;
			}
		}
		public string ChildType
		{
			get
			{
				return this._childType;
			}
			set
			{
				this._childType = value;
			}
		}
	}
}
