
using C__List_And_Generic.Interfaces;
using C__List_And_Generic.Operations;

FilmOperation filmOperation = new(new List<Film>
{
   new Film { Name = "The Guardians of the Galaxy", DirectorName = "James Gunn", ReleaseDate = "31.06.2014", ImdbScore = 8 },
   new Film { Name = "Iron Man", DirectorName = "Jon Favreau", ReleaseDate = "02.05.2008", ImdbScore = 5.5 }
});
filmOperation.Add(new Film { Name = "Doktor Strange", DirectorName = "Scot Derrickson", ReleaseDate = "28.10.2016", ImdbScore = 3 });

foreach (var Film in filmOperation.GetAll())
{
    Console.WriteLine($"Film Name : {Film.Name} Director : {Film.DirectorName} Release Date : {Film.ReleaseDate}");
}

ActorOperation actorOperation = new(new List<Actor>());
actorOperation.Add(new Actor { FirstName = "Robert", LastName = "Downey", Age = 58 });
actorOperation.Add(new Actor { FirstName = "Scarlett", LastName = "Johansson", Age = 38 });

foreach (var actor in actorOperation.GetAll()) 
{
    Console.WriteLine($"Actor Name : {actor.FirstName}, Surname : {actor.LastName} and Age : {actor.Age}");
}

actorOperation.GetFullName();

