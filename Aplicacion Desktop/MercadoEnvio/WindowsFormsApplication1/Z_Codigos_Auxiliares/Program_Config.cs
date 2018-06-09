// Aca se incluiran algunas configuraciones globales.
//
//
//

namespace WindowsFormsApplication1
{
    public static class _Parametros
    {

        //Configuraciones de conexion a la BD
        public static string _connectionString = @"
            Server=localhost\SQLSERVER2012;
            Database=GD1C2016;
            User ID=gd;
            Password=gd2016
            ";

        //Nombre de la aplicacion.
        public static string _nombreAplicacion = "Mercado-Envio v1.0";

        //Nuestro Nombre de Grupo
        public static string _infoGrupoGD = "GD1C2016 - Grupo Nº: DALE_SA";
    
        
        //Consulta SQL para ver las funcionalidades disponibles
        public static string _SQL_verFuncionalidades = @"SELECT TOP 1000    [idfuncionalidad]
                                                                          , [descripcion]
                                                                      FROM [GD1C2016].[DALE_SA].[funcionalidad]";

        //Nombre del rol administrador en la BD.
        public static string _SQL_nombreAdministrador = "ADMINISTRADOR";

        //Nombre del rol administrador en la BD.
        public static string _SQL_idDeLaFuncionalidadAdministrador = "5";   //ya que la funcionalidad es fija en el sistema, lo comparo por ID.

        //Longitud Minima de contraseña
        public static int _longitudMinimaDePWD = 4;
    
    }
}