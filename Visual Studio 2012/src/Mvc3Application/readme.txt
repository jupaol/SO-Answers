Para utilizar la plantilla de intranet, tendrá que habilitar la autenticación 
de Windows y deshabilitar la autenticación anónima.

Para obtener instrucciones detalladas (incluidas las instrucciones para 
IIS 6.0), visite
http://go.microsoft.com/fwlink/?LinkID=213745

IIS 7
1. Abra el Administrador de IIS y navegue a su sitio web.
2. En Vista Características, haga doble clic en Autenticación.
3. En la página Autenticación, seleccione Autenticación de Windows. Si 
   Autenticación de Windows no es una opción, tendrá que asegurarse de que la 
   autenticación de Windows está instalada en el servidor.
        Para habilitar la autenticación de Windows:
 a) En el Panel de control abra "Programas y características".
 b) Seleccione "Activar o desactivar las características de Windows".
 c) Navegue hasta Internet Information Services | Servicios World Wide Web | 
    Seguridad y asegúrese de que la casilla del nodo Autenticación de Windows 
    está activada.
4. En el panel Acciones, haga clic en Habilitar para utilizar la autenticación 
   de Windows.
5. En la página Autenticación, seleccione Autenticación anónima.
6. En el panel Acciones, haga clic en Deshabilitar para deshabilitar la 
   autenticación anónima.

IIS Express
1. Haga clic con el botón secundario en el proyecto de Visual Studio y 
   seleccione Usar IIS Express.
2. Haga clic en el proyecto en el Explorador de soluciones para seleccionar el 
   proyecto.
3. Si el recuadro Propiedades no se abre, asegúrese de abrirlo (F4).
4. En el recuadro Propiedades del proyecto:
 a) Establezca "Autenticación anónima" en "Deshabilitada".
 b) Establezca "Autenticación de Windows" en "Habilitada":

Puede instalar IIS Express mediante el Instalador de plataforma web de 
Microsoft.
    Para Visual Studio: http://go.microsoft.com/fwlink/?LinkID=214802
    Para Visual Web Developer: http://go.microsoft.com/fwlink/?LinkID=214800
