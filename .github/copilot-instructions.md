# Instrucoes de arquitetura do projeto

## Objetivo

Este repositorio e um projeto de exemplos e revisao de codigo com implementacoes em C#, JavaScript e Python. As alteracoes devem priorizar codigo executavel, seguro, legivel e facil de testar.

## Estrutura

- `models/`: modelos de dados e entidades. Devem conter estado e contratos de dados, sem regras de negocio ou acesso a infraestrutura.
- `service/`: regras de negocio e validacoes reutilizaveis. Servicos devem ser pequenos, coesos e independentes de entrada e saida quando possivel.
- `index.cs`, `index.js` e `index.py`: pontos de entrada ou exemplos isolados de cada linguagem. Nao mover regras compartilhadas para esses arquivos.
- `.ai-review/`: tooling local de revisao automatizada. Nao misturar sua configuracao com a logica da aplicacao.
- `.githooks/`: hooks do Git. O `setup.cmd` ou `setup.sh` configura `core.hooksPath` e instala as dependencias necessarias.

## Regras de implementacao

- Preserve a separacao entre modelo, servico e entrada.
- Prefira funcoes e metodos pequenos, com uma responsabilidade clara.
- Valide entradas nas fronteiras do sistema e trate valores nulos, vazios, indices e quantidades invalidas explicitamente.
- Evite estado global mutavel; encapsule colecoes e exponha operacoes bem definidas.
- Nao esconda erros com `catch` generico, `except` vazio ou retorno silencioso. Capture apenas excecoes esperadas e forneca contexto adequado.
- Nao introduza credenciais, segredos ou dados pessoais em codigo, logs, testes ou exemplos. Use variaveis de ambiente e dados ficticios.
- Nao use `eval`, `exec`, concatenacao de SQL, autenticacao baseada em valores fixos ou outras formas de executar entrada do usuario.
- Para acesso a banco, use consultas parametrizadas. Para arquivos, valide o caminho e use gerenciamento automatico de recursos.
- Evite alterar contratos publicos sem atualizar os consumidores e documentar a migracao.

## Convencoes por linguagem

### C#

- Use namespaces consistentes com o modulo e nullable reference types quando o projeto estiver configurado para isso.
- Prefira tipos explicitos para contratos publicos, `var` apenas quando o tipo for evidente e `string?` para valores realmente opcionais.
- Use `ArgumentNullException.ThrowIfNull`, validacoes de argumento e resultados previsveis em vez de excecoes genericas.
- Em colecoes, respeite os limites de indice e use `Try...` ou resultados anulaveis quando a busca puder falhar.

### JavaScript

- Use `const` por padrao e `let` somente quando houver reassinacao.
- Valide arrays vazios, tipos numericos e propriedades obrigatorias antes de calcular.
- Use `async`/`await` para operacoes assincronas e sempre trate erros de `fetch`, incluindo verificacao de `response.ok`.
- Nao logue tokens, senhas ou respostas sensiveis.

### Python

- Siga PEP 8, use type hints em funcoes novas e prefira `with open(...)` para arquivos.
- Evite `except:` sem tipo; trate a excecao esperada e mantenha o traceback quando ele for necessario para diagnostico.
- Use consultas parametrizadas e nunca monte comandos SQL, shell ou Python a partir de entrada sem validacao.
- Nao use `exec` ou `eval` com dados externos. Mantenha autenticacao e autorizacao independentes de nomes fornecidos pelo usuario.

## Testes e validacao

- Toda correcao de comportamento deve incluir ou atualizar um teste focado, quando houver infraestrutura de testes disponivel.
- Cubra casos validos, entradas vazias ou nulas, limites, erros esperados e regressao do comportamento corrigido.
- Antes de concluir, execute a validacao apropriada para os arquivos alterados e informe comandos que nao puderem ser executados.
- Depois de clonar o repositorio, execute `setup.cmd` no Windows ou `sh setup.sh` em ambientes Unix para habilitar os hooks.

## Estilo de alteracao

- Faca mudancas pequenas e relacionadas ao objetivo solicitado.
- Preserve o estilo existente do arquivo e evite reformatar codigo nao relacionado.
- Nao adicione dependencias sem necessidade; quando adicionar uma, atualize a documentacao e os arquivos de configuracao correspondentes.
- Escreva nomes e mensagens claros. Comentarios devem explicar apenas decisoes ou regras que nao sejam obvias pelo codigo.
- Ao revisar codigo, priorize vulnerabilidades, perda de dados, erros de fluxo, contratos quebrados e ausencia de testes antes de observacoes de estilo.
