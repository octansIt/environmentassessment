namespace EnvironmentAssessment.Common.VISoap
{
    public class NicSettingMismatch : CustomizationFault
	{
		protected int _numberOfNicsInSpec;
		protected int _numberOfNicsInVM;
		public int NumberOfNicsInSpec
		{
			get
			{
				return this._numberOfNicsInSpec;
			}
			set
			{
				this._numberOfNicsInSpec = value;
			}
		}
		public int NumberOfNicsInVM
		{
			get
			{
				return this._numberOfNicsInVM;
			}
			set
			{
				this._numberOfNicsInVM = value;
			}
		}
	}
}
