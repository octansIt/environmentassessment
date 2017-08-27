namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterHostInfraUpdateHaModeAction : ClusterAction
	{
		protected string _operationType;
		public string OperationType
		{
			get
			{
				return this._operationType;
			}
			set
			{
				this._operationType = value;
			}
		}
	}
}
