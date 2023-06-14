
using Lesson17;

var continents = new List<Continent>
{ new Continent(){Id=1,ContinentName="Africa"},
  new Continent(){Id=2,ContinentName="North America"},
  new Continent(){Id=3,ContinentName="South America"},
  new Continent(){Id=4,ContinentName="Australia"},
  new Continent(){Id=5,ContinentName="Eurasia"},

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
  new City(){Id=2,Name="Rio de Janeiro", CountryId=4, Population=7000000, FoundationDate=1565,IsCapital=false},
  new City(){Id=3,Name="Melburn", CountryId=3, Population=5000000, FoundationDate=1835,IsCapital=false},
  new City(){Id=4,Name="Canberra", CountryId=3, Population=395000, FoundationDate=1913,IsCapital=true},
  new City(){Id=5,Name="New York", CountryId=2, Population=9000000, FoundationDate=1624,IsCapital=false},
  new City(){Id=6,Name="Washington", CountryId=2, Population=712000, FoundationDate=1790,IsCapital=true},
  new City(){Id=7,Name="Warsaw", CountryId=1, Population=2000000, FoundationDate=1300,IsCapital=true},
};

// кількість країн по континентах
var countriesByContinent = continents
            .Select(c => new
            {
                Continent = c.ContinentName,
                CountryCount = countries.Count(country =>
                country.MainlandId == c.Id)
            });

Console.WriteLine("Кiлькiсть краiн по континентах:");
foreach (var item in countriesByContinent)
{
    Console.WriteLine($"{item.Continent}: {item.CountryCount}");
}


//топ-3 міст за населенням без урахування тих, що були засновані після 1200 року
var topCities = cities.Where(c => c.FoundationDate <= 1200)
                     .OrderByDescending(c => c.Population)
                     .Take(3);
Console.WriteLine("\nТоп-3 мiста за населенням без урахування тих, що були заснованi пiсля 1200 року:");
foreach (var city in topCities)
{
    Console.WriteLine($"Мiсто: {city.Name}, Населення: {city.Population}");
}


//Країни з найбільшим населенням і їх столиці:
var countryWithLargestPopulation = countries.OrderByDescending(c => cities.FirstOrDefault(ct => ct.CountryId == c.Id)?.Population)
                                           .FirstOrDefault();
if (countryWithLargestPopulation != null)
{
    var capital = cities.FirstOrDefault(c => c.CountryId == countryWithLargestPopulation.Id && c.IsCapital);
    Console.WriteLine($"\nКраїна з найбiльшим населенням: {countryWithLargestPopulation.Name}, Столиця: {capital?.Name}\n");
}

// континенти з найбільшою кількістю міст, в яких населення перевищує 1000000
var continentsWithLargeCities = cities.Where(c => c.Population > 1000000)
                                      .Join(countries, city => city.CountryId, country => country.Id, (city, country) => new { city, country })
                                      .GroupBy(x => x.country.MainlandId)
                                      .Select(g => new { ContinentId = g.Key, CityCount = g.Count() })
                                      .OrderByDescending(g => g.CityCount);

foreach (var item in continentsWithLargeCities)
{
    var continent = continents.FirstOrDefault(c => c.Id == item.ContinentId);
    Console.WriteLine($"Континент: {continent?.ContinentName}, Кiлькiсть мiст: {item.CityCount}");
}
