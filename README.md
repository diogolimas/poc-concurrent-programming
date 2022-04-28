# Programação concorrente (C#)

### **O que é**

Geralmente, aplicações e programas performam mais de uma operação ao mesmo tempo, isso é chamado de concorrência.

### **Thread**

É um caminho de execução que pode ser executado de maneira de outras execuções. 

Por exemplo, no cálculo de uma expressão, apenas uma *Thread* pode ser utilizada, no entanto, caso seja necessário calcular outra situação ao mesmo momento, isso pode ser feito, através da utilização de outra *Thread*.

Na criação de uma Thread, ela pode ser criada e utilizada. Essa criação pode se dar com a utilização de outras Threads e elas serão executadas paralelamente.

Perceba, a execuções das Threads são realizadas no Program de maneira paralela e não necessariamente sequencial (aguardando a finalização de uma após a outra):

![Untitled](assets/1.png)

No entanto, esse comportamento pode ser alterado da seguinte maneira: 

Utilizando um variável que represente a Thread .Join() força que uma Thread execute, obrigatoriamente, após a outra.  

No Program 2, veja (uma Thread foi executada após a outra):

![Untitled](assets/2.png)

Caso seja necessário enviar algum parâmetro para os métodos, uma lambda expression pode ser utilizada:

![Untitled](assets/3.png)

