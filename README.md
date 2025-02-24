# Instrucciones
Implementa el juego de Torres de Hanoi utilizando pilas para representar cada torre.
El programa debe permitir:
- Ingresar el número de discos con los que se jugará.
- Mostrar el estado de las torres en cada paso.
### Opcionalmente:
- Resolver automáticamente el problema mostrando cada movimiento.
- La solución debe aplicar el enfoque recursivo clásico para mover los discos de la torre de origen a la torre destino, utilizando una torre auxiliar.
# Procedimientos
- Creé una clase Pile (pila o stack) que ayudaría a definir los discos, incluye las funciones Push, Pop y Peek al igual que una función Print que imprime la pila creada.
- Utilizé un método recursivo P(n) = 2^n - 1, donde P(n) es la función y n es el número de discos, en este se mueven n-1 discos hacía la torre auxiliar, se mueve el disco restante al destino  y se añade un paso inverso utilizando la torre auxiliar.
- Para mostrar los pasos: Dentro de la función para mover los discos se limpia la consola y se utiliza una función que imprime la pila en la que es almacenada cada torre, cada movimiento esta descrito encima del estado de la torre.
    
    

