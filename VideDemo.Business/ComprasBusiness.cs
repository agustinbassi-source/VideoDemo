using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using VideDemo.Business.Interface;
using VideoDemo.Models;
using VideoDemo.Repository.Interface;

namespace VideDemo.Business
{
  public class ComprasBusiness : IComprasBusiness
  {
    private readonly IComprasRepository _comprasRepository;

    public ComprasBusiness(IComprasRepository comprasRepository)
    {
      _comprasRepository = comprasRepository;
    }

    public int CreateCarrito(Carrito carrito)
    {
      carrito.FechaCreacion = DateTime.Now;

      return _comprasRepository.CreateCarrito(carrito);
    }

    public int CreateItem(ItemCarrito item)
    {
      if (item.CarritoId == 0)
      { 
        // bad request
      }

      return _comprasRepository.CreateItem(item);
    }

    public Carrito Find(int id)
    {
      return _comprasRepository.Find(id);
    }

    public List<Carrito> FindByClienteId(int clienteId)
    {
      if (clienteId < 1)
      {
        throw new Exception("El id de cliente no puede ser menor a 1");
      }

      return _comprasRepository.FindByClienteId(clienteId);
    }
  }
}
