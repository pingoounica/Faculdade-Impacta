--Coloque em uso o banco de dados SISTEMA_ACADEMICO;
USE SISTEMA_ACADEMICO

--Utilizando Insert Declarativo, inserir na tabela TB_CARGO os registros:
--SUPERVISORA COMERCIAL
--QUALIDADE
--DIRETOR
--COMPRADOR(A)
--VENDEDOR(A)
--REPRESENTANTE DA DIREÇÃO
--MOTORISTA
--ENG MANUFATURA
--COZINHEIRO
--AUXILIAR LABORATORIO
INSERT INTO TB_CARGO(COD_CARGO,CARGO)
VALUES(1,'SUPERVISORA COMERCIAL')
        ,(2,'QUALIDADE')
        ,(3,'DIRETOR')
        ,(4,'COMPRADOR(A)')
        ,(5,'VENDEDOR(A)')
        ,(6,'REPRESENTANTE DA DIREÇÃO')
        ,(7,'MOTORISTA')
        ,(8,'ENG MANUFATURA')
        ,(9,'COZINHEIRO')
        ,(10,'AUXILIAR LABORATORIO')

/*
Utilizando Insert Posicional, inserir na tabela TB_CARGO os registros:
• GERENTE COMPRAS
• AUXILIAR DE MANUTENÇÃO
• GERENTE ADMINISTRATIVO
• TORNEIRO MECÂNICO
• SUPERVISOR
• GERENTE DE PRODUÇÃO
• QUÍMICO
*/
INSERT INTO TB_CARGO
VALUES(11,'GERENTE DE COMPRAS')
        ,(12,'AUXILIAR DE MANUTENÇÃO')
        ,(13,'TORNEIRO MECÂNICO')
        ,(14,'SUPERVISOR(A)')
        ,(15,'GERENTE DE PRODUÇÃO')
        ,(16,'QUÍMICO(A)')

/*
Na tabela TB_DISCIPLINA, inserir os registros:
• MATEMÁTICA
• HISTÓRIA
• GEOGRAFIA
• LINGUA PORTUGUESA
• INGLÊS
• CIÊNCIAS
*/
INSERT INTO TB_DISCIPLINA (COD_DISCIPLINA, NOME_DISCIPLINA)
VALUES(1,'MATEMÁTICA')
        ,(2,'HISTÓRIA')
        ,(3,'GEOGRAFIA')
        ,(4,'LÍNGUA PORTUGUESA')
        ,(5,'INGLÊS')
        ,(6,'CIÊNCIAS')

SELECT *
FROM TB_DISCIPLINA

/*
Inserir na tabela TB_ALUNO os registros:
• NOME: MARINALVA DA SILVA
• CPF_ALUNO: 14534423423
• COD_CARGO: 5
• END_ALUNO: R.COMENDADOR JOSE ZILLO,401
• BAIRRO_ALUNO: PQ. DOS OCACIS
• CIDADE_ALUNO: ASSIS
• ESTADO_ALUNO: SP
• CEP_ALUNO: 19800000
• FONE: 1124516577
• STATUS_ALUNO: A
• DATA_CAD_ALUNO: DATA_ATUAL
*/
INSERT INTO TB_ALUNO(NOME
                     ,CPF_ALUNO
                     ,COD_CARGO
                     ,END_ALUNO
                     ,BAIRRO_ALUNO
                     ,CIDADE_ALUNO
                     ,ESTADO_ALUNO
                     ,CEP_ALUNO
                     ,FONE
                     ,STATUS_ALUNO
                     ,DATA_CAD_ALUNO)
VALUES('MARINALVA DA SILVA'
        ,14534423423
        ,5
        ,'R.COMENDADOR JOSE ZILLO,401'
        ,' PQ. DOS OCACIS'
        ,'ASSIS'
        ,'SP'
        ,'19800000'
        ,'1124516577'
        ,'A'
        ,GETDATE())

SELECT *
FROM TB_ALUNO

/*
Inserir mais dois registros na tabela TB_ALUNO:
NOME: ALINE ALVES
CPF_ALUNO: 23434427422
COD_CARGO: 13
END_ALUNO: R.OLIVEIRA DE SÁ,47
BAIRRO_ALUNO: PQ. DAS OLIVEIRAS
CIDADE_ALUNO: SÃO PAULO
ESTADO_ALUNO: SP
CEP_ALUNO: 07865000
FONE: 1132753422
STATUS_ALUNO: A
DATA_CAD_ALUNO: DATA_ATUAL

NOME: ANTONIA GOMES
CPF_ALUNO: 17423354566
COD_CARGO: 1
END_ALUNO: R. PADRE OLIVEIRA,322
BAIRRO_ALUNO: VILA MATILDE
CIDADE_ALUNO: SÃO PAULO
ESTADO_ALUNO: SP
CEP_ALUNO: 02532010
FONE: 1126745155
STATUS_ALUNO: A
DATA_CAD_ALUNO: DATA_ATUAL
*/
INSERT INTO TB_ALUNO
VALUES('ALINE ALVES'
        ,23434427422
        ,13
        ,'R.OLIVEIRA DE SÁ,47'
        ,'PQ. DAS OLIVEIRAS'
        ,'SÃO PAULO'
        ,'SP'
        ,'07865000'
        ,'1132753422'
        ,'A'
        ,GETDATE())
        ,('ANTONIA GOMES'
        ,17423354566
        ,1
        ,'R. PADRE OLIVEIRA,322'
        ,'VILA MATILDE'
        ,'SÃO PAULO'
        ,'SP'
        ,'02532010'
        ,'1126745155'
        ,'A'
        ,GETDATE())

SELECT *
FROM TB_ALUNO

/*
Na tabela TB_ALUNO_DISCIPLINA, inserir os registros:
• A aluna Aline Alves cursa as disciplinas: História/Língua Portuguesa/Inglês
• A aluna Antonia Gomes cursa as disciplinas: História/Geografia/Ciências
*/
INSERT INTO TB_ALUNO_DISCIPLINA
VALUES(1,2,2)
        ,(2,2,4)
        ,(3,2,5)

INSERT INTO TB_ALUNO_DISCIPLINA
VALUES(4,3,2)
        ,(5,3,3)
        ,(6,3,6)

SELECT * 
FROM TB_ALUNO_DISCIPLINA