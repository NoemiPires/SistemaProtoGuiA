using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SistemaProtoGuiA
{
    public class UsuarioRepository
    {
        public static void SaveOrUpdate(Usuario usuario)
        {
            try
            {
                using(Repository dbContext = new())
                {
                    if(usuario.Id == 0)
                    {
                        dbContext.Add(usuario);
                    }
                    else
                    {
                        dbContext.Entry(usuario).State
                            = EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
