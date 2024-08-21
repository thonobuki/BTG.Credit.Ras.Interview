Bem vindo ao nosso teste, ele foi desenvolvido baseado em alguns problemas comuns do dia a dia, 
assim como a elaboração de alguns desafios, que demonstram algumas de nossas necessidades. Abaixo pedimos que 
preencha seu nome e email para que consiguemos identificalo ao final da avaliação.

Nome: Thomaz Nobuki Pereira
Email: thonobuki@gmail.com

Dica: Não se preocupe com a ordem, nenhum dos casos de uso esta impedindo o desenvolvimento individual 
de algum dos itens abaixo.

Testes

1- Ao acessar o Swagger da aplicação BTG.Credit.Ras.Interview.Application, podemos identificar um problema. 
Na seção da ChatController quando chamamos o post enviando uma mensagem obtemos sucesso,
ao tentar recuperar as mensagens no Get da mesma controller, não recuperamos a mensagem anteriormente enviada.
Avalie o código e determine o que é nessario para recuperarmos as mensagens enviadas.

2- NotificationController: Atualmente todos os usuários são notificados via e-mail. 
O objetivo desse desafio é mudar o design de classes usando os principios de SOLID 
para que mais tipos sejam suportados (Não é necessario implementar o envio de fato, ex: EmailService).

3- Em analise o time concluiu que o metodo de calculo em lote da CalcController não é de fato assincrono
o objetivo é deixar o método assincrono.

4- O endpoint CalendarController/is_weekend não está retornando resultados quando tentamos executa-lo. Verificar a causa do erro e corrigi-lo

5- O resultado esperado para o acionamento do endpoint DataListController/list_that_contains_customers_with_birthdate, passando a refDate 2024-07-01, é a exibição APENAS da lista "Clientes recém nascidos" (id 7). Verificar porque este comportamento não ocorre e realizar as correções/alterações necessárias para que ele funcione
