namespace TestApi
{
    public class Person
    {
        public Person(int id, string? name, int age, int seasonId)
        {
            Id = id;
            Name = name;
            Age = age;
            SeasonId = seasonId;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public int SeasonId { get; set; }
    }
}