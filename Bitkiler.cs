namespace Inheritance;

public class Bitkiler:Canlilar
{
    public void FotosentezYapmak()
    {
        System.Console.WriteLine("Bitkiler fotosentez yapar.");
    }

}
public class TohumluBitkiler:Bitkiler
{
    public void TohumlaCogalma()
    {
        System.Console.WriteLine("Tohumlu bitkiler tohumla çoğalır");
    }
    
}
public class TohumsuzBitkiler:Bitkiler
{
    public void SporlaCogalma()
    {
        System.Console.WriteLine("Tohumsuz bitkiler sporla çoğalır");
    }
}
