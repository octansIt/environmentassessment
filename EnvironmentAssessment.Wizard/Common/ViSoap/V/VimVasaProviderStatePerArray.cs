namespace EnvironmentAssessment.Common.VISoap
{
    public class VimVasaProviderStatePerArray : DynamicData
    {
        private int priorityField;

        private string arrayIdField;

        private bool activeField;

        public int priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
            }
        }

        public string arrayId
        {
            get
            {
                return this.arrayIdField;
            }
            set
            {
                this.arrayIdField = value;
            }
        }

        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }
}
