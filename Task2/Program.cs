using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

string[] lines = File.ReadAllLines("in.txt");

List<double> sin = new List<double>(lines.Length);
List<double> cos = new List<double>(lines.Length);

foreach (string line in lines)
{
	double radians = double.Parse(line) * (Math.PI / 180);

	(double currentSin, double currentCos) = Math.SinCos(radians);
	
	sin.Add(currentSin);
	cos.Add(currentCos);
}

double result = Math.Atan(sin.Average() / cos.Average()) * (180 / Math.PI);

File.WriteAllText("out.txt", Math.Round(result, 6).ToString());
