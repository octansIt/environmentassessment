namespace EnvironmentAssessment.Common.VISoap
{
    public class LatencySensitivity : DynamicData
	{
		protected LatencySensitivitySensitivityLevel _level;
		protected int? _sensitivity;
		public LatencySensitivitySensitivityLevel Level
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
		public int? Sensitivity
		{
			get
			{
				return this._sensitivity;
			}
			set
			{
				this._sensitivity = value;
			}
		}
	}
}
