var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Contoso6>("contoso6");

builder.Build().Run();
