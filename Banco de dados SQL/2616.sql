A locadora pretende fazer uma promoção para os clientes que ainda não fizeram nenhuma locação.

Seu trabalho é nos entregar o ID e o nome dos clientes que não realizaram nenhuma locação. Ordene a saída por ID.


SELECT c.id, c.name FROM customers AS c WHERE c.id NOT IN(
    SELECT l.id_customers
    FROM locations AS l
    WHERE l.id_customers = c.id);
