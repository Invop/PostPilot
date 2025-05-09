var builder = DistributedApplication.CreateBuilder(args);

builder.AddNpmApp("client", "../../frontend/postpilot","dev")
  .WithEnvironment("BROWSER", "none") // Disable opening browser on npm start
  .WithHttpEndpoint(env: "PORT")
  .WithExternalHttpEndpoints();
builder.Build().Run();
