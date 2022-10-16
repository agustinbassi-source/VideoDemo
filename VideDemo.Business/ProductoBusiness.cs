using System;
using System.Collections.Generic;
using System.Text;
using VideDemo.Business.Interface;
using VideoDemo.Models;
using VideoDemo.Repository.Interface;

namespace VideDemo.Business
{
  public class ProductoBusiness : IProductoBusiness
  {
    private readonly IProductoRepository _productoRepository;

    public ProductoBusiness(IProductoRepository productoRepository)
    {
      _productoRepository = productoRepository;
    }

    public List<Producto> Find()
    {
      return _productoRepository.Find();
    }
  }
}
