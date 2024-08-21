using AutoMapper;
using BTG.Credit.Ras.Interview.Application.Model;
using BTG.Credit.Ras.Interview.Data;
using BTG.Credit.Ras.Interview.Domain;
using BTG.Credit.Ras.Interview.Domain.DataList;
using BTG.Credit.Ras.Interview.Domain.NotifySystem;
using BTG.Credit.Ras.Interview.Domain.Users;
using BTG.Credit.Ras.Interview.Service;
using BTG.Credit.Ras.Interview.Service.DataList;
using BTG.Credit.Ras.Interview.Service.NotifySystem;
using Microsoft.AspNetCore.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using ServiceProvider = BTG.Credit.Ras.Interview.Service.ServiceProvider;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IMessageChatService, MessageChatService>();
builder.Services.AddScoped<MessageData>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<INotificationService, NotificationService>();
builder.Services.AddScoped<ICalcService, SumService>();
builder.Services.AddScoped<ICalcService, SubService>();
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IUserService, UserService>();

builder.Services.AddScoped<IDataListService, DataListService>();
builder.Services.AddScoped<IDataListRepository, DataListRepository>();

builder.Services.AddSingleton(new MapperConfiguration(config =>
{
    config.CreateMap<MessageChatModel, MessageChat>().ReverseMap();
    config.CreateMap<MessageChat, MessageChatModel>().ReverseMap();
    config.CreateMap<CalcRequestModel, CalcRequest>().ReverseMap();
    config.CreateMap<CalcTypeModel, CalcType>().ReverseMap();
}).CreateMapper());

var app = builder.Build();

app.UseExceptionHandler(exceptionHandlerApp =>
{
    exceptionHandlerApp.Run(async context =>
    {
        context.Response.StatusCode = StatusCodes.Status500InternalServerError;

        var ex =
            context.Features.Get<IExceptionHandlerPathFeature>();

        if (ex?.Error is ValidationException validationException)
        {
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
            context.Response.ContentType = Text.Plain;
            await context.Response.WriteAsync(validationException.Message);
        }
    });
});
ServiceProvider.Initialize(app.Services);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
