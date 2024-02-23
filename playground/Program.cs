using System;

public static class Program
{
    public static void Main(string[] args)
    {


        resultBase a = new resultEntrada();

        a.entrada = 2;

        Console.WriteLine(a.entrada);
    }

    public class resultBase
    {
        public virtual int entrada { get; set; }
        public int saida { get; set; }
    }

    public class resultEntrada : resultBase
    {
        public override int entrada => base.entrada + 1;
    }

}