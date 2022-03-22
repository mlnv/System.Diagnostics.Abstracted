namespace System.Diagnostics.Abstracted
{
    public interface IDiagnostics
    {
        IFileVersionInfoFactory FileVersionInfo { get; }
        IStopwatchFactory Stopwatch { get; }
        IProcessFactory Process { get; }
    }
}