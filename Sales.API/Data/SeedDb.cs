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
            await CheckCategoriesAsync();
        }

        private async Task CheckCategoriesAsync()
        {
            if (!_context.Categories.Any())
            {
                _context.Categories.Add(new Category { Name = "Accesorios para Dispositivos" });
                _context.Categories.Add(new Category { Name = "Belleza" });
                _context.Categories.Add(new Category { Name = "Libros " });
                _context.Categories.Add(new Category { Name = "Camaras y Fotografia" });
                _context.Categories.Add(new Category { Name = "Electronicos" });
                _context.Categories.Add(new Category { Name = "Computo y Tablets" });
                _context.Categories.Add(new Category { Name = "Videojuegos" });
                _context.Categories.Add(new Category { Name = "Hogar y Cocina" });
                _context.Categories.Add(new Category { Name = "Herramientas y Hogar" });
                _context.Categories.Add(new Category { Name = "Bebé" });
                _context.Categories.Add(new Category { Name = "Relojes" });
                _context.Categories.Add(new Category { Name = "Deportes" });
                _context.Categories.Add(new Category { Name = "Tiendas de Adultos" });
                _context.Categories.Add(new Category { Name = "Juguetes" });
                _context.Categories.Add(new Category { Name = "Calzado" });
                await _context.SaveChangesAsync();
            }

        }

        private async Task CheckCountriesAsync()
        {
            if (!_context.Countries.Any())
            {
                _context.Countries.Add(new Country
                {
                    Name = "Colombia",
                    States = new List<State>()
                    {
                        new State()
                        {
                        Name = "Antioquia",
                        Cities = new List<City>() {
                            new City() { Name = "Medellín" },
                            new City() { Name = "Itagüí" },
                            new City() { Name = "Envigado" },
                            new City() { Name = "Bello" },
                            new City() { Name = "Rionegro" },
                        }
                    },
                        new State()
                        {
                        Name = "Bogotá",
                        Cities = new List<City>() {
                            new City() { Name = "Usaquen" },
                            new City() { Name = "Champinero" },
                            new City() { Name = "Santa fe" },
                            new City() { Name = "Useme" },
                            new City() { Name = "Bosa" },
                        }
                    },
                }
                });
                _context.Countries.Add(new Country
                {
                    Name = "Estados Unidos",
                    States = new List<State>()
                    {
                        new State()
                        {
                        Name = "Florida",
                        Cities = new List<City>() {
                            new City() { Name = "Orlando" },
                            new City() { Name = "Miami" },
                            new City() { Name = "Tampa" },
                            new City() { Name = "Fort Lauderdale" },
                            new City() { Name = "Key West" },
                        }
                    },
                        new State()
                            {
                            Name = "Texas",
                            Cities = new List<City>() {
                                new City() { Name = "Houston" },
                                new City() { Name = "San Antonio" },
                                new City() { Name = "Dallas" },
                                new City() { Name = "Austin" },
                                new City() { Name = "El Paso" },
                            }
                        },
                    }
                });
                await _context.SaveChangesAsync();
            }

        }

    }
}
