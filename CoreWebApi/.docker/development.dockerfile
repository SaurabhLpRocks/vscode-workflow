FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS base
WORKDIR /src

# Copy only the project file.
# We copied only the project file and not the complete source code
# to leaverage the docker's caching capabilities thereby optimizing up the build time.
COPY ["CoreWebApi.csproj", "./"]

# Restore the packages
RUN dotnet restore "./CoreWebApi.csproj"

# Copy the source code to the /src directory
COPY . .

RUN update-ca-certificates

# Expose ports 5000 & 5001 as our app will run on these ports
EXPOSE 5000 5001
ENTRYPOINT ["dotnet", "watch", "--project=CoreWebApi.csproj", "run"]
