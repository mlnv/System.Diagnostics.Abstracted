﻿using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.Diagnostics.Abstracted
{
    public class ProcessWrapper : IProcess
    {
        private readonly Process inner;

        public ProcessWrapper(Process inner)
        {
            this.inner = inner;
            this.inner.ErrorDataReceived += OnErrorDataReceived;
            this.inner.Exited += OnExited;
            this.inner.OutputDataReceived += OnOutputDataReceived;
        }

        /// <inheritdoc />
        public void Dispose()
        {
            inner.Dispose();
        }

        /// <inheritdoc />
        public int BasePriority => inner.BasePriority;

        /// <inheritdoc />
        public bool EnableRaisingEvents
        {
            get => inner.EnableRaisingEvents;
            set => inner.EnableRaisingEvents = value;
        }

        /// <inheritdoc />
        public int ExitCode => inner.ExitCode;

        /// <inheritdoc />
        public DateTime ExitTime => inner.ExitTime;

        /// <inheritdoc />
        public IntPtr Handle => inner.Handle;

        /// <inheritdoc />
        public int HandleCount => inner.HandleCount;

        /// <inheritdoc />
        public bool HasExited => inner.HasExited;

        /// <inheritdoc />
        public int Id => inner.Id;

        /// <inheritdoc />
        public string MachineName => inner.MachineName;

        /// <inheritdoc />
        public ProcessModule MainModule => inner.MainModule;

        /// <inheritdoc />
        public IntPtr MainWindowHandle => inner.MainWindowHandle;

        /// <inheritdoc />
        public string MainWindowTitle => inner.MainWindowTitle;

        /// <inheritdoc />
        public IntPtr MaxWorkingSet
        {
            get => inner.MaxWorkingSet;
            set => inner.MaxWorkingSet = value;
        }

        public IntPtr MinWorkingSet
        {
            get => inner.MinWorkingSet;
            set => inner.MinWorkingSet = value;
        }

        /// <inheritdoc />
        public ProcessModuleCollection Modules => inner.Modules;

        /// <inheritdoc />
        public int NonpagedSystemMemorySize => inner.NonpagedSystemMemorySize;

        /// <inheritdoc />
        public long NonpagedSystemMemorySize64 => inner.NonpagedSystemMemorySize64;

        /// <inheritdoc />
        public int PagedMemorySize => inner.PagedMemorySize;

        /// <inheritdoc />
        public long PagedMemorySize64 => inner.PagedMemorySize64;

        /// <inheritdoc />
        public int PagedSystemMemorySize => inner.PagedSystemMemorySize;

        /// <inheritdoc />
        public long PagedSystemMemorySize64 => inner.PagedSystemMemorySize64;

        /// <inheritdoc />
        public int PeakPagedMemorySize => inner.PeakPagedMemorySize;

        /// <inheritdoc />
        public long PeakPagedMemorySize64 => inner.PeakPagedMemorySize64;

        /// <inheritdoc />
        public int PeakVirtualMemorySize => inner.PeakVirtualMemorySize;

        /// <inheritdoc />
        public long PeakVirtualMemorySize64 => inner.PeakVirtualMemorySize64;

        /// <inheritdoc />
        public int PeakWorkingSet => inner.PeakWorkingSet;

        /// <inheritdoc />
        public long PeakWorkingSet64 => inner.PeakWorkingSet64;

        /// <inheritdoc />
        public bool PriorityBoostEnabled
        {
            get => inner.EnableRaisingEvents;
            set => inner.EnableRaisingEvents = value;
        }

        /// <inheritdoc />
        public ProcessPriorityClass PriorityClass
        {
            get => inner.PriorityClass;
            set => inner.PriorityClass = value;
        }

        /// <inheritdoc />
        public int PrivateMemorySize => inner.PrivateMemorySize;

        /// <inheritdoc />
        public long PrivateMemorySize64 => inner.PrivateMemorySize64;

        /// <inheritdoc />
        public TimeSpan PrivilegedProcessorTime => inner.PrivilegedProcessorTime;

        /// <inheritdoc />
        public string ProcessName => inner.ProcessName;

        /// <inheritdoc />
        public IntPtr ProcessorAffinity
        {
            get => inner.ProcessorAffinity;
            set => inner.ProcessorAffinity = value;
        }

        /// <inheritdoc />
        public bool Responding => inner.Responding;

        /// <inheritdoc />
        public SafeProcessHandle SafeHandle => inner.SafeHandle;

        /// <inheritdoc />
        public int SessionId => inner.SessionId;

        /// <inheritdoc />
        public StreamReader StandardError => inner.StandardError;

        /// <inheritdoc />
        public StreamWriter StandardInput => inner.StandardInput;

        /// <inheritdoc />
        public StreamReader StandardOutput => inner.StandardOutput;

        /// <inheritdoc />
        public ProcessStartInfo StartInfo
        {
            get => inner.StartInfo;
            set => inner.StartInfo = value;
        }

        /// <inheritdoc />
        public DateTime StartTime => inner.StartTime;

        /// <inheritdoc />
        public ISynchronizeInvoke SynchronizingObject
        {
            get => inner.SynchronizingObject;
            set => inner.SynchronizingObject = value;
        }

        /// <inheritdoc />
        public ProcessThreadCollection Threads => inner.Threads;

        /// <inheritdoc />
        public TimeSpan TotalProcessorTime => inner.TotalProcessorTime;

        /// <inheritdoc />
        public TimeSpan UserProcessorTime => inner.UserProcessorTime;

        /// <inheritdoc />
        public int VirtualMemorySize => inner.VirtualMemorySize;

        /// <inheritdoc />
        public long VirtualMemorySize64 => inner.VirtualMemorySize64;

        /// <inheritdoc />
        public int WorkingSet => inner.WorkingSet;

        /// <inheritdoc />
        public long WorkingSet64 => inner.WorkingSet64;

        /// <inheritdoc />
        public event DataReceivedEventHandler ErrorDataReceived;

        /// <inheritdoc />
        public event EventHandler Exited;

        /// <inheritdoc />
        public event DataReceivedEventHandler OutputDataReceived;

        protected void OnErrorDataReceived(object sender, DataReceivedEventArgs args)
        {
            ErrorDataReceived?.Invoke(sender, args);
        }

        protected void OnExited(object sender, EventArgs args)
        {
            Exited?.Invoke(sender, args);
        }

        protected void OnOutputDataReceived(object sender, DataReceivedEventArgs args)
        {
            OutputDataReceived?.Invoke(sender, args);
        }

        /// <inheritdoc />
        public void BeginErrorReadLine()
        {
            inner.BeginErrorReadLine();
        }

        /// <inheritdoc />
        public void BeginOutputReadLine()
        {
            inner.BeginOutputReadLine();
        }

        /// <inheritdoc />
        public void CancelErrorRead()
        {
            inner.CancelErrorRead();
        }

        /// <inheritdoc />
        public void CancelOutputRead()
        {
            inner.CancelOutputRead();
        }

        /// <inheritdoc />
        public void Close()
        {
            inner.Close();
        }

        /// <inheritdoc />
        public bool CloseMainWindow()
        {
            return inner.CloseMainWindow();
        }

        /// <inheritdoc />
        public void Kill()
        {
            inner.Kill();
        }

        /// <inheritdoc />
        public void Refresh()
        {
            inner.Refresh();
        }

        /// <inheritdoc />
        public bool Start()
        {
            return inner.Start();
        }

        /// <inheritdoc />
        public void WaitForExit()
        {
            inner.WaitForExit();
        }

        /// <inheritdoc />
        public bool WaitForExit(int milliseconds)
        {
            return inner.WaitForExit(milliseconds);
        }

        /// <inheritdoc />
        public bool WaitForInputIdle()
        {
            return inner.WaitForInputIdle();
        }

        /// <inheritdoc />
        public bool WaitForInputIdle(int milliseconds)
        {
            return inner.WaitForInputIdle(milliseconds);
        }

        /// <summary>
        ///     Puts a <see cref="T:System.Diagnostics.Abstractions.Process"></see> component in state to interact with
        ///     operating system processes that run in a special mode by enabling the native property SeDebugPrivilege on the
        ///     current thread.
        /// </summary>
        public static void EnterDebugMode()
        {
            System.Diagnostics.Process.EnterDebugMode();
        }

        /// <summary>
        ///     Gets a new <see cref="T:System.Diagnostics.Abstractions.Process"></see> component and associates it with the
        ///     currently active process.
        /// </summary>
        /// <returns>
        ///     A new <see cref="T:System.Diagnostics.Abstractions.Process"></see> component associated with the process
        ///     resource that is running the calling application.
        /// </returns>
        public static IProcess GetCurrentProcess()
        {
            return new ProcessWrapper(System.Diagnostics.Process.GetCurrentProcess());
        }

        /// <summary>
        ///     Returns a new <see cref="T:System.Diagnostics.Abstractions.Process"></see> component, given the identifier of
        ///     a process on the local computer.
        /// </summary>
        /// <param name="processId">The system-unique identifier of a process resource.</param>
        /// <returns>
        ///     A <see cref="T:System.Diagnostics.Abstractions.Process"></see> component that is associated with the local
        ///     process resource identified by the <paramref name="processId">processId</paramref> parameter.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///     The process specified by the
        ///     <paramref name="processId">processId</paramref> parameter is not running. The identifier might be expired.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">The process was not started by this object.</exception>
        public static IProcess GetProcessById(int processId)
        {
            return new ProcessWrapper(System.Diagnostics.Process.GetProcessById(processId));
        }

        /// <summary>
        ///     Returns a new <see cref="T:System.Diagnostics.Abstractions.Process"></see> component, given a process
        ///     identifier and the name of a computer on the network.
        /// </summary>
        /// <param name="processId">The system-unique identifier of a process resource.</param>
        /// <param name="machineName">The name of a computer on the network.</param>
        /// <returns>
        ///     A <see cref="T:System.Diagnostics.Abstractions.Process"></see> component that is associated with a remote
        ///     process resource identified by the <paramref name="processId">processId</paramref> parameter.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///     The process specified by the
        ///     <paramref name="processId">processId</paramref> parameter is not running. The identifier might be expired.   -or-
        ///     The <paramref name="machineName">machineName</paramref> parameter syntax is invalid. The name might have length
        ///     zero (0).
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException">
        ///     The <paramref name="machineName">machineName</paramref> parameter is
        ///     null.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">The process was not started by this object.</exception>
        public static IProcess GetProcessById(int processId, string machineName)
        {
            return new ProcessWrapper(System.Diagnostics.Process.GetProcessById(processId, machineName));
        }

        /// <summary>
        ///     Creates a new <see cref="T:System.Diagnostics.Abstractions.Process"></see> component for each process resource
        ///     on the local computer.
        /// </summary>
        /// <returns>
        ///     An array of type <see cref="T:System.Diagnostics.Abstractions.Process"></see> that represents all the process
        ///     resources running on the local computer.
        /// </returns>
        public static IProcess[] GetProcesses()
        {
            return System.Diagnostics.Process.GetProcesses().Select(x => new ProcessWrapper(x)).ToArray<IProcess>();
        }

        /// <summary>
        ///     Creates a new <see cref="T:System.Diagnostics.Abstractions.Process"></see> component for each process resource
        ///     on the specified computer.
        /// </summary>
        /// <param name="machineName">The computer from which to read the list of processes.</param>
        /// <returns>
        ///     An array of type <see cref="T:System.Diagnostics.Abstractions.Process"></see> that represents all the process
        ///     resources running on the specified computer.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///     The <paramref name="machineName">machineName</paramref> parameter syntax
        ///     is invalid. It might have length zero (0).
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException">
        ///     The <paramref name="machineName">machineName</paramref> parameter is
        ///     null.
        /// </exception>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The operating system platform does not support this operation
        ///     on remote computers.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        ///     There are problems accessing the performance counter API's used to
        ///     get process information. This exception is specific to Windows NT, Windows 2000, and Windows XP.
        /// </exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">A problem occurred accessing an underlying system API.</exception>
        public static IProcess[] GetProcesses(string machineName)
        {
            return System.Diagnostics.Process.GetProcesses(machineName).Select(x => new ProcessWrapper(x)).ToArray<IProcess>();
        }

        /// <summary>
        ///     Creates an array of new <see cref="T:System.Diagnostics.Abstractions.Process"></see> components and associates
        ///     them with all the process resources on the local computer that share the specified process name.
        /// </summary>
        /// <param name="processName">The friendly name of the process.</param>
        /// <returns>
        ///     An array of type <see cref="T:System.Diagnostics.Abstractions.Process"></see> that represents the process
        ///     resources running the specified application or file.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">
        ///     There are problems accessing the performance counter API's used to
        ///     get process information. This exception is specific to Windows NT, Windows 2000, and Windows XP.
        /// </exception>
        public static IProcess[] GetProcessesByName(string processName)
        {
            return System.Diagnostics.Process.GetProcessesByName(processName).Select(x => new ProcessWrapper(x))
                .ToArray<IProcess>();
        }

        /// <summary>
        ///     Creates an array of new <see cref="T:System.Diagnostics.Abstractions.Process"></see> components and associates
        ///     them with all the process resources on a remote computer that share the specified process name.
        /// </summary>
        /// <param name="processName">The friendly name of the process.</param>
        /// <param name="machineName">The name of a computer on the network.</param>
        /// <returns>
        ///     An array of type <see cref="T:System.Diagnostics.Abstractions.Process"></see> that represents the process
        ///     resources running the specified application or file.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///     The <paramref name="machineName">machineName</paramref> parameter syntax
        ///     is invalid. It might have length zero (0).
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException">
        ///     The <paramref name="machineName">machineName</paramref> parameter is
        ///     null.
        /// </exception>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The operating system platform does not support this operation
        ///     on remote computers.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        ///     There are problems accessing the performance counter API's used to
        ///     get process information. This exception is specific to Windows NT, Windows 2000, and Windows XP.
        /// </exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">A problem occurred accessing an underlying system API.</exception>
        public static IProcess[] GetProcessesByName(string processName, string machineName)
        {
            return System.Diagnostics.Process.GetProcessesByName(processName, machineName).Select(x => new ProcessWrapper(x))
                .ToArray<IProcess>();
        }

        /// <summary>
        ///     Takes a <see cref="T:System.Diagnostics.Abstractions.Process"></see> component out of the state that lets it
        ///     interact with operating system processes that run in a special mode.
        /// </summary>
        public static void LeaveDebugMode()
        {
            System.Diagnostics.Process.LeaveDebugMode();
        }

        /// <summary>
        ///     Starts the process resource that is specified by the parameter containing process start information (for
        ///     example, the file name of the process to start) and associates the resource with a new
        ///     <see cref="T:System.Diagnostics.Abstractions.Process"></see> component.
        /// </summary>
        /// <param name="startInfo">
        ///     The <see cref="T:System.Diagnostics.Abstractions.ProcessStartInfo"></see> that contains the
        ///     information that is used to start the process, including the file name and any command-line arguments.
        /// </param>
        /// <returns>
        ///     A new <see cref="T:System.Diagnostics.Abstractions.Process"></see> that is associated with the process
        ///     resource, or null if no process resource is started. Note that a new process that’s started alongside already
        ///     running instances of the same process will be independent from the others. In addition, Start may return a non-null
        ///     Process with its <see cref="P:System.Diagnostics.Abstractions.Process.HasExited"></see> property already set to
        ///     true. In this case, the started process may have activated an existing instance of itself and then exited.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">
        ///     No file name was specified in the
        ///     <paramref name="startInfo">startInfo</paramref> parameter's
        ///     <see cref="P:System.Diagnostics.Abstractions.ProcessStartInfo.FileName"></see> property.   -or-   The
        ///     <see cref="P:System.Diagnostics.Abstractions.ProcessStartInfo.UseShellExecute"></see> property of the
        ///     <paramref name="startInfo">startInfo</paramref> parameter is true and the
        ///     <see cref="P:System.Diagnostics.Abstractions.ProcessStartInfo.RedirectStandardInput"></see>,
        ///     <see cref="P:System.Diagnostics.Abstractions.ProcessStartInfo.RedirectStandardOutput"></see>, or
        ///     <see cref="P:System.Diagnostics.Abstractions.ProcessStartInfo.RedirectStandardError"></see> property is also true.
        ///     -or-   The <see cref="P:System.Diagnostics.Abstractions.ProcessStartInfo.UseShellExecute"></see> property of the
        ///     <paramref name="startInfo">startInfo</paramref> parameter is true and the
        ///     <see cref="P:System.Diagnostics.Abstractions.ProcessStartInfo.UserName"></see> property is not null or empty or the
        ///     <see cref="P:System.Diagnostics.Abstractions.ProcessStartInfo.Password"></see> property is not null.
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="startInfo">startInfo</paramref> parameter is null.</exception>
        /// <exception cref="T:System.ObjectDisposedException">The process object has already been disposed.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        ///     The file specified in the
        ///     <paramref name="startInfo">startInfo</paramref> parameter's
        ///     <see cref="P:System.Diagnostics.Abstractions.ProcessStartInfo.FileName"></see> property could not be found.
        /// </exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">
        ///     An error occurred when opening the associated file.   -or-
        ///     The sum of the length of the arguments and the length of the full path to the process exceeds 2080. The error
        ///     message associated with this exception can be one of the following: "The data area passed to a system call is too
        ///     small." or "Access is denied."
        /// </exception>
        public static IProcess Start(ProcessStartInfo startInfo)
        {
            return new ProcessWrapper(System.Diagnostics.Process.Start(startInfo));
        }

        /// <summary>
        ///     Starts a process resource by specifying the name of a document or application file and associates the resource
        ///     with a new <see cref="T:System.Diagnostics.Abstractions.Process"></see> component.
        /// </summary>
        /// <param name="fileName">The name of a document or application file to run in the process.</param>
        /// <returns>
        ///     A new <see cref="T:System.Diagnostics.Abstractions.Process"></see> that is associated with the process
        ///     resource, or null if no process resource is started. Note that a new process that’s started alongside already
        ///     running instances of the same process will be independent from the others. In addition, Start may return a non-null
        ///     Process with its <see cref="P:System.Diagnostics.Abstractions.Process.HasExited"></see> property already set to
        ///     true. In this case, the started process may have activated an existing instance of itself and then exited.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.Win32Exception">An error occurred when opening the associated file.</exception>
        /// <exception cref="T:System.ObjectDisposedException">The process object has already been disposed.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The PATH environment variable has a string containing quotes.</exception>
        public static IProcess Start(string fileName)
        {
            return new ProcessWrapper(System.Diagnostics.Process.Start(fileName));
        }

        /// <summary>
        ///     Starts a process resource by specifying the name of an application and a set of command-line arguments, and
        ///     associates the resource with a new <see cref="T:System.Diagnostics.Abstractions.Process"></see> component.
        /// </summary>
        /// <param name="fileName">The name of an application file to run in the process.</param>
        /// <param name="arguments">Command-line arguments to pass when starting the process.</param>
        /// <returns>
        ///     A new <see cref="T:System.Diagnostics.Abstractions.Process"></see> that is associated with the process
        ///     resource, or null if no process resource is started. Note that a new process that’s started alongside already
        ///     running instances of the same process will be independent from the others. In addition, Start may return a non-null
        ///     Process with its <see cref="P:System.Diagnostics.Abstractions.Process.HasExited"></see> property already set to
        ///     true. In this case, the started process may have activated an existing instance of itself and then exited.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The <paramref name="fileName">fileName</paramref> or
        ///     <paramref name="arguments">arguments</paramref> parameter is null.
        /// </exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">
        ///     An error occurred when opening the associated file.   -or-
        ///     The sum of the length of the arguments and the length of the full path to the process exceeds 2080. The error
        ///     message associated with this exception can be one of the following: "The data area passed to a system call is too
        ///     small." or "Access is denied."
        /// </exception>
        /// <exception cref="T:System.ObjectDisposedException">The process object has already been disposed.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The PATH environment variable has a string containing quotes.</exception>
        public static IProcess Start(string fileName, string arguments)
        {
            return new ProcessWrapper(System.Diagnostics.Process.Start(fileName, arguments));
        }

        /// <summary>
        ///     Starts a process resource by specifying the name of an application, a user name, a password, and a domain and
        ///     associates the resource with a new <see cref="T:System.Diagnostics.Abstractions.Process"></see> component.
        /// </summary>
        /// <param name="fileName">The name of an application file to run in the process.</param>
        /// <param name="userName">The user name to use when starting the process.</param>
        /// <param name="password">
        ///     A <see cref="T:System.Security.SecureString"></see> that contains the password to use when
        ///     starting the process.
        /// </param>
        /// <param name="domain">The domain to use when starting the process.</param>
        /// <returns>
        ///     A new <see cref="T:System.Diagnostics.Abstractions.Process"></see> that is associated with the process
        ///     resource, or null if no process resource is started. Note that a new process that’s started alongside already
        ///     running instances of the same process will be independent from the others. In addition, Start may return a non-null
        ///     Process with its <see cref="P:System.Diagnostics.Abstractions.Process.HasExited"></see> property already set to
        ///     true. In this case, the started process may have activated an existing instance of itself and then exited.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">No file name was specified.</exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">There was an error in opening the associated file.</exception>
        /// <exception cref="T:System.ObjectDisposedException">The process object has already been disposed.</exception>
        public static IProcess Start(string fileName, string userName, SecureString password, string domain)
        {
            return new ProcessWrapper(System.Diagnostics.Process.Start(fileName, userName, password, domain));
        }

        /// <summary>
        ///     Starts a process resource by specifying the name of an application, a set of command-line arguments, a user
        ///     name, a password, and a domain and associates the resource with a new
        ///     <see cref="T:System.Diagnostics.Abstractions.Process"></see> component.
        /// </summary>
        /// <param name="fileName">The name of an application file to run in the process.</param>
        /// <param name="arguments">Command-line arguments to pass when starting the process.</param>
        /// <param name="userName">The user name to use when starting the process.</param>
        /// <param name="password">
        ///     A <see cref="T:System.Security.SecureString"></see> that contains the password to use when
        ///     starting the process.
        /// </param>
        /// <param name="domain">The domain to use when starting the process.</param>
        /// <returns>
        ///     A new <see cref="T:System.Diagnostics.Abstractions.Process"></see> that is associated with the process
        ///     resource, or null if no process resource is started. Note that a new process that’s started alongside already
        ///     running instances of the same process will be independent from the others. In addition, Start may return a non-null
        ///     Process with its <see cref="P:System.Diagnostics.Abstractions.Process.HasExited"></see> property already set to
        ///     true. In this case, the started process may have activated an existing instance of itself and then exited.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">No file name was specified.</exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">
        ///     An error occurred when opening the associated file.   -or-
        ///     The sum of the length of the arguments and the length of the full path to the associated file exceeds 2080. The
        ///     error message associated with this exception can be one of the following: "The data area passed to a system call is
        ///     too small." or "Access is denied."
        /// </exception>
        /// <exception cref="T:System.ObjectDisposedException">The process object has already been disposed.</exception>
        public static IProcess Start(string fileName, string arguments, string userName, SecureString password,
            string domain)
        {
            return new ProcessWrapper(System.Diagnostics.Process.Start(fileName, arguments, userName, password, domain));
        }
    }
}