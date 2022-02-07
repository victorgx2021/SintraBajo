use bdAdmision
set dateformat dmy

insert into DIGITADOR_UNSAAC values('70458332','Paredes','Denos','Victor',PWDENCRYPT('123456'))

--SELECT DNIdigitador, Contraseña FROM DIGITADOR_UNSAAC WHERE DNIdigitador = '70458332' AND PWDCOMPARE( '123456', Contraseña)=1;

--delete from ALTERNATIVAS where IdPrueba = 0003;
--delete from CUESTIONARIO where IdPrueba = 0003;
--delete from PRUEBA where IdPrueba = 0001;

--SELECT COUNT(IDPRUEBA) FROM PRUEBA

--================================================================================================

insert into PRUEBA  values('0001','ordinario','27/01/2022','9:00:00','70458332')

insert into CUESTIONARIO values(1,
								'¿En qué alternativa el verbo necesita corregirse? '
								,'e'
								,'0001')

insert into ALTERNATIVAS values('a','Concibió con facilidad la respuesta correcta',1,'0001')
insert into ALTERNATIVAS values('b','El toro embistió al diestro torero en la corrida.',1,'0001')
insert into ALTERNATIVAS values('c','Hiciste lo indicado en el manual de manejo.',1,'0001')
insert into ALTERNATIVAS values('d','Ese pleito no te concierne, Juan Francisco.',1,'0001')
insert into ALTERNATIVAS values('e','Si produciéramos en serie, ganaríamos más.',1,'0001')

insert into CUESTIONARIO values(2,
								'Elija la opción que presenta una acentuación ortográfica correcta.'
								,'e'
								,'0001')
insert into ALTERNATIVAS values('a','El gerente les dió la bienvenida a los nuevos trabajadores.',2,'0001')
insert into ALTERNATIVAS values('b','Cuando el operario nos vió, nos saludó con los brazos alzados.',2,'0001')
insert into ALTERNATIVAS values('c','No sé si a tí o a Jonás se le entregó las herramientas ayer.',2,'0001')
insert into ALTERNATIVAS values('d','Sí ya le diste el si, entonces ponte tranquila, pues, él te ama.',2,'0001')
insert into ALTERNATIVAS values('e','Jaime se preparó dos o tres años en esa misma institución.',2,'0001')

insert into CUESTIONARIO values(3,
								'Elija la alternativa que presenta una ortografía correcta'
								,'e'
								,'0001')
insert into ALTERNATIVAS values('a','Brebage',3,'0001')
insert into ALTERNATIVAS values('b','Ambajes',3,'0001')
insert into ALTERNATIVAS values('c','Garage ',3,'0001')
insert into ALTERNATIVAS values('d','Cirujía ',3,'0001')
insert into ALTERNATIVAS values('e','Crujía',3,'0001')

insert into CUESTIONARIO values(4,
								'Señale la alternativa donde aparezcan palabras agudas y graves respectivamente: '
								,'a'
								,'0001')
insert into ALTERNATIVAS values('a','pastor, jamás; peligro, regla ',4,'0001')
insert into ALTERNATIVAS values('b','conversar, abrazar; sacudir, temblor',4,'0001')
insert into ALTERNATIVAS values('c','técnico, clásico; cruzar, canción ',4,'0001')
insert into ALTERNATIVAS values('d','difícil, llano; saludar, pasión ',4,'0001')
insert into ALTERNATIVAS values('e','bautizo, huérfano; bebía, premio ',4,'0001')

insert into CUESTIONARIO values(5,
								'Elija la opción que presenta el uso incorrecto de la letra mayúscula.'
								,'a'
								,'0001')
insert into ALTERNATIVAS values('a','El Surrealismo y el Dadaísmo son movimientos Vanguardistas.',5,'0001')
insert into ALTERNATIVAS values('b','La restauración de aquella casona estará a cargo del Ministerio de Cultura.',5,'0001')
insert into ALTERNATIVAS values('c','Según los especialistas, el Jurásico superior es un periodo histórico',5,'0001')
insert into ALTERNATIVAS values('d','La comisión del Congreso sesionará en el nuevo hemiciclo.',5,'0001')
insert into ALTERNATIVAS values('e','Alejandro La Rosa compró la novela Vivir para contarla.',5,'0001')

insert into CUESTIONARIO values(6,
								'Marque la alternativa donde hay uso correcto de las letras mayúsculas.'
								,'e'
								,'0001')
insert into ALTERNATIVAS values('a','El día Martes se iniciará un nuevo período académico.',6,'0001')
insert into ALTERNATIVAS values('b','Los Romanos tenían varios dioses.',6,'0001')
insert into ALTERNATIVAS values('c','Thais se ha graduado de Bachiller en derecho',6,'0001')
insert into ALTERNATIVAS values('d','El señor de la Rúa nació en Argentina',6,'0001')
insert into ALTERNATIVAS values('e','José María Arguedas es autor de Los ríos profundos.',6,'0001')

insert into CUESTIONARIO values(7,
								'Indique el enunciado que hace uso correcto del artículo.'
								,'b'
								,'0001')
insert into ALTERNATIVAS values('a','Escribí al Comercio',7,'0001')
insert into ALTERNATIVAS values('b','El agua está turbia',7,'0001')
insert into ALTERNATIVAS values('c','El hache muda',7,'0001')
insert into ALTERNATIVAS values('d','La arma del homicida',7,'0001')
insert into ALTERNATIVAS values('e',' La calor intensa',7,'0001')


insert into CUESTIONARIO values(8,
								'¿Cuál de las alternativas presenta incorrección en el uso de la grafía?'
								,'c'
								,'0001')
insert into ALTERNATIVAS values('a','Laura cuece las verduras para la cena',8,'0001')
insert into ALTERNATIVAS values('b','La cesión de sus bienes será mañana',8,'0001')
insert into ALTERNATIVAS values('c','Prometistes ayudar a pagar los gastos.',8,'0001')
insert into ALTERNATIVAS values('d','Las alhajas no cupían en aquel joyero.',8,'0001')
insert into ALTERNATIVAS values('e','Triunfaremos si se adheren a nosotros.',8,'0001')


insert into CUESTIONARIO values(9,
								'Elija la alternativa que presenta adecuado uso de las letras.'
								,'e'
								,'0001')
insert into ALTERNATIVAS values('a','Tú haz llegado tarde hoy',9,'0001')
insert into ALTERNATIVAS values('b','No abalaré ese préstamo',9,'0001')
insert into ALTERNATIVAS values('c','A él le crecía un fino vello',9,'0001')
insert into ALTERNATIVAS values('d','Iván quedó desecho ese día',9,'0001')
insert into ALTERNATIVAS values('e','Él no cuece bien las habas.',9,'0001')

insert into CUESTIONARIO values(10,
								'Indique el enunciado que presenta un adecuado uso del verbo. '
								,'b'
								,'0001')
insert into ALTERNATIVAS values('a','¿Su actuación no satisfació al jurado?',10,'0001')
insert into ALTERNATIVAS values('b','Se le absuelve de los cargos imputados.',10,'0001')
insert into ALTERNATIVAS values('c','Prometistes ayudar a pagar los gastos.',10,'0001')
insert into ALTERNATIVAS values('d','Las alhajas no cupían en aquel joyero.',10,'0001')
insert into ALTERNATIVAS values('e','Triunfaremos si se adheren a nosotros.',10,'0001')


--==========================================================================================


insert into RECIBO values('0001','11/01/2022','46611292','0001')
insert into RECIBO values('0002','11/01/2022','73958392','0001')
insert into RECIBO values('0003','11/01/2022','73303501','0001')
insert into RECIBO values('0004','11/01/2022','48588518','0001')
insert into RECIBO values('0005','11/01/2022','71498764','0001')
insert into RECIBO values('0006','11/01/2022','48212479','0001')
insert into RECIBO values('0007','11/01/2022','73352912','0001')
insert into RECIBO values('0008','11/01/2022','76041482','0001')
insert into RECIBO values('0009','11/01/2022','71798391','0001')
insert into RECIBO values('0010','11/01/2022','75979441','0001')
insert into RECIBO values('0011','11/01/2022','76049994','0001')
insert into RECIBO values('0012','11/01/2022','73632611','0001')
insert into RECIBO values('0013','11/01/2022','70044082','0001')
insert into RECIBO values('0014','11/01/2022','47087660','0001')
insert into RECIBO values('0015','11/01/2022','76207696','0001')
insert into RECIBO values('0016','11/01/2022','71594285','0001')
insert into RECIBO values('0017','11/01/2022','48492873','0001')
insert into RECIBO values('0018','11/01/2022','43063555','0001')
insert into RECIBO values('0019','11/01/2022','48307248','0001')
insert into RECIBO values('0020','11/01/2022','76047182','0001')

--=============================================================================
insert into POSTULANTE values('46611292','Puma','Huamani','Glina','01/02/2002',PWDENCRYPT('123456'),0)
insert into POSTULANTE values('73958392','Rocca','Huanca','Maria ',	'20/01/2001',PWDENCRYPT('123456'),0)
insert into POSTULANTE values('73303501','Fernandez','Puma','Sebastian','12/05/2002',PWDENCRYPT('123456'),0)
insert into POSTULANTE values('48588518','Veslasquez','Nina' , 'Juan ' ,'03/11/1999',PWDENCRYPT('123456'),0)
insert into POSTULANTE values('71498764','Yana','Cuno ','Yamilet' ,	'05/07/2000',PWDENCRYPT('123456'),0)
insert into POSTULANTE values('48212479','Uscca','Diaz','Yudith' ,'15/07/2002',PWDENCRYPT('123456'),0)
insert into POSTULANTE values('73352912','Meza	','Ttupa' , 'Jose' ,'28/06/1998',PWDENCRYPT('123456'),0)
insert into POSTULANTE values('76041482','Sotelo','Quispe' , 'Hilda' ,	'29/10/1998',PWDENCRYPT('123456'),0)
insert into POSTULANTE values('71798391','Leon','Mercado' , 'Carlos' ,	'30/12/2000',PWDENCRYPT('123456'),0)
insert into POSTULANTE values('75979441','Quispe','Masias' , 'Rodrigo' ,'14/02/2000',PWDENCRYPT('123456'),0)
insert into POSTULANTE values('76049994','Alegria','Mendoza' , 'Jesu' ,	'18/01/1999',PWDENCRYPT('123456'),0)
insert into POSTULANTE values('73632611','Hinojosa','Huarca' , 'Fernanda' ,	'13/02/1998',PWDENCRYPT('123456'),0)
insert into POSTULANTE values('70044082','Mora','Huichi' , 'Alex' ,	'23/01/2001',PWDENCRYPT('123456'),0)
insert into POSTULANTE values('47087660','Urquizo','Carbajal' , 'Victor' ,'05/07/2000',PWDENCRYPT('123456'),0)
insert into POSTULANTE values('76207696','Condori','Quispe' , 'Axel ' ,	'25/11/2001',PWDENCRYPT('123456'),0)
insert into POSTULANTE values('71594285','Huaman','Cabrera' , 'Yonathan' ,'28/06/2000',PWDENCRYPT('123456'),0)
insert into POSTULANTE values('48492873','Macedo','Quispe' , 'Victor' ,	'29/10/1999',PWDENCRYPT('123456'),0)
insert into POSTULANTE values('43063555','Grovas','Lima' , 'Alan' ,	'18/01/2001',PWDENCRYPT('123456'),0)
insert into POSTULANTE values('48307248','Ayte','Alvarez' , 'Franszua' ,'07/09/2000',PWDENCRYPT('123456'),0)--
insert into POSTULANTE values('76047182','Rojas	','Mayo' , 'Elvira' ,'15/08/1998',PWDENCRYPT('123456'),0)--
--=============================================================================

exec usp_insertar_prueba -1,'46611292','0001'

exec usp_insertar_respuesta_postulante 1,'e','46611292','0001'
exec usp_insertar_respuesta_postulante 2,'e','46611292','0001'
exec usp_insertar_respuesta_postulante 3,'e','46611292','0001'
exec usp_insertar_respuesta_postulante 4,'a','46611292','0001'
exec usp_insertar_respuesta_postulante 5,'a','46611292','0001'
exec usp_insertar_respuesta_postulante 6,'e','46611292','0001'
exec usp_insertar_respuesta_postulante 7,'b','46611292','0001'
exec usp_insertar_respuesta_postulante 8,'c','46611292','0001'
exec usp_insertar_respuesta_postulante 9,'e','46611292','0001'
exec usp_insertar_respuesta_postulante 10,'b','46611292','0001'
------------------------------------------------------------------
exec usp_insertar_prueba -1,'73958392','0001'

exec usp_insertar_respuesta_postulante 1,'e','73958392','0001'
exec usp_insertar_respuesta_postulante 2,'e','73958392','0001'
exec usp_insertar_respuesta_postulante 3,'e','73958392','0001'
exec usp_insertar_respuesta_postulante 4,'b','73958392','0001'
exec usp_insertar_respuesta_postulante 5,'a','73958392','0001'
exec usp_insertar_respuesta_postulante 6,'e','73958392','0001'
exec usp_insertar_respuesta_postulante 7,'b','73958392','0001'
exec usp_insertar_respuesta_postulante 8,'e','73958392','0001'
exec usp_insertar_respuesta_postulante 9,'e','73958392','0001'
exec usp_insertar_respuesta_postulante 10,'b','73958392','0001'
------------------------------------------------------------------
exec usp_insertar_prueba -1,'73303501','0001'

exec usp_insertar_respuesta_postulante 1,'e','73303501','0001'  
exec usp_insertar_respuesta_postulante 2,'e','73303501','0001'
exec usp_insertar_respuesta_postulante 3,'e','73303501','0001'
exec usp_insertar_respuesta_postulante 4,'e','73303501','0001'
exec usp_insertar_respuesta_postulante 5,'a','73303501','0001'
exec usp_insertar_respuesta_postulante 6,'e','73303501','0001'
exec usp_insertar_respuesta_postulante 7,'e','73303501','0001'
exec usp_insertar_respuesta_postulante 8,'c','73303501','0001'
exec usp_insertar_respuesta_postulante 9,'e','73303501','0001'
exec usp_insertar_respuesta_postulante 10,'a','73303501','0001'
------------------------------------------------------------------
exec usp_insertar_prueba -1,'48588518','0001'

exec usp_insertar_respuesta_postulante 1,'e','48588518','0001'
exec usp_insertar_respuesta_postulante 2,'e','48588518','0001'
exec usp_insertar_respuesta_postulante 3,'e','48588518','0001'
exec usp_insertar_respuesta_postulante 4,'a','48588518','0001'
exec usp_insertar_respuesta_postulante 5,'a','48588518','0001'
exec usp_insertar_respuesta_postulante 6,'e','48588518','0001'
exec usp_insertar_respuesta_postulante 7,'b','48588518','0001'
exec usp_insertar_respuesta_postulante 8,'c','48588518','0001'
exec usp_insertar_respuesta_postulante 9,'e','48588518','0001'
exec usp_insertar_respuesta_postulante 10,'b','48588518','0001'
------------------------------------------------------------------ 
exec usp_insertar_prueba -1,'71498764','0001'					   
																   
exec usp_insertar_respuesta_postulante 1,'e','71498764','0001'	   
exec usp_insertar_respuesta_postulante 2,'e','71498764','0001'	   
exec usp_insertar_respuesta_postulante 3,'e','71498764','0001'	   
exec usp_insertar_respuesta_postulante 4,'a','71498764','0001'	   
exec usp_insertar_respuesta_postulante 5,'e','71498764','0001'	   
exec usp_insertar_respuesta_postulante 6,'e','71498764','0001'	   
exec usp_insertar_respuesta_postulante 7,'b','71498764','0001'	   
exec usp_insertar_respuesta_postulante 8,'c','71498764','0001'	   
exec usp_insertar_respuesta_postulante 9,'b','71498764','0001'	   
exec usp_insertar_respuesta_postulante 10,'b','71498764','0001'	   
------------------------------------------------------------------ 
exec usp_insertar_prueba -1,'48212479','0001'					   

exec usp_insertar_respuesta_postulante 1,'c','48212479','0001'
exec usp_insertar_respuesta_postulante 2,'e','48212479','0001'
exec usp_insertar_respuesta_postulante 3,'e','48212479','0001'
exec usp_insertar_respuesta_postulante 4,'a','48212479','0001'
exec usp_insertar_respuesta_postulante 5,'a','48212479','0001'
exec usp_insertar_respuesta_postulante 6,'a','48212479','0001'
exec usp_insertar_respuesta_postulante 7,'b','48212479','0001'
exec usp_insertar_respuesta_postulante 8,'d','48212479','0001'
exec usp_insertar_respuesta_postulante 9,'e','48212479','0001'
exec usp_insertar_respuesta_postulante 10,'e','48212479','0001'
------------------------------------------------------------------
exec usp_insertar_prueba -1,'73352912','0001'					  
																  
exec usp_insertar_respuesta_postulante 1,'d','73352912','0001'	  
exec usp_insertar_respuesta_postulante 2,'e','73352912','0001'	  
exec usp_insertar_respuesta_postulante 3,'d','73352912','0001'	  
exec usp_insertar_respuesta_postulante 4,'a','73352912','0001'	  
exec usp_insertar_respuesta_postulante 5,'c','73352912','0001'	  
exec usp_insertar_respuesta_postulante 6,'e','73352912','0001'	  
exec usp_insertar_respuesta_postulante 7,'b','73352912','0001'	  
exec usp_insertar_respuesta_postulante 8,'c','73352912','0001'	  
exec usp_insertar_respuesta_postulante 9,'e','73352912','0001'	  
exec usp_insertar_respuesta_postulante 10,'a','73352912','0001'	  
------------------------------------------------------------------
exec usp_insertar_prueba -1,'76041482','0001'

exec usp_insertar_respuesta_postulante 1,'e','76041482','0001'
exec usp_insertar_respuesta_postulante 2,'e','76041482','0001'
exec usp_insertar_respuesta_postulante 3,'e','76041482','0001'
exec usp_insertar_respuesta_postulante 4,'a','76041482','0001'
exec usp_insertar_respuesta_postulante 5,'a','76041482','0001'
exec usp_insertar_respuesta_postulante 6,'e','76041482','0001'
exec usp_insertar_respuesta_postulante 7,'b','76041482','0001'
exec usp_insertar_respuesta_postulante 8,'c','76041482','0001'
exec usp_insertar_respuesta_postulante 9,'e','76041482','0001'
exec usp_insertar_respuesta_postulante 10,'b','76041482','0001'
------------------------------------------------------------------ 
exec usp_insertar_prueba -1,'71798391','0001'					   
																   
exec usp_insertar_respuesta_postulante 1,'e','71798391','0001'	   
exec usp_insertar_respuesta_postulante 2,'d','71798391','0001'	   
exec usp_insertar_respuesta_postulante 3,'e','71798391','0001'	   
exec usp_insertar_respuesta_postulante 4,'a','71798391','0001'	   
exec usp_insertar_respuesta_postulante 5,'a','71798391','0001'	   
exec usp_insertar_respuesta_postulante 6,'e','71798391','0001'	   
exec usp_insertar_respuesta_postulante 7,'b','71798391','0001'	   
exec usp_insertar_respuesta_postulante 8,'c','71798391','0001'	   
exec usp_insertar_respuesta_postulante 9,'e','71798391','0001'
exec usp_insertar_respuesta_postulante 10,'b','71798391','0001'
------------------------------------------------------------------
exec usp_insertar_prueba -1,'75979441','0001'

exec usp_insertar_respuesta_postulante 1,'e','75979441','0001'
exec usp_insertar_respuesta_postulante 2,'e','75979441','0001'
exec usp_insertar_respuesta_postulante 3,'e','75979441','0001'
exec usp_insertar_respuesta_postulante 4,'c','75979441','0001'
exec usp_insertar_respuesta_postulante 5,'a','75979441','0001'
exec usp_insertar_respuesta_postulante 6,'e','75979441','0001'
exec usp_insertar_respuesta_postulante 7,'e','75979441','0001'
exec usp_insertar_respuesta_postulante 8,'c','75979441','0001'
exec usp_insertar_respuesta_postulante 9,'e','75979441','0001'
exec usp_insertar_respuesta_postulante 10,'b','75979441','0001'
------------------------------------------------------------------ 
exec usp_insertar_prueba -1,'76049994','0001'					   
																   
exec usp_insertar_respuesta_postulante 1,'e','76049994','0001'	   
exec usp_insertar_respuesta_postulante 2,'e','76049994','0001'	   
exec usp_insertar_respuesta_postulante 3,'e','76049994','0001'	   
exec usp_insertar_respuesta_postulante 4,'c','76049994','0001'	   
exec usp_insertar_respuesta_postulante 5,'a','76049994','0001'	   
exec usp_insertar_respuesta_postulante 6,'e','76049994','0001'	   
exec usp_insertar_respuesta_postulante 7,'b','76049994','0001'
exec usp_insertar_respuesta_postulante 8,'d','76049994','0001'
exec usp_insertar_respuesta_postulante 9,'e','76049994','0001'
exec usp_insertar_respuesta_postulante 10,'e','76049994','0001'
------------------------------------------------------------------
exec usp_insertar_prueba -1,'73632611','0001'

exec usp_insertar_respuesta_postulante 1,'e','73632611','0001'
exec usp_insertar_respuesta_postulante 2,'a','73632611','0001'
exec usp_insertar_respuesta_postulante 3,'e','73632611','0001'
exec usp_insertar_respuesta_postulante 4,'e','73632611','0001'
exec usp_insertar_respuesta_postulante 5,'a','73632611','0001'
exec usp_insertar_respuesta_postulante 6,'e','73632611','0001'
exec usp_insertar_respuesta_postulante 7,'c','73632611','0001'
exec usp_insertar_respuesta_postulante 8,'c','73632611','0001'
exec usp_insertar_respuesta_postulante 9,'e','73632611','0001'
exec usp_insertar_respuesta_postulante 10,'e','73632611','0001'
------------------------------------------------------------------ 
exec usp_insertar_prueba -1,'70044082','0001'					   
																   
exec usp_insertar_respuesta_postulante 1,'e','70044082','0001'	   
exec usp_insertar_respuesta_postulante 2,'e','70044082','0001'	   
exec usp_insertar_respuesta_postulante 3,'e','70044082','0001'	   
exec usp_insertar_respuesta_postulante 4,'e','70044082','0001'	   
exec usp_insertar_respuesta_postulante 5,'a','70044082','0001'
exec usp_insertar_respuesta_postulante 6,'e','70044082','0001'
exec usp_insertar_respuesta_postulante 7,'c','70044082','0001'
exec usp_insertar_respuesta_postulante 8,'c','70044082','0001'
exec usp_insertar_respuesta_postulante 9,'e','70044082','0001'
exec usp_insertar_respuesta_postulante 10,'b','70044082','0001'
------------------------------------------------------------------
exec usp_insertar_prueba -1,'47087660','0001'

exec usp_insertar_respuesta_postulante 1,'e','47087660','0001'
exec usp_insertar_respuesta_postulante 2,'c','47087660','0001'
exec usp_insertar_respuesta_postulante 3,'e','47087660','0001'
exec usp_insertar_respuesta_postulante 4,'a','47087660','0001'
exec usp_insertar_respuesta_postulante 5,'a','47087660','0001'
exec usp_insertar_respuesta_postulante 6,'e','47087660','0001'
exec usp_insertar_respuesta_postulante 7,'b','47087660','0001'
exec usp_insertar_respuesta_postulante 8,'c','47087660','0001'
exec usp_insertar_respuesta_postulante 9,'e','47087660','0001'
exec usp_insertar_respuesta_postulante 10,'b','47087660','0001'
------------------------------------------------------------------
exec usp_insertar_prueba -1,'76207696','0001'					  
																  
exec usp_insertar_respuesta_postulante 1,'e','76207696','0001'	  
exec usp_insertar_respuesta_postulante 2,'e','76207696','0001'	  
exec usp_insertar_respuesta_postulante 3,'e','76207696','0001'
exec usp_insertar_respuesta_postulante 4,'a','76207696','0001'
exec usp_insertar_respuesta_postulante 5,'b','76207696','0001'
exec usp_insertar_respuesta_postulante 6,'e','76207696','0001'
exec usp_insertar_respuesta_postulante 7,'b','76207696','0001'
exec usp_insertar_respuesta_postulante 8,'c','76207696','0001'
exec usp_insertar_respuesta_postulante 9,'e','76207696','0001'
exec usp_insertar_respuesta_postulante 10,'b','76207696','0001'
------------------------------------------------------------------
exec usp_insertar_prueba -1,'71594285','0001'

exec usp_insertar_respuesta_postulante 1,'c','71594285','0001'
exec usp_insertar_respuesta_postulante 2,'e','71594285','0001'
exec usp_insertar_respuesta_postulante 3,'e','71594285','0001'
exec usp_insertar_respuesta_postulante 4,'a','71594285','0001'
exec usp_insertar_respuesta_postulante 5,'a','71594285','0001'
exec usp_insertar_respuesta_postulante 6,'e','71594285','0001'
exec usp_insertar_respuesta_postulante 7,'b','71594285','0001'
exec usp_insertar_respuesta_postulante 8,'c','71594285','0001'
exec usp_insertar_respuesta_postulante 9,'a','71594285','0001'
exec usp_insertar_respuesta_postulante 10,'b','71594285','0001'
------------------------------------------------------------------ 
exec usp_insertar_prueba -1,'48492873','0001'

exec usp_insertar_respuesta_postulante 1,'a','48492873','0001'
exec usp_insertar_respuesta_postulante 2,'e','48492873','0001'
exec usp_insertar_respuesta_postulante 3,'e','48492873','0001'
exec usp_insertar_respuesta_postulante 4,'a','48492873','0001'
exec usp_insertar_respuesta_postulante 5,'a','48492873','0001'
exec usp_insertar_respuesta_postulante 6,'e','48492873','0001'
exec usp_insertar_respuesta_postulante 7,'a','48492873','0001'
exec usp_insertar_respuesta_postulante 8,'c','48492873','0001'
exec usp_insertar_respuesta_postulante 9,'e','48492873','0001'
exec usp_insertar_respuesta_postulante 10,'b','48492873','0001'
------------------------------------------------------------------
exec usp_insertar_prueba -1,'43063555','0001'

exec usp_insertar_respuesta_postulante 1,'e','43063555','0001'
exec usp_insertar_respuesta_postulante 2,'e','43063555','0001'
exec usp_insertar_respuesta_postulante 3,'e','43063555','0001'
exec usp_insertar_respuesta_postulante 4,'a','43063555','0001'
exec usp_insertar_respuesta_postulante 5,'a','43063555','0001'
exec usp_insertar_respuesta_postulante 6,'e','43063555','0001'
exec usp_insertar_respuesta_postulante 7,'b','43063555','0001'
exec usp_insertar_respuesta_postulante 8,'c','43063555','0001'
exec usp_insertar_respuesta_postulante 9,'e','43063555','0001'
exec usp_insertar_respuesta_postulante 10,'b','43063555','0001'
------------------------------------------------------------------

select * from RESPUESTA_POSTULANTE
select * from PRUEBA_POSTULANTE

select*
		from RESPUESTA_POSTULANTE where DNIpostulante = 12345678

select Calificacion from PRUEBA_POSTULANTE where DNIpostulante = 12345678

select * from RECIBO
