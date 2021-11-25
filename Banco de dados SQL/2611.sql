Uma Vídeo locadora contratou seus serviços para catalogar os filmes dela. 
Eles precisam que você selecione o código e o nome dos filmes cuja descrição do gênero seja 'Action'.

SELECT m.id, m.name FROM movies as m, genres as g
WHERE m.id_genres=g.id AND g.description='Action';
