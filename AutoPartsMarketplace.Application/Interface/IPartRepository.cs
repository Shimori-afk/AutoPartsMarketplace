using AutoPartsMarketplace.Domain.Entities;

namespace AutoPartsMarketplace.Application.Interface
{

public interface IPartRepository
{
    Task<List<Part>> GetAllPartsAsync();

    Task<List<Part>> GetPartsByCategoryAsync(int categoryId);
    Task<Part?> GetPartByIdAsync(int id);

}

}
