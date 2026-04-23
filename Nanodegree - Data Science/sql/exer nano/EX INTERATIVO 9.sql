USE PEDIDOS

--Criar um script para alterar a tabela TB_CARGO, mudando o salário inicial do cargo DIRETOR para 2500,00.
UPDATE TB_CARGO
SET SALARIO_INIC = 2500
WHERE CARGO='DIRETOR'

--Criar um script para alterar a tabela de cargos, estipulando 10% de aumento para o campo SALARIO_INIC de todos os cargos.
UPDATE TB_CARGO
SET SALARIO_INIC =SALARIO_INIC * 1.10

--Fazer um script para alterar o campo ICMS da tabela TB_CLIENTE para 12. Considere apenas clientes dos estados: RJ, RO, AC, RR, MG, PR, SC.
UPDATE TB_CLIENTE
SET ICMS = 12
OUTPUT inserted.CODCLI
      ,deleted.ICMS AS ICMS_ANTERIOR
      ,inserted.ICMS AS ICMS_ATUAL
FROM TB_CLIENTE AS CLI
WHERE CLI.ESTADO IN ('RJ', 'RO', 'AC', 'RR', 'MG', 'PR', 'SC')

--Criar uma cópia da tabela TB_EMPREGADO com o nome TBEMP_TEMP.
--Usar a tabela TBEMP_TEMP para realizar os exercícios abaixo:
SELECT *
INTO TBEMP_TEMP
FROM TB_EMPREGADO

--Apagar os registros do departamento 2.
BEGIN TRAN
DELETE
FROM TBEMP_TEMP
WHERE COD_DEPTO=2
ROLLBACK

--Apagar os registros que possuem a coluna SALARIO NULL.
BEGIN TRAN

DELETE
FROM TBEMP_TEMP
WHERE SALARIO IS NULL
ROLLBACK

--Apagar os registros do cargo 3,5,8.
BEGIN TRAN
DELETE
FROM TBEMP_TEMP
WHERE COD_CARGO IN (3,5,8)
ROLLBACK

--Criar uma cópia da tabela TB_CLIENTE com o nome TBEMP_CLI.
SELECT *
INTO TBEMP_CLI
FROM TB_CLIENTE

--Usar a tabela TBEMP_CLI para realizar os exercícios abaixo:
--5. Apagar os registros que estão com Estado NULL.
BEGIN TRAN
DELETE
FROM TBEMP_CLI
WHERE ESTADO IS NULL
ROLLBACK