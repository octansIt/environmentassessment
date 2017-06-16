using System;
namespace EnvironmentAssessment.Common.VISoap
{
	public class Extension : DynamicData
	{
		protected Description _description;
		protected string _key;
		protected string _company;
		protected string _type;
		protected string _version;
		protected string _subjectName;
		protected ExtensionServerInfo[] _server;
		protected ExtensionClientInfo[] _client;
		protected ExtensionTaskTypeInfo[] _taskList;
		protected ExtensionEventTypeInfo[] _eventList;
		protected ExtensionFaultTypeInfo[] _faultList;
		protected ExtensionPrivilegeInfo[] _privilegeList;
		protected ExtensionResourceInfo[] _resourceList;
		protected DateTime _lastHeartbeatTime;
		protected ExtensionHealthInfo _healthInfo;
		protected ExtensionOvfConsumerInfo _ovfConsumerInfo;
		protected ExtExtendedProductInfo _extendedProductInfo;
		protected ExtManagedEntityInfo[] _managedEntityInfo;
		protected bool? _shownInSolutionManager;
		protected ExtSolutionManagerInfo _solutionManagerInfo;
		public Description Description
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
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public string Company
		{
			get
			{
				return this._company;
			}
			set
			{
				this._company = value;
			}
		}
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		public string Version
		{
			get
			{
				return this._version;
			}
			set
			{
				this._version = value;
			}
		}
		public string SubjectName
		{
			get
			{
				return this._subjectName;
			}
			set
			{
				this._subjectName = value;
			}
		}
		public ExtensionServerInfo[] Server
		{
			get
			{
				return this._server;
			}
			set
			{
				this._server = value;
			}
		}
		public ExtensionClientInfo[] Client
		{
			get
			{
				return this._client;
			}
			set
			{
				this._client = value;
			}
		}
		public ExtensionTaskTypeInfo[] TaskList
		{
			get
			{
				return this._taskList;
			}
			set
			{
				this._taskList = value;
			}
		}
		public ExtensionEventTypeInfo[] EventList
		{
			get
			{
				return this._eventList;
			}
			set
			{
				this._eventList = value;
			}
		}
		public ExtensionFaultTypeInfo[] FaultList
		{
			get
			{
				return this._faultList;
			}
			set
			{
				this._faultList = value;
			}
		}
		public ExtensionPrivilegeInfo[] PrivilegeList
		{
			get
			{
				return this._privilegeList;
			}
			set
			{
				this._privilegeList = value;
			}
		}
		public ExtensionResourceInfo[] ResourceList
		{
			get
			{
				return this._resourceList;
			}
			set
			{
				this._resourceList = value;
			}
		}
		public DateTime LastHeartbeatTime
		{
			get
			{
				return this._lastHeartbeatTime;
			}
			set
			{
				this._lastHeartbeatTime = value;
			}
		}
		public ExtensionHealthInfo HealthInfo
		{
			get
			{
				return this._healthInfo;
			}
			set
			{
				this._healthInfo = value;
			}
		}
		public ExtensionOvfConsumerInfo OvfConsumerInfo
		{
			get
			{
				return this._ovfConsumerInfo;
			}
			set
			{
				this._ovfConsumerInfo = value;
			}
		}
		public ExtExtendedProductInfo ExtendedProductInfo
		{
			get
			{
				return this._extendedProductInfo;
			}
			set
			{
				this._extendedProductInfo = value;
			}
		}
		public ExtManagedEntityInfo[] ManagedEntityInfo
		{
			get
			{
				return this._managedEntityInfo;
			}
			set
			{
				this._managedEntityInfo = value;
			}
		}
		public bool? ShownInSolutionManager
		{
			get
			{
				return this._shownInSolutionManager;
			}
			set
			{
				this._shownInSolutionManager = value;
			}
		}
		public ExtSolutionManagerInfo SolutionManagerInfo
		{
			get
			{
				return this._solutionManagerInfo;
			}
			set
			{
				this._solutionManagerInfo = value;
			}
		}
	}
}
