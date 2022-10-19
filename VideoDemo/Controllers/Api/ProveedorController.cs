using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using VideDemo.Business.Interface;
using VideoDemo.Models;
using VideoDemo.Models.Models;

namespace VideoDemo.Controllers.Api
{
  [Route("api/[controller]/[action]")]
  [ApiController]
  public class ProveedorController : ControllerBase
  {
    private readonly IProveedorBusiness _proveedorBusiness;

    public ProveedorController(IProveedorBusiness proveedorBusiness)
    {
      _proveedorBusiness = proveedorBusiness;
    }

    [HttpPost]
    public async Task<ActionResult<int>> CreateProvedor(Proveedor proveedor)
    {
      try
      {
        int response = _proveedorBusiness.CreateProveedor(proveedor);

        return Ok(response);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }

    }



  }
}
