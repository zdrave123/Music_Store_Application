using MusicStore.Domain.Domain;
using MusicStore.Repository.Interface;
using MusicStore.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Service.Implementation
{
    public class AccessoryService : IAccessoryService
    {
        private readonly IRepository<Accessory> _accessoryRepository;

        public AccessoryService(IRepository<Accessory> accessoryRepository)
        {
            _accessoryRepository = accessoryRepository;
        }

        public void CreateNewAccessory(Accessory accessory)
        {
            _accessoryRepository.Insert(accessory);
        }

        public void DeleteAccessory(Guid id)
        {
            Accessory accessory = _accessoryRepository.Get(id);
            _accessoryRepository.Delete(accessory);
        }

        public List<Accessory> GetAllAccessories()
        {
            return _accessoryRepository.GetAll().ToList();
        }

        public Accessory GetDetailsForAccessory(Guid? id)
        {
            return _accessoryRepository.Get(id);
        }

        public void UpdateExistingAccessory(Accessory accessory)
        {
            _accessoryRepository.Update(accessory);
        }
    }
}
