# Proyecto SOLCRM - Taller de Programación (Semana 8)

Este proyecto corresponde a la actividad colaborativa de la **Semana 8** del módulo **PRO201 - Taller de Programación**, desarrollado en Visual Studio 2019 como una aplicación de escritorio (Windows Forms) en C#.

El objetivo principal fue crear una aplicación que permita conectar con una base de datos SQL Server y ejecutar operaciones básicas como insertar, actualizar, eliminar y buscar registros dentro de una tabla `USUARIO`, utilizando ADO.NET.

---

## 🔗 Conexión a Base de Datos

Se utilizó una clase `BD.cs` para administrar la conexión a SQL Server mediante autenticación `sa`, con la siguiente cadena:

```csharp
"Data Source=localhost\SQLEXPRESS;Initial Catalog=NAME-DE-TU-BBDD;User ID=sa;Password=TUCLAVE"
```

---

## 📂 Estructura del Proyecto

* **SOLCRM.sln**: Solución principal.
* **CRM/**: Proyecto Windows Forms que contiene:

  * `Form1.cs`: formulario principal con los botones de acción.
  * `BD.cs`: clase de conexión a la base de datos.
  * `Form1.Designer.cs`: diseño visual de la interfaz.

---

## 📊 Funcionalidades por Etapa

### 1. Probar Conexión

* Botón: `btnProbarConexion`
* Verifica si la conexión a la base de datos es exitosa o muestra error.

### 2. Insertar Registro

* Botón: `btnInsertarRegistro`
* Inserta un nuevo usuario con valores estáticos.
* Incluye validación de clave primaria (rut).

### 3. Actualizar Registro

* Botón: `btnActualizarRegistro`
* Cambia la clave de todos los usuarios a un valor fijo (`AIEP`).

### 4. Eliminar Registro

* Botón: `btnEliminarRegistro`
* Elimina un usuario específico por su RUT (`rut = '9'`).

### 5. Buscar Registro

* Botón: `btnBuscar`
* Permite ingresar un RUT y mostrar si existe o no, junto con su clave.

---

## 📖 Requisitos del sistema

* Visual Studio 2019 o superior
* SQL Server Express (instancia SQLEXPRESS)
* Base de datos: `crmcli` con tabla `USUARIO`

---

## 🔗 Referencias

* Apuntes y orientaciones del módulo PRO201 Semana 8 - AIEP
* Microsoft Docs: [SqlConnection Class](https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlconnection)
* [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/es-es/sql/ssms/download-ssms)

---

**Versión:** 1.0 - Taller Semana 8 - CRM con SQL Server
