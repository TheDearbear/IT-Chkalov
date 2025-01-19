using System.IO;
using System.Text;

string encoded = File.ReadAllText("signal.txt");
StringBuilder sb = new StringBuilder(encoded.Length);

for (int i = 0; i < encoded.Length; i++)
{
	if (!char.IsAsciiLetter(encoded[i]))
	{
		sb.Append(encoded[i]);
		continue;
	}
	bool isLower = char.IsAsciiLetterLower(encoded[i]);

	char result = (char)(encoded[i] - 3);
	if (result < 'A' || (result < 'a' && isLower))
	{
		result += (char)26;
	}

	sb.Append(result);
}

File.WriteAllText("decoded.txt", sb.ToString());
