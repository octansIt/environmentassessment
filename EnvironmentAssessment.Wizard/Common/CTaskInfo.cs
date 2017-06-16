using System;

namespace EnvironmentAssessment.Common
{
    public class CTaskInfo : IDisposable
    {
        public class State : IDisposable
        {
            private int _status;

            private static string[] States = { "Active", "Success", "Warning", "Error"  };

            public const int Active = 0;
            public const int Success = 1;
            public const int Warning = 2;
            public const int Error = 3;

            public State(int t = -1)
            {
                _status = t;
            }

            public void Dispose()
            {
                States = null;
            }

            public override string ToString()
            {
                return States[_status];
            }

            public static implicit operator int(State x)
            {
                int i = x._status;
                return i;
            }
        }

        private string CompletionTime = null;
        public string Service;
        public string StartTime;
        public string UID;
        private State _Status;
        public State Status
        {
            get 
            {
                return _Status;
            }
            set
            {
                if (value != State.Active) { if (CompletionTime == null) { CompletionTime = CFunctions.GetDateTime(); } }
                _Status = value;
            }
        }
        public string Details { get; set; }
        public string Duration { get {

                string s = StartTime;
                string c = CompletionTime;

                DateTime st = CFunctions.ConvertDateTime(s);
                DateTime ct = DateTime.Now;
                if (CompletionTime != null) { ct = CFunctions.ConvertDateTime(c); }

                TimeSpan diff = ct.Subtract(st);

                string hours = (diff.TotalHours.ToString().Replace(',','.')).Split('.')[0]; // should cover both rounding options for regions using commas and decimals

                string minutes = (diff.Minutes + 100).ToString().Substring(1);
                string seconds = (diff.Seconds + 100).ToString().Substring(1);

                return hours + ":" + minutes + ":" + seconds;
        
        } }

        public void Dispose() {
            Status = null;
        }
    }
}
