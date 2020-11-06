# Interface Inteligentes - Práctica 3

## 1. Agregar dos objetos en la escena: A y B. Cuando el jugador colisiona con un objeto de tipo B, el objeto A volcará en consola un mensaje. Cuando toca el objeto A se incrementará un contador en el objeto B.

Para la resolución del ejercicio he realizado lo siguiente. Primero, he creado dos objetos, un cilindro (objeto A) y un cuadrado (objeto B), cada uno de ellos tiene un script con la función correspondiente a lo que quiero que hagan. Posteriormente, he creado el objeto jugador (conejo) que contiene su propio script y, dentro de este, he establecido una referencia a cada uno de los otros dos objetos.

El objeto jugador es el que se encarga de detectar las colisiones con los objetos identificados con el tag "ObjectA" y "ObjectB" y cuando esto sucede, se llama a la función del objeto B y el objeto A respectivamente.

**Colision objeto B:**
![eje1.1.gif](Images/eje1.1.gif)

**Colision objeto A:**
![eje1.2.gif](Images/eje1.2.gif)