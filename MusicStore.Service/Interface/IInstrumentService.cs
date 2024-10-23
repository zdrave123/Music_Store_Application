using MusicStore.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Service.Interface
{
    public interface IInstrumentService
    {
        List<Instrument> GetAllInstruments();
        Instrument GetDetailsForInstrument(Guid? id);
        void CreateNewInstrument(Instrument p);
        void UpdateExistingInstrument(Instrument p);
        void DeleteInstrument(Guid id);
    }
}
