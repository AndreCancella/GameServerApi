# GameServerApi

# Como rodar o projeto?
A única configuração para rodar o projeto, é abrir o mesmo no Visual Studio e executá-lo.

# Como o projeto foi divido?
O projeto foi divido da seguinte forma:
* Pasta Models: onde ficam os modelos de retorno da api.
* RestClient: onde é feita as chamadas para o endpoint da api acessada, nesse caso é a BattleMetrics. Poderia ser separado em uma bliblioteca de classes facilitando a escabilidade mas escolhi essa forma para não aumentar o nível da complexidade do projeto.
* RestClient/Interface: onde fica a interface contendo a chamada para o controller.
* RestClient/Models: modelo das informações específicas que desejo retornar pela api.
* Controllers: Os endpoints disponiveis na api desenvolvida.
