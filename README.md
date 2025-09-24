# Projeto_Vitoria_Lanches

- Vitória Lanches é um sistema integrado de gestão e vendas desenvolvido em C# e PHP, voltado para lanchonetes e pequeno. Ele combina funcionalidades de ERP (cadastro e controle de produtos, clientes e fornecedores), PDV (registro e fechamento de pedidos no caixa) e Autoatendimento (permitindo que o próprio cliente realize pedidos diretamente).
---
## Tarefas
## Ordem de Prioridade
### Organização / Base
- ~~definição de atores e R.U'S~~
- ~~caso de uso~~ - *extends e includes*
- ~~decidir telas~~
- ~~requisitos funcionais~~
- funcinalidades(prototipo de media fidalidade)
### Banco de Dados
- ~~criar tb_users, tb_funcionarios~~
- ~~MER para relação entre users e clientes/funcionários~~
- ~~criar user admin~~
### C# 
- ~~criar tela de login~~
- tela cadastro~~
- gerenciar telas e permissões
- finalizar tela pedido (refazer ordenqando por tipo de prod igual ecomere)
- finalizar tela relatório
- tratamentos gerais
- modularização final
- mudar todas as telas com permiss~çoes nos paneis
### PHP – Apoio
- ~~tela login~~
- ~~tela cadastro~~
- tela mainenu
- tela menupedidos
- tela CadPedido
- tela acomPedidos
- tela CadProduto
- tela CadTipoproduto
- tela Cadcliente
- tela relatorio
- anti sql injection
- !!verificar classes!!
---

#### Passo a Passo para Montar Requisitos de um Sistema

<details>
<summary>1. Definir Objetivo do Sistema</summary>
Escreva em **um parágrafo** o que o sistema faz, para quem é feito e qual problema resolve.  

📌 **Exemplo:**  
> "Um sistema de PDV para lanchonete que registra pedidos, controla produtos, gerencia clientes e gera relatórios para administração."
</details>

<details>
<summary>2. Identificar os Atores</summary>
Liste quem **usa o sistema** (pessoas ou sistemas externos).  

Para cada ator, defina suas responsabilidades.  

📌 **Exemplo:**
- **Recepção** → cadastra pedidos, produtos e clientes.  
- **Cozinha** → visualiza e finaliza pedidos.  
- **Admin** → gerencia usuários, gera relatórios, controla cadastros.
</details>

<details>
<summary>3. Levantar Requisitos Funcionais (RF)</summary>
Numere cada requisito (RF01, RF02…) e responda:  
*"O que o sistema deve permitir o usuário fazer?"*  

📌 **Exemplo:**
- **RF01** – O sistema deve permitir cadastrar clientes.  
- **RF02** – O sistema deve permitir cadastrar produtos.  
- **RF03** – O sistema deve permitir visualizar pedidos em aberto.  
- **RF04** – O sistema deve permitir excluir cliente apenas se não houver pedidos vinculados.
</details>

<details>
<summary>4. Levantar Requisitos Não Funcionais (RNF)</summary>
Define **como o sistema deve se comportar**, não o que ele faz.  

📌 **Exemplo:**
- **RNF01** – O sistema deve ser acessível via navegador web.  
- **RNF02** – O sistema deve ter tempo de resposta menor que 3 segundos.  
- **RNF03** – O sistema deve exigir login para acesso.
</details>

<details>
<summary>5. Mapear Telas / Interfaces</summary>
Para cada requisito, indique a **tela** ou parte do sistema que o atende.  

Detalhe campos obrigatórios, botões e regras.  

📌 **Exemplo:**  

**Tela de Cadastro de Cliente**  
- **Campos:** Nome, Telefone, Endereço  
- **Botões:** Salvar, Cancelar  
- **Regras:** Não permitir salvar sem nome
</details>

<details>
<summary>6. Criar Fluxo Básico</summary>
Monte um **fluxograma simples** (pode ser à mão) mostrando: