using Common.Application;

namespace Shop.Application.Comments.Delete;

public record DeleteCommentCommand(long CommentId, long UserId) : IBaseCommand;