# StoreXY  <img alt="Online Store icon" src="https://img.icons8.com/nolan/2x/online-store.png" >

Prueba Evertec

Una tienda muy básica, donde un cliente puede comprar un solo producto con un valor fijo, el cliente necesita únicamente proporcionar su nombre, dirección decorreo electrónico y su número de celular para efectuar la compra. Una vez un cliente procede a la compra de su producto, como es debido, su sistema debe saber que se creó
una nueva orden de pedido, asignarle su código único para identificarla y saber si esta se encuentra pendiente de pago o si ya se ha realizado un pago para poder “despacharla".

## Tener en cuenta 👀

La tienda debe contener las siguientes vistas
1. Una donde el cliente proporcione los datos necesarios para generar una nueva orden
2. Una donde se presente un resumen de la orden y se permita proceder a pagar
3. Una donde el cliente pueda ver el estado de su orden, si está pagada muestre el mensaje de que está pagada, de lo contrario, un botón que permita reintentarlo debe estar presente
4. Una donde se pueda ver el listado de todas las órdenes que tiene la tienda

### API REST con Placetopay

Se agrega una capa extra para manejar las llamadas a Place To Pay para crear una sesión y pagar las ordenes. Con la información devuelta se actualiza la base de datos propia de la tienda.


## Tecnología 💻

Visual Studio 2019
Sql Server 2018
.NET Framework C#, Modelo MVC por capas
Paginas con Razor
Javascript, HTML, CSS, Bootstrap


## Autor ✒️

_Creador:_

* **Cristian David Bracale**

---
⌨️ con ❤️ por [CristianDBracale](https://www.linkedin.com/in/cristianbracale/) 😊
