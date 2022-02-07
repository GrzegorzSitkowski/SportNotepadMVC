using Microsoft.Extensions.DependencyInjection;
using SportNotepadMVC.Domain.Interfaces;
using SportNotepadMVC.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Infrastructure
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<ICompetitionRepository, CompetitionRepository>();
            services.AddTransient<ITrainingRepository, TrainingRepository>();
            services.AddTransient<IProfileUserRepository, ProfileUserRepository>();
            services.AddTransient<IPhotoGalleryRepository, PhotoGalleryRepository>();
            services.AddTransient<IGoalRepository, GoalRepository>();
            return services;
        }
    }
}
