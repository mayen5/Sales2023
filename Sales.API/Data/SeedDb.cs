using Sales.Shared.Entities;

namespace Sales.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
        }

        private async Task CheckCountriesAsync()
        {
            if (!_context.Countries.Any()) {
                _context.Countries.Add(new Country { Name = "Guatemala" });
                _context.Countries.Add(new Country { Name = "Belice" });
                _context.Countries.Add(new Country { Name = "El Salvador" });
                _context.Countries.Add(new Country { Name = "Honduras" });
                _context.Countries.Add(new Country { Name = "Nicaragua" });
                _context.Countries.Add(new Country { Name = "Costa Rica" });
                _context.Countries.Add(new Country { Name = "Panamá" });
                await _context.SaveChangesAsync();
            }
        }
    }
}
