// using System.Security.Cryptography.X509Certificates;
// using LinQ;

// var songs = new List<Songs>
// {
//     new Songs(id:1, name:"Enter Sandman", band:"Metallica", new DateTime(year:1991, month:8, day:7)),
//     new Songs(id:2, name:"Eyes Without a Face", band:"Billy Idol", new DateTime(year:1984, month:6, day:12)),
//     new Songs(id:3, name:"Sweet Child o' Mine", band:"Guns N' Roses", new DateTime(year:1988, month:6, day:21)),
//     new Songs(id:4, name:"Highway To Hell", band:"AC/DC", new DateTime(year:1979, month:7, day:27)),
// };

// Console.WriteLine("Songs released in 1991:");
// var songsReleasedIn91 = songs
// .Where(x => x.ReleaseDate.Year == 1991)
// .ToList();

// foreach(var datas in songsReleasedIn91)
// {
//     Console.WriteLine($"{datas}\n");
// }

// Console.WriteLine("Songs released on June:");
// var songsReleasedInJune = songs
// .Where(x => x.ReleaseDate.Month == 6);

// foreach(var datas in songsReleasedInJune)
// {
//     Console.WriteLine($"{datas}");
// }



// Console.WriteLine("\nReturn songs in alphabetical order:");
// var songsOrder = songs
// .OrderBy(x => x.Name)
// .ToList();

// foreach(var item in songsOrder)
// {
//     Console.WriteLine($"{item}");
// }


// Console.WriteLine("\nLast two songs registred in alphabetical order:");
// var songsOrderDesc = songs
// .TakeLast(2)
// .ToList();

// foreach(var item in songsOrderDesc)
// {
//     Console.WriteLine($"{item}");
// }




//Three parts of a Linq  Query:
// 1. Data Source.

int[] numbers = [ 0, 1, 2, 3, 4, 5 ];

//2. Query creation.
// numQuery is an IEnumerable<int>

var numQuery =
    from num in numbers
    where (num % 2) == 0
    select num;

//3. Query execution

foreach (int num in numQuery)
{
    Console.Write(num);
}