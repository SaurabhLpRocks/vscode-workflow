FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS base
WORKDIR /src

# Copy only the project file.
# We copied only the project file and not the complete source code
# to leaverage the docker's caching capabilities thereby optimizing up the build time.
COPY ["CoreApi.csproj", "./"]

# Restore the packages
RUN dotnet restore "./CoreApi.csproj"

# Copy the source code to the /src directory
COPY . .

# Expose ports 5000 & 5001 as our app will run on these ports
EXPOSE 5000 5001
ENTRYPOINT ["dotnet", "watch", "--project=CoreApi.csproj", "run"]
