using System;
using System.Text;

namespace basics
{
	public class Flag
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002086 File Offset: 0x00000286
		public static string GetFlag()
		{
			return Encoding.UTF8.GetString(Flag._obfuscatedFlag);
		}

		// Token: 0x04000003 RID: 3
		private static readonly byte[] _obfuscatedFlag = new byte[]
		{
			72,
			84,
			66,
			123,
			76,
			49,
			98,
			114,
			52,
			114,
			121,
			95,
			70,
			76,
			52,
			103,
			125
		};
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			var x = Flag.GetFlag();
			Console.WriteLine(x);
		}
	}
}
