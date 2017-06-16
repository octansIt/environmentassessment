namespace EnvironmentAssessment.Common.VISoap
{
    public class HostCpuIdInfo : DynamicData
	{
		protected int _level;
		protected string _vendor;
		protected string _eax;
		protected string _ebx;
		protected string _ecx;
		protected string _edx;
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
		public string Vendor
		{
			get
			{
				return this._vendor;
			}
			set
			{
				this._vendor = value;
			}
		}
		public string Eax
		{
			get
			{
				return this._eax;
			}
			set
			{
				this._eax = value;
			}
		}
		public string Ebx
		{
			get
			{
				return this._ebx;
			}
			set
			{
				this._ebx = value;
			}
		}
		public string Ecx
		{
			get
			{
				return this._ecx;
			}
			set
			{
				this._ecx = value;
			}
		}
		public string Edx
		{
			get
			{
				return this._edx;
			}
			set
			{
				this._edx = value;
			}
		}
	}
}
