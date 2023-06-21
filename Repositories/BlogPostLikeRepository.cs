using Microsoft.EntityFrameworkCore;
using Miniblog.Data;
using Miniblog.Models.Domain;

namespace Miniblog.Repositories
{
    public class BlogPostLikeRepository : IBlogPostLikeRepository
    {
        private readonly MiniblogDbContext bloggieDbContext;

        public BlogPostLikeRepository(MiniblogDbContext bloggieDbContext)
        {
            this.bloggieDbContext = bloggieDbContext;
        }

        public async Task AddLikeForBlog(Guid blogPostId, Guid userId)
        {
            var like = new BlogPostLike
            {
                Id = Guid.NewGuid(),
                BlogPostId = blogPostId,
                UserId = userId
            };

            await bloggieDbContext.BlogPostLike.AddAsync(like);
            await bloggieDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<BlogPostLike>> GetLikesForBlog(Guid BlogPostId)
        {
            return await bloggieDbContext.BlogPostLike.Where(x => x.BlogPostId == BlogPostId).ToListAsync();
        }

        public async Task<int> GetTotalLikesForBlog(Guid blogPostId)
        {
            return await bloggieDbContext.BlogPostLike.CountAsync(x => x.BlogPostId == blogPostId);
        }
    }
}
