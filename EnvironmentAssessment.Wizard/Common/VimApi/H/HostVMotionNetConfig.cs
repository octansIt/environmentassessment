namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVMotionNetConfig : DynamicData
	{
		protected HostVirtualNic[] _candidateVnic;
		protected string _selectedVnic;
		public HostVirtualNic[] CandidateVnic
		{
			get
			{
				return this._candidateVnic;
			}
			set
			{
				this._candidateVnic = value;
			}
		}
		public string SelectedVnic
		{
			get
			{
				return this._selectedVnic;
			}
			set
			{
				this._selectedVnic = value;
			}
		}
	}
}
