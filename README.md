# Instrucciones
    Implementa el juego de Torres de Hanoi utilizando pilas para representar cada torre.
    El programa debe permitir:
        - Ingresar el número de discos con los que se jugará.
        - Mostrar el estado de las torres en cada paso.
    Opcionalmente:
        - Resolver automáticamente el problema mostrando cada movimiento.
        - La solución debe aplicar el enfoque recursivo clásico para mover los discos de la torre de origen a la torre destino, utilizando una torre auxiliar.
# Procedimientos
    Utilizé un método recursivo P(n) = 2^n - 1, donde P(n) es la función y n es el número de discos y añadiendo un paso inverso utilizando la torre auxiliar.
    Para mostrar los pasos se limpia la consola y se utiliza un función que imprime la pila en la que es almacenada cada torre, cada movimiento esta descrito encima del estado de la torre.
    
    

