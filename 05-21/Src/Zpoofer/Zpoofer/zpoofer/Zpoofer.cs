using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Win32;

namespace zpoofer
{
	// Token: 0x02000003 RID: 3
	internal class Zpoofer
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002164 File Offset: 0x00000364
		public static void bXGmOoIp4cD8EAPyaStP()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("                         ::::::::: :::::::::   ::::::::   ::::::::  :::::::::: :::::::::: ::::::::: ");
			Console.WriteLine("                             :+:  :+:    :+: :+:    :+: :+:    :+: :+:        :+:        :+:    :+: ");
			Console.WriteLine("                           +:+   +:+    +:+ +:+    +:+ +:+    +:+ +:+        +:+        +:+    +:+  ");
			Console.WriteLine("                         +#+    +#++:++#+  +#+    +:+ +#+    +:+ :#::+::#   +#++:++#   +#++:++#: ");
			Console.WriteLine("                       +#+     +#+        +#+    +#+ +#+    +#+ +#+        +#+        +#+    +#+   ");
			Console.WriteLine("                     #+#      #+#        #+#    #+# #+#    #+# #+#        #+#        #+#    #+#   ");
			Console.WriteLine("                   ######### ###         ########   ########  ###        ########## ###    ###   ");
			Console.ForegroundColor = ConsoleColor.White;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000021E4 File Offset: 0x000003E4
		public static void checkHWID()
		{
			try
			{
				Console.Clear();
				string str = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001", "GUID", "default");
				Console.WriteLine("[Zpoofer] Current HWID: " + str);
				Console.ReadKey();
			}
			catch (Exception)
			{
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("[ZSpoofer] Error while getting your HWID");
				Console.ReadKey();
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002274 File Offset: 0x00000474
		public static void spoofHWID()
		{
			try
			{
				Console.Clear();
				string keyName = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001";
				string str = (string)Registry.GetValue(keyName, "HwProfileGuid", "default");
				string text = string.Concat(new string[]
				{
					"{Zpoofer-",
					Zpoofer.randomString(5),
					"-",
					Zpoofer.randomString(5),
					"-",
					Zpoofer.randomString(4),
					"-",
					Zpoofer.randomString(9),
					"}"
				});
				Registry.SetValue(keyName, "GUID", text);
				Registry.SetValue(keyName, "HwProfileGuid", text);
				Console.WriteLine("[Zpoofer] HWID ZPOOFED!");
				Console.WriteLine("\n[Zpoofer] Old HWID: " + str);
				Console.WriteLine("\n[Zpoofer] New HWID: " + text);
				Console.ReadKey();
			}
			catch (Exception)
			{
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("[Zpoofer] - Failed to Zpoof your HWID [Try to launch as administrator =)] ");
				Console.ReadKey();
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000023B4 File Offset: 0x000005B4
		public static string randomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("123457869", length)
				select s[Zpoofer.rdm.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		public Zpoofer()
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002058 File Offset: 0x00000258
		// Note: this type is marked as 'beforefieldinit'.
		static Zpoofer()
		{
		}

		// Token: 0x04000001 RID: 1
		private static Random rdm = new Random();

		// Token: 0x02000004 RID: 4
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000009 RID: 9 RVA: 0x00002064 File Offset: 0x00000264
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
			public <>c()
			{
			}

			// Token: 0x0600000B RID: 11 RVA: 0x00002070 File Offset: 0x00000270
			internal char <GenID>b__4_0(string s)
			{
				return s[Zpoofer.rdm.Next(s.Length)];
			}

			// Token: 0x04000002 RID: 2
			public static readonly Zpoofer.<>c <>9 = new Zpoofer.<>c();

			// Token: 0x04000003 RID: 3
			public static Func<string, char> <>9__4_0;
		}
	}
}
