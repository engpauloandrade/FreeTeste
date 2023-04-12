# Teste para aprimorar seus conhecimentos em C# e .NET

Esse teste foi criado para aprimorar suas habilidades com .NET e C# em geral. 


### Para começar

O primeiro passo é clonar esse repositório na sua máquina

Escolha o local onde deseja clonar o projeto em sua máquina e, em seu GitBash, 
digite/cole: 

```
git clone https://github.com/engpauloandrade/FreeTeste.git
```

Para esse teste eu utilizei o SqlServer, mas você pode utilizar outro banco de dados.
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

Realize os testes unitários

