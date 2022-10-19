using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using VideoDemo.Models.Models;
using VideoDemo.Repository.Interface;

namespace VideoDemo.Repository
{
  public class ProveedorRepository : IProveedorRepository
  {
    private readonly VideoDemoContext _context;

    public ProveedorRepository(VideoDemoContext context)
    {
      _context = context;
    }

    public int CreateProveedor(Proveedor proveedor)
    {
      _context.Proveedor.Add(proveedor);

      _context.SaveChanges();

      return proveedor.Id;
    }
  }
}
