# mini_analizador_sintactico

Este analizador sintactico resuelve especificamente dos ejercicios los cuales son los siguientes:


El primer ejercicio, que tiene de entrada hola+mundo


![image](https://user-images.githubusercontent.com/84942556/187570106-20918ff1-faac-451f-a100-e09bff8951a3.png)


El segundo ejercicio, que tiene como entrada a+b+c+d+e+f


![image](https://user-images.githubusercontent.com/84942556/187570180-303695de-3b93-4b29-84a5-dd6ae7bc7489.png)

Para esto se utilizo una pila para poder ir haciendo los desplazamientos y las reducciones, ya que se esta utilizando el analisis LR 1, estos movimientos se ven reflejados en numeros enteros, a cotinuacion veremos el resultado del primer ejercicio:


![image](https://user-images.githubusercontent.com/84942556/187570453-af1f1a51-3ee6-4a0e-bad3-a468f1d2a9ee.png)


El ultimo entero qeu arroja es un 1 lo que nos indica que se llego a un estado de aceptación.


Luego tenemos el ejercicio dos:


![image](https://user-images.githubusercontent.com/84942556/187570550-2c62cbf0-e53b-40e1-921f-f30cf8cee79f.png)


Igualmente podemos ver que el ultimo numero es 1 lo que simboliza que se llego a un estado de aceptacion.



Se han incluido cambios en los que se utiliza una pila orientada a objetos.

Ahora la salida se ve asi:


este es el ejercicio 1, en el cual podemos ver el proceso un poco mas claro.


![image](https://user-images.githubusercontent.com/84942556/189502482-ab722ec2-8b26-423c-84d9-53ba1069f448.png)

y el ejercicio 2


![image](https://user-images.githubusercontent.com/84942556/189502536-cf84530f-ea1b-41a7-82d5-a134a8280bbc.png)


