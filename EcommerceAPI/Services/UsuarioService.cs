
using EcommerceAPI.Database;
using EcommerceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_app.Services
{
    public static class UsuarioService
    {
        public static Usuario Obtener(int id) { 
            using(EcommerceContext context = new())
            {
                return context.Usuarios.Find(id);
            }
        }
        public static List<Usuario> Listar() {
            using(EcommerceContext context = new())
            {
                return context.Usuarios.ToList();
            }
        }
        public static void Crear(Usuario u) {
            using(EcommerceContext context = new())
            {
                context.Usuarios.Add(u);
                context.SaveChanges();
            }
        }
        public static bool Modificar(Usuario u) {
            using(EcommerceContext ctx = new())
            {
                if(Obtener(u.Id) is not null) {
                    ctx.Usuarios.Update(u);
                    ctx.SaveChanges();
                    return true;
                }
            else return false;
            }
        }
        public static bool Eliminar(int id) {
            using (EcommerceContext ctx = new())
            {
                Usuario u = Obtener(id);
                if (u is not null)
                {
                    ctx.Usuarios.Remove(u);
                    ctx.SaveChanges();
                    return true;
                }
                else return false;
            }
        } 

       
    }
}
