using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VideDemo.Business.Interface;
using VideoDemo.Models;

namespace VideoDemo.Controllers.Api
{
  [Route("api/[controller]/[action]")]
  [ApiController]
  public class CarritoController : ControllerBase
  {
    private readonly IComprasBusiness _comprasBusiness;

    public CarritoController(IComprasBusiness comprasBusiness)
    {
      _comprasBusiness = comprasBusiness;
    }

    [HttpGet]
    public async Task<ActionResult<Carrito>> GetCarrito(int id)
    {
      try
      {
        var carrito = _comprasBusiness.Find(id);

        if (carrito == null)
          return NotFound();

        return Ok(carrito);
      }
      catch (Exception exception)
      {
        return BadRequest(exception.Message);
      }
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Carrito>>> GetCarritos(int clienteId)
    {
      try
      {
        var carritos = _comprasBusiness.FindByClienteId(clienteId);

        if (carritos == null)
          return NotFound();

        return Ok(carritos);
      }
      catch (Exception exception)
      {
        return BadRequest(exception.Message);
      }
    }

    [HttpPost]
    public async Task<ActionResult<int>> CreateCarrito(Carrito carrito)
    {
      try
      {
        _comprasBusiness.CreateCarrito(carrito);

        if (carrito.Id == 0)
          return BadRequest();

        return Ok(carrito.Id);
      }
      catch (Exception exception)
      {
        return BadRequest(exception.Message);
      }
    }

    [HttpPost]
    public async Task<ActionResult<int>> CreateItem(ItemCarrito item)
    {
      try
      {
        _comprasBusiness.CreateItem(item);

        if (item.Id == 0)
          return BadRequest();

        return Ok(item.Id);
      }
      catch (Exception exception)
      {
        return BadRequest(exception.Message);
      }
    }
  }
}
