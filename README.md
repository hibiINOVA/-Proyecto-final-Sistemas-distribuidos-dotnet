# Integración Pipedream - Backend .NET Core

Este proyecto .NET Core (C\#) está diseñado para interactuar y consumir un flujo de trabajo (workflow) o un endpoint específico alojado en Pipedream.

## Inicio Rápido

Sigue estos pasos para configurar el entorno y ejecutar la aplicación .NET Core.

### 1\. Requisitos Previos

  * **SDK de .NET Core:** Debes tener instalado el SDK de .NET (versión 6.0 o superior recomendada).
  * **API Key / Endpoint de Pipedream:** Necesitas la URL del endpoint de tu workflow en Pipedream.

### 2\. Instalación de Dependencias

Navega al directorio raíz del proyecto .NET (donde se encuentra el archivo `.csproj`) e instala las dependencias:

```bash
dotnet restore
```

### 3\. Compilación y Ejecución del Proyecto

Una vez que las dependencias estén instaladas y la configuración de Pipedream esté en su lugar, puedes compilar y ejecutar la aplicación.

**A. Ejecutar la Aplicación**

Utiliza el comando estándar de .NET para ejecutar el proyecto directamente:

```bash
dotnet run
```

Este comando compila el proyecto y lo inicia inmediatamente.

### 4\. Verificación de la Integración

  * **Si es una aplicación de consola:** La aplicación realizará la llamada a Pipedream.
  * **Si es un servicio web (ASP.NET Core):** El servicio se iniciará (ej. en `http://localhost:5020`).

-----
