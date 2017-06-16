namespace EnvironmentAssessment.Common.VISoap
{
    public class KernelModuleSectionInfo : DynamicData
	{
		protected long _address;
		protected int? _length;
		public long Address
		{
			get
			{
				return this._address;
			}
			set
			{
				this._address = value;
			}
		}
		public int? Length
		{
			get
			{
				return this._length;
			}
			set
			{
				this._length = value;
			}
		}
	}
}
