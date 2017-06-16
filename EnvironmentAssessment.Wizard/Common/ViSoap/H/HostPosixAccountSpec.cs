namespace EnvironmentAssessment.Common.VISoap
{
    public class HostPosixAccountSpec : HostAccountSpec
	{
		protected int? _posixId;
		protected bool? _shellAccess;
		public int? PosixId
		{
			get
			{
				return this._posixId;
			}
			set
			{
				this._posixId = value;
			}
		}
		public bool? ShellAccess
		{
			get
			{
				return this._shellAccess;
			}
			set
			{
				this._shellAccess = value;
			}
		}
	}
}
