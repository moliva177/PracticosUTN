create database veterinaria;
go

use veterinaria;
go

create table clientes(
	dni bigint,
	nombre varchar(50),
	sexo char,
	constraint pk_clientes primary key(dni)
	);

create table tipos_mascota(
	id int identity(1,1),
	tipo varchar(50),
	constraint pk_tipos_mascota primary key(id)
	);

create table mascotas(
	id int identity(1,1),
	cliente bigint,
	nombre varchar(50),
	edad int,
	tipo int,
	constraint pk_mascotas primary key(id),
	constraint fk_mascotas_clientes foreign key(cliente)
		references clientes(dni),
	constraint fk_mascotas_tipos_mascota foreign key(tipo)
		references tipos_mascota(id)
	);

create table atenciones(
	id int identity(1,1),
	mascota int,
	fecha datetime,
	descripcion varchar(250),
	importe decimal(19,4),
	constraint pk_atenciones primary key(id),
	constraint fk_atenciones_mascotas foreign key(mascota)
		references mascotas(id)
	);

insert into clientes values
	(80083667, 'Maximiliano', 'M'),
	(78236618, 'Carlos', 'M'),
	(48574021, 'Ezequiel', 'M'),
	(45765956, 'Sol', 'F'),
	(74953367, 'Natalia', 'F'),
	(24764326, 'Florencia', 'F');

insert into tipos_mascota values
	('Perro'),
	('Gato'),
	('Araña'),
	('Iguana');
go

create proc sp_clientes
as
	begin
		select dni, nombre + ' - ' + sexo cliente from clientes;
	end;
go

create proc sp_mascotas_cliente
@id bigint
as
	begin
		select m.id, m.nombre + ' - ' + t.tipo mascota
		from mascotas m join tipos_mascota t on t.id = m.tipo
		where m.cliente = @id
	end;
go

create proc sp_tipos_mascota
as
	begin
		select * from tipos_mascota
	end;
go

create proc sp_insert_mascota
@cliente bigint,
@nombre varchar(50),
@edad int,
@tipo int,
@id int output
as
	begin
		insert into mascotas values(@cliente, @nombre, @edad, @tipo);
		set @id = SCOPE_IDENTITY();
	end;
go

create proc sp_insert_atencion
@mascota int,
@fecha datetime = getdate,
@descripcion varchar(250),
@importe decimal(19,4)
as
	begin
		insert into atenciones values(@mascota, @fecha, @descripcion, @importe)
	end;
go

create proc sp_consultar_atenciones
@fecha_desde datetime,
@fecha_hasta datetime,
@cliente bigint = -1
as
	begin
	if @cliente = -1
		select
			c.dni,
			c.nombre cliente,
			c.sexo,
			m.nombre mascota,
			m.edad,
			t.tipo
		from 
			atenciones a, mascotas m,tipos_mascota t, clientes c
		where
			a.mascota = m.id
			and m.cliente = c.dni
			and t.id = m.tipo
			and cast(a.fecha as date) between cast(@fecha_desde as date) and cast(@fecha_hasta as date)
	else
		select
			c.nombre cliente,
			c.dni,
			c.sexo,
			m.nombre mascota,
			m.edad,
			t.tipo
		from 
			atenciones a, mascotas m,tipos_mascota t, clientes c
		where
			a.mascota = m.id
			and m.cliente = c.dni
			and t.id = m.tipo
			and cast(a.fecha as date) between cast(@fecha_desde as date) and cast(@fecha_hasta as date)
			and m.cliente = @cliente
	end;