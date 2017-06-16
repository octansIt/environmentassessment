namespace EnvironmentAssessment.Common.VISoap
{
    public class CpuIncompatible : VirtualHardwareCompatibilityIssue
	{
		protected int _level;
		protected string _registerName;
		protected string _registerBits;
		protected string _desiredBits;
		protected ManagedObjectReference _host;
		protected CpuIncompatible_LinkedView _linkedView;
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
		public string RegisterBits
		{
			get
			{
				return this._registerBits;
			}
			set
			{
				this._registerBits = value;
			}
		}
		public string DesiredBits
		{
			get
			{
				return this._desiredBits;
			}
			set
			{
				this._desiredBits = value;
			}
		}
		public ManagedObjectReference Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public CpuIncompatible_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
