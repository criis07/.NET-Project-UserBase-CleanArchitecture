FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY src/TemplateProject.Domain/TemplateProject.Domain.csproj ./src/TemplateProject.Domain/
COPY src/TemplateProject.Application/TemplateProject.Application.csproj ./src/TemplateProject.Application/
COPY src/TemplateProject.Infrastructure/TemplateProject.Infrastructure.csproj ./src/TemplateProject.Infrastructure/
COPY src/TemplateProject.Api/TemplateProject.Api.csproj ./src/TemplateProject.Api/
RUN dotnet restore ./src/TemplateProject.Api/TemplateProject.Api.csproj

COPY . ./
RUN dotnet publish ./src/TemplateProject.Api -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
EXPOSE 8080
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "TemplateProject.Api.dll"]
