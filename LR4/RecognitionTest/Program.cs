using System;

const int n = 10;

var weights = new double[n];
var random = new Random();
var result = string.Empty;

for (var i = 0; i < weights.Length; i++)
{
    weights[i] = Math.Round(random.NextDouble(), 2);
    result += weights[i] + " ";
}

result = result.TrimEnd(',', ' ');

Console.WriteLine(result);
