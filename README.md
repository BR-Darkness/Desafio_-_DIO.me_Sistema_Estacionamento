<br>

<p align="center"><img src="./Imagens/Logo-Digital-Innovation-One.svg" width="156px" alt="Logo Dio.me"></p>

<h1 align="center">DIO - Trilha .NET - Fundamentos</h1>
<h2 align="center">Desafio: Criando um Sistema para um Estacionamento</h2>

<br>

> Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

<br>

## 📝: Alterações Realizadas

- Métodos do desafio implementados.

- Adicionada validação da placa dos veiculos nos métodos `Adicionar` e `Remover`.

- Adicionada validação caso haja um veículo estacionado com a mesma placa.

- Listagem clara mostrando o número e a placa do veículo e a quantidade de veiculos estacionados.

- Melhorias de navegação e clareza entre os menus da aplicação.

<br>

## 💻: Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

<br>

## 📋: Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:

<br>

<p align="center"><img src="./Imagens/diagrama_classe_estacionamento.png" alt="Diagrama de classe estacionamento"></p>

<br>

A classe contém três variáveis, sendo:

- **precoInicial**: Tipo `decimal`. É o preço cobrado para deixar seu veículo estacionado.

- **precoPorHora**: Tipo `decimal`. É o preço por hora que o veículo permanecer estacionado.

- **veiculos**: É uma `lista de string`, representando uma coleção de veículos estacionados. (_Contém apenas a placa do veículo_).

<br>

A classe contém três métodos, sendo:

- **AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável `veiculos`.

- **RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: `precoInicial * precoPorHora`, exibindo para o usuário.

- **ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

<br>

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:

    1. Cadastrar veículo
    2. Remover veículo
    3. Listar veículos
    4. Encerrar

<br>

## 🔍: Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

<br><hr><br>

## 🔗│ Links e Referencias:

- **Sobre o Bootcamp**: https://www.dio.me/bootcamp/gft-start-7-net
- **DIO.me**: https://www.dio.me/