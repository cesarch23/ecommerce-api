using EcommerceAPI.Database;
using EcommerceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_app.Services
{
    public  class ProductoVendidoService
    {
        private EcommerceContext context;
        public ProductoVendidoService( EcommerceContext ctx)
        {
            this.context = ctx;
        }
        public ProductoVendido Obtener(int id) {
            
             return this.context.ProductoVendidos.Where(u => u.Id == id).FirstOrDefault();
            
        }
        public  List<ProductoVendido> Listar() {
          
              return this.context.ProductoVendidos.ToList();
           
        }
        public void Crear(ProductoVendido productoVendido) {
         
                this.context.ProductoVendidos.Add(productoVendido);
                this.context.SaveChanges();
          
        }

        public bool Modificar(ProductoVendido productoVendido) { 
          
                if (productoVendido == null)return false;
                this.context.ProductoVendidos.Update(productoVendido);
                this.context.SaveChanges();
                return true;
            
        }

        public bool Eliminar(int id) { 
       
                if (Obtener(id) is not null)
                {
                    this.context.ProductoVendidos.Remove(Obtener(id));
                    this.context.SaveChanges();
                    return true;
                }
                else return false;
       
        }
    }
}
