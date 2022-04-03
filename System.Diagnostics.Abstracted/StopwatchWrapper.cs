namespace System.Diagnostics.Abstracted
{
    public class StopwatchWrapper : IStopwatch
    {
        private readonly Stopwatch inner;

        public StopwatchWrapper() : this(new Stopwatch())
        {
        }

        protected internal StopwatchWrapper(Stopwatch inner)
        {
            this.inner = inner;
        }

        public static long Frequency => Stopwatch.Frequency;

        public static bool IsHighResolution => Stopwatch.IsHighResolution;

        public TimeSpan Elapsed => inner.Elapsed;
        public long ElapsedMilliseconds => inner.ElapsedMilliseconds;
        public long ElapsedTicks => inner.ElapsedTicks;
        public bool IsRunning => inner.IsRunning;

        public void Reset()
        {
            inner.Reset();
        }

        public void Restart()
        {
            inner.Restart();
        }

        public void Start()
        {
            inner.Start();
        }

        public void Stop()
        {
            inner.Stop();
        }

        public static long GetTimestamp()
        {
            return Stopwatch.GetTimestamp();
        }

        public static StopwatchWrapper StartNew()
        {
            var diagnosticsSw = Stopwatch.StartNew();
            return new StopwatchWrapper(diagnosticsSw);
        }
    }
}