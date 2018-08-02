# Configuração Automação - Selenium


# Ferramentas

  - Visual Studio Enterprise (Instalar UnitTestAdaptor, Nunit e Selenium)
  - Chrome Driver (http://www.seleniumhq.org/download/)
  - Se necessário instalar "NUnit Test Adapter"
   ```Tools -> Extensions And Updates -> Online -> Search for "Nunit Test Adapter" -> Click on "NUnit Test Adapter" in results list -> Click on Download button ```

# Principais assuntos
  - Assert
  - Atribuição de valores vindos da tela

# Classes criadas

| Classe | Função |
| ------ | ------ |
| Tests | Classe Mãe de todo o teste, herdando valores da WebDriver e executando as suites de testes |
| SeleniumUteis | Classe responsável pelo patch do driver (Pode ser substituido por urls estáticas) |
| WebDriver | Cria o Driver(recebe o patch, aqui ele pode ser estático), navega para URL e amplia a tela |


# Fluxo de Execução

* Tests inicia chamando a herança da WebDriver
* WebDriver cria o driver pegando o patch da SeleniumUteis
* Abre o chrome e navega até a URL
* Retorna para a Tests e as suites são executadas


# Funções Abordadas
Assert
```sh
NUnit.Framework.Assert.AreEqual("VALOR",driver.FindElement(By.Id("CAMPO")).Text);
```

Atribuição de valores
```sh
// pega os dos valores na tela e guarda em uma variável
    string valor1 = driver.FindElement(By.Id("number1")).Text;
   string valor2 = driver.FindElement(By.Id("number2")).Text;

// transforma os resultados em um número inteiro para a soma
    int resultadoInt = Int32.Parse(valor1) + Int32.Parse(valor2);
```
