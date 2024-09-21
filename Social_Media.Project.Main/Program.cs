//{ }
using ClassLibrary.Concrate;
using Social_Media.Project.DAL.Repositories.Concrate;

public class Project
{
    static void Main(string[] args)
    {
        Console.WriteLine("Start>>");
        UserDetailsRepository userDetailsRepository = new UserDetailsRepository();
        UserRepository userRepository = new UserRepository();
        PostRepository postRepository = new PostRepository();
        CommentRepository commentRepository = new CommentRepository();

        UserDetails user_INFO_1 = new UserDetails() { 
            Name = "Mehemmed",
            Surname = "Humbetli",
            BirthDay = DateTime.Now,
            UserRole = UserDetails.Role.Admin
        };

        User user1 = new User()
        {
            UserDetailsId = 1
        };

        Post post1 = new Post()
        {
            Text = "Step It Academy",
            Comment = "Eziyyetde bizik, Veziyyetde!!",
            UserId = 1,
        };

        CommentClass commentClass1 = new CommentClass()
        {
            Text = "Reply",
            Comment = "Yaxsi Oglan Backend devoloper olar!",

        };

        userDetailsRepository.Add(user_INFO_1);
        userRepository.Add(user1);
        postRepository.Add(post1);
        commentRepository.Add(commentClass1);

        userDetailsRepository.SaveChanges();
        userRepository.SaveChanges();
        postRepository.SaveChanges();
        commentRepository.SaveChanges();
    }
}