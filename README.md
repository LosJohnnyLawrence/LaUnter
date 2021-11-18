# Unter

## Para cliente correr
* Desde el proyecto de cliente *
npm run start

## Para correr Server core correr
* Desde el proyecto de API *
dotnet run

## para crear una nueva migracion de DB correr 
* Desde el proyecto de datos *
dotnet ef --startup-project ..\CAECE.JL.Unter.Server.API\ migrations add nombre-migration

## para ejecutar las migraciones de db
* Desde el proyecto de datos *
dotnet ef --startup-project ..\CAECE.JL.Unter.Server.API\ database update
