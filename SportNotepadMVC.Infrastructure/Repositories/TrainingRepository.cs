using SportNotepadMVC.Domain.Interfaces;
using SportNotepadMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Infrastructure.Repositories
{  
    public class TrainingRepository : ITrainingRepository
    {
        private readonly Context _context;
        public TrainingRepository(Context context)
        {
            _context = context;
        }
        public int AddTraining(Training trainig)
        {
            _context.Trainings.Add(trainig);
            _context.SaveChanges();
            return trainig.Id;
        }

        public void DeleteTraining(int id)
        {
            var training = _context.Trainings.Find(id);
            if(training != null)
            {
                _context.Trainings.Remove(training);
                _context.SaveChanges();
            }           
        }

        public void EditTraining(Training training)
        {
            _context.Attach(training);
            _context.Entry(training).Property("Date").IsModified = true;
            _context.Entry(training).Property("Distance").IsModified = true;
            _context.Entry(training).Property("Result").IsModified = true;
            _context.Entry(training).Property("AveragePace").IsModified = true;
            _context.Entry(training).Property("Localization").IsModified = true;
            _context.Entry(training).Property("Comment").IsModified = true;
            _context.SaveChanges();
        }

        public IQueryable<Training> GetAllTrainings()
        {
            return _context.Trainings.Where(p => true);
        }

        public Training GetTrainingById(int trainingId)
        {
            return _context.Trainings.FirstOrDefault(p => p.Id == trainingId);
        }
    }
}
