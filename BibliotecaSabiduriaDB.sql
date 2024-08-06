--CREACION DE LA DB
create database Biblioteca_Sabiduria
go

--USO DE LA DB
use Biblioteca_Sabiduria


--CREACION DE LA TABLAS
create table USUARIOS 
(
Id int identity (1,1) primary key,
Nombre nvarchar (100),
Apellido nvarchar (100),
Celular nvarchar(20),
Email nvarchar (100),
Usuario nvarchar (100),
Contrasena nvarchar (100),
Rol nvarchar (30)
)

create table GENEROS 
(
Id int identity (1,1) primary key,
Nombre nvarchar (100),
Descripcion nvarchar (max)
)

create table AUTORES 
(
Id int identity (1,1) primary key,
Nombre nvarchar (100),
Bibliografia nvarchar (max)
)
create  table LIBROS (
    Id INT PRIMARY KEY IDENTITY,
    Titulo nvarchar(100),
    Autor INT FOREIGN KEY REFERENCES AUTORES(Id),
    AñoPublicacion INT,
    Genero INT FOREIGN KEY REFERENCES GENEROS(Id)
);

--INSERTO DATOS EN LAS TABLAS
INSERT INTO LIBROS (Titulo, Autor, AñoPublicacion, Genero)
VALUES 
('Cien años de soledad', 1, 1967, 1),
('Orgullo y Prejuicio', 2, 1813, 1),
('Las aventuras de Tom Sawyer', 3, 1876, 2),
('Beloved', 4, 1987, 1),
('Crimen y castigo', 5, 1866, 1);

INSERT INTO USUARIOS (Nombre, Apellido, Celular, Email, Usuario, Contrasena, Rol)
VALUES 
('Cristian', 'Cruz', 1234567890, 'cristian.cruz@gmail.com', 'admin', '123', 'Admin'),
('Maria', 'Gomez', 2345678901, 'maria.gomez@gmail.com', 'mariagomez', 'password456', 'Empleado'),
('Carlos', 'Lopez', 3456789012, 'carlos.lopez@gmail.com', 'carloslopez', 'password789', 'Empleado'),
('Ana', 'Martinez', 4567890123, 'ana.martinez@gmail.com', 'anamartinez', 'password101', 'Empleado'),
('Luis', 'Rodriguez', 5678901234, 'luis.rodriguez@gmail.com', 'luisrodriguez', 'password202', 'Empleado');

INSERT INTO GENEROS (Nombre, Descripcion)
VALUES 
('Novela', 'Una narracion extensa y compleja, desarrollada en prosa, que explora en profundidad las experiencias humanas a traves de personajes y situaciones ficticias.'),
('Cuento', 'Un relato breve y conciso, centrado en un solo incidente o personaje, que busca provocar una fuerte impresion o emocion en el lector.'),
('Poesia', 'Expresion artistica de sentimientos y emociones, utilizando un lenguaje ritmico y a menudo con rima, que busca crear belleza a traves de la palabra.'),
('Ensayo', 'Un texto en prosa que analiza, interpreta o evalua un tema especifico desde un punto de vista personal y subjetivo, ofreciendo reflexiones y argumentos.'),
('Teatro', 'Obra literaria concebida para ser representada en un escenario, donde los personajes dialogan y actuan frente a un publico, explorando conflictos humanos y sociales.');

INSERT INTO AUTORES (Nombre, Bibliografia)
VALUES 
('Gabriel Garcia Marquez', 'Autor de "Cien años de soledad" y Premio Nobel de Literatura.'),
('Jane Austen', 'Escritora de "Orgullo y Prejuicio" y otras novelas clasicas.'),
('Mark Twain', 'Autor de "Las aventuras de Tom Sawyer" y "Las aventuras de Huckleberry Finn".'),
('Toni Morrison', 'Ganadora del Premio Nobel de Literatura y autora de "Beloved".'),
('Fyodor Dostoevsky', 'Escritor ruso conocido por "Crimen y castigo" y "Los hermanos Karamazov".');

--VER LAS TABLAS
select * from USUARIOS

select * from GENEROS

select * from AUTORES

--USUARIOS
create proc MostrarUsuarios
as
select * from USUARIOS
go

create proc InsertarUsuarios
@Nombre nvarchar(100),
@Apellido nvarchar (100),
@Celular nvarchar (100),
@Email nvarchar (100),
@Usuario nvarchar (100),
@Contrasena nvarchar (100),
@Rol nvarchar (100)

as

Insert Into USUARIOS values (@Nombre,@Apellido,@Celular,@Email,@Usuario,@Contrasena,@Rol)
GO
create proc EditarUsuarios
@Nombre nvarchar(100),
@Apellido nvarchar (100),
@Celular nvarchar (100),
@Email nvarchar (100),
@Usuario nvarchar (100),
@Contrasena nvarchar (100),
@Rol nvarchar (100),
@Id int
as
update USUARIOS set Nombre=@Nombre,Apellido=@Apellido,Celular = @Celular,Email=@Email,usuario=@Usuario,Contrasena=@Contrasena,Rol=@Rol
where id=@Id
go

create proc EliminarUsuarios
@IdUsu int
as
delete from USUARIOS where Id=@IdUsu
go

exec MostrarUsuarios
exec EditarUsuarios 'jose','aguirre','38155423020','jose@gmail.com','jose10','12345','empleado','6'
exec InsertarUsuarios 'jose','aguirre','38155423020','jose@gmail.com','jose10','123456','empleado'
exec EliminarUsuarios 8
USE Biblioteca_Sabiduria;
GO

---AUTORES

create proc MostrarAutores
as
select * from AUTORES
go

create proc InsertarAutores
@Nombre nvarchar(100),
@Bibliografia nvarchar (1000)
as

Insert Into AUTORES values (@Nombre,@Bibliografia)
GO

create proc EditarAutores
@Nombre nvarchar(100),
@Bibliografia nvarchar (1000),
@Id int
as
update AUTORES set Nombre=@Nombre,Bibliografia=@Bibliografia
where id=@Id
go

create proc EliminarAutores
@IdAut int
as
delete from AUTORES where Id=@IdAut
go

exec MostrarAutores
exec EditarAutores 'jose','aguirre','38155423020','jose@gmail.com','jose10','12345','empleado','6'
exec InsertarAutores 'jose','aguirre','38155423020','jose@gmail.com','jose10','123456','empleado'
exec EliminarAutores 8


---GENEROS

create proc MostrarGeneros
as
select * from GENEROS
go

create proc InsertarGeneros
@Nombre nvarchar(100),
@Descripcion nvarchar (1000)
as

Insert Into GENEROS values (@Nombre,@Descripcion)
GO

create proc EditarGeneros
@Nombre nvarchar(100),
@Descripcion nvarchar (1000),
@Id int
as
update GENEROS set Nombre=@Nombre,Descripcion=@Descripcion
where id=@Id
go

create proc EliminarGeneros
@IdGen int
as
delete from GENEROS where Id=@IdGen
go

exec MostrarGeneros
exec EditarAutores 'jose','aguirre','38155423020','jose@gmail.com','jose10','12345','empleado','6'
exec InsertarAutores 'jose','aguirre','38155423020','jose@gmail.com','jose10','123456','empleado'
exec EliminarAutores 8

---LIBROS

create proc MostrarLibros
AS
BEGIN
    SELECT 
        l.Id, 
        l.Titulo, 
        a.Nombre AS Autor, 
        l.AñoPublicacion, 
        g.Nombre AS Genero
    FROM 
        LIBROS l
    JOIN 
        AUTORES a ON l.Autor = a.Id
    JOIN 
        GENEROS g ON l.Genero = g.Id;
END
GO

create proc InsertarLibros
@Titulo nvarchar(100),
@Autor int,
@AñoPublicacion int,
@Genero int
as

Insert Into LIBROS values (@Titulo,@Autor,@AñoPublicacion,@Genero)
go

create proc EditarLibros
@Titulo nvarchar(100),
@Autor int,
@AñoPublicacion int,
@Genero int,
@Id int
as
update LIBROS set Titulo=@Titulo,Autor=@Autor,AñoPublicacion=@AñoPublicacion,Genero=@Genero
where id=@Id
go

create proc EliminarLibros
@IdLib int
as
delete from LIBROS where Id=@IdLib
go

---Para Obtener todos los Autores y Generos 
create proc ObtenerAutores
as
 select Id, Nombre FROM AUTORES;
 go

create proc ObtenerGeneros
as
select Id, Nombre FROM GENEROS;
go



ALTER PROCEDURE MostrarLibros
AS
select * from LIBROS
GO

SELECT 
    OBJECT_DEFINITION(OBJECT_ID('MostrarLibros')) AS ProcedimientoAlmacenado;
