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
            if (!_context.Countries.Any())
            {
                _context.Countries.Add(new Country
                {
                    Name = "Guatemala",
                    States = new List<State>
                    {
                        new State
                        {
                            Name = "Guatemala",
                            Cities = new List<City>
                            {
                                new City { Name = "Ciudad de Guatemala" },
                                new City { Name = "Fraijanes" },
                                new City { Name = "San José Pinula" },
                                new City { Name = "Santa Catarina Pinula" },
                                new City { Name = "Palencia" },
                            }
                        },
                        new State
                        {
                            Name = "Santa Rosa",
                            Cities = new List<City>
                            {
                                new City { Name = "Cuilapa" },
                                new City { Name = "Barberena" },
                                new City { Name = "Casillas" },
                                new City { Name = "Oratorio" },
                                new City { Name = "Pueblo Nuevo Viñas" },
                            }
                        },

                    }
                });

                _context.Countries.Add(new Country
                {
                    Name = "El Salvador",
                    States = new List<State>
                    {
                        new State
                        {
                            Name = "San Salvador",
                            Cities = new List<City>
                            {
                                new City { Name = "San Salvador Norte" },
                                new City { Name = "San Salvador Oeste" },
                                new City { Name = "San Salvador Este" },
                                new City { Name = "San Salvador Centro" },
                                new City { Name = "San Salvador Sur" },
                            }
                        },
                        new State
                        {
                            Name = "San Miguel",
                            Cities = new List<City>
                            {
                                new City { Name = "San Miguel Norte" },
                                new City { Name = "San Miguel Centro" },
                                new City { Name = "San Miguel Oeste" },
                            }
                        },

                    }
                });

                _context.Countries.Add(new Country
                {
                    Name = "Panamá",
                    States = new List<State>
                    {
                        new State
                        {
                            Name = "Panamá",
                            Cities = new List<City>
                            {
                                new City { Name = "Balboa" },
                                new City { Name = "Chepo" },
                                new City { Name = "Chimán" },
                                new City { Name = "Panamá" },
                                new City { Name = "San Miguelito" },
                                new City { Name = "Taboga" },
                            }
                        },
                        new State
                        {
                            Name = "Bocas del Toro",
                            Cities = new List<City>
                            {
                                new City { Name = "Almirante" },
                                new City { Name = "Bocas del Toro" },
                                new City { Name = "Changuinola" },
                                new City { Name = "Chiriquí Grande" },
                            }
                        },

                    }
                });

                await _context.SaveChangesAsync();
            }
        }
    }
}
