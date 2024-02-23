using AutoBuilder.Queries;
using System;

namespace AutoBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlBuiler = SqlBuilder.Select
                                      .Top(10)
                                      .Column("Preco")
                                      .Column("Promocao", false)
                                      .Column("Desconto", "Desc")
                                      .From("Produto").GetSql();

            Console.WriteLine(sqlBuiler);
        }
    }
}
