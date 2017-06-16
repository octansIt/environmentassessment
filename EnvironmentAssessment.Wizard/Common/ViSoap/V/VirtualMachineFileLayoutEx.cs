using System;
namespace EnvironmentAssessment.Common.VISoap
{
	public class VirtualMachineFileLayoutEx : DynamicData
	{
		protected VirtualMachineFileLayoutExFileInfo[] _file;
		protected VirtualMachineFileLayoutExDiskLayout[] _disk;
		protected VirtualMachineFileLayoutExSnapshotLayout[] _snapshot;
		protected DateTime _timestamp;
		public VirtualMachineFileLayoutExFileInfo[] File
		{
			get
			{
				return this._file;
			}
			set
			{
				this._file = value;
			}
		}
		public VirtualMachineFileLayoutExDiskLayout[] Disk
		{
			get
			{
				return this._disk;
			}
			set
			{
				this._disk = value;
			}
		}
		public VirtualMachineFileLayoutExSnapshotLayout[] Snapshot
		{
			get
			{
				return this._snapshot;
			}
			set
			{
				this._snapshot = value;
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
