// See https://aka.ms/new-console-template for more information
int result = 1;
for(int i = 1; i < 5; i++)
{
    result=result*3;
}
Console.WriteLine(result);
islemler instance = new();
Console.WriteLine(instance.expo(3, 4));

string ifade = "Alp Dereli";
if (ifade.checkspace())
{
    Console.WriteLine(ifade.removespace());
}
Console.WriteLine(ifade.uppercaser());

int[] dizi = {2,342,5,24,647,13,63,142};
dizi.sortere();
dizi.yazdir();
Console.WriteLine(ifade.first());


public class islemler
{
    public int expo(int sayi, int us)
    {
        if (us < 2)
        {
            return sayi;
        }
        return expo(sayi, us-1);
    }
}
public static class extensions
{
    public static bool checkspace(this string param)
    {
        return param.Contains(" ");
    }
    public static string removespace(this string param)
    {
        string[] dizi = param.Split(" ");
        return string.Join("", dizi);
    }
    public static string uppercaser(this string param)
    {
        
        return param.ToUpper();
    }
    public static int[] sortere(this int[] param)
    {
        Array.Sort(param);
        return param;
    }
    public static void yazdir(this int[] param)
    {
        foreach(int i in param)
        {
            Console.WriteLine(i);
        }
    }
    public static string first(this string param)
    {
        return param.Substring(0,1);
    }
}
