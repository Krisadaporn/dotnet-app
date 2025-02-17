# Use the official .NET SDK (Build Environment) image for building the application
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# Copy the entire project to the working directory in the container
COPY . ./

# Restore dependencies
RUN dotnet restore

# Build the application (Release mode for production)
RUN dotnet publish -c Release -o /app/out

# Use a smaller, runtime-only image to run the app
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app

# Copy the published app from the build stage
COPY --from=build /app/out .

# Expose the port your app is listening on (default is 5000 for ASP.NET Core)
EXPOSE 5000

# Set the command to run the application
ENTRYPOINT ["dotnet", "WebApp.dll"]