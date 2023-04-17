# Teste para aprimorar seus conhecimentos em C# e .NET

Esse teste foi criado para aprimorar suas habilidades com .NET e C# em geral. 

O intuíto desse teste é fazer com que você se desenvolva, aprenda detalhes de projeto,
aprenda enxergar novas soluções para códigos já feitos, não se preocupe e faça no seu tempo.

## Para começar
O primeiro passo é criar uma **cópia** deste repositório. Por favor, perceba que fazer uma cópia é diferente de realizar um clone ou fork. Siga os passos abaixo para fazer a cópia:

- Crie um novo repositório em sua conta do GitHub. Dê o nome que desejar.
- Abra seu client do git e siga os comandos:
```
git clone --bare https://github.com/engpauloandrade/FreeTeste.git
```
Esse comando gera uma cópia do repositório do teste em seu computador. Agora, continue com os comandos
```
cd FreeTeste.git
git push --mirror https://github.com/SEUSUARIO/FreeTeste.git
```
Note que você precisa alterar o SEUUSUARIO pelo seu username do GitHub, utilizado para criar o repositório no primeiro passo.
Você pode apagar o diretório ```FreeTeste.git``` que foi criado em seu computador.

Tudo certo: você possui um repositório em seu nome com tudo que precisa para começar responder seu teste. Agora sim, faça o clone (git clone) em sua máquina e você está pronto para trabalhar.
```
git clone https://github.com/SEUSUARIO/FreeTeste.git
```

> Lembre-se: NÃO gere um Fork do repositório. Siga os passos acima para copiar o repositório para sua conta.


Para esse teste eu utilizei o ```SqlServer```, mas você pode utilizar outro banco de dados.
Instale o banco de dados na sua máquina, configure o ```appsettings.json``` no seu projeto:

![image](https://user-images.githubusercontent.com/81451506/231345324-15906ebb-1757-4da5-ac38-06fcbb4d0057.png)

> Após configurar o banco de dados, você já conseguirá rodar a migration em seu projeto.

Está sendo utilizado o Entity Framework também, mas é bem simples de mexer com ele, abaixo estão os dois comandos mais utilizados para rodar as migrations:

```
Add-Migration Testando
```

Após add a migration, será criada uma pasta com esse nome e, se tudo der certo, é só atualizar o banco de dados:

```
Update-Database
```

Esses comandos devem ser rodados no `Package Manager Console`:

![image](https://user-images.githubusercontent.com/81451506/231037886-0a7a0eb4-4efc-45dd-a7bd-3e9f3f773b72.png)

![image](https://user-images.githubusercontent.com/81451506/231038522-d627b933-9a95-4f51-a94e-5e7cc872495b.png)


### Conhecendo o projeto

> Eu recomendo que você utilize o Visual Studio 2022 (pode ser a versão community). Você também precisa do .NET 6 instalado, ok? Ah, não esquece de instalar o pacote de desenvolvimento para o ASP NET durante a instalação do Visual Studio.

Ao abrir o projeto no Visual Studio, você pode notar que se trata de um projeto Web API do ASP NET. Você pode se orientar pela pasta ```Controllers```. Dentro dela, cada Controller representa uma etapa do teste. Logo abaixo vamos falar mais sobre essas etapas e como você pode resolvê-las.


Pronto, tudo configurado, vamos ao que interessa.

## Atividades propostas

No código têm alguns comentários provocativos e a ideia deles é fazer você pensar em alguma solução para isso.

Cada um está livre para desenvolver as soluções de acordo com o que desejar, mas vou deixar algumas dicas abaixo:

### Dica #1

Tem usar os conceitos de S.O.L.I.D, você pode encontrar eles aqui:

```
https://warcontent.com/principios-solid-imagens/
```

### Dica #2

Tente utilizar um banco de dados diferente, o PostegreSQL é uma boa, o MySql também.

### Dica #3

Tente separar seu projeto em camadas, abaixo está um exemplo:

![image](https://user-images.githubusercontent.com/81451506/231036067-25f11bd5-0fc2-443d-aea1-f17d70f5c9ae.png)


Veja um pouco sobre Design Patterns

```
https://refactoring.guru/design-patterns
```

### Dica #4 

Realize os testes unitários em ```NUnit``` ou ```XUnit``` 

