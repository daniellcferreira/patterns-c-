# Design Patterns em C#

Bem-vindo ao repositório do curso de Design Patterns em C# oferecido pela Ada Tech. Este curso aborda diversos padrões de projeto fundamentais para o desenvolvimento de software em C#.

## Estrutura do Projeto

O projeto está organizado da seguinte forma:

- **Ada.DesignPatterns/**: Diretório principal contendo os exemplos de código para cada padrão de projeto.
- **Ada.DesignPatterns.sln**: Arquivo de solução do Visual Studio para facilitar a navegação e execução dos exemplos.

## Padrões de Projeto Abordados

### Padrões Criacionais

- **Abstract Factory**: Interface para criar famílias de objetos relacionados ou dependentes sem especificar suas classes concretas.
- **Builder**: Separa a construção de um objeto complexo da sua representação, permitindo criar diferentes representações.
- **Factory Method**: Define uma interface para criar objetos, permitindo que subclasses decidam qual classe instanciar.
- **Prototype**: Cria novos objetos clonando uma instância prototípica.
- **Singleton**: Garante que uma classe tenha apenas uma instância e fornece um ponto global de acesso a ela.

### Padrões Estruturais

- **Adapter**: Converte a interface de uma classe em outra esperada pelos clientes.
- **Bridge**: Separa abstração da implementação, permitindo que variem independentemente.
- **Composite**: Composição de objetos em hierarquias parte-todo.
- **Decorator**: Anexa responsabilidades adicionais a um objeto dinamicamente.
- **Facade**: Interface simplificada para um conjunto de interfaces de um subsistema.
- **Flyweight**: Compartilhamento eficiente de grandes quantidades de objetos.
- **Proxy**: Substituto ou representante para controlar o acesso a outro objeto.

### Padrões Comportamentais

- **Chain of Responsibility**: Passa solicitações por uma cadeia de manipuladores.
- **Command**: Encapsula uma solicitação como um objeto, permitindo operações como desfazer.
- **Interpreter**: Representação gramatical e interpretador para linguagens específicas.
- **Iterator**: Acesso sequencial a elementos de um agregado sem expor sua representação.
- **Mediator**: Encapsula interações entre objetos para reduzir acoplamento.
- **Memento**: Captura e restaura o estado interno de um objeto.
- **Observer**: Notifica dependentes sobre mudanças de estado de um objeto.
- **State**: Altera o comportamento de um objeto com base em seu estado interno.
- **Strategy**: Define uma família de algoritmos e os torna intercambiáveis.
- **Template Method**: Define o esqueleto de um algoritmo, permitindo que subclasses implementem partes específicas.
- **Visitor**: Representa operações a serem realizadas em elementos de uma estrutura de objeto.
