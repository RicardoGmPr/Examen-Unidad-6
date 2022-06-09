using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_U6
{
    public class Productos
    {
        public string nombre, descripcion;
        public float precio;
        public int cantidad;

        public Productos(string nombre, string descripcion, float precio, int cantidad)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.cantidad = cantidad;
        }
    }
}
