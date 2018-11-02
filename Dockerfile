FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 8002

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Booklist_Razor_Pages/Booklist_Razor_Pages.csproj", "Booklist_Razor_Pages/"]
RUN dotnet restore "Booklist_Razor_Pages/Booklist_Razor_Pages.csproj"
COPY . .
WORKDIR "/src/Booklist_Razor_Pages"
RUN dotnet build "Booklist_Razor_Pages.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Booklist_Razor_Pages.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Booklist_Razor_Pages.dll"]