FROM microsoft/dotnet:2.2.103-sdk AS build
WORKDIR /app
COPY FSharpEFPostgreSQL/ ./
RUN dotnet publish -c Release -o out

FROM microsoft/dotnet:2.2.1-aspnetcore-runtime AS runtime
COPY --from=build /app/out/ ./
ENTRYPOINT ["dotnet", "FSharpEFPostgreSQL.dll"]
