using System.Security;

namespace System.Diagnostics.Abstracted
{
    public class ProcessFactory : IProcessFactory
    {
        /// <inheritdoc />
        public void EnterDebugMode()
        {
            ProcessWrapper.EnterDebugMode();
        }

        /// <inheritdoc />
        public IProcess GetCurrentProcess()
        {
            return ProcessWrapper.GetCurrentProcess();
        }

        /// <inheritdoc />
        public IProcess GetProcessById(int processId)
        {
            return ProcessWrapper.GetProcessById(processId);
        }

        /// <inheritdoc />
        public IProcess GetProcessById(int processId, string machineName)
        {
            return ProcessWrapper.GetProcessById(processId, machineName);
        }

        /// <inheritdoc />
        public IProcess[] GetProcesses()
        {
            return ProcessWrapper.GetProcesses();
        }

        /// <inheritdoc />
        public IProcess[] GetProcesses(string machineName)
        {
            return ProcessWrapper.GetProcesses(machineName);
        }

        /// <inheritdoc />
        public IProcess[] GetProcessesByName(string processName)
        {
            return ProcessWrapper.GetProcessesByName(processName);
        }

        /// <inheritdoc />
        public IProcess[] GetProcessesByName(string processName, string machineName)
        {
            return ProcessWrapper.GetProcessesByName(processName, machineName);
        }

        /// <inheritdoc />
        public void LeaveDebugMode()
        {
            ProcessWrapper.LeaveDebugMode();
        }

        /// <inheritdoc />
        public IProcess Start(ProcessStartInfo startInfo)
        {
            return ProcessWrapper.Start(startInfo);
        }

        /// <inheritdoc />
        public IProcess Start(string fileName)
        {
            return ProcessWrapper.Start(fileName);
        }

        /// <inheritdoc />
        public IProcess Start(string fileName, string arguments)
        {
            return ProcessWrapper.Start(fileName, arguments);
        }

        /// <inheritdoc />
        public IProcess Start(string fileName, string userName, SecureString password, string domain)
        {
            return ProcessWrapper.Start(fileName, userName, password, domain);
        }

        /// <inheritdoc />
        public IProcess Start(string fileName, string arguments, string userName, SecureString password, string domain)
        {
            return ProcessWrapper.Start(fileName, arguments, userName, password, domain);
        }
    }
}