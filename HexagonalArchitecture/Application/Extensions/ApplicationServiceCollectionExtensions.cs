﻿using HexagonalArchitecture.Application.UseCase;

namespace HexagonalArchitecture.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Application services
        services.AddScoped<IUserCreation, UserManagementService>();
        services.AddScoped<IUserDisplay, UserManagementService>();
        services.AddScoped<IUserDeletion, UserManagementService>();
        services.AddScoped<IUserDetailsModification, UserManagementService>();
        services.AddScoped<IUserRegistration, UserRegistrationService>();
        services.AddScoped<IUserSignIn, AuthenticationService>();
        services.AddScoped<IEventPublishing, EventPublisherService>();
        services.AddSingleton<INotificationSending, NotificationService>();

        return services;
    }
}