USE PEDIDOS

--Retornar os dois últimos dígitos do CNPJ do fornecedor. Lembrando que a coluna CPNJ está com 20 caracteres, logo, é necessário tirar os espaços em branco à direita.
SELECT NOME
		,CNPJ
		,RIGHT(RTRIM(CNPJ),2) AS CNPJ_DIGITO
FROM TB_FORNECEDOR

--Retornar os números da Matriz ou Filial da coluna CNPJ (0001) do fornecedor.
SELECT NOME
		,CNPJ
		,SUBSTRING(CNPJ,9,4) AS MATRIZ_FILIAL_CNPJ
FROM TB_FORNECEDOR

-- Fazer uma query para retornar as colunas NOME e SALARIO da tabela TB_EMPREGADO, sendo que a coluna SALARIO deve ser exibida com ZERO quando NULL.
SELECT NOME
		,ISNULL(SALARIO,0) AS SALARIO
FROM TB_EMPREGADO
ORDER BY SALARIO

--Retornar as colunas NUM_PEDIDO, NOME DO VENDEDOR, VLR_TOTAL e SITUAÇÃO DO PEDIDO.
--SITUACAO deve ser apresentada: Quando E então Encerrado, Quando C então Cancelado, Quando P então Pendente.
SELECT NUM_PEDIDO
		,NOME AS NOME_VENDEDOR
		,VLR_TOTAL
		,IIF(SITUACAO='E','ENCERRADO'
		,IIF(SITUACAO='C', 'CANCELADO','PENDENTE')) AS SITUACAO
FROM TB_PEDIDO AS PED
INNER JOIN TB_VENDEDOR AS VEND
ON PED.CODVEN=VEND.CODVEN

--Fazer uma query para retornar o valor do item (QUANTIDADE*PR_UNITARIO) da tabela TB_ITENSPEDIDO. O valor do item deve ser arredondado com 2 casas decimais e apresentado somente com 2 casas decimais. A query deve retornar também as colunas NUM_PEDIDO, NUM_ITEM, ID_PRODUTO e DESCRICAO da tabela TB_PRODUTO.
SELECT ITEM.NUM_PEDIDO
		,ITEM.NUM_ITEM
		,ITEM.ID_PRODUTO
		,PROD.DESCRICAO
		,FORMAT(ROUND(ITEM.QUANTIDADE*ITEM.PR_UNITARIO,2), '#########0.00') AS PRECO
FROM TB_ITENSPEDIDO AS ITEM
INNER JOIN TB_PRODUTO AS PROD
ON ITEM.ID_PRODUTO=PROD.ID_PRODUTO

--Na tabela TB_EMPREGADO, retornar somente o primeiro nome da coluna NOME.
SELECT NOME
		,SUBSTRING(NOME,1,CHARINDEX(' ',NOME)) AS PRIMEIRO_NOME
FROM TB_EMPREGADO

/*
Retornar as colunas NOME e ESTADO da tabela TB_FORNECEDOR. ESTADO deve ser apresentado por extenso, como exibido a seguir:
• ES-ESPIRITO_SANTO
• MG-MINAS GERAIS
• PE-PERNAMBUCO
• PR-PARANÁ
• RJ-RIO DE JANEIRO
• RS-RIO GRANDE DO SUL
• SC-SANTA CATARINA
• SP-SÃO PAULO
*/
SELECT NOME
		,CASE ESTADO
		   WHEN 'ES' THEN 'ESPIRITO_SANTO'
			 WHEN 'MG' THEN 'MINAS GERAIS'
			 WHEN 'PE' THEN 'PERNAMBUCO'
			 WHEN 'PR' THEN 'PARANÁ'
			 WHEN 'RJ' THEN 'RIO DE JANEIRO'
			 WHEN 'RS' THEN 'RIO GRANDE DO SUL'
			 WHEN 'SC' THEN 'SANTA CATARINA'
			 WHEN 'SP' THEN 'SÃO PAULO'
			 ELSE 'NAO SE APLICA'
			 END AS ESTADO
FROM TB_FORNECEDOR
ORDER BY ESTADO

-- Retornar os pedidos com data de emissão menor que Janeiro de 2017;
SELECT *
FROM TB_PEDIDO
WHERE DATA_EMISSAO < '2017.1.1'

-- Retornar os pedidos que foram emitidos em Janeiro de 2017 em uma sexta-feira.
SELECT *
FROM TB_PEDIDO
WHERE YEAR(DATA_EMISSAO)=2017
AND MONTH(DATA_EMISSAO) = 1
AND DATEPART(WEEKDAY, DATA_EMISSAO) = 6