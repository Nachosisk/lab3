double s = 0;
for (double i = 1.175; i <= 2.152; i += 0.015)
{
    s += i;
}
Console.WriteLine( s);

double s = 0;
double i = 1.175;
while (i <= 2.152)
{
    s += i;
    i += 0.015;
}
Console.WriteLine(s);