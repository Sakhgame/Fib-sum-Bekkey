// See https://aka.ms/new-console-template for more informationi
int N= int.Parse(Console.ReadLine());
int s = 0;
int f1 = 1;
int f2 = 1;
int c;
for (int i = 1; i < N; i++)
{
    s = s + f1;
    c = f1;
    f1 = f2;
    f2 = c + f2;
}
Console.WriteLine(s);

