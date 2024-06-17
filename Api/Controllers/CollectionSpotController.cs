using Application.Common.Interfaces.Entities.CollectionPoints;
using Application.Common.Interfaces.Entities.CollectionPoints.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("/api/collection-spots")]
public class CollectionSpotController : ControllerBase
{
    private readonly ICollectionPointService _collectionPointService;

    public CollectionSpotController(ICollectionPointService collectionPointService)
    {
        _collectionPointService = collectionPointService;
    }

    [HttpGet]
    public async Task<List<CollectionPointWithCompanyResponse>> GetCollectionPoints(string cep)
    {
        return await _collectionPointService.GetCollectionPointsBasedOnCep(cep);
    }
}