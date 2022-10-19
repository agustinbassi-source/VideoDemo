using System;
using System.Collections.Generic;
using System.Text;
using VideDemo.Business.Interface;
using VideoDemo.Models.Models;
using VideoDemo.Repository.Interface;

namespace VideDemo.Business
{
  public class ProveedorBusiness : IProveedorBusiness
  {
    private readonly IProveedorRepository _proveedorRepository;

    public ProveedorBusiness(IProveedorRepository proveedorRepository)
    {
      _proveedorRepository = proveedorRepository;
    }
    public int CreateProveedor(Proveedor proveedor)
    {
      if (proveedor.Email.IndexOf(@"@") < 0)
      {
        throw new Exception("No se encontro el @ en el email");
      }

      int response = _proveedorRepository.CreateProveedor(proveedor);

      return response;
    }
  }
}
