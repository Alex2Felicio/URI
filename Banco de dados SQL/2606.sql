Quando os dados foram migrados de Banco de Dados, houve um pequeno mal-entendido por parte do antigo DBA.

Seu chefe precisa que você exiba o código e o nome dos produtos, cuja categoria inicie com 'super'.


SELECT p.id, p.name FROM products AS p INNER JOIN categories AS c ON c.id = p.id_categories WHERE c.name LIKE 'super%'
