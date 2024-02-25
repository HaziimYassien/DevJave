var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.More_depressed_than_Valorant_Players>("more_depressed_than_valorant_players");

builder.Build().Run();
