# LevelUp

**Descrição**

LevelUp é um **aplicativo desktop de simulação** para compra de jogos. O objetivo do projeto é demonstrar fluxos básicos de um sistema de e-commerce de games (login, listagem de jogos, compra, e painel administrativo) sem envolver transações reais — **é apenas uma simulação**.

---

## Funcionalidades

### Para usuários comuns

* Visualizar catálogo de jogos com nome, ano e preço.
* Realizar a simulação de compra de um jogo.
* Histórico simples de transações (apenas para visualização dentro da simulação).

### Para administrador (login com conta administrativa)

Ao logar com a conta de administrador, o usuário terá acesso às seguintes funcionalidades administrativas:

* Visualizar todas as transações registradas (modo de simulação).
* Ativar / desativar empresas (fornecedores) — altera se os jogos daquela empresa aparecem no catálogo.
* Adicionar novas empresas e editar empresas existentes.
* Adicionar novos jogos e editar jogos existentes.

> Observação: todas as ações simulam comportamento de um sistema real, mas não fazem chamadas externas nem processam pagamentos.

---

## Arquivos e banco de dados

* O banco de dados usado pela aplicação está incluído junto com os arquivos do projeto. Se você for testar o sistema, não precisa criar o banco do zero — apenas use o arquivo fornecido.

Arquivos de interesse (exemplos):

* `levelup (2).sql` (arquivo do banco que acompanha o projeto)
* Executável / solução do projeto (ex.: `LevelUp.exe` ou pasta do projeto)

---

## Credenciais de teste (administrador)

* **Email:** `admin@admin.com`
* **Senha:** `admin123`

> Essas credenciais existem apenas para facilitar testes dentro da simulação.

---

## Como executar

1. Extraia o conteúdo do pacote do projeto (se estiver compactado).
2. Verifique se o arquivo de banco de dados (`levelup (2).sql`) está na mesma pasta do executável ou na pasta de configuração especificada.
3. Execute o arquivo da aplicação (ex.: `LevelUp.exe`) ou abra a solução no Visual Studio e execute em modo Debug.
4. Use as credenciais fornecidas para acessar o painel administrativo ou crie/registre um usuário comum para testar compras.

**Requisitos mínimos**

* Windows 10/11 (ou sistema compatível com o executável gerado)
* .NET (versão dependendo do build — ver arquivo de projeto) **ou** runtime necessário para executar o executável

---

## Nomes das imagens (para incluir no README ou documentação)

Vou incluir quatro imagens para ilustrar telas do aplicativo. Use estes nomes de arquivo ao adicionar as imagens ao repositório:

1. `login_screen.png` — imagem da tela de login.
2. `admin_dashboard.png` — imagem mostrando a interface quando logado como administrador.
3. `compra_usuario.png` — imagem mostrando o processo de compra como usuário comum.
4. `jogos_crud.png` — imagem mostrando a parte de **adicionar e editar jogos**.

Coloque essas imagens na mesma pasta do README ou em uma pasta `assets/` e referencie-as no README se quiser que apareçam inline.

---

## Observações finais

* **Importante:** este projeto é uma **simulação** destinada a fins educativos/demonstrativos. Não armazene nem utilize dados sensíveis reais ao testar.
* Se for submeter o projeto (por exemplo, em uma entrega de trabalho ou repositório público), remova credenciais reais ou substitua o banco de dados por uma versão de demonstração limpa, se necessário.

---

## Licença

Este projeto não possui licença especificada por padrão. Se quiser, adicione uma licença (ex.: MIT) no repositório.

---

## Contato

Se precisar de ajuda com o README ou quiser que eu gere uma versão em inglês, me avise.

