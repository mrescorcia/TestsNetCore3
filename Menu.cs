using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class Menu : IMenu
    {
        Almacen golosina = new Golosinas();
        public void Golosinas()
        {
            var des = "";
            var valor = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Venta de Golosinas y Frutas");
                if (golosina.getProductos("").Count.Equals(0))
                {
                    Console.WriteLine("No hay Golosinas");
                    Console.WriteLine("Desea agregar Golosinas? Presione las teclas s/n");
                    des = Console.ReadLine();
                    if (des.Equals("s"))
                    {
                        Console.WriteLine("Cuantas Golosinas Desea Agregar?");
                        int cant = Convert.ToInt16(Console.ReadLine());
                        for (int i = 0; i < cant; i++)
                        {
                            Console.WriteLine("Nueva Golosina");
                            Console.WriteLine("Ingrese la Id");
                            var id = Console.ReadLine();
                            Console.WriteLine("Ingrese Nombre");
                            var nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese Precio");
                            var precio = Convert.ToDouble(Console.ReadLine());
                            golosina.addProducto(new Producto { 
                                Id = id,
                                Nombre = nombre,
                                Precio = precio
                            });
                        }
                        Console.WriteLine("Desea ir al Inicio? s/n");
                        des = Console.ReadLine();
                        if (des.Equals("s"))
                        {
                            valor = true;
                        }
                        else
                        {
                            valor = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Desea ir al Inicio? s/n");
                        des = Console.ReadLine();
                        if (des.Equals("s"))
                        {
                            Console.Clear();
                            Console.WriteLine("Venta de Golosinas y Frutas");
                        }
                        else
                        {
                            valor = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Lista de Golosinas");
                    foreach (var item in golosina.getProductos(""))
                    {
                        Console.WriteLine($"Codigo: {item.Id} Golosina: {item.Nombre} Precio: {item.Precio}");
                    }
                    Console.WriteLine("Desea realizar ventas de golosinas? s/n");
                    des = Console.ReadLine();
                    if (des.Equals("s"))
                    {
                        Ventas();
                    }
                    else
                    {
                        valor = false;
                    }
                }
            } while (valor);
        }

        public double SolicitarPago()
        {
            Boolean pagoCorrecto = false;
            Double res = 0;
            while (!pagoCorrecto)
            {
                Console.WriteLine("Como desea pagar con: 10, 5");
                res = Double.Parse(Console.ReadLine());
                if (res != 5 && res != 10)
                {
                    Console.WriteLine("Pago NO Valido");
                }
                else
                {
                    pagoCorrecto = true;
                }
            }
            return res;
        }

        public void Ventas()
        {
            Double total = 0;
            String des = "";
            do
            {
                Console.WriteLine("Ingrese el Producto");
                String producto = Console.ReadLine();
                var productos = golosina.getProductos(producto);
                while (productos.Count.Equals(0))
                {
                    Console.WriteLine("Golosinas no disponibles, por favor seleccione otro.");
                    producto = Console.ReadLine();
                    productos = golosina.getProductos(producto);
                }
                Console.WriteLine($"Su monto a pagar es: {productos[0].Precio} $Dolar");
                Double pago = SolicitarPago();

                while (pago < productos[0].Precio)
                {
                    Console.WriteLine($"Faltan {productos[0].Precio - pago} Dolar");
                    pago += SolicitarPago();
                }
                Console.WriteLine($"Su cambio es {pago - productos[0].Precio}");
                total += productos[0].Precio;
                Console.WriteLine($"Su pago fue de {total} $Dolar");
                Console.WriteLine("Desea realizar otra compra? s/n");
                des = Console.ReadLine();

            } while (des.Equals("s"));
        }
    }
}
