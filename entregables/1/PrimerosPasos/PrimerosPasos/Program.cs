using PrimerosPasos.Clases;

Producto producto = new Producto(1, "Camiseta", 10, 20, 100, 1);

Console.WriteLine(  "el producto con el id " + producto.Id.ToString() +
                    "es " + producto.Descripcion);
Console.ReadKey();