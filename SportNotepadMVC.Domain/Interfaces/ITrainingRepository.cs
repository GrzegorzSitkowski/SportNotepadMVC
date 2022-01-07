using SportNotepadMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Domain.Interfaces
{
    public interface ITrainingRepository
    {
        int AddTraining(Training traing);
        void EditTraining(Training training);
        void DeleteTraining(int id);
        Training GetTrainingById(int trainingId);
        IQueryable<Training> GetAllTraining();
    }
}
