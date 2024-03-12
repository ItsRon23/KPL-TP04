// See https://aka.ms/new-console-template for more information

using static KodePos;
    
public class KodePos
{
    public enum EnumKodepos
    {
        Batununggal, Kujangsari,
        Mengger, Wates,
        Cijaura, Jatisari,
        Sekejati, Kebonwaru,
        Maleer, Samoja
    }

    public static String getKodePos(EnumKodepos Wilayah)
    {
        String[] outputKode = { "40266", "40287", "40267", "40256", "40287", "40286", "40286", "40286", "40272", "40274", "40273" };
        return outputKode[(int)Wilayah];
    }
}



public class Hello
{
    public static void Main(String[] args)
    {
        EnumKodepos list = EnumKodepos.Sekejati;
        String kodePos = getKodePos(list);
        Console.WriteLine("wilayah {1}, Kode Pos nya {0}", kodePos, list);


    }
}