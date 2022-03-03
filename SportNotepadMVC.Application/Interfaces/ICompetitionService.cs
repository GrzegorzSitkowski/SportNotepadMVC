using SportNotepadMVC.Application.ViewModels.Competition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Application.Interfaces
{
    public interface ICompetitionService
    {
        int AddCopmetition(NewCompetitionVm competition);
        void EditCompetition(NewCompetitionVm model);
        void DeleteCompetition(int id);
        CompetitionDetailsVm GetCompetitionDetails(int id);
        NewCompetitionVm CompetitionForEdit(int id);
        ListCompetitionForListVm GetAllCompetitions(int pageNo, int pageSize, string searchString);
        void DownloadList();
    }
}
