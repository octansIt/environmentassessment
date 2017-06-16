namespace EnvironmentAssessment.Common.VISoap
{
    public class OvfMappedOsId : OvfImport
	{
		protected int _ovfId;
		protected string _ovfDescription;
		protected string _targetDescription;
		public int OvfId
		{
			get
			{
				return this._ovfId;
			}
			set
			{
				this._ovfId = value;
			}
		}
		public string OvfDescription
		{
			get
			{
				return this._ovfDescription;
			}
			set
			{
				this._ovfDescription = value;
			}
		}
		public string TargetDescription
		{
			get
			{
				return this._targetDescription;
			}
			set
			{
				this._targetDescription = value;
			}
		}
	}
}
