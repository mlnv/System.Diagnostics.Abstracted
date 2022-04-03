namespace System.Diagnostics.Abstracted
{
    public class Stopwatch : IStopwatch
    {
        private readonly System.Diagnostics.Stopwatch inner;

        public Stopwatch() : this(new System.Diagnostics.Stopwatch())
        {
        }

        protected internal Stopwatch(System.Diagnostics.Stopwatch inner)
        {
            this.inner = inner;
        }

        public static long Frequency => System.Diagnostics.Stopwatch.Frequency;

        public static bool IsHighResolution => System.Diagnostics.Stopwatch.IsHighResolution;

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
            return System.Diagnostics.Stopwatch.GetTimestamp();
        }

        public static Stopwatch StartNew()
        {
            var diagnosticsSw = System.Diagnostics.Stopwatch.StartNew();
            return new Stopwatch(diagnosticsSw);
        }
    }
}