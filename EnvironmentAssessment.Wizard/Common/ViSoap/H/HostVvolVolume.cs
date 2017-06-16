namespace EnvironmentAssessment.Common.VISoap
{
    public class HostVvolVolume : HostFileSystemVolume
    {
        private string scIdField;

        private VVolHostPE[] hostPEField;

        private VimVasaProviderInfo[] vasaProviderInfoField;

        private VASAStorageArray[] storageArrayField;

        public string scId
        {
            get
            {
                return this.scIdField;
            }
            set
            {
                this.scIdField = value;
            }
        }
        public VVolHostPE[] hostPE
        {
            get
            {
                return this.hostPEField;
            }
            set
            {
                this.hostPEField = value;
            }
        }

        public VimVasaProviderInfo[] vasaProviderInfo
        {
            get
            {
                return this.vasaProviderInfoField;
            }
            set
            {
                this.vasaProviderInfoField = value;
            }
        }
        
        public VASAStorageArray[] storageArray
        {
            get
            {
                return this.storageArrayField;
            }
            set
            {
                this.storageArrayField = value;
            }
        }
    }
}
