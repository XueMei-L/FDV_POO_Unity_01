FDV_POO_Unity

```
>> PRACTICA:   Unity Project - POO with Unity
>> COMPONENTE: XueMei Lin
>> GITHUB:     https://github.com/XueMei-L/FDV_POO_Unity_01.git
>> Versión:    1.0.0
```

# Introducción a la POO con Unity

La **programación orientada a objetos (POO)** es una forma de organizar el código pensando en el mundo real.  
En lugar de tener un gran bloque de instrucciones, agrupamos el código en **objetos** que tienen:

- **Propiedades** → lo que son  
- **Comportamientos** → lo que hacen  

En Unity, ya trabajas con objetos, por ejemplo:  
- Un personaje  
- Una moneda  
- Un enemigo  

La POO ayuda a crear propios objetos con reglas personalizadas.

# Proceso de la practica
## Ejercicio 1: Programando clases
1. crear una clase con el script llamado: ***CuboDeColores.cs***
2. Definir las propiedades:
    > **public Color color = Color.blue;** // Variable pública, representa el color del cubo.

    > **public float tamano = 1f;** // Variable pública, representa el tamaño del cubo.
3. Implementa el comportamiento inicial: Haz que el cubo tome el color que prefieras y un tamaño predeterminado.


3. Usar la clase:
   
    Crear la clase sin ndada

    ***CuboDeColores.cs***: 
    ```
    using UnityEngine;

    public class CuboDeColores : MonoBehaviour
    {
        
    }
    ```

    Crear en la escena 3 cubos 3D

    ![alt text](image.png)

    Asignar el script ***CuboDeColores.cs*** a cada cubo


    
    
