USE PEDIDOS

--Fazer um script para exibir os produtos que não foram vendidos.
SELECT *
FROM TB_PRODUTO
WHERE ID_PRODUTO NOT IN (SELECT ID_PRODUTO
                        FROM TB_ITENSPEDIDO)

--Fazer um script para exibir os cargos que não possuem funcionários associados na tabela TB_EMPREGADO.
SELECT CARGO
FROM TB_CARGO
WHERE COD_CARGO NOT IN (SELECT COD_CARGO
                      FROM TB_EMPREGADO
                      WHERE COD_CARGO IS NOT NULL)

--Fazer um script para exibir os produtos vendidos em Abril de 2018 e que não são da cor PRATA.
SELECT *
FROM TB_PEDIDO AS PED
WHERE YEAR(DATA_EMISSAO) = 2018
  AND MONTH(DATA_EMISSAO) = 4
  AND NOT EXISTS (SELECT *
                 FROM TB_ITENSPEDIDO AS ITEM
                 INNER JOIN TB_COR AS COR
                 ON COR.CODCOR = ITEM.CODCOR
                 WHERE NUM_PEDIDO = PED.NUM_PEDIDO
                 AND COR.COR ='PRATA')

--Fazer um script para exibir os produtos que foram vendidos em abril de 2017. O produto CHAVE DESMONTADO não deve ser exibido.
SELECT *
FROM TB_PRODUTO
WHERE ID_PRODUTO IN(SELECT ID_PRODUTO
                   FROM TB_PEDIDO AS PED
                   INNER JOIN TB_ITENSPEDIDO AS ITEM
                   ON ITEM.NUM_PEDIDO = PED.NUM_PEDIDO
                   WHERE YEAR(DATA_EMISSAO)= 2017
                     AND MONTH(DATA_EMISSAO) = 4)
                     AND DESCRICAO<>'CHAVEIRO DESMONTADO'
                   ORDER BY DESCRICAO

--Fazer um script para exibir os vendedores que não venderam no mês Dezembro de 2012.
SELECT *
FROM TB_VENDEDOR AS VEND
WHERE CODVEN NOT IN (SELECT DISTINCT CODVEN
                     FROM TB_PEDIDO AS PED
                     WHERE YEAR(DATA_EMISSAO)= 2012
                       AND MONTH(DATA_EMISSAO) = 12)