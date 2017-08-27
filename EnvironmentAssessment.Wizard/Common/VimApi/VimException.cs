using System;
using System.Text;
namespace EnvironmentAssessment.Common.VimApi
{
    public class VimException : Exception
    {
        private MethodFault methodFault;
        public MethodFault MethodFault
        {
            get
            {
                return this.methodFault;
            }
            set
            {
                this.methodFault = value;
            }
        }
        public VimException()
        {
        }
        public VimException(string message) : base(message)
        {
        }
        public VimException(string message, Exception innerException) : base(message, innerException)
        {
        }
        public VimException(string message, MethodFault methodFault) : base(VimException.EnrichErrorMessage(message, methodFault))
        {
            this.methodFault = methodFault;
        }
        public VimException(string message, MethodFault methodFault, Exception inner) : base(VimException.EnrichErrorMessage(message, methodFault), inner)
        {
            this.methodFault = methodFault;
        }
        private static string EnrichErrorMessage(string message, MethodFault methodFault)
        {
            if (methodFault == null || methodFault.FaultMessage == null)
            {
                return message;
            }
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(message.Trim());
            LocalizableMessage[] faultMessage = methodFault.FaultMessage;
            for (int i = 0; i < faultMessage.Length; i++)
            {
                LocalizableMessage localizableMessage = faultMessage[i];
                stringBuilder.Append((stringBuilder[stringBuilder.Length - 1] != '.') ? ". " : " ");
                if (!string.IsNullOrEmpty(localizableMessage.Message))
                {
                    stringBuilder.Append(localizableMessage.Message.Trim());
                }
            }
            return stringBuilder.ToString();
        }
    }
}
