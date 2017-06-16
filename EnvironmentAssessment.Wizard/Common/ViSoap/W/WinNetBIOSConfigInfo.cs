namespace EnvironmentAssessment.Common.VISoap
{
    public class WinNetBIOSConfigInfo : NetBIOSConfigInfo
	{
		protected string _primaryWINS;
		protected string _secondaryWINS;
		public string PrimaryWINS
		{
			get
			{
				return this._primaryWINS;
			}
			set
			{
				this._primaryWINS = value;
			}
		}
		public string SecondaryWINS
		{
			get
			{
				return this._secondaryWINS;
			}
			set
			{
				this._secondaryWINS = value;
			}
		}
	}
}
