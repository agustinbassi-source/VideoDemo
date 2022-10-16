using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoDemo.Models;
using VideoDemo.Repository.Interface;

namespace VideoDemo.Repository
{
  public class ProductoRepository : IProductoRepository
  {
    private readonly VideoDemoContext _context;

    public ProductoRepository(VideoDemoContext context)
    {
      _context = context;
    }

    public List<Producto> Find()
    {
      return _context.Producto.ToList();
    }
  }
}
