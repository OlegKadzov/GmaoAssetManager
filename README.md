API REST para un sistema de gestión del mantenimiento de equipos industriales (GMAO/MES). La aplicación permite llevar un registro de máquinas herramienta, bombas y otros activos, así como realizar un seguimiento de los estados y las fechas de mantenimiento.
## Pila tecnológica
* **Lenguaje:** C#
* **Framework:** .NET 10 (ASP.NET Core Web API)
* **Base de datos:** SQLite (local)
* **ORM:** Entity Framework Core
* **Documentación de la API:** Swagger / OpenAPI
* ## Funcionalidad principal (CRUD)
La API proporciona los siguientes puntos finales para gestionar la entidad `Equipment`:
* `GET /api/Equipment`: obtener la lista de todo el equipo
* `POST /api/Equipment`: añadir una nueva unidad de equipo
* `PUT /api/Equipment/{id}`: actualizar los datos de un equipo existente
* `DELETE /api/Equipment/{id}`: eliminar un equipo de la base de datos

## Cómo ejecutar el proyecto de forma local

1. Clona el repositorio:
   ```bash
   git clone [https://github.com/Oleg Kadzov/GmaoAssetManager.git](https://github.com/ВАШ_USERNAME/GmaoAssetManager.git)
