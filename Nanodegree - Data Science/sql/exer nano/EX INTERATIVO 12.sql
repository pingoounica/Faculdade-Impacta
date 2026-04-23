USE PEDIDOS

--Criar um script para receber dois números inteiros e exibir o produto (multiplicação) desses dois números.
DECLARE @VALOR1 INT
       ,@VALOR2 INT
	   ,@RESULTADO INT
SET @VALOR1=2
SET @VALOR2=3
SET @RESULTADO=@VALOR1 * @VALOR2
PRINT @RESULTADO

--Criar um script para receber dois números inteiros e exibir o número maior.
DECLARE @NUM1 INT
    ,@NUM2 INT
    ,@NUM_MAIOR CHAR(20)
SET @NUM1=10
SET @NUM2=37
SELECT @NUM_MAIOR=CASE
                  WHEN @NUM1>@NUM2 THEN CONCAT('MAIOR_VALOR=',@NUM1)
                                   ELSE CONCAT('MAIOR_VALOR=',@NUM2)
                                   END
SELECT @NUM_MAIOR AS MAIOR_VALOR 

--Criar um script para receber o código do produto e exibir o nome do produto com este código informado para o script.
USE PEDIDOS
DECLARE @CODPROD INT
        ,@NOMEPROD CHAR(30)
SET @CODPROD = 45
SELECT @NOMEPROD=DESCRICAO
FROM TB_PRODUTO
WHERE ID_PRODUTO=@CODPROD
SELECT @NOMEPROD AS DESCRICAO_PRODUTO   

/*
 Criar um script para receber o código do produto.
 exibir a descrição do produto, mas somente o primeiro nome do produto (primeira palavra que compõe o nome do produto).
*/
DECLARE @CDPROD INT
SET @CDPROD=77
SELECT SUBSTRING(DESCRICAO,1,CHARINDEX(' ',DESCRICAO)) AS DESCRICAO
FROM TB_PRODUTO
WHERE ID_PRODUTO=@CDPROD    

--Criar uma procedure para exibir o nome do cliente, telefone e o número de seus pedidos.
CREATE PROCEDURE SP_PEDIDOS_CLIENTE
AS
BEGIN
    SELECT CLI.CODCLI
            ,CLI.NOME
            ,cli.FONE1
            ,PED.NUM_PEDIDO
    FROM TB_PEDIDO AS PED
    INNER JOIN TB_CLIENTE AS CLI
    ON PED.CODCLI=CLI.CODCLI
END

EXEC SP_PEDIDOS_CLIENTE   

