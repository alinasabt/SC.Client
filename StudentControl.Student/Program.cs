using AutoMapper;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using StudentControl.DTO;
using StudentControl.Student;
using StudentControl.Student.Shared;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddAutoMapper(typeof(MapperProfile));
var MapperConfiguration = new MapperConfiguration(conf => conf.AddProfile(new MapperProfile()));
var Mapper = MapperConfiguration.CreateMapper();
builder.Services.AddSingleton(Mapper);




await builder.Build().RunAsync();
