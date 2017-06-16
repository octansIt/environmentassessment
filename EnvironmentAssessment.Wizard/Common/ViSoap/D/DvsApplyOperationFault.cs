namespace EnvironmentAssessment.Common.VISoap
{
    public class DvsApplyOperationFault : DvsFault
	{
		protected DvsApplyOperationFaultFaultOnObject[] _objectFault;
		public DvsApplyOperationFaultFaultOnObject[] ObjectFault
		{
			get
			{
				return this._objectFault;
			}
			set
			{
				this._objectFault = value;
			}
		}
	}
}
