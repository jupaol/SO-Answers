Para usar la plantilla de Intranet, deberá habilitar la autenticación de Windows
y deshabilitar la autenticación anónima.

IIS 7 e IIS 8
1. Abra el Administrador de IIS y navegue hasta su sitio.
2. En Vista Características, haga doble clic en Autenticación.
3. En la página Autenticación, seleccione Autenticación de Windows. Si Autenticación
   de Windows no aparece como opción, deberá asegurarse de que el servicio Autenticación de Windows
   esté instalado en el sistema.

      Para habilitar la autenticación de Windows en Windows:
      a) En el Panel de control, abra "Programas y características".
      b) Seleccione "Activar o desactivar las características de Windows".
      c) Vaya a Internet Information Services > Servicios World Wide Web > Seguridad
         y asegúrese de que el nodo Autenticación de Windows está activado.

      Para habilitar la autenticación de Windows en Windows Server:
      a) En el Administrador de servidores, seleccione Servidor web (IIS) y haga clic en Agregar servicios de rol.
      b) Vaya a Servidor web > Seguridad
         y asegúrese de que el nodo Autenticación de Windows está activado.

4. En el panel Acciones, haga clic en Habilitar para usar la autenticación de Windows.
5. En la página Autenticación, seleccione Autenticación anónima.
6. En el panel Acciones, haga clic en Deshabilitar para deshabilitar la autenticación anónima.

IIS Express
1. Haga clic en el proyecto en el Explorador de soluciones para seleccionar el proyecto.
2. Si no el panel Propiedades no está abierto, ábralo ahora (F4).
3. En el panel Propiedades del proyecto:
 a) Establezca la opción "Autenticación anónima" en "Deshabilitado".
 a) Establezca la opción "Autenticación de Windows" en "Habilitado".
