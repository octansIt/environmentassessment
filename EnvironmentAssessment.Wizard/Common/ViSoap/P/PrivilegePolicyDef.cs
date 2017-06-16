namespace EnvironmentAssessment.Common.VISoap
{
    public class PrivilegePolicyDef : DynamicData
	{
		protected string _createPrivilege;
		protected string _readPrivilege;
		protected string _updatePrivilege;
		protected string _deletePrivilege;
		public string CreatePrivilege
		{
			get
			{
				return this._createPrivilege;
			}
			set
			{
				this._createPrivilege = value;
			}
		}
		public string ReadPrivilege
		{
			get
			{
				return this._readPrivilege;
			}
			set
			{
				this._readPrivilege = value;
			}
		}
		public string UpdatePrivilege
		{
			get
			{
				return this._updatePrivilege;
			}
			set
			{
				this._updatePrivilege = value;
			}
		}
		public string DeletePrivilege
		{
			get
			{
				return this._deletePrivilege;
			}
			set
			{
				this._deletePrivilege = value;
			}
		}
	}
}
