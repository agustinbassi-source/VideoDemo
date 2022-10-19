using System;
using System.Collections.Generic;
using System.Text;
using VideoDemo.Models.Models;

namespace VideoDemo.Repository.Interface
{
  public interface IProveedorRepository
  {
    int CreateProveedor(Proveedor proveedor);
  }
}
