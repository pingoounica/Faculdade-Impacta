USE PEDIDOS
--Faça uma query para ler a tabela TB_PRODUTO, exibindo as colunas ID_PRODUTO, DESCRICAO, PRECO_CUSTO e PRECO_VENDA e calculando o lucro unitário (PRECO_VENDA – PRECO_CUSTO);
SELECT ID_PRODUTO
		,DESCRICAO
		,PRECO_CUSTO
		,PRECO_VENDA
		,PRECO_VENDA - PRECO_CUSTO AS [lucro unitário]
FROM TB_PRODUTO

--Ler a tabela TB_PRODUTO e exibir os campos ID_PRODUTO e DESCRICAO, calculando o valor total investido no estoque daquele produto (QTD_REAL * PRECO_CUSTO);
SELECT ID_PRODUTO
		,DESCRICAO
		,QTD_REAL * PRECO_CUSTO AS [VALOR TOTAL INVESTIDO]
FROM TB_PRODUTO

-- Ler a tabela TB_PRODUTO e exibir as colunas ID_PRODUTO, DESCRICAO, PRECO_CUSTO e PRECO_VENDA, calculando o lucro unitário em reais (PRECO_VENDA – PRECO_CUSTO) e o lucro unitário percentual ((100 * (PRECO_VENDA - PRECO_CUSTO) / PRECO_CUSTO)).
SELECT ID_PRODUTO,
		DESCRICAO,
		PRECO_CUSTO,
		PRECO_VENDA,
		PRECO_VENDA - PRECO_CUSTO AS [lucro unitário],
		(100 * (PRECO_VENDA - PRECO_CUSTO) / PRECO_CUSTO) as [Percentual lucro unitário]
FROM TB_PRODUTO
where 
PRECO_CUSTO>0

 --Na tabela TB_PRODUTO, exiba os registros que tenham quantidade real acima de 5000;
SELECT *
FROM TB_PRODUTO
WHERE QTD_REAL>5000

--Na tabela TB_PRODUTO, exiba os registros com a QTD_REAL entre 500 e 1000 unidades;
SELECT * FROM TB_PRODUTO
WHERE QTD_REAL BETWEEN 500 AND 1000

--Na tabela TB_PRODUTO, exiba os produtos com quantidade real acima de 5000 e código do tipo igual a 6.
SELECT * 
FROM TB_PRODUTO
WHERE QTD_REAL>5000 AND COD_TIPO = 6

--Faça uma query para exibir os clientes dos estados de Minas Gerais e Rio de Janeiro (MG, RJ);
SELECT CODCLI
		,CIDADE
FROM TB_CLIENTE
WHERE ESTADO ='MG' OR ESTADO ='RJ'

--Faça uma query para retornar o nome do empregado MARCO ANTONIO;
SELECT * FROM TB_EMPREGADO
WHERE NOME LIKE 'MARCO ANTONIO%'

--Faça uma query para retornar os clientes que tenham NOME terminando com LTDA;
select * from TB_CLIENTE
where NOME LIKE '%LTDA'

--Faça uma query para retornar os clientes que tenham NOME contendo BRINDES.
select * from TB_CLIENTE
where NOME LIKE '%BRINDES%'