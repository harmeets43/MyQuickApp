using DataAccessLayer.Core;
using Microsoft.AspNetCore.Http;

namespace DataAccessLayer {
    public class HttpUnitOfWork: UnitOfWork {
        public HttpUnitOfWork(ApplicationDbContext context, IHttpContextAccessor httpAccessor) : base(context)
        {
            context.CurrentUserId = httpAccessor.HttpContext?.User.FindFirst(ClaimConstants.Subject)?.Value?.Trim();
        }
    }
}