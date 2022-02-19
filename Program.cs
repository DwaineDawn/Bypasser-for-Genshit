using System;
using System.Linq;
using System.Text;
using System.Net;
using System.Runtime.CompilerServices; 
using System.Linq.Expressions;
using Microsoft.CSharp.RuntimeBinder;
using System.IO;
using System.Threading;
using System.Diagnostics;  
using System.Runtime.InteropServices; 
using System.CodeDom.Compiler;
using System.Reflection;
using System.Data;
using System.Security.Principal;
using System.Security.AccessControl;

namespace Bypasser_Mhyprot2
{
    public class Program
    {
        [STAThread]
        [DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "3.1.0.2")]
        
        public static void Main(string[] args)
        {
            
            RandTitle();
            
            //Global 
            if (Process.GetProcessByName("GenshinImpact").Lenght != 0)
            {
                Console.WriteLine("PROCESS FOUND");
            }
            
            //Chinese
            if (Process.GetProcessByName("GenshinImpact").Lenght != 0)
            {
                Console.WriteLine("PROCESS FOUND");
            }
            
            //not found
            Console.WriteLine("START GENSHIN IMPACT");
	    Console.ReadKey();
        }
        
        private static void RandTitle()
        {
            Console.Title = "";
            Random rnd = new Random();
            Char[] pwdChars = new Char[62]
            {   'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };
            for (int i = 20; i < 75; i++)
            {
                Console.Title += pwdChars[rnd.Next(0, 35)];
            }
            Thread.Sleep(10);
        }
        
        public static void LoadFile()
        {
            bool flag = false;
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | 
                                                       SecurityProtocolType.Tls | 
                                                       SecurityProtocolType.Tls11 | 
                                                       SecurityProtocolType.Tls12;
                
                WebClient webClient = new WebClient();
                Console.WriteLine("Retrieving...");
                
                if (File.Exists(Path.Combine(Path.GetTempPath(), "")) && new FileInfo(
                    Path.Combine(Path.GetTempPath(), "")).Length > 200L)
		{
		     flag = true;
	        }
                else
                {
                    return 0;
                }
                
                if (flag)
                {
                    //bypass
                    File.Delete(Path.Combine(Path.GetTempPath(), "Bypass.exe"));
                    Thread.Sleep(100);
                }
                
            }
            catch (Exception arg)
            {
                Console.WriteLine("Error! " + arg);
	        Console.ReadKey();
            }
            catch (WebException)
            {
                Console.WriteLine("No internet connection!");
		Console.ReadKey();
            }
        }
        
        
//         [Flags]
//         public enum ProcessAccessFlags : uint
//         {
//             All = 0x001F0FFF,
// 			Terminate = 0x00000001,
// 			CreateThread = 0x00000002,
// 			VirtualMemoryOperation = 0x00000008,
// 			VirtualMemoryRead = 0x00000010,
// 			VirtualMemoryWrite = 0x00000020,
// 			DuplicateHandle = 0x00000040,
// 			CreateProcess = 0x000000080,
// 			SetQuota = 0x00000100,
// 			SetInformation = 0x00000200,
// 			QueryInformation = 0x00000400,
// 			QueryLimitedInformation = 0x00001000,
// 			Synchronize = 0x00100000
//         }
        
//         [DllImport("kernel32.dll", SetLastError = true)]
// 		private static extern IntPtr OpenProcess(ProcessAccessFlags processAccess, bool bInheritHandle, int processId);
// 		[DllImport("kernel32.dll", SetLastError = true)]
// 		[return: MarshalAs(UnmanagedType.Bool)]
// 		private static extern bool CloseHandle(IntPtr hObject);
// 		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
// 		public static extern IntPtr GetModuleHandle(string lpModuleName);
// 		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
// 		private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);
// 		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
// 		private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);
// 		[DllImport("kernel32.dll")]
// 		private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, Int32 nSize, out IntPtr lpNumberOfBytesWritten);
// 		[DllImport("kernel32.dll", SetLastError = true)]
// 		private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);
// 		[DllImport("kernel32.dll")]
// 		static extern UInt32 WaitForSingleObject(IntPtr hHandle, UInt32 dwMilliseconds);
    }
}
