Token for Download Nugets from krea Org
ebwrxkgj6a3q7man2ycrn5itb2qvuew6w2vd36r5abt7du5wlmba


# Tweetbook
Guiado desde [ASP.NET Core 2.2 & 3 REST API Tutorial](https://www.youtube.com/watch?v=sdlt3-ptt9g&amp;list=PLUOequmGnXxOgmSDWU7Tl6iQTsOtyjtwU&amp;index=1)
<iframe width="560" height="315" src="https://www.youtube.com/embed/ESdvXlrG9zQ" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>

# Construir nuget desde Pipeline

## se crea el proyecto en DevOps
## Se agrega el pipeline con sus pasoss

Una de las **Task** del Pipeline implica la restauración de nugets desde un Feed rpivado de la organización

> Para ello se requiere crear una conexión para acceso a nuget del repositorio privado de la organización para su descarga y restauración
de la siguiente manera:
>> Prerequisito:
>> * crear un Token de acceso de solo lectura para Nugets, desde **Personal Access Tokens**, se necesitará para suministrar acceso a la conexión que Restaura Nugets en el Pipeline

<table>
  <tr>
    <th>
      Creación del Service Connection
    </th>
  </tr>
  <tr>
    <td>
      1. Ingresar al proyecto<br/>
      2. Ingresar a configuraciones del proyecto (Gear Button)<br/>
      3. Ingresar a <b>Service Connections</b><br/>
      4. crear un <b>New Service Connection</b><br/>
      5. Seleccione Nuget y <b>Next</b><br/>
      6. Suministre los datos de conexión al Feed (<b>Recuerde emplear el access Token creado</b>)<br/>
      7. Verifique el nombre de la conexión y su creación<br/>
    </td>
    <td>
     <img src="https://media.giphy.com/media/fVmWSAklgAglqm9aGB/giphy.gif"></img>
    </td>
  </tr>
</table>

## Los resultados!!! 
<table>
  <tr>
    <th>
      Creación de la Task
    </th>
    <th>
      Resultado de la ejecución
    </th>
  </tr>
  <tr>
    <td>
      <img src="https://media.giphy.com/media/Kc8MY6nol3tH5vhJXm/giphy.gif?raw=true"></img>
    </td>
    <td>
      <img src="https://media.giphy.com/media/lkcYcp0sd2lwE5ysJ9/giphy.gif?raw=true"></img>
    </td>
  </tr>
</table>

> contenido del archivo `nuget.config`
```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <add key="nuget" value="https://api.nuget.org/v3/index.json" />
    <add key="kreaCore" value="https://pkgs.dev.azure.com/javiertrigos88/kreaCore/_packaging/kreaCore/nuget/v3/index.json" />
  </packageSources>
</configuration>
```

> ejemplo de la tarea Nuget Restore dentro de `azure-pipelines.yml`
```yml
- task: NuGetCommand@2
  displayName: Nuget Restore
  inputs:
    command: 'restore'
    restoreSolution: '**/*.sln'
    feedsToUse: 'config'
    nugetConfigPath: './AzurePipeline/nuget.config'
    externalFeedCredentials: 'kreaCoreNugetDownloader'
```


# Como hacer Deploy sobre AWS, Heroku, Azure de un repo con un solo click en el README
https://github.com/Erudika/scoold


# Referencias y enlaces de interes
* https://dev.to/raznerd/azure-pipelines-how-to-restore-local-nuget-packages-38o
* https://mallibone.com/post/private-nuget-feed-azure-devops
* https://intercom.help/appcenter/en/articles/2216043-restore-private-azuredevops-package-management-feeds-using-pat

---------

## Configurando los Cover Test con SonarCloud

1. Cree repo publico
2. Enlace cuenta DevOps con SonarCloud
3. Cree proyecto en SonarCloud 
4. Asigne nombre y clave al proyecto `wkreaTestSonarCloud`
5. Instale la aplicación SonarCloud desde el [Markerplace Azure](https://marketplace.visualstudio.com/items?itemName=SonarSource.sonarcloud)

6. Desde SonarCloud generar un token de acceso
> wkrea/TestSonarCloud - fcd133a190ea9c18a86f1b25af82d61dfbe11dd4

7. Luego desde DevOps crear Service Connection para SonarCloud (fcd133a190ea9c18a86f1b25af82d61dfbe11dd4)
Insertar GIF

8. Siguiendo el [tutorial](http://diegogiacomelli.com.br/publishing-a-dotnet-core-project-to-sonarcloud-with-cake/)
9. Creando la tarea de ejecución en Pipeline
```
```

# Referencias
* https://docs.microsoft.com/en-us/labs/devops/sonarcloudlab/index


# Referencias

https://sonarcloud.io/dashboard?id=wkreaTestSonarCloud
> Invoke-WebRequest https://cakebuild.net/download/bootstrapper/windows -OutFile build
./build #(Win or Lin)
https://cakebuild.net/docs/tutorials/setting-up-a-new-project
http://diegogiacomelli.com.br/publishing-a-dotnet-core-project-to-sonarcloud-with-cake/

https://geeks.ms/jlguerrero/en/2019/01/13/code-analysis-and-code-coverage-using-netcore-vs-code-publishing-to-sonarqube-sonarcloud-io/
http://www.serginet.com/2018/11/net-core-cobertura.html
https://github.com/SonarSource/sq-com_example_standard-sqscanner-travis
https://github.com/SonarSource/sq-com_example_standard-sqscanner-travis
https://github.com/SonarSource/sonarcloud_examples
