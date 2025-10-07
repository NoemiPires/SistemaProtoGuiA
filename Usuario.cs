using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaProtoGuiA;

namespace SistemaProtoGuiA
{
    public class Usuario
    {
        public UInt64 Id { get; set; }
        public String Nome {  get; set; }

        public Boolean Ativo {  get; set; }

        public Usuario() 
        {
            Nome = String.Empty;
        }

        public override string ToString()
        {
            return Nome + " [" + Ativo +"]";
        }
    }
}
