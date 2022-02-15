using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public abstract class Almacen
    {
        public abstract List<Producto> getProductos(string producto);
        public abstract void addProducto(Producto producto);
    }
}
