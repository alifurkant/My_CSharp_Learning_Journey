//Ternary If Examples

Console.Write("Lütfen adınızı giriniz : ");

string name = Console.ReadLine();

Console.WriteLine(name == "Furkan" ? "girilen isim doğrudur" : "girilen isim yanlıştır ");


//Example 2

Console.Write("birinci sayıyı giriniz : ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("ikinci sayıyı giriniz : ");

int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num1 < num2 ? "birinci sayı küçüktür" : "ikinci sayı küçüktür");


//Assigning bool value with Ternary If

bool sonuc = num1 < num2 ? true : false;

Console.WriteLine("sonuç değişkeninin değeri : {0}", sonuc.ToString());

Console.WriteLine("sonuç değişkenindeki değere göre : {0}", (sonuc ? "birinci sayı küçüktür" : "ikinci sayı küçüktür"));