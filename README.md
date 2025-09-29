# Sistema de biblioteca

## Equipe
<ul>
  <li>Cícero Jeferson Santos de Araújo 2023011591</li>
  <li>Francisco Airton Araújo Júnior 2023010960</li>
  <li>Jorge Pereira de Oliveira 2023011027</li>
</ul>

[![Status do Build .NET](https://github.com/Jpereira29/sistema-biblioteca-api/actions/workflows/dotnet.yml/badge.svg)](https://github.com/Jpereira29/sistema-biblioteca-api/actions)

Este projeto implementa um sistema de gerenciamento de biblioteca, com funcionalidades básicas de cadastro de clientes, autores, livros e gerenciamento de empréstimos. O objetivo é fornecer uma aplicação simples e funcional para o controle de empréstimos de livros em uma biblioteca.

## 🚀 Testes de Software e Qualidade

Para garantir a robustez e a confiabilidade da API, implementamos uma suíte de testes de integração automatizados que validam os principais fluxos e regras de negócio do sistema.

### Ferramentas e Abordagem

* **Framework de Teste:** **xUnit**, o padrão moderno para testes em .NET, pela sua simplicidade e poder.
* **Testes de Integração:** Utilizamos o **`WebApplicationFactory`** para hospedar a API completa em memória durante a execução dos testes. Isso nos permite testar todo o pipeline da aplicação (roteamento, controllers, serviços, banco de dados) de forma rápida e isolada.
* **Banco de Dados em Memória:** Para garantir que os testes não dependam de um ambiente externo (como um banco SQL Server) e que cada execução seja limpa e previsível, utilizamos o provedor **EF Core InMemory**.

### O Que os Testes Validam?

A suíte de testes foi desenhada para cobrir os cenários mais críticos da aplicação:

1.  ✅ **Segurança:** Valida se endpoints protegidos não podem ser acessados sem um token de autenticação (`Retorna 401 Unauthorized`).
2.  ✅ **Autenticação:** Confirma que um usuário autenticado com um token válido pode acessar os recursos (`Retorna 200 OK`).
3.  ✅ **Criação de Dados (Caminho Feliz):** Garante que a criação de um novo autor com dados válidos funciona e retorna o status correto (`Retorna 201 Created`).
4.  ✅ **Validação de Dados (Caminho Triste):** Verifica se a API rejeita corretamente dados inválidos (ex: um livro sem título), retornando um erro apropriado (`Retorna 400 Bad Request`).
5.  ✅ **Tratamento de Casos de Borda:** Assegura que o sistema lida de forma elegante com situações como a tentativa de deletar um recurso que não existe (`Retorna 404 Not Found`).

### Como Executar os Testes Localmente

Qualquer desenvolvedor pode validar a saúde da aplicação a qualquer momento. Para isso, siga os passos:

1.  Clone o repositório.
2.  Abra um terminal na pasta raiz da solução.
3.  Execute o seguinte comando:

    ```bash
    dotnet test
    ```
O terminal exibirá o resultado de todos os testes, indicando sucesso ou falha.

## 🚀 O Processo de Integração Contínua (CI)

Este projeto utiliza GitHub Actions para automatizar a compilação e os testes a cada nova contribuição de código. Isso garante que a base de código principal (`master`) esteja sempre estável e funcional.

**Como funciona?**

O fluxo de trabalho, definido em `.github/workflows/dotnet.yml`, é acionado automaticamente quando:
1.  Um `push` é feito diretamente para o branch `master`.
2.  Um `pull request` é aberto ou atualizado para o branch `master`.

O processo executa as seguintes etapas:
- **Build**: Compila todo o código para garantir que não há erros de sintaxe.
- **Test**: Executa todos os testes automatizados para verificar se as funcionalidades existentes não foram quebradas.

Um "check" verde (✅) no pull request ou no histórico de commits indica que as alterações são seguras para serem integradas. Um "X" vermelho (❌) indica uma falha, e os detalhes podem ser vistos na aba "Actions" para correção.

---

## [Componente Extensionista] A Importância dos Testes para a Sociedade

*(Seção redigida com o objetivo de promover uma consciência sobre o impacto da qualidade de software na sociedade)*

Testes de software transcendem a verificação técnica; eles são um pilar de **confiança e responsabilidade social** na era digital. Hoje, o software não é apenas uma ferramenta que usamos, mas a infraestrutura invisível que gerencia nossas finanças, nossa saúde, nossa segurança e nossa comunicação. Cada linha de código tem o potencial de impactar a vida das pessoas de forma profunda e, por isso, a qualidade não é um luxo, mas uma necessidade fundamental.

Quando pensamos em um aplicativo bancário, testes rigorosos são o que garantem que uma transferência de dinheiro não desapareça no éter digital. Em um sistema hospitalar, a qualidade do software pode ser a diferença entre um diagnóstico correto e um erro grave. Em um carro autônomo, falhas de software têm consequências fatais. Testar é o ato de antecipar essas falhas. É a disciplina de sistematicamente procurar por fraquezas em um ambiente controlado para que elas não se manifestem de forma catastrófica no mundo real.

Para nós, como desenvolvedores, a prática de testar representa a evolução do nosso papel de meros "codificadores" para o de **engenheiros**. Ela nos força a pensar criticamente sobre nosso próprio trabalho, a considerar os casos de borda e a construir sistemas que não apenas funcionam no "caminho feliz", mas que são resilientes e seguros diante do inesperado. Em última análise, investir em testes é investir na segurança, na estabilidade e na confiança que a sociedade deposita em nós e na tecnologia que criamos.

## [Componente Extensionista] O que é Integração Contínua e por que é importante?

*(Seção redigida com o objetivo de ser acessível a outros estudantes da UFCA e à comunidade externa)*

### O que é Integração Contínua (CI)?

Imagine que você e seus amigos estão montando um grande quebra-cabeça. Em vez de cada um trabalhar em um canto isoladamente e só tentar juntar tudo no final (o que provavelmente causaria problemas de encaixe), vocês adotam uma regra: a cada pequena peça que alguém encontra, essa pessoa imediatamente a leva até a montagem principal para ver se ela encaixa.

**Integração Contínua (CI)** é exatamente isso, mas para o desenvolvimento de software. Em vez de um desenvolvedor escrever muito código por semanas e só depois tentar "juntar" com o trabalho dos outros, a CI incentiva que pequenas alterações sejam integradas à base de código principal de forma frequente. A cada integração, um processo automático (como o nosso GitHub Actions) compila e testa o projeto inteiro para garantir que a "nova peça" não quebrou nada.

### Por que a CI é importante para quem está aprendendo a programar?

Aprender a usar CI desde o início da sua jornada na programação é um grande diferencial.

1.  **Cria Bons Hábitos**: A CI te "força" a escrever código mais limpo e a criar testes, pois você sabe que ele será validado automaticamente. Isso ajuda a evitar o famoso "na minha máquina funciona".
2.  **Aumenta a Confiança para Experimentar**: Com uma rede de segurança de testes automáticos, você perde o medo de fazer alterações ou de refatorar seu código. Se algo quebrar, você saberá na hora e poderá corrigir facilmente. Isso acelera muito o aprendizado.
3.  **Constrói um Portfólio Profissional**: Ter um selo de "build passando" (a badge ✅) em seus projetos no GitHub é um sinal claro para recrutadores de que você conhece as práticas modernas de desenvolvimento de software. Mostra profissionalismo e cuidado com a qualidade.
4.  **Prepara para o Mercado de Trabalho**: Praticamente todas as empresas de tecnologia utilizam CI/CD. Chegar em uma entrevista ou em um novo emprego já sabendo como essa cultura funciona coloca você muitos passos à frente.
