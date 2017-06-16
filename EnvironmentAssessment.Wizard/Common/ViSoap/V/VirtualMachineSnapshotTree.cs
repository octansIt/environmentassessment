using System;
namespace EnvironmentAssessment.Common.VISoap
{
	public class VirtualMachineSnapshotTree : DynamicData
	{
		protected ManagedObjectReference _snapshot;
		protected ManagedObjectReference _vm;
		protected string _name;
		protected string _description;
		protected int _id;
		protected DateTime _createTime;
		protected VirtualMachinePowerState _state;
		protected bool _quiesced;
		protected string _backupManifest;
		protected VirtualMachineSnapshotTree[] _childSnapshotList;
		protected bool? _replaySupported;
		protected VirtualMachineSnapshotTree_LinkedView _linkedView;
		public ManagedObjectReference Snapshot
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
		public ManagedObjectReference Vm
		{
			get
			{
				return this._vm;
			}
			set
			{
				this._vm = value;
			}
		}
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
		public int Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		public DateTime CreateTime
		{
			get
			{
				return this._createTime;
			}
			set
			{
				this._createTime = value;
			}
		}
		public VirtualMachinePowerState State
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}
		public bool Quiesced
		{
			get
			{
				return this._quiesced;
			}
			set
			{
				this._quiesced = value;
			}
		}
		public string BackupManifest
		{
			get
			{
				return this._backupManifest;
			}
			set
			{
				this._backupManifest = value;
			}
		}
		public VirtualMachineSnapshotTree[] ChildSnapshotList
		{
			get
			{
				return this._childSnapshotList;
			}
			set
			{
				this._childSnapshotList = value;
			}
		}
		public bool? ReplaySupported
		{
			get
			{
				return this._replaySupported;
			}
			set
			{
				this._replaySupported = value;
			}
		}
		public VirtualMachineSnapshotTree_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
