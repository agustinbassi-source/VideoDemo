using System;
using System.Collections.Generic;
using System.Text;
using VideoDemo.Models;

namespace VideoDemo.Repository.Interface
{
  public interface IProductoRepository
  {
    List<Producto> Find();
  }
}
