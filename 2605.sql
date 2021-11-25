O setor financeiro precisa de um relatório sobre os fornecedores dos produtos que vendemos. Os relatórios contemplam todas as categorias, mas por algum motivo, os fornecedores dos produtos cuja categoria é a executiva, não estão no relatório.

Seu trabalho é retornar os nomes dos produtos e dos fornecedores cujo código da categoria é 6.


SELECT p.name, pr.name FROM products AS p INNER JOIN providers AS pr ON pr.id = p.id_providers
WHERE p.id_categories = 6
