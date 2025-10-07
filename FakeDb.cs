using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaProtoGuiA
{
    public class FakeDb
    {
       private List<Produto> _dados;
       public FakeDb() 
        {
            _dados = new List<Produto>();
            _dados.Add(new Produto() { Id = 1, Name = "Abacaxi", Preco = 9.89m });
            _dados.Add(new Produto() { Id = 2, Name = "Banana", Preco = 10.99m });
            _dados.Add(new Produto() { Id = 3, Name = "Caqui", Preco = 1.99m });
            _dados.Add(new Produto() { Id = 4, Name = "Damasco", Preco = 8.99m });
            _dados.Add(new Produto() { Id = 5, Name = "Embaúba", Preco = 3.99m });
            _dados.Add(new Produto() { Id = 5, Name = "Figo", Preco = 3.99m });
        }

       public List<Produto> LoadAll()
        {
            return _dados;
        }
    }
}
