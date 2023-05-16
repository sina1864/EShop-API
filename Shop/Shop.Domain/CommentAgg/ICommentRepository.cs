using Common.Domain.Repository;

namespace Shop.Domain.CommentAgg;

public interface ICommentRepository : IBaseRepository<Comment>
{
    Task DeleteAndSave(Comment comment);
}