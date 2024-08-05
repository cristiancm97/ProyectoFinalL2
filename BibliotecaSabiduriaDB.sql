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
Celular bigint,
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

--INSERTO DATOS EN LAS TABLAS
INSERT INTO USUARIOS (Nombre, Apellido, Celular, Email, Usuario, Contrasena, Rol)
VALUES 
('Cristian', 'Cruz', 1234567890, 'cristian.cruz@gmail.com', 'admin', '123', 'Admin'),
('María', 'Gómez', 2345678901, 'maria.gomez@gmail.com', 'mariagomez', 'password456', 'Empleado'),
('Carlos', 'López', 3456789012, 'carlos.lopez@gmail.com', 'carloslopez', 'password789', 'Empleado'),
('Ana', 'Martínez', 4567890123, 'ana.martinez@gmail.com', 'anamartinez', 'password101', 'Empleado'),
('Luis', 'Rodríguez', 5678901234, 'luis.rodriguez@gmail.com', 'luisrodriguez', 'password202', 'Empleado');

INSERT INTO GENEROS (Nombre, Descripcion)
VALUES 
('Novela', 'Una narración extensa y compleja, desarrollada en prosa, que explora en profundidad las experiencias humanas a través de personajes y situaciones ficticias.'),
('Cuento', 'Un relato breve y conciso, centrado en un solo incidente o personaje, que busca provocar una fuerte impresión o emoción en el lector.'),
('Poesía', 'Expresión artística de sentimientos y emociones, utilizando un lenguaje rítmico y a menudo con rima, que busca crear belleza a través de la palabra.'),
('Ensayo', 'Un texto en prosa que analiza, interpreta o evalúa un tema específico desde un punto de vista personal y subjetivo, ofreciendo reflexiones y argumentos.'),
('Teatro', 'Obra literaria concebida para ser representada en un escenario, donde los personajes dialogan y actúan frente a un público, explorando conflictos humanos y sociales.');

INSERT INTO AUTORES (Nombre, Bibliografia)
VALUES 
('Gabriel García Márquez', 'Autor de "Cien años de soledad" y Premio Nobel de Literatura.'),
('Jane Austen', 'Escritora de "Orgullo y Prejuicio" y otras novelas clásicas.'),
('Mark Twain', 'Autor de "Las aventuras de Tom Sawyer" y "Las aventuras de Huckleberry Finn".'),
('Toni Morrison', 'Ganadora del Premio Nobel de Literatura y autora de "Beloved".'),
('Fyodor Dostoevsky', 'Escritor ruso conocido por "Crimen y castigo" y "Los hermanos Karamazov".');

--VER LAS TABLAS
select * from USUARIOS

select * from GENEROS

select * from AUTORES

SELECT * FROM USUARIOS
WHERE Rol = 'Empleado';
