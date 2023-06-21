using Microsoft.EntityFrameworkCore;
using Miniblog.Data;
using Miniblog.Models.Domain;

namespace Miniblog.Repositories
{
    public class BlogPostCommentRepository : IBlogPostCommentRepository
    {
        private readonly MiniblogDbContext bloggieDbContext;

        public BlogPostCommentRepository(MiniblogDbContext bloggieDbContext )
        {
            this.bloggieDbContext = bloggieDbContext;
        }
        public async Task<BlogPostComment> AddAsync(BlogPostComment blogPostComment)
        {
            await bloggieDbContext.BlogPostComment.AddAsync(blogPostComment);
            await bloggieDbContext.SaveChangesAsync();
            return blogPostComment;
        }

        public async Task<IEnumerable<BlogPostComment>> GetAllAsync(Guid blogPostId)
        {
            return await bloggieDbContext.BlogPostComment.Where(x => x.BlogPostId == blogPostId).ToListAsync();
        }
    }
}
