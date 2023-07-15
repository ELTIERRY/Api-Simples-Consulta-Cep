# Consulta CEP via API 

## Sobre o projeto
Consulta de API. 
Ao digitar um CEP, o projeto retorna um endereço entre outros resultados.

## Documentação

A documentação pode ser obtida no site [BrasilAPI](https://brasilapi.com.br/).

## Tecnologias utilizadas
### Back end
- C#


## Pré-requisitos
[.Net 5.0](https://dotnet.microsoft.com/pt-br/download/dotnet/5.0).

## Como executar a aplicação
Digitar o comando no terminal:
```
dotnet run
```


## Telas
### Boas vindas
```
Bem vindo ao sistema de consulta de CEP.
Pressione qualquer tecla para iniciar.
```

### Opções
```
Escolha uma das seguintes opções e tecle ENTER:
1: Para digitar o CEP.
2: Para sair.
Sua opção:
```

### Digitar CEP (Apenas números)
```
Você digitou 1!

Digite o CEP com apenas números:
```

### CEP correto
```
Você digitou 1!

Digite o CEP com apenas números: 22241330

Resposta: 200 = OK
{"cep":"22241330","state":"RJ","city":"Rio de Janeiro","neighborhood":"Santa Teresa","street":"Estrada das Paineiras","service":"correios-alt"}

Pressione qualquer tecla para VOLTAR.
```

### CEP não encontrado
```
Você digitou 1!

Digite o CEP com apenas números: 12345678

Request failed with status code:  404 = NotFound.
*** CEP < 12345678 > não encontrado ***

Pressione qualquer tecla para VOLTAR.
```

### CEP com caracteres inválidos
```
Você digitou 1!

Digite o CEP com apenas números: a123-4567b
Erro de digitação!

Pressione qualquer tecla para VOLTAR.
```

### Saindo com a opção 2
```
Você digitou 2!

Obrigado por utilizar nossos serviços!
Pressione qualquer tecla para SAIR.
```

## Agradecimentos
[BrasilAPI](https://brasilapi.com.br/)

## Contribuição
Os pull requests são bem-vindos. Para mudanças importantes, abra um problema primeiro para discutir o que você gostaria de mudar.
Certifique-se de atualizar os testes conforme apropriado.

## License
[![NPM](https://img.shields.io/npm/l/react)](https://github.com/ELTIERRY/Api-Simples-Consulta-Cep/blob/main/LICENSE)