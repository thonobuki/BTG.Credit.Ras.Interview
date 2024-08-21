Bem vindo ao nosso teste, ele foi desenvolvido baseado em alguns problemas comuns do dia a dia, 
assim como a elabora��o de alguns desafios, que demonstram algumas de nossas necessidades. Abaixo pedimos que 
preencha seu nome e email para que consiguemos identificalo ao final da avalia��o.

Nome: Thomaz Nobuki Pereira
Email: thonobuki@gmail.com

Dica: N�o se preocupe com a ordem, nenhum dos casos de uso esta impedindo o desenvolvimento individual 
de algum dos itens abaixo.

Testes

1- Ao acessar o Swagger da aplica��o BTG.Credit.Ras.Interview.Application, podemos identificar um problema. 
Na se��o da ChatController quando chamamos o post enviando uma mensagem obtemos sucesso,
ao tentar recuperar as mensagens no Get da mesma controller, n�o recuperamos a mensagem anteriormente enviada.
Avalie o c�digo e determine o que � nessario para recuperarmos as mensagens enviadas.

2- NotificationController: Atualmente todos os usu�rios s�o notificados via e-mail. 
O objetivo desse desafio � mudar o design de classes usando os principios de SOLID 
para que mais tipos sejam suportados (N�o � necessario implementar o envio de fato, ex: EmailService).

3- Em analise o time concluiu que o metodo de calculo em lote da CalcController n�o � de fato assincrono
o objetivo � deixar o m�todo assincrono.

4- O endpoint CalendarController/is_weekend n�o est� retornando resultados quando tentamos executa-lo. Verificar a causa do erro e corrigi-lo

5- O resultado esperado para o acionamento do endpoint DataListController/list_that_contains_customers_with_birthdate, passando a refDate 2024-07-01, � a exibi��o APENAS da lista "Clientes rec�m nascidos" (id 7). Verificar porque este comportamento n�o ocorre e realizar as corre��es/altera��es necess�rias para que ele funcione
