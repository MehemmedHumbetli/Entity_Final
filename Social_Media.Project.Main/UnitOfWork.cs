using Social_Media.Project.DAL.Context;
using Social_Media.Project.DAL.Repositories.Concrate;

namespace Social_Media.Project.Main;

public class UnitOfWork
{
    private readonly dbCONTEXT _context;

    public UnitOfWork(dbCONTEXT context, UserDetailsRepository userDetailsRepository, UserRepository userRepository, PostRepository postRepository, CommentRepository commentRepository)
    {
        _context = context;
        UserDetailsRepository = userDetailsRepository;
        UserRepository = userRepository;
        PostRepository = postRepository;
        CommentRepository = commentRepository;
    }

    public UserDetailsRepository UserDetailsRepository { get; set; }
    public UserRepository UserRepository { get; set; }
    public PostRepository PostRepository { get; set; }
    public CommentRepository CommentRepository { get; set; }
}
