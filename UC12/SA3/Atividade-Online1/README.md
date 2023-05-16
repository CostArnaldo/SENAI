# Documento de Especificação de Requisitos de Software (SRS) - Hatumus


## Introdução

Este documento descreve os requisitos de software para o sistema da Hatumus, uma empresa que oferece cursos online na área de desenvolvimento de software. 
O objetivo é fornecer uma plataforma eficiente para a gestão de cursos, inscrições, conteúdo didático e avaliações.

## Visão Geral do Sistema

O sistema da Hatumus é uma plataforma online que permite o cadastro de alunos, criação de cursos por instrutores, gerenciamento de inscrições, 
disponibilização de conteúdo didático, realização de avaliações e acompanhamento do progresso dos alunos.

## Requisitos Funcionais

 **RF1: Cadastro de alunos**

O sistema deve permitir que os alunos se cadastrem fornecendo informações pessoais, como nome, e-mail e senha.
O sistema deve validar os dados fornecidos pelos alunos durante o cadastro.

**RF2: Criação de cursos**

Os instrutores devem poder criar cursos, fornecendo informações como título, descrição, carga horária e pré-requisitos.
Os cursos devem poder ser categorizados em diferentes áreas temáticas.

**RF3: Gerenciamento de inscrições**

Os alunos devem poder se inscrever nos cursos disponíveis.
Os instrutores devem poder visualizar e gerenciar as inscrições dos alunos em seus cursos.

**RF4: Conteúdo didático**

O sistema deve permitir que os instrutores disponibilizem conteúdo didático aos alunos, como vídeos, textos e exercícios.
Os alunos devem poder acessar o conteúdo didático dos cursos em que estão inscritos.

**RF5: Avaliações**

Os instrutores devem poder criar avaliações para os cursos, como testes e projetos.
Os alunos devem poder realizar as avaliações e receber feedback sobre seu desempenho.

**RF6: Acompanhamento do progresso**

O sistema deve permitir que os alunos acompanhem seu progresso nos cursos, visualizando os módulos concluídos e as notas obtidas.

## Requisitos Não Funcionais

**RNF1: Segurança**

O sistema deve garantir a segurança das informações dos alunos, incluindo criptografia de dados e autenticação de usuários.

**RNF2: Usabilidade**

A interface do sistema deve ser intuitiva e de fácil navegação para alunos e instrutores.
O sistema deve ser responsivo e compatível com diferentes dispositivos, como computadores e dispositivos móveis.

**RNF3: Desempenho**

O sistema deve ser capaz de lidar com um grande número de alunos e cursos simultaneamente, sem degradação significativa de desempenho.

## Requisitos de Interface

O sistema deve fornecer uma interface de usuário amigável para alunos e instrutores, com menus, formulários e painéis de controle.

## Requisitos de Dados

Os dados do sistema, como informações de alunos, cursos e inscrições, devem ser armazenados de forma segura em um banco de dados.
Este exemplo é apenas uma visão superficial e simplificada de um possível SRS para a empresa Hatumus. Um SRS completo exigiria uma análise detalhada dos requisitos, 
levando em consideração os diferentes fluxos de trabalho, regras de negócio, requisitos de integração, entre outros aspectos.

## Restrições e Limitações

**RL1: Orçamento:** O desenvolvimento do sistema deve ser feito dentro do orçamento definido pela empresa Hatumus.

**RL2: Cronograma:** O sistema deve ser desenvolvido e implantado dentro do prazo estabelecido, considerando as restrições de tempo do projeto.

**RL3: Tecnologias:** O sistema deve ser desenvolvido utilizando tecnologias compatíveis com a infraestrutura existente na empresa Hatumus.

## Requisitos de Segurança e Privacidade

**RS1: Autenticação:** O sistema deve ter um mecanismo de autenticação seguro para garantir que apenas usuários autorizados possam acessar as funcionalidades.

**RS2: Proteção de Dados Pessoais:** O sistema deve estar em conformidade com as regulamentações de proteção de dados e garantir a privacidade das informações pessoais dos usuários.

**RS3: Criptografia:** As comunicações entre o sistema e os usuários devem ser criptografadas para garantir a segurança das informações transmitidas.

**RS4: Controle de Acesso:** O sistema deve ter um sistema de controle de acesso que defina as permissões de cada usuário com base em seu papel e responsabilidades.

## Requisitos de Teste

**RT1: Testes de Unidade:** Devem ser realizados testes de unidade em cada componente do sistema para verificar se funcionam corretamente individualmente.

**RT2: Testes de Integração:** Devem ser realizados testes de integração para verificar a interoperabilidade entre os diferentes componentes do sistema.

**RT3: Testes de Desempenho:** Devem ser realizados testes de desempenho para avaliar o comportamento do sistema sob condições de carga e identificar possíveis gargalos.

**RT4: Testes de Usabilidade:** Devem ser realizados testes de usabilidade com usuários reais para garantir que a interface do sistema seja intuitiva e de fácil utilização.

## Requisitos de Segurança e Privacidade

**RS1: Autenticação:** O sistema deve ter um mecanismo de autenticação seguro para garantir que apenas usuários autorizados possam acessar as funcionalidades.

**RS2: Proteção de Dados Pessoais:** O sistema deve estar em conformidade com as regulamentações de proteção de dados e garantir a privacidade das informações pessoais dos usuários.

**RS3: Criptografia:** As comunicações entre o sistema e os usuários devem ser criptografadas para garantir a segurança das informações transmitidas.

**RS4: Controle de Acesso:** O sistema deve ter um sistema de controle de acesso que defina as permissões de cada usuário com base em seu papel e responsabilidades.

## Requisitos de Teste

**RT1: Testes de Unidade:** Devem ser realizados testes de unidade em cada componente do sistema para verificar se funcionam corretamente individualmente.

**RT2: Testes de Integração:** Devem ser realizados testes de integração para verificar a interoperabilidade entre os diferentes componentes do sistema.

**RT3: Testes de Desempenho:** Devem ser realizados testes de desempenho para avaliar o comportamento do sistema sob condições de carga e identificar possíveis gargalos.

**RT4: Testes de Usabilidade:** Devem ser realizados testes de usabilidade com usuários reais para garantir que a interface do sistema seja intuitiva e de fácil utilização.

## Glossário
**Aluno:** Pessoa que se registra no sistema para participar de cursos oferecidos pela Hatumus.

**Instrutor:** Profissional responsável por criar e ministrar os cursos na plataforma da Hatumus.

**Carga horária:** Tempo estimado necessário para a conclusão de um curso.

**Pré-requisitos:** Conhecimentos ou cursos necessários para se inscrever em determinado curso.

**Avaliação:** Teste ou projeto utilizado para avaliar o desempenho dos alunos em um curso.

**Progresso:** Indicador que mostra o avanço do aluno nos cursos, incluindo módulos concluídos e notas obtidas.