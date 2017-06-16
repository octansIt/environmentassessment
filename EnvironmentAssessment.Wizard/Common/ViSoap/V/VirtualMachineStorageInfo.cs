using System;
namespace EnvironmentAssessment.Common.VISoap
{
	public class VirtualMachineStorageInfo : DynamicData
	{
		protected VirtualMachineUsageOnDatastore[] _perDatastoreUsage;
		protected DateTime _timestamp;
		public VirtualMachineUsageOnDatastore[] PerDatastoreUsage
		{
			get
			{
				return this._perDatastoreUsage;
			}
			set
			{
				this._perDatastoreUsage = value;
			}
		}
		public DateTime Timestamp
		{
			get
			{
				return this._timestamp;
			}
			set
			{
				this._timestamp = value;
			}
		}
	}
}
