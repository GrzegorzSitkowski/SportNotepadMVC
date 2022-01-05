using SportNotepadMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Domain.Interfaces
{
    public interface ICompetitionRepository
    {
        int AddCompetition(Competition competition);
        void EditCompetition(Competition competition);
        void DeleteCompetition(int id);
        Competition GetCompetitionById(int competitionId);
        IQueryable<Competition> GetAllCompetitions();

    }
}
