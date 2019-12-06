Token for Download Nugets from krea Org
ebwrxkgj6a3q7man2ycrn5itb2qvuew6w2vd36r5abt7du5wlmba


# Tweetbook
Guiado desde https://www.youtube.com/watch?v=sdlt3-ptt9g&amp;list=PLUOequmGnXxOgmSDWU7Tl6iQTsOtyjtwU&amp;index=1

# Construir nuget desde Pipeline

## se crea el proyecto en DevOps
## Se agrega el pipeline con sus pasoss

Uno de de los pasos del Pipeline implica la restauración de nugets desde un Feed rpivado de la organización

> Para ello se requiere crear una conexión para acceso a nuget del repositorio privado de la organización para su descarga y restauración
de la siguiente manera:
>> Prerequisito:
>> * crear un Token de acceso de solo lectura para Nugets, desde ` **Personal Access Tokens**, se necesitará para suministrar acceso a la conexión que Restaura Nugets en el Pipeline

1. Ingresar al proyecto
2. Ingresar a configuraciones del proyecto (Gear Button) 
3. Ingresar a `Service Connections`
4. crear un `New Service Connection`
5. Seleccione Nuget y `Next`
6. Suministre los datos de conexión al Feed (`Recuerde emplear el access Token creado`)
7. Verifique el nombre de la conexión y su creación

![](https://media.giphy.com/media/fVmWSAklgAglqm9aGB/giphy.gif)

# Como hacer Deploy sobre AWS, Heroku, Azure de un repo con un solo click en el README
https://github.com/Erudika/scoold
