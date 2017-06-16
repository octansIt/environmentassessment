namespace EnvironmentAssessment.Common.VISoap
{
    public class OvfCpuCompatibility : OvfImport
	{
		protected string _registerName;
		protected int _level;
		protected string _registerValue;
		protected string _desiredRegisterValue;
		public string RegisterName
		{
			get
			{
				return this._registerName;
			}
			set
			{
				this._registerName = value;
			}
		}
		public int Level
		{
			get
			{
				return this._level;
			}
			set
			{
				this._level = value;
			}
		}
		public string RegisterValue
		{
			get
			{
				return this._registerValue;
			}
			set
			{
				this._registerValue = value;
			}
		}
		public string DesiredRegisterValue
		{
			get
			{
				return this._desiredRegisterValue;
			}
			set
			{
				this._desiredRegisterValue = value;
			}
		}
	}
}
