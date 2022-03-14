using AutoMapper;
using FluentAssertions;
using Moq;
using SportNotepadMVC.Application.Mapping;
using SportNotepadMVC.Application.Services;
using SportNotepadMVC.Application.ViewModels.Training;
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
    public class TrainingServiceTests
    {
        private Training SetTraining()
        {
            var training = new Training()
            {
                Id = 1,
                Date = DateTime.Now,
                Distance = "1",
                Result = "00:00:00",
                AveragePace = "00:00",
                Location = "Łódź",
                Comment = "..."
            };

            return training;
        }

        [Fact]
        public void ShouldReturnTraining()
        {
            var training = SetTraining();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();
            var trainingRepo = new Mock<ITrainingRepository>();
            trainingRepo.Setup(t => t.GetTrainingById(1)).Returns(training);
            var trainingServ = new TrainingService(trainingRepo.Object, mapper);

            var trainingResult = trainingServ.GetTrainingById(1);

            trainingResult.Should().NotBeNull();
            trainingResult.Should().BeOfType(typeof(Training));
            trainingResult.Should().BeSameAs(training);
        }

        [Fact]
        public void ShouldReturnTrainingToEdit()
        {
            var training = SetTraining();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();
            var trainingRepo = new Mock<ITrainingRepository>();
            trainingRepo.Setup(t => t.GetTrainingById(1)).Returns(training);
            var trainingServ = new TrainingService(trainingRepo.Object, mapper);

            var trainingVmResult = trainingServ.TrainingForEdit(1);

            trainingVmResult.Should().NotBeNull();
            trainingVmResult.Should().BeOfType(typeof(NewTrainingVm));
        }

        [Fact]
        public void ShouldReturnTrainingDetailsVm()
        {
            var training = SetTraining();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();
            var trainingRepo = new Mock<ITrainingRepository>();
            trainingRepo.Setup(t => t.GetTrainingById(1)).Returns(training);
            var trainingServ = new TrainingService(trainingRepo.Object, mapper);

            var trainingDetailsVmResult = trainingServ.GetTrainingDetails(1);

            trainingDetailsVmResult.Should().NotBeNull();
            trainingDetailsVmResult.Should().BeOfType(typeof(TrainingDetailsVm));
        }

        [Fact]
        public void ShouldReturnAllTrainigs()
        {
            var trainings = new List<Training>() { SetTraining(), SetTraining(), SetTraining() };
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();
            var trainingRepo = new Mock<ITrainingRepository>();
            trainingRepo.Setup(t => t.GetAllTrainings()).Returns(trainings.AsQueryable());
            var trainingServ = new TrainingService(trainingRepo.Object, mapper);

            var listResult = trainingServ.GetAllTrainigs();

            listResult.Should().NotBeNull();
            listResult.Should().BeOfType(typeof(ListTrainingForListVm));
            listResult.Trainings.Should().AllBeOfType(typeof(TrainingForListVm));
            listResult.Trainings.Should().HaveCount(3);
        }
    }
}
