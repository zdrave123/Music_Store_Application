using MusicStore.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Service.Interface
{
    public interface IAccessoryService
    {
        List<Accessory> GetAllAccessories();
        Accessory GetDetailsForAccessory(Guid? id);
        void CreateNewAccessory(Accessory p);
        void UpdateExistingAccessory(Accessory p);
        void DeleteAccessory(Guid id);
    }
}
