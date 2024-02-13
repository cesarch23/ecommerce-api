
using EcommerceAPI.Database;
using EcommerceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_app.Services
{
    public class UsuarioService
    {
        private readonly EcommerceContext context;
        public UsuarioService( EcommerceContext ctx ) {
            this.context = ctx;
        }
        public  Usuario Obtener(int id) { 
           
                return this.context.Usuarios.Find(id);
          
        }
        public  List<Usuario> Listar() {
           
                return  this.context.Usuarios.ToList();
           
        }
        public  void Crear(Usuario u) {
            
                this.context.Usuarios.Add(u);
                this.context.SaveChanges();
            
        }
        public bool Modificar(Usuario u) {
          
                if(Obtener(u.Id) is not null) {
                    this.context.Usuarios.Update(u);
                    this.context.SaveChanges();
                    return true;
                }
                else return false;
            
        }
        public  bool Eliminar(int id) {
          
                Usuario u = Obtener(id);
                if (u is not null)
                {
                    this.context.Usuarios.Remove(u);
                    this.context.SaveChanges();
                    return true;
                }
                else return false;
           
        } 

       
    }
}
