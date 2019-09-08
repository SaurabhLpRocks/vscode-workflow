#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.2-sdk as DEV
COPY ["CoreApi.csproj", "src/CoreApi.csproj"]
RUN dotnet restore "src/CoreApi.csproj"
RUN apt-get update
RUN apt-get install -y curl unzip
#To support linux "ps" command, install procps
RUN apt-get install -y procps
RUN curl -sSL https://aka.ms/getvsdbgsh | bash /dev/stdin -v latest -l /publish/vsdbg
ENV DOTNET_USE_POLLING_FILE_WATCHER 1
WORKDIR /src
COPY . .
EXPOSE 80
ENTRYPOINT ["dotnet", "watch", "run", "--urls=http://+:80"]