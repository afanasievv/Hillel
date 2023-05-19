
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
};

var cities = new List<City>
{ new City(){Id=1,Name="Сairo", CountryId=5, Population=9000000, YearOfFoundation=969,IsCapital=true},
  new City(){Id=1,Name="Rio de Janeiro", CountryId=4, Population=7000000, YearOfFoundation=1565,IsCapital=false},
  new City(){Id=1,Name="Melburn", CountryId=3, Population=5000000, YearOfFoundation=1835,IsCapital=false},
  new City(){Id=1,Name="New York", CountryId=2, Population=9000000, YearOfFoundation=1624,IsCapital=false},
  new City(){Id=1,Name="Warsaw", CountryId=1, Population=2000000, YearOfFoundation=1300,IsCapital=true},
};

            var result = from m in mainlands
            join c in countries on m.Id equals c.MainlandId
             select (c.Name, m.MainlandName);
//var result = 
          
                
         
Console.WriteLine();
