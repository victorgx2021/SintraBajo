USE MASTER
CREATE DATABASE bdAdmision
--use master

--drop database bdAdmision

GO

/* ********************************************************************
      CREACION DE TIPOS
 ******************************************************************** */
use bdAdmision 
/* ********************************************************************
      CREACION DE TABLAS
 ******************************************************************** */

create table POSTULANTE(
	DNIpostulante varchar(8) not null,
	ApellidoPaterno varchar(20) not null,
	ApellidoMaterno varchar(20) not null,
    Nombres varchar(45) not null,
	FechaNacimiento date not null,
	Contraseña varbinary(max) not null,
	Anular bit not null,

    primary key(DNIpostulante),
);

create table DIGITADOR_UNSAAC(
	DNIdigitador varchar(8) not null,
	ApellidoPaterno varchar(20) not null,
	ApellidoMaterno varchar(20) not null,
    Nombres varchar(45) not null,
	Contraseña varbinary(max) not null,

    primary key(DNIdigitador),
);
create table PRUEBA(
	IdPrueba varchar(6) not null,
	Tipo varchar(45) not null,
	Fecha date not null,
	Hora time not null,
	DNIdigitador varchar(8)not null,

    primary key(IdPrueba),

	foreign key (DNIdigitador) references DIGITADOR_UNSAAC(DNIdigitador),
);
create table RECIBO(
	NroRecibo varchar(4) not null,
	Fecha date not null,
	DNIpostulante varchar(8),
	IdPrueba varchar (6) not null,

    primary key(NroRecibo),

	foreign key (IdPrueba) references PRUEBA(IdPrueba),
);
create table PRUEBA_POSTULANTE(
	Calificacion int,
	DNIpostulante varchar(8)not null,
	IdPrueba varchar(6) not null,

    primary key(DNIpostulante,IdPrueba),

	foreign key (DNIpostulante) references POSTULANTE(DNIpostulante),
	foreign key (IdPrueba) references PRUEBA(IdPrueba),
);
create table RESPUESTA_POSTULANTE(
	NroPregunta int not null,
	Respuesta varchar(1),
	DNIpostulante varchar(8)not null,
	IdPrueba varchar(6) not null,

	foreign key (DNIpostulante,IdPrueba) references PRUEBA_POSTULANTE(DNIpostulante,IdPrueba),
);
create table CUESTIONARIO(
	NroPregunta int not null,
	Formulacion varchar(560)not null,
	ClaveCorrecta varchar(1) not null,
	IdPrueba varchar(6) not null,

    primary key(NroPregunta,IdPrueba),

	foreign key (IdPrueba) references PRUEBA(IdPrueba),
);
create table ALTERNATIVAS(
	Clave varchar(1) not null,
	Respuesta varchar(100),
	NroPregunta int not null,
	IdPrueba varchar(6) not null,   

	primary key(Clave,NroPregunta,IdPrueba),

	foreign key (NroPregunta, IdPrueba) references CUESTIONARIO(NroPregunta, IdPrueba),
);

-----------------------------
-- PROCEDIMIENTOS----------------
-----------------------------
-- CUESTIONARIO
-- crear modificar CUESTIONARIO----------
drop procedure if exists usp_insertar_cuestionario;
go
CREATE PROCEDURE usp_insertar_cuestionario 
					@NroPregunta int,
					@Formulacion varchar(560),
					@ClaveCorrecta varchar(1),
					@IdPrueba varchar(6)
AS
BEGIN
	if not exists(select*from CUESTIONARIO where NroPregunta=@NroPregunta and IdPrueba=@IdPrueba)
		begin
			insert into CUESTIONARIO values(@NroPregunta,@Formulacion,@ClaveCorrecta,@IdPrueba);
		end
	else
		begin
			update CUESTIONARIO
			set Formulacion=@Formulacion,
				ClaveCorrecta=@ClaveCorrecta
			where NroPregunta=@NroPregunta 
				and IdPrueba=@IdPrueba
		end
END
go
-- exec usp_insertar_cuestionario 8,'¿Cuál de las alternativas presenta incorrección en el uso de la grafía?','c','0001'
-- seleccionar CUESTIONARIO----------
drop procedure if exists usp_seleccionar_cuestionario;
go
CREATE PROCEDURE usp_seleccionar_cuestionario 
					@NroPregunta int,					
					@IdPrueba varchar(6)
AS
BEGIN
	select*
		from CUESTIONARIO
		where NroPregunta=@NroPregunta and IdPrueba=@IdPrueba
END
go
-- exec usp_seleccionar_cuestionario '1','0001'

-- ALTERNATIVA
-- crear modificar ALTERNATIVA----------
drop procedure if exists usp_insertar_alternativa;
go
CREATE PROCEDURE usp_insertar_alternativa 
					@Clave varchar(1),
					@Respuesta varchar(100),
					@NroPregunta int,
					@IdPrueba varchar(6)
AS
BEGIN
	if not exists(select*from ALTERNATIVAS where Clave=@Clave and NroPregunta=@NroPregunta and IdPrueba=@IdPrueba)
		begin
			insert into ALTERNATIVAS values(@Clave,@Respuesta,@NroPregunta,@IdPrueba);
		end
	else
		begin
			update ALTERNATIVAS
			set Respuesta=@Respuesta
			where Clave=@Clave 
			and NroPregunta=@NroPregunta 
			and IdPrueba=@IdPrueba
		end
END
go

-- exec usp_insertar_alternativa 'a','Triunfaremos si se adheren a nosotros.',10,'0001'

-- seleccionar ALTERNATIVA----------
drop procedure if exists usp_seleccionar_alternativa;
go
CREATE PROCEDURE usp_seleccionar_alternativa 
					@Clave varchar(1),					
					@NroPregunta int,
					@IdPrueba varchar(6)
AS
BEGIN
	select*
		from ALTERNATIVAS
		where Clave=@Clave and NroPregunta=@NroPregunta and IdPrueba=@IdPrueba
END
go
-- exec usp_seleccionar_alternativa 'e','1','0001'
-- PRUEBA
-- crear modificar PRUEBA----------
drop procedure if exists usp_insertar_prueba;
go
CREATE PROCEDURE usp_insertar_prueba 
					@IdPrueba varchar(6),
					@Tipo varchar(45),
					@Fecha datetime,
					@Hora time,
					@DNIdigitador varchar(8)
AS
BEGIN
	if not exists(select*from PRUEBA where IdPrueba=@IdPrueba)
		begin
			insert into PRUEBA values(@IdPrueba,@Tipo,@Fecha,@hora,@DNIdigitador);
		end
	else
		begin
			update PRUEBA
			set Tipo=@Tipo,
				Fecha=@Fecha
			where IdPrueba=@IdPrueba			
		end
END
go

--  exec usp_insertar_prueba '0002','Ordinario','27/01/2022','70458332'
-- seleccionar PRUEBA----------
drop procedure if exists usp_seleccionar_prueba;
go
CREATE PROCEDURE usp_seleccionar_prueba 
					@IdPrueba varchar(6)
AS
BEGIN
	select*
		from PRUEBA
		where IdPrueba=@IdPrueba
END
go
--
---   ALUMNO-------------
--------------------------------
--PROCEDIMIENTO PARA GUARDAR EXAMEN ALUMNO
drop procedure if exists usp_insertar_prueba;
go
CREATE PROCEDURE usp_insertar_prueba
					@Calificacion int,
					@DNIpostulante varchar(8),
					@IdPrueba varchar(6)
AS
BEGIN
	if not exists(select*from PRUEBA_POSTULANTE where DNIpostulante=@DNIpostulante and IdPrueba=@IdPrueba)
		begin
			insert into PRUEBA_POSTULANTE values(@Calificacion,@DNIpostulante,@IdPrueba);
		end
	else
		begin
			update PRUEBA_POSTULANTE
			set Calificacion=@Calificacion
			where DNIpostulante=@DNIpostulante 
			and IdPrueba=@IdPrueba 
		end
END
go

-- PROCEDIMIENTO PARA RECUPERAR EXAMEN POSTULANTE
drop procedure if exists usp_recuperar_examen;
go
CREATE PROCEDURE usp_recuperar_examen 
					@DNIPostulante varchar(8)
AS
BEGIN
	select*
		from PRUEBA_POSTULANTE
		where DNIPostulante=@DNIPostulante
END
go
-- exec usp_recuperar_examen '12345678'
--	LISTAR EXAMENES DE POSTULANTES
drop procedure if exists usp_listar_examenes;
go
CREATE PROCEDURE usp_listar_examenes (@IdPrueba	varchar(6))			
AS
BEGIN
	select DNIpostulante,Calificacion
		from PRUEBA_POSTULANTE
		where IdPrueba=@IdPrueba
END
go
-- exec usp_listar_examenes '0001'



--
--PROCEDIMIENTO PARA GUARDAR RESPUESTAS DEL POSTULANTE
drop procedure if exists usp_insertar_respuesta_postulante;
go
CREATE PROCEDURE usp_insertar_respuesta_postulante
					@NroPregunta int,
					@Respuesta varchar(1),
					@DNIpostulante varchar(8),
					@IdPrueba varchar(6)
AS
BEGIN
	if not exists(select*from RESPUESTA_POSTULANTE where NroPregunta=@NroPregunta
														and DNIpostulante=@DNIpostulante and IdPrueba=@IdPrueba)
		begin
			insert into RESPUESTA_POSTULANTE values(@NroPregunta,@Respuesta,@DNIpostulante,@IdPrueba);
		end
	else
		begin
			update RESPUESTA_POSTULANTE
			set Respuesta=@Respuesta
			where NroPregunta=@NroPregunta
				and DNIpostulante=@DNIpostulante and IdPrueba=@IdPrueba
		end
END
go
-- LISTAR RESPUESTA POSTULANTE
-- seleccionar ALTERNATIVA----------
drop procedure if exists usp_seleccionar_respuesta;
go
CREATE PROCEDURE usp_seleccionar_respuesta 
					@DNIPostulante varchar(8),					
					@NroPregunta int
AS
BEGIN
	select*
		from RESPUESTA_POSTULANTE
		where DNIPostulante=@DNIPostulante and NroPregunta=@NroPregunta
END
go
-- exec usp_seleccionar_respuesta '123456780',1
--
-- FUNCION PARA RECUPERAR RESPUESTA POSTULANTE
drop function if exists fn_respuesta_postulante;
GO 
CREATE FUNCTION fn_respuesta_postulante (@IdPrueba varchar(6), @DNIpostulante varchar(8),@NroPregunta int)
RETURNS varchar(1)
AS 
BEGIN
	declare @respuesta varchar(1);
	select @respuesta=Respuesta
		from RESPUESTA_POSTULANTE
		where IdPrueba=@IdPrueba and 
				DNIpostulante=@DNIpostulante and NroPregunta=@NroPregunta
	return (@respuesta)
END
--print dbo.fn_respuesta_postulante('0001','12345678',2)
go
--procedimiento para calificar examenes
drop procedure if exists usp_calificar_postulante 
GO 
CREATE PROCEDURE usp_calificar_postulante (@IdPrueba varchar(6), @DNIpostulante varchar(8))
AS
BEGIN
	declare @nota int
	set @nota=0
	declare @taCalificar table (DNIPostulante varchar(8),
								ClaveCorrecta varchar(1),
								Respuesta varchar(1),
								Nota int
								)
	insert into @taCalificar
	select P.DNIpostulante, ClaveCorrecta, Respuesta, Nota=0
		from RESPUESTA_POSTULANTE P inner join CUESTIONARIO C on P.IdPrueba=C.IdPrueba and P.NroPregunta=C.NroPregunta
		where P.IdPrueba=@IdPrueba and P.DNIpostulante=@DNIpostulante

	update @taCalificar
		set @nota=Nota= case
							when ClaveCorrecta<>Respuesta then
								@Nota
							else @Nota +2
						end;
						
	exec usp_insertar_prueba @Nota,@DNIpostulante,@IdPrueba
END
go
-- exec usp_calificar_postulante '0001','46611292'


-- exec usp_insertar_respuesta_postulante 1,'b','46611292','0001'
select * from POSTULANTE
select * from PRUEBA_POSTULANTE
select * from RESPUESTA_POSTULANTE
select * from CUESTIONARIO
-- FUNCION CALIFICAR EXAMEN

--tabla cruzada alternativas-----------------
select NroPregunta,Clave,Respuesta
	into #Resp
	from ALTERNATIVAS
	group by NroPregunta,Clave,Respuesta

select NroPregunta,
		"alternativa1"=case when Clave='a' then Respuesta  end,
		"alternativa2"=case when Clave='b' then Respuesta  end,
		"alternativa3"=case when Clave='c' then Respuesta  end,
		"alternativa4"=case when Clave='d' then Respuesta  end,
		"alternativa5"=case when Clave='e' then Respuesta  end
		into #alter
		from #Resp 


--VISTAS---------------------------------------------
/*
create view viAlternativas1
as
	select NroPregunta,Clave,Respuesta
	--into #Resp
	from ALTERNATIVAS
	group by NroPregunta,Clave,Respuesta

create view viAlternativas2
as	
	select NroPregunta,
		"alternativa1"=case when Clave='a' then Respuesta else 'sinalternativa' end,
		"alternativa2"=case when Clave='b' then Respuesta else 'sinalternativa' end,
		"alternativa3"=case when Clave='c' then Respuesta else 'sinalternativa' end,
		"alternativa4"=case when Clave='d' then Respuesta else 'sinalternativa' end,
		"alternativa5"=case when Clave='e' then Respuesta else 'sinalternativa' end
		
		from viAlternativas1
*/