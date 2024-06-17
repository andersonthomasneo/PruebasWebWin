# PruebasWebWin

Si el proyecto de inicio es Prueba.Servicios.Web
[http://localhost:5001/weatherforecast](http://localhost:5001/weatherforecast)

Si el proyecto de inicio es Prueba.Servicios.Win
[http://localhost:5002/weatherforecast](http://localhost:5002/weatherforecast)


El puerto está definido en el appsettings.json correspondiente


# Instalar servicio windows
- Publicar *Prueba.Servicios.Win*
- Abrir CMD como Administrador
- Ejecutar el siguiete comando (cambiar directorio del .exe si fuese necesario):

`sc.exe create "Net Pruebas" binpath="C:\Publicar\Pruebas\Prueba.Servicios.Win.exe"`
- Iniciar servicio:

`sc.exe start "Net Pruebas"`
- abrir  navegador para probar [http://localhost:5002/weatherforecast](http://localhost:5002/weatherforecast)
- detener servicio para probar que la url ya no funciona:

`sc.exe stop "Net Pruebas"`

