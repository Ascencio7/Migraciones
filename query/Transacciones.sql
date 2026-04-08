CREATE DATABASE TRANSACCIONES;

GO
USE TRANSACCIONES;
GO

-- Tabla Departamento
CREATE TABLE [dbo].[Departamentos] (
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [NombreDepto] NVARCHAR(200) NOT NULL,
    [CantidadEmpleados] INT NOT NULL
);

-- Tabla Persona
CREATE TABLE [dbo].[Personas] (
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Nombre] NVARCHAR(200) NOT NULL,
    [Apellido] NVARCHAR(200) NOT NULL,
    [Salario] DECIMAL(18,2) NOT NULL,
    [deptoId] INT NOT NULL,
    CONSTRAINT [FK_Personas_Departamento_deptoId] FOREIGN KEY ([deptoId]) REFERENCES [dbo].[Departamentos]([Id])
);

-- Tabla Carrera
CREATE TABLE [dbo].[Carreras] (
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Nombre] NVARCHAR(200) NOT NULL,
    [Jornada] NVARCHAR(100) NOT NULL,
    [CantMaterias] INT NOT NULL,
    [DepartamentoId] INT NOT NULL,
    CONSTRAINT [FK_Carreras_Departamento_DepartamentoId] FOREIGN KEY ([DepartamentoId]) REFERENCES [dbo].[Departamentos]([Id]),
    CONSTRAINT [CK_Carrera_CantMaterias] CHECK ([CantMaterias] <= 20)
);


INSERT INTO Departamentos (NombreDepto, CantidadEmpleados) VALUES
('Recursos Humanos', 15),
('Finanzas', 20),
('Tecnología', 30),
('Marketing', 12),
('Ventas', 25),
('Producción', 40),
('Logística', 18),
('Legal', 8),
('Investigación', 10),
('Calidad', 14);


INSERT INTO Personas (Nombre, Apellido, Salario, deptoId) VALUES
('Juan', 'Perez', 500.25, 1),
('Maria', 'Lopez', 750.00, 2),
('Carlos', 'Gomez', 1200.50, 3),
('Ana', 'Martinez', 950.75, 4),
('Luis', 'Hernandez', 1100.00, 5),
('Sofia', 'Ramirez', 800.40, 6),
('Pedro', 'Cruz', 670.20, 7),
('Laura', 'Morales', 1300.00, 8),
('Diego', 'Castro', 900.00, 9),
('Valeria', 'Torres', 1000.00, 10);


INSERT INTO Carreras (Nombre, Jornada, CantMaterias, DepartamentoId) VALUES
('Ingeniería en Sistemas', 'Matutina', 15, 3),
('Contaduría Pública', 'Vespertina', 18, 2),
('Administración de Empresas', 'Matutina', 20, 1),
('Marketing Digital', 'Nocturna', 12, 4),
('Ventas Internacionales', 'Matutina', 10, 5),
('Producción Industrial', 'Vespertina', 16, 6),
('Logística Empresarial', 'Matutina', 14, 7),
('Derecho Corporativo', 'Nocturna', 20, 8),
('Investigación Científica', 'Matutina', 8, 9),
('Gestión de Calidad', 'Vespertina', 12, 10);

SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Personas';

SELECT * FROM Departamentos;
SELECT * FROM Personas;
SELECT * FROM Carreras;