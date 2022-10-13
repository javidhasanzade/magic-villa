using MagicVillaAPI.Data;
using MagicVillaAPI.Models;
using MagicVillaAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MagicVillaAPI.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class VillaAPIController : ControllerBase
{
    [HttpGet]
    public IEnumerable<VillaDTO> GetVillas()
    {
        return VillaStore.Villas;
    }

    [HttpGet("id")]
    public VillaDTO GetVilla(int id)
    {
        return VillaStore.Villas.FirstOrDefault(x => x.Id == id) ?? throw new NullReferenceException();
    }
}