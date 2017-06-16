using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class DiagnosticManager : ViewBase
	{
		public DiagnosticManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public DiagnosticManagerLogDescriptor[] QueryDescriptions(ManagedObjectReference host)
		{
			DiagnosticManagerLogDescriptor[] result;
			try
			{
				result = (DiagnosticManagerLogDescriptor[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryDescriptions((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public DiagnosticManagerLogHeader BrowseDiagnosticLog(ManagedObjectReference host, string key, int? start, int? lines)
		{
			DiagnosticManagerLogHeader result;
			try
			{
				result = (DiagnosticManagerLogHeader)VIConvert.ToVim(((VimService)this.Client.VimService).BrowseDiagnosticLog((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host), key, start.GetValueOrDefault(), start.HasValue, lines.GetValueOrDefault(), lines.HasValue));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}

        public ManagedObjectReference GenerateLogBundles_Task(bool includeDefault, ManagedObjectReference[] host, KeyValue[] supportOptions)
        {
            ManagedObjectReference managedObjectReference;
            try
            {
                managedObjectReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).GenerateLogBundles_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), includeDefault, (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(host), (VimApi_60.KeyValue[])VIConvert.ToWsdlType(supportOptions)));
            }
            catch (SoapException ex)
            {
                throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
            }
            return managedObjectReference;
        }

        [Obsolete("The method GenerateLogBundles_Task in DiagnosticManager is deprecated in version 5.5.")]
        public ManagedObjectReference GenerateLogBundles_Task(bool includeDefault, ManagedObjectReference[] host)
		{
            return this.GenerateLogBundles_Task(includeDefault, host, null);
		}

        public DiagnosticManagerBundleInfo[] GenerateLogBundles(bool includeDefault, ManagedObjectReference[] host, KeyValue[] supportOptions)
        {
            DiagnosticManagerBundleInfo[] result;
            try
            {
                ManagedObjectReference taskReference4 = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).GenerateLogBundles_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), includeDefault, (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(host), (VimApi_60.KeyValue[])VIConvert.ToWsdlType(supportOptions)));
                result = (DiagnosticManagerBundleInfo[])this.Client.WaitForTask(taskReference4);
            }
            catch (SoapException ex)
            {
                throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
            }
            return result;
        }

        [Obsolete("The method GenerateLogBundles in DiagnosticManager is deprecated in version 5.5.")]
		public DiagnosticManagerBundleInfo[] GenerateLogBundles(bool includeDefault, ManagedObjectReference[] host)
		{
            return this.GenerateLogBundles(includeDefault, host, null);
		}
	}
}
