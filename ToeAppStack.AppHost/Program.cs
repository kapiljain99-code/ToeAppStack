var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ToeAppStack_Server>("toeappstack-server");

builder.Build().Run();
