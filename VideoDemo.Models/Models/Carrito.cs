using System;
using System.Collections.Generic;

namespace VideoDemo.Models
{
    public class Carrito : BaseEntity
    {
        public List<ItemCarrito> Detalle { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public DateTime  FechaCreacion { get; set; }
    }
}
