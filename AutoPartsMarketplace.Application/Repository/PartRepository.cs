using AutoPartsMarketplace.Application.Interface;
using AutoPartsMarketplace.Domain.Entities;
using AutoPartsMarketplace.Infrastructure.Data;
namespace AutoPartsMarketplace.Application.Repository
{   
public class PartRepository : IPartRepository
{
    private readonly AppDbContext _context;

    public PartRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Part>> GetAllPartsAsync()
    {
        return await _context.Parts.ToListAsync();
    }

    public async Task<List<Part>> GetPartsByCategoryAsync(int categoryId)
    {
        return await _context.Parts
            .Where(p => p.CategoryId == categoryId)
            .ToListAsync();
    }

    public async Task<Part?> GetPartByIdAsync(int id)
    {
        return await _context.Parts.FindAsync(id);
    }
}
}
