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
    public class InstrumentService : IInstrumentService
    {
        private readonly IRepository<Instrument> _instrumentRepository;

        public InstrumentService(IRepository<Instrument> instrumentRepository)
        {
            _instrumentRepository = instrumentRepository;
        }

        public void CreateNewInstrument(Instrument p)
        {
            _instrumentRepository.Insert(p);
        }

        public void DeleteInstrument(Guid id)
        {
            Instrument instrument = _instrumentRepository.Get(id);
            _instrumentRepository.Delete(instrument);
        }

        public List<Instrument> GetAllInstruments()
        {
            return _instrumentRepository.GetAll().ToList();
        }

        public Instrument GetDetailsForInstrument(Guid? id)
        {
            return _instrumentRepository.Get(id);
        }

        public void UpdateExistingInstrument(Instrument p)
        {
            _instrumentRepository.Update(p);
        }

    }
}
