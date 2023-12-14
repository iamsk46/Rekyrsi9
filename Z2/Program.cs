int m = Numbers("Введите M: ");
int n = Numbers("Введите N: ");

int Akkerman = MN(m, n);

Console.Write($"Функция Аккермана = {Akkerman} ");

int MN(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return MN(m - 1, 1);
  else return MN(m - 1, MN(m, n - 1));
}

int Numbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}