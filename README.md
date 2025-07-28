# Sistema de biblioteca

## Equipe
<ul>
  <li>Cícero Jeferson Santos de Araújo 2023011591</li>
  <li>Francisco Airton Araújo Júnior 2023010960</li>
  <li>Jorge Pereira de Oliveira 2023011027</li>
</ul>

[![Status do Build .NET](https://github.com/Jpereira29/sistema-biblioteca-api/actions/workflows/dotnet.yml/badge.svg)](https://github.com/Jpereira29/sistema-biblioteca-api/actions)

Este projeto implementa um sistema de gerenciamento de biblioteca, com funcionalidades básicas de cadastro de clientes, autores, livros e gerenciamento de empréstimos. O objetivo é fornecer uma aplicação simples e funcional para o controle de empréstimos de livros em uma biblioteca.

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

## Colaboradores

-  JORGE PEREIRA DE OLIVEIRA 
- CICERO JEFERSON SANTOS DE ARAÚJO 
- FRANCISCO AIRTON ARAUJO JUNIOR 

## Contribuição

Participei da organização do repositório, da documentação e acompanhei o desenvolvimento da API.

