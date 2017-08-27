using System;
using System.Collections.Generic;
namespace EnvironmentAssessment.Common.VimApi
{
	public class EntityViewBase : ExtensibleManagedObject
	{
		public EntityViewBase(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		[Obsolete("Use GetSearchFilterSpec(VimClient, ManagedObjectReference, PropertySpec) instead", false)]
		public static PropertyFilterSpec GetSearchFilterSpec(ManagedObjectReference beginEntity, PropertySpec propSpec)
		{
			return EntityViewBase.GetSearchFilterSpec(null, beginEntity, propSpec);
		}
		public static PropertyFilterSpec GetSearchFilterSpec(IVimClient client, ManagedObjectReference beginEntity, PropertySpec propSpec)
		{
			TraversalSpec traversalSpec = new TraversalSpec();
			traversalSpec.Name = "resourcePoolTraversalSpec";
			traversalSpec.Type = "ResourcePool";
			traversalSpec.Path = "resourcePool";
			traversalSpec.Skip = new bool?(false);
			SelectionSpec selectionSpec = new SelectionSpec();
			selectionSpec.Name = "resourcePoolTraversalSpec";
			traversalSpec.SelectSet = new SelectionSpec[2];
			traversalSpec.SelectSet[0] = selectionSpec;
			selectionSpec = new SelectionSpec();
			selectionSpec.Name = "resourcePoolVmTraversalSpec";
			traversalSpec.SelectSet[1] = selectionSpec;
			TraversalSpec traversalSpec2 = new TraversalSpec();
			traversalSpec2.Name = "resourcePoolVmTraversalSpec";
			traversalSpec2.Type = "ResourcePool";
			traversalSpec2.Path = "vm";
			traversalSpec2.Skip = new bool?(false);
			TraversalSpec traversalSpec3 = new TraversalSpec();
			traversalSpec3.Name = "computeResourceRpTraversalSpec";
			traversalSpec3.Type = "ComputeResource";
			traversalSpec3.Path = "resourcePool";
			traversalSpec3.Skip = new bool?(false);
			selectionSpec = new SelectionSpec();
			selectionSpec.Name = "resourcePoolTraversalSpec";
			traversalSpec3.SelectSet = new SelectionSpec[2];
			traversalSpec3.SelectSet[0] = selectionSpec;
			selectionSpec = new SelectionSpec();
			selectionSpec.Name = "resourcePoolVmTraversalSpec";
			traversalSpec3.SelectSet[1] = selectionSpec;
			TraversalSpec traversalSpec4 = new TraversalSpec();
			traversalSpec4.Name = "computeResourceHostTraversalSpec";
			traversalSpec4.Type = "ComputeResource";
			traversalSpec4.Path = "host";
			traversalSpec4.Skip = new bool?(false);
			TraversalSpec traversalSpec5 = new TraversalSpec();
			traversalSpec5.Name = "datacenterVmTraversalSpec";
			traversalSpec5.Type = "Datacenter";
			traversalSpec5.Path = "vmFolder";
			traversalSpec5.Skip = new bool?(false);
			selectionSpec = new SelectionSpec();
			selectionSpec.Name = "folderTraversalSpec";
			traversalSpec5.SelectSet = new SelectionSpec[1];
			traversalSpec5.SelectSet[0] = selectionSpec;
			TraversalSpec traversalSpec6 = new TraversalSpec();
			traversalSpec6.Name = "datacenterHostTraversalSpec";
			traversalSpec6.Type = "Datacenter";
			traversalSpec6.Path = "hostFolder";
			traversalSpec6.Skip = new bool?(false);
			selectionSpec = new SelectionSpec();
			selectionSpec.Name = "folderTraversalSpec";
			traversalSpec6.SelectSet = new SelectionSpec[1];
			traversalSpec6.SelectSet[0] = selectionSpec;
			TraversalSpec traversalSpec7 = new TraversalSpec();
			traversalSpec7.Name = "hostVmTraversalSpec";
			traversalSpec7.Type = "HostSystem";
			traversalSpec7.Path = "vm";
			traversalSpec7.Skip = new bool?(false);
			selectionSpec = new SelectionSpec();
			selectionSpec.Name = "folderTraversalSpec";
			traversalSpec7.SelectSet = new SelectionSpec[1];
			traversalSpec7.SelectSet[0] = selectionSpec;
			TraversalSpec traversalSpec8 = new TraversalSpec();
			traversalSpec8.Name = "datacenterDatastoreTraversalSpec";
			traversalSpec8.Type = "Datacenter";
			traversalSpec8.Path = "datastoreFolder";
			traversalSpec8.Skip = new bool?(false);
			selectionSpec = new SelectionSpec();
			selectionSpec.Name = "folderTraversalSpec";
			traversalSpec8.SelectSet = new SelectionSpec[1];
			traversalSpec8.SelectSet[0] = selectionSpec;
			TraversalSpec traversalSpec9 = new TraversalSpec();
			traversalSpec9.Name = "datacenterNetworkTraversalSpec";
			traversalSpec9.Type = "Datacenter";
			traversalSpec9.Path = "networkFolder";
			traversalSpec9.Skip = new bool?(false);
			selectionSpec = new SelectionSpec();
			selectionSpec.Name = "folderTraversalSpec";
			traversalSpec9.SelectSet = new SelectionSpec[1];
			traversalSpec9.SelectSet[0] = selectionSpec;
			TraversalSpec traversalSpec10 = new TraversalSpec();
			traversalSpec10.Name = "folderTraversalSpec";
			traversalSpec10.Type = "Folder";
			traversalSpec10.Path = "childEntity";
			traversalSpec10.Skip = new bool?(false);
			traversalSpec10.SelectSet = new List<SelectionSpec>(new SelectionSpec[]
			{
				new SelectionSpec
				{
					Name = "folderTraversalSpec"
				},
				new SelectionSpec
				{
					Name = "datacenterHostTraversalSpec"
				},
				new SelectionSpec
				{
					Name = "datacenterVmTraversalSpec"
				},
				new SelectionSpec
				{
					Name = "computeResourceRpTraversalSpec"
				},
				new SelectionSpec
				{
					Name = "computeResourceHostTraversalSpec"
				},
				new SelectionSpec
				{
					Name = "hostVmTraversalSpec"
				},
				new SelectionSpec
				{
					Name = "resourcePoolVmTraversalSpec"
				}
			})
			{
				new SelectionSpec
				{
					Name = "datacenterDatastoreTraversalSpec"
				},
				new SelectionSpec
				{
					Name = "datacenterNetworkTraversalSpec"
				}
			}.ToArray();
			ObjectSpec objectSpec = new ObjectSpec();
			objectSpec.Obj = beginEntity;
			objectSpec.Skip = new bool?(false);
			objectSpec.SelectSet = new List<SelectionSpec>(new SelectionSpec[]
			{
				traversalSpec10,
				traversalSpec5,
				traversalSpec6,
				traversalSpec4,
				traversalSpec3,
				traversalSpec,
				traversalSpec7,
				traversalSpec2
			})
			{
				traversalSpec8,
				traversalSpec9
			}.ToArray();
			return new PropertyFilterSpec
			{
				PropSet = new PropertySpec[]
				{
					propSpec
				},
				ObjectSet = new ObjectSpec[]
				{
					objectSpec
				}
			};
		}
		public TaskHistoryCollector GetTaskCollectorView(TaskFilterSpecRecursionOption recursionOption, TaskFilterSpec taskFilterSpec)
		{
			if (taskFilterSpec == null)
			{
				taskFilterSpec = new TaskFilterSpec();
			}
			taskFilterSpec.Entity = new TaskFilterSpecByEntity
			{
				Entity = this.MoRef,
				Recursion = recursionOption
			};
			ManagedObjectReference moRef = ((TaskManager)this.Client.GetView(this.Client.ServiceContent.TaskManager, null)).CreateCollectorForTasks(taskFilterSpec);
			TaskHistoryCollector taskHistoryCollector = new TaskHistoryCollector(this.Client, moRef);
			taskHistoryCollector.UpdateViewData(null);
			return taskHistoryCollector;
		}
		public TaskHistoryCollector GetEntityOnlyTasksCollectorView(TaskFilterSpec taskFilterSpec)
		{
			return this.GetTaskCollectorView(TaskFilterSpecRecursionOption.self, taskFilterSpec);
		}
		public TaskHistoryCollector GetAllTasksView(TaskFilterSpec taskFilterSpec)
		{
			return this.GetTaskCollectorView(TaskFilterSpecRecursionOption.all, taskFilterSpec);
		}
		public EventHistoryCollector GetEventCollectorView(EventFilterSpecRecursionOption recursionOption, EventFilterSpec eventFilterSpec)
		{
			if (eventFilterSpec == null)
			{
				eventFilterSpec = new EventFilterSpec();
			}
			eventFilterSpec.Entity = new EventFilterSpecByEntity
			{
				Entity = this.MoRef,
				Recursion = recursionOption
			};
			ManagedObjectReference moRef = ((EventManager)this.Client.GetView(this.Client.ServiceContent.EventManager, null)).CreateCollectorForEvents(eventFilterSpec);
			EventHistoryCollector eventHistoryCollector = new EventHistoryCollector(this.Client, moRef);
			eventHistoryCollector.UpdateViewData(null);
			return eventHistoryCollector;
		}
		public EventHistoryCollector GetEntityOnlyEventsCollectorView(EventFilterSpec eventFilterSpec)
		{
			return this.GetEventCollectorView(EventFilterSpecRecursionOption.self, eventFilterSpec);
		}
		public EventHistoryCollector GetAllEventsView(EventFilterSpec eventFilterSpec)
		{
			return this.GetEventCollectorView(EventFilterSpecRecursionOption.all, eventFilterSpec);
		}
	}
}
