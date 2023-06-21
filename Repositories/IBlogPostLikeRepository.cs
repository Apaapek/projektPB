using Miniblog.Models.Domain;

namespace Miniblog.Repositories
{
    public interface IBlogPostLikeRepository
    {
        Task<int> GetTotalLikesForBlog(Guid blogPostId);

        Task AddLikeForBlog(Guid blogPostLikeId, Guid userId);

        Task<IEnumerable<BlogPostLike>> GetLikesForBlog(Guid BlogPostId);
    }
}
