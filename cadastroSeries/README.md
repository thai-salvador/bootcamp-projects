# Cadastro de séries 🎥

Nesta aplicação console, implementamos um CRUD de séries e fizemos o uso de uma list < T > para o armazenamento das mesmas. 

Criamos uma classe abstrata, como entidade base, e uma interface contendo os métodos que deverão ser implementados pelas demais classes. 

Foi utilizado um enum para os gêneros cinematográficos, além de adotar, como boa prática, a exclusão de uma série sem consequente reordenação de seu código identificativo (id). Apenas informamos a sua exclusão, de modo a evitar o reutilizo do id de uma série excluída para outra, conservando nosso registro.

