namespace EnvironmentAssessment.Common.VISoap
{
    public class VMwareDVSPvlanMapEntry : DynamicData
	{
		protected int _primaryVlanId;
		protected int _secondaryVlanId;
		protected string _pvlanType;
		public int PrimaryVlanId
		{
			get
			{
				return this._primaryVlanId;
			}
			set
			{
				this._primaryVlanId = value;
			}
		}
		public int SecondaryVlanId
		{
			get
			{
				return this._secondaryVlanId;
			}
			set
			{
				this._secondaryVlanId = value;
			}
		}
		public string PvlanType
		{
			get
			{
				return this._pvlanType;
			}
			set
			{
				this._pvlanType = value;
			}
		}
	}
}
