using AutoMapper;
using FluentAssertions;
using Moq;
using SportNotepadMVC.Application.Mapping;
using SportNotepadMVC.Application.Services;
using SportNotepadMVC.Application.ViewModels.Competition;
using SportNotepadMVC.Domain.Interfaces;
using SportNotepadMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SportNotepadMVC.Tests.Services
{
    public class CompetitionsServiceTests
    {
        private Competition SetCompetition()
        {
            var competition = new Competition()
            {
                Id = 1,
                StartNumber = "1",
                Position = 1,
                Result = "01:48:56",
                Name = "Półmaraton Warszawski",
                City = "Warszawa",
                Country = "Polska",
                Distance = "21.047",
                Date = DateTime.Now,
                Comment = "..."
            };

            return competition;
        }

        [Fact]
        public void ShouldReturnCompetition()
        {
            //Arrage
            var competition = SetCompetition();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();
            var competitionRepo = new Mock<ICompetitionRepository>();
            competitionRepo.Setup(c => c.GetCompetitionById(1)).Returns(competition);
            var competitionServ = new CompetitionService(competitionRepo.Object, mapper);
            //Act
            var competitionResult = competitionServ.GetCompetitionById(1);
            //Assert
            competitionResult.Should().NotBeNull();
            competitionResult.Should().BeOfType(typeof(Competition));
            competitionResult.Should().BeSameAs(competition);
        }

        [Fact]
        public void ShouldReturnCompetitionVmToEdit()
        {
            var competition = SetCompetition();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();
            var competitionRepo = new Mock<ICompetitionRepository>();
            competitionRepo.Setup(c => c.GetCompetitionById(1)).Returns(competition);
            var competitionService = new CompetitionService(competitionRepo.Object, mapper);
            var competitionVmResult = competitionService.CompetitionForEdit(1);

            competitionVmResult.Should().NotBeNull();
            competitionVmResult.Should().BeOfType(typeof(NewCompetitionVm));
        }

        [Fact]
        public void ShouldreturnCompetitionDetailVm()
        {
            var competition = SetCompetition();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();
            var competitionRepo = new Mock<ICompetitionRepository>();
            competitionRepo.Setup(s => s.GetCompetitionById(1)).Returns(competition);
            var competitionServ = new CompetitionService(competitionRepo.Object, mapper);

            var competitionDetailsVmResult = competitionServ.GetCompetitionDetails(1);

            competitionDetailsVmResult.Should().NotBeNull();
            competitionDetailsVmResult.Should().BeOfType(typeof(CompetitionDetailsVm));
        }

        [Fact]
        public void ShouldReturnAllCompetitions()
        {
            var competitions = new List<Competition>() { SetCompetition(), SetCompetition(), SetCompetition() };
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();
            var competitionRepo = new Mock<ICompetitionRepository>();
            competitionRepo.Setup(c => c.GetAllCompetitions()).Returns(competitions.AsQueryable());
            var competitionServ = new CompetitionService(competitionRepo.Object, mapper);

            var resultList = competitionServ.GetAllCompetitions(1,1,"");

            resultList.Should().NotBeNull();
            resultList.Should().BeOfType(typeof(ListCompetitionForListVm));
           // resultList.Count.Should().Be(3);
            resultList.Competitions.Should().AllBeOfType(typeof(CompetitionForListVm));
            //resultList.Competitions.Should().HaveCount(3);
        }
    }
}
