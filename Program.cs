// See https://aka.ms/new-console-template for more information

using static KodePos;
public enum trigger { BukaPintu, KunciPintu };
public enum status { Terkunci, Terbuka };

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

public class DoorMachine
{

    public status currentStatus;
    public DoorMachine()
    {
        this.currentStatus = status.Terkunci;
    }

    public void action(trigger Trigger)
    {
        if (Trigger == trigger.BukaPintu)
        {
            this.currentStatus = status.Terbuka;
        }
        else if (Trigger == trigger.KunciPintu)
        {
            this.currentStatus = status.Terkunci;
        }
    }
}

public class Hello
{
    public static void Main(String[] args)
    {
        EnumKodepos list = EnumKodepos.Sekejati;
        String kodePos = getKodePos(list);
        Console.WriteLine("wilayah {1}, Kode Pos nya {0}", kodePos, list);

        DoorMachine machine = new DoorMachine();
        machine.action(trigger.KunciPintu);

        if (machine.currentStatus == status.Terbuka)
        {
            Console.WriteLine("pintu tidak terkunci");
        }
        else if ((machine.currentStatus == status.Terkunci))
        {
            Console.WriteLine("pintu terkunci");
        }
    }
}