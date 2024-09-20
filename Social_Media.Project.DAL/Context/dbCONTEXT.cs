using ClassLibrary.Concrate;
using ConsoleApp1.Concrate;
using Microsoft.EntityFrameworkCore


namespace Social_Media.Project.DAL.Context;

public class dbCONTEXT:DbContext
{
    public DbSet<UserDetails> Users_details { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<>
}
