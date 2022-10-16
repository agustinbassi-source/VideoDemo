using System;
using System.Collections.Generic;
using System.Text;
using VideoDemo.Models;

namespace VideDemo.Business.Interface
{
  public interface IProductoBusiness
  {
    List<Producto> Find();
 
  }
}
