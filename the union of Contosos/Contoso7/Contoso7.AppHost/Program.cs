var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Contoso7>("contoso7");

builder.Build().Run();
