# Configuração Automação - Selenium
 Este projeto tem como principal propósito a prática de Automação envolvendo diversas tecnologias e padrões de desenvolvimento, linguagem C#, Selenium WebDriver e SeleniumGrid. O sistema que foi automatizado foi o Mantis - Bug Tracker.
 
# Projeto Mantis
 - 50 Casos de teste (Incluindo um DDT - arquivo input_date.csv) que foram estruturados em 7 tópicos principais:
 -HOME

-ISSUE

-LOGIN

-LOST_PASSWORD

-MANAGE

-MY_ACCOUNT

-VIEW_ISSUES

- PageObjects

 - SeleniumGrid
 

# Ferramentas

  - Visual Studio Enterprise (Instalar UnitTestAdaptor, Nunit e Selenium)
  - Chrome Driver (http://www.seleniumhq.org/download/)
  - Internet Explorer Driver
  - Firefox Driver(gecko)
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
| Maps | Classes responsável por conter funções genéricas com os IWebelements(click, selecionar combobox, asserts) |
| Credentials | Classes responsável por conter crendenciais |
| GerarRandom | Classes responsável por gerar conteúdo genérico |

# Fluxo de Execução

* Execução do DDT para preenchimento da massa de testes
* Execução dos demais testes


# Configuração Selenium Grid
Baixar o arquivo do selenium server
```sh
https://www.seleniumhq.org/download/
```
Colocar o Jar em C: e abrir o CMD na pasta(Shift+Botão Direito)

Executar o comando via CMD
```sh
 java -jar selenium-server-standalone-2.30.0.jar -role hub
 ```
Caso a porta esteja ocupada use:
```sh
 java -jar selenium-server-standalone-2.30.0.jar -port 4445 -role hub
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


```
Agradecimentos: Saymon Oliveira e Base2 Tecnologia
Fonte: https://www.guru99.com/introduction-to-selenium-grid.html
