using System;
using zpoofer;

namespace mainzpoofer
{
	// Token: 0x02000002 RID: 2
	internal class Program
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002088 File Offset: 0x00000288
		private static void Main(string[] args)
		{
			Console.WriteLine("");
			Console.WriteLine("");
			Console.Title = "¤ _-_-_-_-_-_-__-_-_-_-_-_-__-_-_-_-_-_-__-_-_-_-_-_-__-_-_-_-_Zpoofer by Nelectrons_-_-_-_-_-_-__-_-_-_-_-_-__-_-_-_-_-_-__-_-_-_-_-_-__-_-_-_-_ ¤";
			Zpoofer.bXGmOoIp4cD8EAPyaStP();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("                                            |-------------------|");
			Console.WriteLine("                                            | [ 1 ] Spoof HWID  |");
			Console.WriteLine("                                            | [ 2 ] Check HWID  |");
			Console.WriteLine("                                            |-------------------|");
			Console.WriteLine();
			Console.Write("Choice : ");
			string a = Console.ReadLine();
			if (a == "1")
			{
				Zpoofer.spoofHWID();
			}
			if (a == "2")
			{
				Zpoofer.checkHWID();
				return;
			}
			Console.WriteLine("Choose one valid plz.");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		public Program()
		{
		}
	}
}
