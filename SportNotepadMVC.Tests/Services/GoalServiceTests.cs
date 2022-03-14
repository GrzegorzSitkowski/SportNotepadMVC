using AutoMapper;
using FluentAssertions;
using Moq;
using SportNotepadMVC.Application.Mapping;
using SportNotepadMVC.Application.Services;
using SportNotepadMVC.Application.ViewModels.Goal;
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
    public class GoalServiceTests
    {
        private Goal SetGoal()
        {
            var goal = new Goal()
            {
                Id = 1,
                Date = DateTime.Now,
                Name = "Name",
                Distance = "0 km",
                Time = "00:00:00",
                Location = "Łódź",
                Paid = true,
                Comment = "Comment"
            };

            return goal;
        }

        [Fact]
        public void ShouldReturnGoal()
        {
            var goal = SetGoal();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();
            var goalRepo = new Mock<IGoalRepository>();
            goalRepo.Setup(g => g.GetGoalById(1)).Returns(goal);
            var goalServ = new GoalService(goalRepo.Object, mapper);

            var goalResult = goalServ.GetGoalById(1);

            goalResult.Should().NotBeNull();
            goalResult.Should().BeOfType(typeof(Goal));
            goalResult.Should().BeSameAs(goal);
        }

        [Fact]
        public void ShouldReturnGoalVmToEdit()
        {
            var goal = SetGoal();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();
            var goalRepo = new Mock<IGoalRepository>();
            goalRepo.Setup(g => g.GetGoalById(1)).Returns(goal);
            var goalServ = new GoalService(goalRepo.Object, mapper);

            var goalVmToEditResult = goalServ.GoalForEdit(1);

            goalVmToEditResult.Should().NotBeNull();
            goalVmToEditResult.Should().BeOfType(typeof(NewGoalVm));
        }

        [Fact]
        public void ShouldReturnGoalDetailsVm()
        {
            var goal = SetGoal();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();
            var goalRepo = new Mock<IGoalRepository>();
            goalRepo.Setup(g => g.GetGoalById(1)).Returns(goal);
            var goalServ = new GoalService(goalRepo.Object, mapper);

            var goalVmDetailsResult = goalServ.GetGoalDetails(1);

            goalVmDetailsResult.Should().NotBeNull();
            goalVmDetailsResult.Should().BeOfType(typeof(GoalDetailsVm));
        }

        [Fact]
        public void ShouldReturnAllGoals()
        {
            var goals = new List<Goal>() { SetGoal(), SetGoal(), SetGoal() };
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();
            var goalRepo = new Mock<IGoalRepository>();
            goalRepo.Setup(g => g.GetAllGoals()).Returns(goals.AsQueryable());
            var goalServ = new GoalService(goalRepo.Object, mapper);

            var resultList = goalServ.GetAllGoal();

            resultList.Should().NotBeNull();
            resultList.Should().BeOfType(typeof(ListGoalForListVm));
            resultList.Goals.Should().AllBeOfType(typeof(GoalForListVm));
            resultList.Goals.Should().HaveCount(3);
        }
    }
}
