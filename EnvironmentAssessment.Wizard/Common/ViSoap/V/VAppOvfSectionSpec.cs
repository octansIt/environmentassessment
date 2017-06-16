namespace EnvironmentAssessment.Common.VISoap
{
    public class VAppOvfSectionSpec : ArrayUpdateSpec
	{
		protected VAppOvfSectionInfo _info;
		public VAppOvfSectionInfo Info
		{
			get
			{
				return this._info;
			}
			set
			{
				this._info = value;
			}
		}
	}
}
