using Microsoft.Extensions.DependencyInjection;
using SportNotepadMVC.Application.Interfaces;
using SportNotepadMVC.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Application
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<ICompetitionService, CompetitionService>();
            services.AddTransient<ITrainingService, TrainingService>();
            services.AddTransient<IProfileUserService, ProfileUserService>();
            services.AddTransient<IPhotoGalleryService, PhotoGalleryService>();
            services.AddTransient<IGoalService, GoalService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
