Console.Clear();
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= num){
    Console.WriteLine(Math.Pow (count, 3));
    count ++;
}