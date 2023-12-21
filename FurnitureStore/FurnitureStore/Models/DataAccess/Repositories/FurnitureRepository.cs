using FurnitureStore.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace FurnitureStore.Models.DataAccess.Repositories
{
    public class FurnitureRepository : IFurnitureRepository
    {
        private readonly FurnitureContext _context;
        public FurnitureRepository(FurnitureContext ctx) => _context = ctx;

        public IEnumerable<Furniture> GetInventory
        {
            get
            {
                return _context.Furnitures.Include(c => c.Category);
            }
        }

        public IEnumerable<Furniture> GetClearance
        {
            get
            {
                return _context.Furnitures.Include(c => c.Category).Where(f => f.Clearance);
            }
        }

        public Furniture GetFurnitureById(int furnId)
        {
            return _context.Furnitures.FirstOrDefault(f => f.FurnitureID == furnId);
        }
    }
}
