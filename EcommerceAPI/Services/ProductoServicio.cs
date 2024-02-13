using EcommerceAPI.Database;
using EcommerceAPI.Models;

namespace EcommerceAPI.Services
{
    public class ProductoServicio

    {

        public  Producto Obtener(int id)
        {
            using (EcommerceContext context = new EcommerceContext())
            {
                return context.Productos.Where(u => u.Id == id).FirstOrDefault();
            }

        }
        public  List<Producto> Listar()
        {
            using (EcommerceContext context = new())
            {
                List<Producto> list = context.Productos.ToList();
                return list;
            }
        }
        public  void Crear(Producto producto)
        {
            using (EcommerceContext context = new())
            {
                context.Productos.Add(producto);
                context.SaveChanges();
            }
        }
        public  bool Modificar(Producto producto)
        {
            using (EcommerceContext ctx = new EcommerceContext())
            {
                if (Obtener(producto.Id) is not null)
                {
                    ctx.Update(producto);
                    ctx.SaveChanges();
                    return true;
                }
                else return false;
            }
        }
        public  bool Eliminar(int id)
        {
            using (EcommerceContext context = new EcommerceContext())
            {
                Producto p = Obtener(id);
                if (p is not null)
                {
                    context.Remove(p);
                    context.SaveChanges();
                    return true;
                }
                else return false;
            }
        }

    }
}
