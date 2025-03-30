# Teste Vericode

A automação foi desenvolvida utilizando **C#**, **Selenium**, **Reqnroll** e **Allure Report**.

## Estrutura do Projeto

O projeto segue o padrão **BDD (Behavior-Driven Development)**, organizando-se em **features**, **step definitions** e **page objects**, conforme as melhores práticas do mercado.

## Estrutura da Massa de Dados

Por se tratar de um teste simples, não foi necessário o uso de uma biblioteca de dados fictícios ou gerenciamento via banco de dados.
A massa de dados é totalmente gerenciada por meio das tabelas **"Exemplos"** nos arquivos **.feature**.

## Relatório de Execução

O **Allure Report** é utilizado para a geração dos relatórios de execução.
Por padrão, os relatórios são gerados em uma pasta do servidor, mas essa configuração foi alterada para a pasta **Reports**, localizada na raiz do projeto.

A cada execução, uma nova pasta é criada com o report HTML seguindo o padrão de nomenclatura: **ddmmyy_hhmmss**.

O arquivo build.bat e o responsavel por gerenciar os reports.

O screenshot e reportado apenas em caso de falha no step. Para abrir o report HTML, digite o comando "allure open nome_do_dir" no terminal.

Exemplo:
```
allure open 190522_154000
```

** Observação: ** O Allure Report deve estar instalado na máquina para a execução do comando. Foi realizado o commit de uma evidencia para efeito de avaliação.