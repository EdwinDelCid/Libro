using System;
using System.Collections.Generic;

namespace Libreria
{
    class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal CantidadEnInventario { get; set; }
        public string Categoria { get; set; }
        public int Cantidad { get; set; }

        public Libro(string titulo, string autor, string descripcion, decimal precio, decimal cantidadin, string categoria, int cantidad)
        {
            Titulo = titulo;
            Autor = autor;
            Descripcion = descripcion;
            Precio = precio;
            CantidadEnInventario = cantidadin;
            Categoria = categoria;
            Cantidad = cantidad;
        }

        public Libro(string titulo, string autor, string descripcion, decimal precio, decimal cantidadin, string categoria)
        {
            Titulo = titulo;
            Autor = autor;
            Descripcion = descripcion;
            Precio = precio;
            CantidadEnInventario = cantidadin;
            Categoria = categoria;
        }

        public double ObtenerPrecio()
        {
            return (double)Precio;
        }

        public string ObtenerTitulo()
        {
            return Titulo;
        }

        public string ObtenerAutor()
        {
            return Autor;
        }

        public string ObtenerDescripcion()
        {
            return Descripcion;
        }

        public decimal ObtenerCantidad()
        {
            return CantidadEnInventario;
        }

        public string ObtenerCategoria()
        {
            return Categoria;
        }

        public void AumentarCantidad(decimal cantidad)
        {
            CantidadEnInventario += cantidad;
        }

        public void DisminuirCantidad(decimal cantidadRetirada)
        {
            if (cantidadRetirada <= CantidadEnInventario)
            {
                CantidadEnInventario -= cantidadRetirada;
            }
            else
            {
                Console.WriteLine("Error: no hay suficientes libros en inventario");
            }
        }
    }



    class CarritoDeCompras
    {
        private List<Libro> libros;

        public int CantidadEnInventario { get; set; }

        public CarritoDeCompras()
        {
            libros = new List<Libro>();
        }

        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        public void RemoverLibro(Libro libro)
        {
            libros.Remove(libro);
        }
        public List<Libro> ObtenerLibros()
        {
            return libros;
        }
        public decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (Libro libro in libros)
            {
                total += libro.Precio;
            }

            return total;
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Elija 0 para eliminar la ultima seleccion \n");
            Libro libro1 = new Libro("La Casa de los Espíritus", "Isabel Allende",
                              "Una novela que sigue a tres generaciones de la familia Trueba en Chile.",
                              15.99m, 10, "Ficción");

            Libro libro2 = new Libro("Cosmos", "Carl Sagan",
                                     "Un libro que explora el universo y nuestro lugar en él.",
                                     12.50m, 5, "No ficción");

            Libro libro3 = new Libro("El Gato con Botas", "Charles Perrault",
                                     "Un cuento popular europeo que sigue las aventuras de un astuto gato.",
                                     7.99m, 20, "Infantil");

            Libro libro4 = new Libro("Cien años de soledad", "Gabriel García Márquez", 
                                    "Una familia de la estirpe de los Buendía, cuyos miembros están condenados a vivir el mismo patrón de conducta hasta la séptima generación", 
                                    18.00m, 10, "Ficción");

            Libro libro5 = new Libro("El Señor de los Anillos", "J.R.R. Tolkien", 
                                     "La historia de un hobbit llamado Frodo Baggins y su viaje para destruir el Anillo Único.", 
                                     15.65m, 9, "Ficción");

            Libro libro6 = new Libro("Breve historia del tiempo", "Stephen Hawking", 
                                    "Una explicación de los conceptos más complicados de la física y el universo.",
                                    12.95m, 5, "No ficción");

            Libro libro7 = new Libro("La Sombra del Viento", "Carlos Ruis Zafon",
                                     "Barcelona, 1945. El pequeño Daniel Sempere es conducido por su padre a un misterioso lugar: " +
                                     "El Cementerio de los Libros Olvidados. Allí descubrirá un libro maldito que le cambiará la vida y le llevará a descubrir unos caminos repletos de enigmas y secretos.",
                                     24.99m, 3, "Ficción");


            Libro libro8 = new Libro("El Principito", "Antoine de Saint-Exupéry",
                                     "La historia se centra en un pequeño príncipe que realiza una travesía por el universo. En este viaje descubre la extraña forma en que los adultos ven la vida y comprende " +
                                     "el valor del amor y la amistad..",
                                     10.99m, 7, "Infantil");

            Console.WriteLine("Libros disponibles en Inventario:");
            Console.WriteLine("1. " + libro1.Titulo);
            Console.WriteLine("2. " + libro2.Titulo);
            Console.WriteLine("3. " + libro3.Titulo);
            Console.WriteLine("4. " + libro4.Titulo);
            Console.WriteLine("5. " + libro5.Titulo);
            Console.WriteLine("6. " + libro6.Titulo);
            Console.WriteLine("7. " + libro7.Titulo);
            Console.WriteLine("8. " + libro8.Titulo);


            CarritoDeCompras carrito = new CarritoDeCompras();
            string respuesta = "";
            do
            {
                Console.Write("Ingrese el número del libro que desea agregar al carrito (o presione Enter para terminar):\n ");
                respuesta = Console.ReadLine();

                if (respuesta == "1")
                {
                    carrito.AgregarLibro(libro1);
                    Console.WriteLine("El libro '" + libro1.Titulo + "' ha sido agregado al carrito.");
                }
                else if (respuesta == "2")
                {
                    carrito.AgregarLibro(libro2);
                    Console.WriteLine("El libro '" + libro2.Titulo + "' ha sido agregado al carrito.");
                }
                else if (respuesta == "3")
                {
                    carrito.AgregarLibro(libro3);
                    Console.WriteLine("El libro '" + libro3.Titulo + "' ha sido agregado al carrito.");
                }
                else if (respuesta == "4")
                {
                    carrito.AgregarLibro(libro4);
                    Console.WriteLine("El libro '" + libro5.Titulo + "' ha sido agregado al carrito.");
                }
                else if (respuesta == "5")
                {
                    carrito.AgregarLibro(libro5);
                    Console.WriteLine("El libro '" + libro5.Titulo + "' ha sido agregado al carrito.");
                }
                else if (respuesta == "6")
                {
                    carrito.AgregarLibro(libro6);
                    Console.WriteLine("El libro '" + libro6.Titulo+ "' ha sido agregado al carrito.");
                }
                else if (respuesta == "7")
                {
                    carrito.AgregarLibro(libro7);
                    Console.WriteLine("El libro '" + libro7.Titulo + "' ha sido agregado al carrito.");
                }
                else if (respuesta == "8")
                {
                    carrito.AgregarLibro(libro8);
                    Console.WriteLine("El libro '" + libro8.Titulo + "' ha sido agregado al carrito.");
                }
                else if (respuesta == "0") 
                { 
                    carrito.RemoverLibro(libro1);
                    Console.WriteLine("El Libro que habia elegido fue removido de la lista.");
                }
                else if (respuesta != "")
                {
                    Console.WriteLine("El valor ingresado no es válido. Inténtelo de nuevo.");
                }
            } while (respuesta != "");

            Console.WriteLine("Carrito de compras:");
            foreach (Libro libro in carrito.ObtenerLibros())
            {
                Console.WriteLine($"{libro.ObtenerTitulo()} de {libro.ObtenerAutor()} - {libro.ObtenerCategoria()}: {libro.ObtenerPrecio()}");
            }
            Console.WriteLine($"Total: {carrito.CalcularTotal()}");

            MostrarLibros();

        }

        private static void MostrarLibros()
        {
            Console.WriteLine("Listado de libros en el carrito de compras:");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");

            CarritoDeCompras carrito = new CarritoDeCompras();
            List<Libro> libros = carrito.ObtenerLibros();

            foreach (Libro libro in libros)
            {
                Console.WriteLine("Título: {0}", libro.ObtenerTitulo());
                Console.WriteLine("Autor: {0}", libro.ObtenerAutor());
                Console.WriteLine("Descripción: {0}", libro.ObtenerDescripcion());
                Console.WriteLine("Precio: {0:C}", libro.ObtenerPrecio());
                Console.WriteLine("Cantidad en inventario: {0}", libro.ObtenerCantidad());
                Console.WriteLine("Categoría: {0}", libro.ObtenerCategoria());
                Console.WriteLine("------------------------------------------");

                Console.ReadLine();
            }
            Console.ReadKey();
        }

    }
}
