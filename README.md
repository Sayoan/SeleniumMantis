# Configuração Automação - Selenium
 Este projeto tem como principal propósito a prática de Automação envolvendo diversas tecnologias e padrões de desenvolvimento, linguagem C#, Selenium WebDriver e SeleniumGrid. O sistema que foi automatizado foi o Mantis - Bug Tracker.
 
# Projeto Mantis
- PageObjects

 - SeleniumGrid
 
 - 50 Casos de teste (Incluindo um DDT - arquivo input_date.csv) que foram estruturados em 7 tópicos principais:
 
 -HOME

-ISSUE

-LOGIN

-LOST_PASSWORD

-MANAGE

-MY_ACCOUNT

-VIEW_ISSUES

# Ferramentas

  - Visual Studio Enterprise (Instalar UnitTestAdaptor, Nunit e Selenium)
  - Chrome Driver (http://www.seleniumhq.org/download/)
  - Internet Explorer Driver
  - Firefox Driver(gecko)
  - Selenium Server
  - Se necessário instalar "NUnit Test Adapter"
   ```Tools -> Extensions And Updates -> Online -> Search for "Nunit Test Adapter" -> Click on "NUnit Test Adapter" in results list -> Click on Download button ```

# Principais assuntos
  - Page Objects
  - Data Driven
  - Selenium Grid

# Classes criadas

| Classe | Função |
| ------ | ------ |
| Tests | Classe Mãe de todo o teste, herdando valores da WebDriver e executando as suites de testes |
| SeleniumUteis | Classe responsável pelo patch do driver (Pode ser substituido por urls estáticas) |
| WebDriver | Cria o Driver(recebe o patch, aqui ele pode ser estático), navega para URL e amplia a tela, dentro dele é necessário escolher se será local ou através do selenium grid|
| PageObjects | Classe responsável pelo mapeamento dos elementos da tela e seus métodos|
| Maps | Classe responsável por conter funções genéricas com os IWebelements(click, selecionar combobox, asserts) |
| Credentials | Classe responsável por conter crendenciais |
| GerarRandom | Classe responsável por gerar conteúdo genérico |

# Fluxo de Execução

* Execução do DDT para preenchimento da massa de testes
* Execução dos demais testes

# Page Objects
Padrão de Projeto onde temos manipulação de Objetos através de Elementos da Tabela mapeados como IWebElement, classes genéricas e métodos genéricos.
![alt text](https://i.imgur.com/Y6Lxiuc.png)


# Data Driven Testing
O Data-driven é uma estrutura de automação de testes que armazena dados de teste em uma tabela ou no formato de planilha distribuída. Isso permite que os engenheiros de automação tenham um único script de teste que possa executar testes para todos os dados de teste na tabela. Neste projeto foi utilizado o DDT para o report de issues e suas variações.

Criação de uma função com retorno de uma lista de TestCaseData
```sh
public static List<TestCaseData> InsercaoIssues {}
 ```
 Criação de uma lista de TestCaseData
 ```sh
 var testCases = new List<TestCaseData>();
```
Preenchimento da lista de TesteCaseData com TesteCase 
```sh
var testCase = new TestCaseData(category, reproducibility, severity, priority, summary, description);
                                testCases.Add(testCase);
```

Criação do Teste recebendo um TesteCaseSource referente à lista retornada pelo InsercaoIssues e seus parâmetros
```sh
[Category("DataDriven"), TestCaseSource("InsercaoIssues")]
        public void Issue_DD_InsertSimple(string category, string reproducibility, string severity, string priority, string summary, string description)
        {}
```

# Configuração Selenium Grid
O Selenium-Grid permite que você execute seus testes em diferentes máquinas em diferentes navegadores em paralelo. Ou seja, executando vários testes ao mesmo tempo em diferentes máquinas executando diferentes navegadores e sistemas operacionais. 

Baixar o arquivo do selenium server
```sh
https://www.seleniumhq.org/download/
```
Colocar o Jar em C: e abrir o CMD na pasta (Shift+Botão Direito)

Executar o comando via CMD
```sh
 java -jar seleniumserver.jar -role hub
 ```
Caso a porta esteja ocupada use:
```sh
 java -jar seleniumserver.jar -port 4445 -role hub
```
Acessar o servidor via navegador e verificar se o HUB está conectado
```sh
Link http://localhost:4444/grid/console
```

- Cadastro de nó

```sh
java -jar seleniumserver.jar -role webdriver -hub https://IPHUB:PORTA/grid/register
```

Configurando o Selenium GRID - HUB com arquivo JSON (O arquivo deve estar na pasta que irá executar o comando)
```sh
java -jar "seleniumserver.jar" -port 4444 -role hub -hubConfig HubConfig.json
```
Conteúdo Arquivo HUBConfig.JSON
```sh
{
	  "port": 4444,
	  "newSessionWaitTimeout": -1,
	  "servlets" : [],
	  "withoutServlets": [],
	  "custom": {},
	  "capabilityMatcher": "org.openqa.grid.internal.utils.DefaultCapabilityMatcher",
	  "registryClass": "org.openqa.grid.internal.DefaultGridRegistry",
	  "throwOnCapabilityNotPresent": true,
	  "cleanUpCycle": 5000,
	  "role": "hub",
	  "debug": false,
	  "browserTimeout": 0,
	  "timeout": 1800
}
```
Configurando o Selenium GRID - Nó com arquivo JSON (O arquivo deve estar na pasta que irá executar o comando)
```sh
java -Dwebdriver.chrome.driver="chromedriver.exe" -Dwebdriver.ie.driver="IEDriverServer.exe" -Dwebdriver.gecko.driver="geckodriver.exe" -jar seleniumserver.jar -role node -nodeConfig NodeDeafultConfig.json
```
Conteúdo Arquivo NodeDeafultConfig.JSON (JUNIT 3 acima)
```sh
{
  "capabilities":
  [
    {
      "browserName": "firefox",
      "marionette": true,
      "maxInstances": 5,
      "seleniumProtocol": "WebDriver"
    },
     {
      "browserName": "internet explorer",
      "marionette": true,
      "maxInstances": 5,
      "seleniumProtocol": "WebDriver"
    },
    {
      "browserName": "chrome",
      "maxInstances": 5,
      "seleniumProtocol": "WebDriver"
    }
  ],
  "proxy": "org.openqa.grid.selenium.proxy.DefaultRemoteProxy",
  "maxSession": 5,
  "port": -1,
  "register": true,
  "registerCycle": 5000,
  "hub": "http://localhost:4444",
  "nodeStatusCheckTimeout": 5000,
  "nodePolling": 5000,
  "role": "node",
  "unregisterIfStillDownAfter": 60000,
  "downPollingLimit": 2,
  "debug": false,
  "servlets" : [],
  "withoutServlets": [],
  "custom": {},
  "browserTimeout": 0,
  "timeout": 1800
}
```
# Configuração do WebDriver com o RemoteWebDriver 
Configurar via AppConfig a key responsável pelo NavegadorDefault e HubIp.
![alt text](https://i.imgur.com/l73Ilqv.png)


Agradecimentos: [Saymon Oliveira](https://github.com/saymowan)

[Fonte com mais informações do Selenium Grid - Guru99](https://www.guru99.com/introduction-to-selenium-grid.html)

[Informações sobre Data Driven Testing - Guru99](https://www.guru99.com/data-driven-testing.html)

