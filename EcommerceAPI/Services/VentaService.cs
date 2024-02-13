
using EcommerceAPI.Database;
using EcommerceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_app.Services
{
    public  class VentaService
    {
        private EcommerceContext context;
        public VentaService(EcommerceContext ctx) {
            this.context = ctx;
        }

        public Venta Obtener(int id) {
          
                return this.context.Venta.Find(id);
            
        }
        public  List<Venta> Listar() {
            
                return this.context.Venta.ToList();
           
        }
        public void Crear(Venta venta) {
            
                this.context.Venta.Add(venta);
                this.context.SaveChanges();
            
        }
        public bool Modificar(Venta v)
        {
            
                if (Obtener(v.Id) is not null)
                {
                    this.context.Venta.Update(v);
                    this.context.SaveChanges();
                    return true;
                }
                else return false;
            
        }
        public bool Delete(int id) {
            
                Venta v = Obtener(id);
                if (v is not null)
                {
                    this.context.Venta.Remove(v);
                    this.context.SaveChanges();
                    return true;
                }
                else return false;
             
        }   
 
    }
}
