Console.Clear();
Console.Write("Введите пятизначное число ");
int num = int.Parse(Console.ReadLine());
string s = Convert.ToString(num);
if (s[0] == s[4] && s[1] == s[3]){
    Console.WriteLine("Число палиндром");
}
else Console.WriteLine("Число не является палиндромом");