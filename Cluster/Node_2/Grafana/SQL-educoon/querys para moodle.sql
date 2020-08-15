/*Busca inicial de usuário*/
SELECT id as Identificacao, firstname as 'Primeiro Nome', lastname as 'Sobrenome' FROM `user` WHERE 1;

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

/*Criação da Esfera para os já cadsatrados*/
INSERT INTO user_info_data (`id`,`userid`,`fieldid`,`data`,`dataformat`) VALUES 
(24103,1,31,'Município de Nova Iguaçu',0),
(24104,2,31,'Município de Nova Iguaçu',0),
(24105,3,31,'Município de Nova Iguaçu',0),
(24106,4,31,'Município de Nova Iguaçu',0),
(24107,5,31,'Município de Nova Iguaçu',0);
