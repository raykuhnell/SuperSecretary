using System;

namespace SuperSecretary.Events
{
    public class ProgressEventArgs : EventArgs
    {
        public string Status { get; private set; }
        public int Current { get; private set; }
        public int Total { get; private set; }

        public ProgressEventArgs(string status, int current, int total)
        {
            Status = status;
            Current = current;
            Total = total;
        }
    }
}
