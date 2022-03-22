namespace System.Diagnostics.Abstracted
{
    public class Diagnostics : IDiagnostics
    {
        public IFileVersionInfoFactory FileVersionInfo => new FileVersionInfoFactory();
        public IStopwatchFactory Stopwatch => new StopwatchFactory();
        public IProcessFactory Process => new ProcessFactory();
    }
}