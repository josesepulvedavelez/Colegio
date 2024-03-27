
create database Colegio;
use Colegio;

create table Grado
(	
	GradoNombre varchar(50),

	Observaciones varchar(MAX),
	Estado bit,
	GradoId int identity(1, 1) primary key,
);

create table Estudiante
(	
	NombresApellidos varchar(100),
	Edad int,
	Rh varchar(3),
	LugarNacimiento varchar(100),
	FechaNacimiento date,
	Ti varchar(20),
	Direccion varchar(MAX),
	Telefono varchar(10),
	Talla varchar(5),
	Peso decimal(3, 2),
	Barrio varchar(100),
	Localidad varchar(50),
	Estrato int, 
	Religion varchar(50),
	Padre varchar(100),
	OficioPadre varchar(100),
	CelularPadre varchar(10),
	LugarTrabajoPadre varchar(100),
	CorreoPadre varchar(MAX),
	Madre varchar(100),
	OficioMadre varchar(100),
	CelularMadre varchar(10),
	LugarTrabajoMadre varchar(100),
	CorreoMadre varchar(MAX),
	EstadoCivil varchar(20),
	Acudiente varchar(100),
	Parentesco varchar(50),
	DireccionParentesco varchar(MAX),
	CelularParentesco varchar(10),

	Observaciones varchar(MAX),
	Estado bit,
	GradoId int foreign key references Grado(GradoId),
	EstudianteId int identity(1, 1) primary key
);

create table Matricula
(
	FechaInicio date,
	FechaFinal date,
	Meses int,
	ValorMatricula money,
	OtrosCostos money,
	ValorPension money,
	TotalPension money, --> Meses * ValorPension
	FechaMatricula date,

	Observaciones varchar(MAX),
	Estado bit,
	EstudianteId int foreign key references Estudiante(EstudianteId),
	MatriculaId int identity(1, 1) primary key
);

create table Pago
(
	Fecha date,	
	Motivo money, --> Matricula, Pension, Otros costos
	Monto money,
	Tipo varchar(20), --> Transferencia, efectivo, consignacion

	Observaciones varchar(MAX),
	Estado bit,
	MatriculaId int foreign key references Matricula(MatriculaId),
	PensionId int identity(1, 1) primary key
);

create table Usuario
(
	NombreUsuario varchar(15) unique,
	Contrasena varchar(10),
	Nivel varchar(30),

	Estado bit,
	UsuarioId int identity(1, 1) primary key
);


