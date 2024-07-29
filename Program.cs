var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<Program>());

var app = builder.Build();

app.Run();
