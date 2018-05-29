using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHotkey.Core
{
	public static class PasswordGenerator
	{
		public static void GeneratePassword()
		{
			char[] chars = { '2', '3', '4', '5', '6', '7', '8', '9',
							'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'j', 'k', 'm', 'n', 'p', 'r', 's', 't', 'w', 'z', 'y', 'x',
							'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'M', 'N', 'P', 'R', 'S', 'T', 'W', 'Z', 'Y', 'X' };

			string password;

			Random rnd = new Random();
			do
			{
				password = "";

				for (int i = 0; i < 14; i++)
				{
					password += chars[rnd.Next(chars.Length)];
				}

			} while (password == password.ToUpper() || password == password.ToLower() || password.All(char.IsLetter) || password.All(char.IsDigit));

			System.Windows.Clipboard.SetText(password);

		}
	}
}
