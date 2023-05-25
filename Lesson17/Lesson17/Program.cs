
using Lesson17;

var mainlands = new List<Mainland>
{ new Mainland(){Id=1,MainlandName="Africa"},
  new Mainland(){Id=2,MainlandName="North America"},
  new Mainland(){Id=3,MainlandName="South America"},
  new Mainland(){Id=4,MainlandName="Australia"},
  new Mainland(){Id=5,MainlandName="Eurasia"},

};

var countries = new List<Country>
{ new Country(){Id=1,Name="Poland", MainlandId=5},
  new Country(){Id=2,Name="USA",MainlandId=2},
  new Country(){Id=3,Name="Australia", MainlandId=4},
  new Country(){Id=4,Name="Brasil", MainlandId=3},
  new Country(){Id=5,Name="Egypt", MainlandId=1},
  new Country(){Id=5,Name="Ephyopia", MainlandId=1},
};

var cities = new List<City>
{ new City(){Id=1,Name="Сairo", CountryId=5, Population=9000000, FoundationDate=969,IsCapital=true},
  new City(){Id=5666,Name="Сairo1", CountryId=5, Population=9000000, FoundationDate=969,IsCapital=true},
  new City(){Id=5666,Name="Сairo2", CountryId=5, Population=9000000, FoundationDate=969,IsCapital=true},
  new City(){Id=2,Name="Rio de Janeiro", CountryId=4, Population=7000000, FoundationDate=1565,IsCapital=false},
  new City(){Id=3,Name="Melburn", CountryId=3, Population=5000000, FoundationDate=1835,IsCapital=false},
  new City(){Id=4,Name="Canberra", CountryId=3, Population=395000, FoundationDate=1913,IsCapital=true},
  new City(){Id=5,Name="New York", CountryId=2, Population=9000000, FoundationDate=1624,IsCapital=false},
  new City(){Id=6,Name="Washington", CountryId=2, Population=712000, FoundationDate=1790,IsCapital=true},
  new City(){Id=7,Name="Warsaw", CountryId=1, Population=2000000, FoundationDate=1300,IsCapital=true},
};

//Виведення кількості країн по континентах
var countriesByContinent = mainlands
            .Select(c => new
            {
                Continent = c.MainlandName,
                CountryCount = countries.Count(country =>
                country.MainlandId == c.Id)
            });
Console.WriteLine("Кiлькiсть краiн по континентах:");

foreach (var item in countriesByContinent)
{
    Console.WriteLine($"{item.Continent}: {item.CountryCount}");
}


//Топ-3 мiста за населенням без урахування тих, що були заснованi пiсля 1200 року
var topCities = cities.Where(c => c.FoundationDate <= 1200)
                     .OrderByDescending(c => c.Population)
                     .Take(3);
Console.WriteLine("\nТоп-3 мiста за населенням без урахування тих, що були заснованi пiсля 1200 року:");
foreach (var city in topCities)
{
    Console.WriteLine($"Мiсто: {city.Name}, Населення: {city.Population}");
}


//Виведення країни з найбільшим населенням і її столиці:
var countryWithLargestPopulation = countries.OrderByDescending(c => cities.FirstOrDefault(ct => ct.CountryId == c.Id)?.Population)
                                           .FirstOrDefault();
if (countryWithLargestPopulation != null)
{
    var capital = cities.FirstOrDefault(c => c.CountryId == countryWithLargestPopulation.Id && c.IsCapital);
    Console.WriteLine($"\nКраїна з найбiльшим населенням: {countryWithLargestPopulation.Name}, Столиця: {capital?.Name}\n");
}

// континенти з найбильшою кількістю міст, в яких населення перевищує 1000000
var continentsWithLargeCities = cities.Where(c => c.Population > 100)
                                      .Join(countries, city => city.CountryId, country => country.Id, (city, country) => new { city, country })
                                      .GroupBy(x => x.country.MainlandId)
                                      .Select(g => new { ContinentId = g.Key, CityCount = g.Count() })
                                      .OrderByDescending(g => g.CityCount);

foreach (var item in continentsWithLargeCities)
{
    var continent = mainlands.FirstOrDefault(c => c.Id == item.ContinentId);
    Console.WriteLine($"Континент: {continent?.MainlandName}, Кiлькiсть мiст: {item.CityCount}");
}
