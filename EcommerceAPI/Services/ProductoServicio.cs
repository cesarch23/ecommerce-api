using EcommerceAPI.Database;
using EcommerceAPI.Models;

namespace EcommerceAPI.Services
{
    public class ProductoServicio

    {
        private EcommerceContext context;

        public ProductoServicio(EcommerceContext ctx) {
            this.context = ctx; 
        }

        public  Producto Obtener(int id)
        {
            //using (EcommerceContext context = new EcommerceContext())
            //{
                return this.context.Productos.Where(u => u.Id == id).FirstOrDefault();
            //}

        }
        public  List<Producto> Listar()
        {
            //using (EcommerceContext context = new())
            //{
                List<Producto> list = this.context.Productos.ToList();
                return list;
            //}
        }
        public  void Crear(Producto producto)
        {
            //using (EcommerceContext context = new())
            //{
                this.context.Productos.Add(producto);
                this.context.SaveChanges();
            //}
        }
        public  bool Modificar(Producto producto)
        {
            //using (EcommerceContext ctx = new EcommerceContext())
            //{
                if (Obtener(producto.Id) is not null)
                {
                    this.context.Update(producto);
                    this.context.SaveChanges();
                    return true;
                }
                else return false;
            //}
        }
        public  bool Eliminar(int id)
        {
            //using (EcommerceContext context = new EcommerceContext())
            //{
                Producto p = Obtener(id);
                if (p is not null)
                {
                    this.context.Remove(p);
                    this.context.SaveChanges();
                    return true;
                }
                else return false;
            //}
        }

    }
}
