# Teste Vericode

A automa��o foi desenvolvida utilizando **C#**, **Selenium**, **Reqnroll** e **Allure Report**.

## Estrutura do Projeto

O projeto segue o padr�o **BDD (Behavior-Driven Development)**, organizando-se em **features**, **step definitions** e **page objects**, conforme as melhores pr�ticas do mercado.

## Estrutura da Massa de Dados

Por se tratar de um teste simples, n�o foi necess�rio o uso de uma biblioteca de dados fict�cios ou gerenciamento via banco de dados.
A massa de dados � totalmente gerenciada por meio das tabelas **"Exemplos"** nos arquivos **.feature**.

## Relat�rio de Execu��o

O **Allure Report** � utilizado para a gera��o dos relat�rios de execu��o.
Por padr�o, os relat�rios s�o gerados em uma pasta do servidor, mas essa configura��o foi alterada para a pasta **Reports**, localizada na raiz do projeto.

A cada execu��o, uma nova pasta � criada com o report HTML seguindo o padr�o de nomenclatura: **ddmmyy_hhmmss**.

O arquivo build.bat e o responsavel por gerenciar os reports.

O screenshot e reportado apenas em caso de falha no step. Para abrir o report HTML, digite o comando "allure open nome_do_dir" no terminal.

Exemplo:
```
allure open 190522_154000
```

** Observa��o: ** O Allure Report deve estar instalado na m�quina para a execu��o do comando. Foi realizado o commit de uma evidencia para efeito de avalia��o.