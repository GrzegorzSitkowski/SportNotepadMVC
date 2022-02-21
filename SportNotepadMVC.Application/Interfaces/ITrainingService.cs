using SportNotepadMVC.Application.ViewModels.Training;
using SportNotepadMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Application.Interfaces
{
    public interface ITrainingService
    {
        int AddTraining(NewTrainingVm training);
        void EditTraining(NewTrainingVm model);
        void DeleteTraining(int id);
        TrainingDetailsVm GetTrainingDetails(int id);
        NewTrainingVm TrainingForEdit(int id);      
        Training GetTrainingById(int trainingId);
        ListTrainingForListVm GetAllTrainigs();
    }
}
