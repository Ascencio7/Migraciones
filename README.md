<div align="left">🔴🟡🟢</div>

<br>

## 👤 Migraciones SQL con C#, Entity Framework Core y .NET 8

**Proyecto de consola de C# para realizar la guía práctica de DPWA**

<picture>
  <img align="right" src="https://cdna.artstation.com/p/assets/images/images/052/141/832/original/johan-cediel-rodriguez-pixel-art-take-008.gif?1659036879?raw=true" width="200"/>
</picture>


- Este repositorio contiene **una aplicación de consola con C#** que implementa la migración a SQL Server. 

- La aplicación se conecta a una base de datos SQL Server para migrar datos. 

- La base de datos se actualiza en tiempo real, lo que permite una gestión eficiente de los pedidos. 

--- 

## 🛠️ Tecnologías Utilizadas

✅ C# <br>
✅ .NET<br>
✅ Entity Framework<br>
✅ SQL Server<br>

---
## 💻 ​Comandos de instalación

1. Instalación de paquetes EF Core (versión 7 para ser compatible con .NET 8

```bash
dotnet add package Microsoft.EntityFrameworkCore --version 7.0.18
```

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.18
```

```bash
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.18
```

```bash
dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.18
```

2. Instalación de herramienta global de Entity Framework

```bash
dotnet tool install --global dotnet-ef
```

3. Crear las migraciones (los nombres pueden varias al gusto)
   
```bash
dotnet ef migrations add AddPersonaContraints
```

```bash
dotnet ef migrations add AddCarreraConstraint
```

4. Aplicar la migración a la base de datos SQL Server

```bash
python.exe -m pip install --upgrade pip
```

5. Finalmente se compila el proyecto

```bash
dotnet build
```
---

## Consulta a SQL Server: Tablas vacías
<figure>
  <img src="/images/consultaSQL.png" alt="Captura de consulta SQL" style="max-width: 600px; display:block; margin:auto;">
</figure>

## Consulta SQL Server: Inserciones de prueba
<figure>
  <img src="/images/pedidosActivos.png" alt="Captura de pedidos activos" style="max-width: 600px; display:block; margin:auto;">
</figure>

<br>

---
## ✨ Autor

Vladimir Ascencio – Desarrollador en aprendizaje continuo 🚀

¡Gracias por visitar este proyecto! 🧑‍💻

---

<h3 align="left">🔎 Contactos</h3>
<table align="center">
  <tr>
    <td align="center">
      <a href="mailto:ascencio3.1417@gmail.com" target="_blank" rel="noopener noreferrer">
        <img src="https://skillicons.dev/icons?i=gmail" width="50" alt="Gmail" title="Gmail" />
      </a>
    </td>
    <td align="center">
      <a href="https://www.instagram.com/vl_ascencio" target="_blank" rel="noopener noreferrer">
        <img src="https://skillicons.dev/icons?i=instagram" width="50" alt="Instagram" title="Instagram" />
      </a>
    </td>
    <td align="center">
      <a href="https://discord.com/users/vl_ascencio" target="_blank" rel="noopener noreferrer">
        <img src="https://skillicons.dev/icons?i=discord" width="50" alt="Discord" title="Discord" />
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/Ascencio7" target="_blank" rel="noopener noreferrer">
        <img src="https://skillicons.dev/icons?i=github" width="50" alt="GitHub" title="GitHub" />
      </a>
    </td>
  </tr>
</table>

<br><br>

  ---

<!-- Footer -->
<div align="center">
  <img width="100%" src="https://capsule-render.vercel.app/api?type=waving&height=100&color=gradient&reversal=true" alt="footer waving" />
</div>
