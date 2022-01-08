using AutoMapper;
using AutoMapper.QueryableExtensions;
using SportNotepadMVC.Application.Interfaces;
using SportNotepadMVC.Application.ViewModels.Training;
using SportNotepadMVC.Domain.Interfaces;
using SportNotepadMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Application.Services
{
    public class TrainingService : ITrainingService
    {
        private readonly ITrainingRepository _trainingRepo;
        private readonly IMapper _mapper;
        public TrainingService(ITrainingRepository trainingRepo, IMapper mapper)
        {
            _trainingRepo = trainingRepo;
            _mapper = mapper;
        }
        public int AddTraining(NewTrainingVm training)
        {
            var _training = _mapper.Map<Training>(training);
            var id = _trainingRepo.AddTraining(_training);
            return id;
        }

        public void DeleteTraining(int id)
        {
            _trainingRepo.DeleteTraining(id);
        }

        public void EditTraining(NewTrainingVm model)
        {
            var training = _mapper.Map<Training>(model);
            _trainingRepo.EditTraining(training);
        }
        public NewTrainingVm TrainingForEdit(int id)
        {
            var training = _trainingRepo.GetTrainingById(id);
            var trainingVm = _mapper.Map<NewTrainingVm>(training);
            return trainingVm;
        }

        public ListTrainingForListVm GetAllTrainigs(int pageNo, int pageSize, string searchString)
        {
            var trainings = _trainingRepo.GetAllTraining().Where(p => p.Id.ToString().StartsWith(searchString))
                .ProjectTo<TrainingForListVm>(_mapper.ConfigurationProvider).ToList();

            var trainigToShow = trainings.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();

            var trainingList = new ListTrainingForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                SearchString = searchString,
                Trainings = trainigToShow,
                Count = trainings.Count
            };
            return trainingList;
        }


        public Training GetTrainingById(int trainingId)
        {
            var id = _trainingRepo.GetTrainingById(trainingId);
            return id;
        }

        public TrainingDetailsVm GetTrainingDetails(int id)
        {
            var training = _trainingRepo.GetTrainingById(id);
            var trainingVm = _mapper.Map<TrainingDetailsVm>(training);
            return trainingVm;
        }      
    }
}
