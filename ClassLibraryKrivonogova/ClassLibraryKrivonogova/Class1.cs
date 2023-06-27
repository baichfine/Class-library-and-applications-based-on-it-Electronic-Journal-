using System.Data.Entity;

namespace ClassLibraryKrivonogova
{
    public class Week1Day1
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string HomeWork { get; set; }
        public string Assessment { get; set; }
    }
    public class Week1Day2
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string HomeWork { get; set; }
        public string Assessment { get; set; }
    }
    public class Week1Day3
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string HomeWork { get; set; }
        public string Assessment { get; set; }
    }
    public class Week1Day4
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string HomeWork { get; set; }
        public string Assessment { get; set; }
    }
    public class Week1Day5
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string HomeWork { get; set; }
        public string Assessment { get; set; }
    }
    public class Week1Day6
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string HomeWork { get; set; }
        public string Assessment { get; set; }
    }
    public class Week2Day1
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string HomeWork { get; set; }
        public string Assessment { get; set; }
    }
    public class Week2Day2
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string HomeWork { get; set; }
        public string Assessment { get; set; }
    }
    public class Week2Day3
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string HomeWork { get; set; }
        public string Assessment { get; set; }
    }
    public class Week2Day4
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string HomeWork { get; set; }
        public string Assessment { get; set; }
    }
    public class Week2Day5
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string HomeWork { get; set; }
        public string Assessment { get; set; }
    }
    public class Week2Day6
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string HomeWork { get; set; }
        public string Assessment { get; set; }
    }
    public class Week3Day1
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string HomeWork { get; set; }
        public string Assessment { get; set; }
    }
    public class Week3Day2
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string HomeWork { get; set; }
        public string Assessment { get; set; }
    }
    public class Week3Day3
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string HomeWork { get; set; }
        public string Assessment { get; set; }
    }
    public class Week3Day4
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string HomeWork { get; set; }
        public string Assessment { get; set; }
    }
    public class Week3Day5
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string HomeWork { get; set; }
        public string Assessment { get; set; }
    }
    public class Week3Day6
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string HomeWork { get; set; }
        public string Assessment { get; set; }
    }
    public class Week4Day1
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string HomeWork { get; set; }
        public string Assessment { get; set; }
    }
    public class Week4Day2
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string HomeWork { get; set; }
        public string Assessment { get; set; }
    }
    public class Week4Day3
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string HomeWork { get; set; }
        public string Assessment { get; set; }
    }
    public class Week4Day4
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string HomeWork { get; set; }
        public string Assessment { get; set; }
    }
    public class Week4Day5
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string HomeWork { get; set; }
        public string Assessment { get; set; }
    }
    public class Week4Day6
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string HomeWork { get; set; }
        public string Assessment { get; set; }
    }
    public class UserContext : DbContext
    {
        public UserContext() : base("bdNastya") // имя будущей строки подключения к базе данных
        { }
        public DbSet<Week1Day1> Weeks1Days1 { get; set; }
        public DbSet<Week1Day2> Weeks1Days2 { get; set; }
        public DbSet<Week1Day3> Weeks1Days3 { get; set; }
        public DbSet<Week1Day4> Weeks1Days4 { get; set; }
        public DbSet<Week1Day5> Weeks1Days5 { get; set; }
        public DbSet<Week1Day6> Weeks1Days6 { get; set; }

        public DbSet<Week2Day1> Weeks2Days1 { get; set; }
        public DbSet<Week2Day2> Weeks2Days2 { get; set; }
        public DbSet<Week2Day3> Weeks2Days3 { get; set; }
        public DbSet<Week2Day4> Weeks2Days4 { get; set; }
        public DbSet<Week2Day5> Weeks2Days5 { get; set; }
        public DbSet<Week2Day6> Weeks2Days6 { get; set; }

        public DbSet<Week3Day1> Weeks3Days1 { get; set; }
        public DbSet<Week3Day2> Weeks3Days2 { get; set; }
        public DbSet<Week3Day3> Weeks3Days3 { get; set; }
        public DbSet<Week3Day4> Weeks3Days4 { get; set; }
        public DbSet<Week3Day5> Weeks3Days5 { get; set; }
        public DbSet<Week3Day6> Weeks3Days6 { get; set; }

        public DbSet<Week4Day1> Weeks4Days1 { get; set; }
        public DbSet<Week4Day2> Weeks4Days2 { get; set; }
        public DbSet<Week4Day3> Weeks4Days3 { get; set; }
        public DbSet<Week4Day4> Weeks4Days4 { get; set; }
        public DbSet<Week4Day5> Weeks4Days5 { get; set; }
        public DbSet<Week4Day6> Weeks4Days6 { get; set; }
    }
}
