using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using VideoDemo.Models;
using System.Collections.Generic;
using VideDemo.Business.Interface;

namespace VideoDemo.Controllers.Api
{
  [Route("api/[controller]/[action]")]
  [ApiController]
  public class ProductoController : ControllerBase
  {
    private readonly IProductoBusiness  _productoBusiness;

    public ProductoController(IProductoBusiness productoBusiness)
    {
      _productoBusiness = productoBusiness;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Producto>>> GetProductos()
    {
      try
      {
        var productos = _productoBusiness.Find();

        if (productos == null)
          return NotFound();

        return Ok(productos);
      }
      catch (Exception exception)
      {
        return BadRequest(exception.Message);
      }
    }
  }
}
