# GameServerApi

# Como rodar o projeto?
Única configuração para rodar o projeto abrir o mesmo no Visual Studio e executar.

# Como o projeto foi divido?
O projeto foi divido da seguinte forma:
* Pasta Models: onde eu criei um arquivo chamado ServerModel.cs onde foi mapeado todos os items que foi solicitado da chamada da API
* Pasta RestClient: foi criado a pasta ResCliente que contém outras duas pastas chamadas de Interfaces e Models
* RestCliente/Interfaces: na pasta foi criada um arquivo chamado IBattleMetricsRestClient onde se encontra uma interface com o método que eu quero usar chamado GetServers do arquivo ServerController.
* ServerController: arquivo onde foi colocado o método que receberá o nome do jogo e qual página será retornada.
