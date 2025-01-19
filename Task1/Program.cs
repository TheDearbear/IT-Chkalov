using System;
using System.IO;
using System.Text;

byte[] bytes = File.ReadAllBytes("input.txt");
StringBuilder sb = new StringBuilder(bytes.Length / 8);

int bit = 0;
byte semiResult = 0;
foreach (byte value in bytes)
{
	byte numValue = (byte)(value - 0x30); // '0' == 0x30

	semiResult <<= 1;
	semiResult += numValue;

	if (++bit == 8)
	{
		sb.Append((char)semiResult);
		bit = 0;
		semiResult = 0;
	}
}

File.WriteAllText("output.txt", sb.ToString());
