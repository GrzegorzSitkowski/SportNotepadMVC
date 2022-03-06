using AutoMapper;
using AutoMapper.QueryableExtensions;
using SportNotepadMVC.Application.Interfaces;
using SportNotepadMVC.Application.ViewModels.Competition;
using SportNotepadMVC.Domain.Interfaces;
using SportNotepadMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Application.Services
{
    public class CompetitionService : ICompetitionService
    {
        private readonly IMapper _mapper;
        private readonly ICompetitionRepository _competitionRepo;
        public CompetitionService(ICompetitionRepository competitionRepo, IMapper mapper)
        {
            _mapper = mapper;
            _competitionRepo = competitionRepo;
        }
        public int AddCopmetition(NewCompetitionVm competition)
        {
            var _competition = _mapper.Map<Competition>(competition);
            var id = _competitionRepo.AddCompetition(_competition);
            return id;
        }

        public NewCompetitionVm CompetitionForEdit(int id)
        {
            var competition = _competitionRepo.GetCompetitionById(id);
            var competitionVm = _mapper.Map<NewCompetitionVm>(competition);
            return competitionVm;
        }

        public void DeleteCompetition(int id)
        {
            _competitionRepo.DeleteCompetition(id);
        }

        public void EditCompetition(NewCompetitionVm model)
        {
            var competition = _mapper.Map<Competition>(model);
            _competitionRepo.EditCompetition(competition);
        }

        public ListCompetitionForListVm GetAllCompetitions(int pageSize, int pageNo, string searchString)
        {
            var competitions = _competitionRepo.GetAllCompetitions().Where(p => p.Name.StartsWith(searchString))
                .ProjectTo<CompetitionForListVm>(_mapper.ConfigurationProvider).ToList();

            var competitionToShow = competitions.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();

            var competitionList = new ListCompetitionForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                SearchString = searchString,
                Competitions = competitionToShow,
                Count = competitions.Count
            };
            return competitionList;
        }

        public CompetitionDetailsVm GetCompetitionDetails(int id)
        {
            var competition = _competitionRepo.GetCompetitionById(id);
            var competitionVm = _mapper.Map<CompetitionDetailsVm>(competition);
            return competitionVm;
        }

        public void DownloadList()
        {
            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = path + "\\CompetitionList.txt";
            using StreamWriter sw = File.AppendText(fileName);

            var competition = _competitionRepo.GetCompetitionById(1);
            var competitionToFile = _competitionRepo.GetAllCompetitions();
            foreach(var item in competitionToFile)
            {
                sw.WriteLine(item.Position + " | " + item.Result + " | " + item.Name + " | " + item.Distance + " | " +
                    item.Date);
            }
        }
    }
}
