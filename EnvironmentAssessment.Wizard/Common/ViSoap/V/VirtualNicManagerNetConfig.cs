namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualNicManagerNetConfig : DynamicData
	{
		protected string _nicType;
		protected bool _multiSelectAllowed;
		protected HostVirtualNic[] _candidateVnic;
		protected string[] _selectedVnic;
		public string NicType
		{
			get
			{
				return this._nicType;
			}
			set
			{
				this._nicType = value;
			}
		}
		public bool MultiSelectAllowed
		{
			get
			{
				return this._multiSelectAllowed;
			}
			set
			{
				this._multiSelectAllowed = value;
			}
		}
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
		public string[] SelectedVnic
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
