using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Helpers;

namespace API.Interfaces
{
    public interface ILikesRepository
    {
         public Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);
         public Task<AppUser> GetUserWithLikes(int userId);
         public Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);

    }
}