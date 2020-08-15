/*Busca inicial de usuário*/
SELECT id as Identificacao, firstname as 'Primeiro Nome', lastname as 'Sobrenome' FROM `user` WHERE 1;

===============//===============//===============

/*Cursos*/
SELECT `id`, `fullname` FROM `course` WHERE 1

===============//===============//===============

/*Busca de usuário inscrito en curso*/
SELECT  firstname as 'Primeiro Nome', lastname as 'Sobrenome', `fullname` as 'Curso Inscrito'
FROM `user`
INNER JOIN user_enrolments ON user.id = user_enrolments.userid
INNER JOIN enrol ON user_enrolments.enrolid=enrol.id
INNER JOIN course ON enrol.courseid=course.id
ORDER by firstname

===============//===============//===============

/*Criação da Esfera para os já cadsatrados*/
INSERT INTO user_info_data (`id`,`userid`,`fieldid`,`data`,`dataformat`) VALUES 
(24103,1,31,'Município de Nova Iguaçu',0),
(24104,2,31,'Município de Nova Iguaçu',0),
(24105,3,31,'Município de Nova Iguaçu',0),
(24106,4,31,'Município de Nova Iguaçu',0),
(24107,5,31,'Município de Nova Iguaçu',0);

===============//===============//===============

SELECT DISTINCT CONCAT(user.firstname, " " , user.lastname) as Nome_Participante,
user_info_data.data as Unidade_Escolar,
course.shortname as Evento,
CASE role_assignments.roleid WHEN '3' THEN 'Formador'
	WHEN '5' THEN 'Participante'
    END as Papel,
CASE user_enrolments.status WHEN '0' THEN 'Aceito'end as Aceitos,
CASE user_enrolments.status WHEN '1' THEN 'Analizar'end as Analizar,
CASE user_enrolments.status WHEN '2' THEN 'Esperando'end as Esperando
FROM `enrol`
INNER JOIN course ON course.id=enrol.courseid
INNER JOIN user_enrolments ON user_enrolments.enrolid=enrol.id
INNER JOIN user ON user.id=user_enrolments.userid
INNER JOIN user_info_data on user.id=user_info_data.userid
INNER JOIN role_assignments ON role_assignments.userid=user.id
WHERE user_info_data.fieldid LIKE 1
ORDER BY Nome_Participante;

===============//===============//===============

/*Falta retirar os suspensos*/ 
SELECT *
FROM (
	SELECT 
	*
	FROM
			-- Listagem de participantes para criação dos emails unidade e evento, 
			(SELECT
			CONCAT(user.firstname, " " , user.lastname) as Nome_Participante,
			user_enrolments.status as AtivosParticipantes,
			user_info_data.data as Unidade_Escolar,
			course.fullname as Evento,
			course.visible as AtivosCursos
			FROM `enrol`
			    INNER JOIN course ON course.id=enrol.courseid
			    INNER JOIN user_enrolments ON user_enrolments.enrolid=enrol.id
			    INNER JOIN user ON user.id=user_enrolments.userid
			    INNER JOIN user_info_data on user.id=user_info_data.userid
			WHERE user_info_data.fieldid LIKE 1
			) EventosAtivos
	WHERE AtivosCursos AND AtivosParticipantes LIKE '1'
	ORDER BY Unidade_Escolar) ativos
	;


-- Estatisticas de inscri??o em evento
