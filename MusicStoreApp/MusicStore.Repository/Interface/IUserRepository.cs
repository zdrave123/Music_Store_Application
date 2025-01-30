using MusicStore.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<MusicStoreApplicationUser> GetAll();
        MusicStoreApplicationUser Get(string id);
        void Insert(MusicStoreApplicationUser entity);
        void Update(MusicStoreApplicationUser entity);
        void Delete(MusicStoreApplicationUser entity);
    }
}
