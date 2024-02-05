namespace Inheritance;

public class Hayvanlar:Canlilar
{
    public void Adaptasyon()
    {
        System.Console.WriteLine("Hayvanlar adapte olabilir.");
    }

}
public class Sürüngenler:Hayvanlar
{
    public void SurunerekHareketEderler()
    {
        System.Console.WriteLine("Sürüngenler sürünerek hareket ederler.");
    }
    
}

public class Kuslar:Hayvanlar
{
    public void Ucmak()
    {
        System.Console.WriteLine("Kuslar ucarlar.");
    }
}
