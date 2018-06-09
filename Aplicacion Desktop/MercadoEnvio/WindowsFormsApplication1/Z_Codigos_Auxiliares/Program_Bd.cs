using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
        //Hago que solo se pueda hacer una instancia de esta clase que conecta con la BD
    public sealed class _conexionSQL
    {
        private static volatile _conexionSQL instance = null;
        private static readonly object padlock = new object();

        private SqlConnection cnn = new SqlConnection(_Parametros._connectionString);

        private _conexionSQL() { }

        public static _conexionSQL Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        instance = new _conexionSQL();
                    }
                }

                return instance;
            }
        }


        //Codigo para conectar a la BD
        private void conectar()
        {
            try
            {
                cnn.Open();
                System.Console.WriteLine("Se conecto a la BD");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Hubo un problema al conectarse a la BD");
            }
        }


        //Codigo para des-conectar a la BD
        private void desconectar()
        {
            try
            {
                cnn.Close();
                System.Console.WriteLine("Se des-conecto a la BD");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Hubo un problema al desconectarse a la BD");
            }
        }

        //El formulario de login al hacer click en el boton llama a este metodo. Valida usuario y contraseña contra la BD
        public string prueba_login(string user, string password)
        {
            
            DataTable resultadoConsulta;
            try
            {
                conectar();
                string sql;
                sql = @"exec DALE_SA.pr_loguin '" + user + @"','" + password+@"'";
                resultadoConsulta = comando_sql(sql);
                System.Console.WriteLine("CONSULTA SQL OK");
                System.Console.WriteLine("SARA: "+resultadoConsulta.Rows);
                if(resultadoConsulta.Rows[0][0].Equals(-1))
	            {
                    System.Console.WriteLine("usuario incorrecto");
                            return "-1";
                }
                else if (resultadoConsulta.Rows[0][0].Equals(-2))
	            {
                    System.Console.WriteLine("Usuario Bloqueado");
                    
                            return "-2";
                }
                
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Hubo un problema con la peticion");
                return "-3";
            }
            finally //si tiro error o si todo bien, cierra la sesion.
            {
                desconectar();
                
            }
            return resultadoConsulta.Rows[0][0].ToString();
        }

        public Boolean prueba_data(string user,ref DataTable resultadoConsulta) 
        {
            Boolean retorno=false;
            try
            {



                conectar();
                
                
                string sql;

                
                sql = @"
                        SELECT [nombre],[estado]
                        FROM [GD1C2016].[DALE_SA].[rol] R,DALE_SA.rol_usuario UR where UR.idrol=R.idrol AND UR.idusuario="
                    +user;
           

                System.Console.WriteLine("Sentencia: " + sql);
                resultadoConsulta = comando_sql(sql);
                System.Console.WriteLine("CONSULTA  DATA SQL OK");
                



            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Hubo un problema con la peticion");
                return retorno;
                
            }
            finally //si tiro error o si todo bien, cierra la sesion.
            {
                desconectar();

            }
            return retorno;
        }


        public void consultar_rol_x_funcionalidad(int idRol, Boolean soloDisponibles, ref DataTable resultadoConsulta)
        {

           // DataTable resultadoConsulta;
            try
            {
                conectar();
                string sql;
                if (soloDisponibles)
                {
                    sql = @"select idfuncionalidad, descripcion FROM [DALE_SA].funcionalidad T1
                        where T1.idfuncionalidad IN 
                            ((select idfuncionalidad from [DALE_SA].rol_funcionalidad T2 where T2.idrol =" + idRol.ToString() + @"
                        ))";
                }
                else
                {   //se agrega un NOT al IN.
                    sql = @"select idfuncionalidad, descripcion  FROM [DALE_SA].funcionalidad T1
                        where T1.idfuncionalidad NOT IN 
                            ((select idfuncionalidad from [DALE_SA].rol_funcionalidad T2 where T2.idrol =" + idRol.ToString() + @"
                        ))";
                }
                resultadoConsulta = comando_sql(sql);
                System.Console.WriteLine("CONSULTA SQL OK");
                //System.Console.WriteLine("SARA: " + resultadoConsulta.Rows);

            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Hubo un problema con la peticion");
              //  return null;
            }
            finally //si tiro error o si todo bien, cierra la sesion.
            {
                desconectar();

            }
           // return resultadoConsulta;
        }



        public void cambiar_estado_rol(int idRol, int estado)
        {

            DataTable resultadoConsulta;
            try
            {
                conectar();
                string sql;
                sql = @"Update [DALE_SA].rol set estado = " + estado.ToString() + @"
                        where [DALE_SA].rol.idrol = "+ idRol.ToString() + @"
                        ";
                resultadoConsulta = comando_sql(sql);
                System.Console.WriteLine("CONSULTA SQL OK");
                //System.Console.WriteLine("SARA: " + resultadoConsulta.Rows);

            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Hubo un problema con la peticion");
                //return null;
            }
            finally //si tiro error o si todo bien, cierra la sesion.
            {
                desconectar();

            }
            //return resultadoConsulta;
        }


        public void cambiar_estado_usuario(int idUsuario, int estado)
        {

            DataTable resultadoConsulta;
            try
            {
                conectar();
                string sql;
                sql = @"Update [DALE_SA].usuario set estado = " + estado.ToString() + @"
                        where [DALE_SA].usuario.idusuario = " + idUsuario.ToString() + @"
                        ";
                resultadoConsulta = comando_sql(sql);
                System.Console.WriteLine("CONSULTA SQL OK");
                //System.Console.WriteLine("SARA: " + resultadoConsulta.Rows);

            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Hubo un problema con la peticion");
                //return null;
            }
            finally //si tiro error o si todo bien, cierra la sesion.
            {
                desconectar();

            }
            //return resultadoConsulta;
        }


        public DataTable ejecutarUnaQuery(string codigoSQL)
        {

            DataTable resultadoConsulta;
            try
            {
                conectar();
                resultadoConsulta = comando_sql(codigoSQL);
                System.Console.WriteLine("CONSULTA SQL OK");
                //System.Console.WriteLine("SARA: " + resultadoConsulta.Rows);

            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Hubo un problema con la peticion");
                return null;
            }
            finally //si tiro error o si todo bien, cierra la sesion.
            {
                desconectar();

            }
            return resultadoConsulta;
        }


        public Boolean modificar_Rol_Funcionalidad (int idrol, string nombre, DataTable dt)
        {

            //DataTable resultadoConsulta;
            try
            {
                //conectar();

                using (var command = new SqlCommand("DALE_SA.ModificarRolFuncionalidad") { CommandType = CommandType.StoredProcedure })
                {
                    //var dt = new DataTable(); //create your own data table
                    command.Parameters.AddWithValue("@dt", dt);
                    command.Parameters.AddWithValue("@idRol", idrol);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Connection = cnn;

                    conectar();
                    command.ExecuteNonQuery();
                }
                System.Console.WriteLine("CONSULTA SQL OK");

            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Hubo un problema con la peticion");
                return false;
            }
            finally //si tiro error o si todo bien, cierra la sesion.
            {
                desconectar();

            }
            return true;
        }


        public int crearRol(string nombre)
        {

            //DataTable resultadoConsulta;
            try
            {
                
                int respuesta = 0;
                using (var command = new SqlCommand("DALE_SA.CrearRol") { CommandType = CommandType.StoredProcedure })
                {
                    //var dt = new DataTable(); //create your own data table
                    //command.Parameters.Add(new SqlParameter("@nombre", nombre));
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Connection = cnn;
                   
                    conectar();
                    
                    respuesta = Convert.ToInt32(command.ExecuteScalar());
                    //System.Console.WriteLine(respuesta.ToString());
                    //respuesta = (int)command.Parameters["@ID"].Value;
                }

                System.Console.WriteLine("CONSULTA SQL OK");
                return respuesta;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Hubo un problema con la peticion");
                return 0;
            }
            finally //si tiro error o si todo bien, cierra la sesion.
            {
                desconectar();

            }
            //return respuesta;
        }


        //private DataTable comando_sql(string sql, SqlParameter parametro1, SqlParameter parametro2)
        private DataTable comando_sql(string sql)
        {
            try
            {
                //SqlDataReader myReader = null;
                //SqlCommand myCommand = new SqlCommand(sql, cnn);

                //queda aprolijar esta parte del codigo con los parametros
                //myCommand.Parameters.Add(parametro1);
                //myCommand.Parameters.Add(parametro2);

                SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
                //System.Console.WriteLine(sql);
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda.Fill(dt);
                return dt;

               // int resultado = int.Parse(myCommand.ExecuteScalar().ToString());
                //myReader = myCommand.ExecuteReader();
                //while (myReader.Read())
                //{
                //    Console.WriteLine(myReader["Column1"].ToString());
                //    Console.WriteLine(myReader["Column2"].ToString());
                //}

                //myReader.Close();
                //myCommand.Dispose();
                //return resultado;
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Hubo un problema con la consulta SQL");
                Console.WriteLine(e.ToString());
                return null;
            }
            finally
            {
                //.....
            }

        }

    
       
                
         public Boolean publicar (publicar_dto  dto)
        {
            /*
                      @stock = 1,
		@descripcion = N'des',
		@estado = 1,
		@idvisibilidad = 1,
		@fecha_inicio = N'//',
		@fecha_vencimiento = N'//',
		@permitir_preguntas = 1,
		@precio = 1.1,
		@costo = 1.1,
		@tipo_publicacion = N'Directa',
		@idrubro = 1,
		@idusuario = 1
             */
            //DataTable resultadoConsulta;
            try
            {
                //conectar();

                using (var command = new SqlCommand("DALE_SA.pr_publicar") { CommandType = CommandType.StoredProcedure })
                {
                    //var dt = new DataTable(); //create your own data table
                    command.Parameters.AddWithValue("@stock", dto.getstock());
                    command.Parameters.AddWithValue("@descripcion", dto.getdescripcion());
                    command.Parameters.AddWithValue("@estado", dto.getestado());
                    command.Parameters.AddWithValue("@idvisibilidad", dto.getidvisibilidad());
                    command.Parameters.AddWithValue("@fecha_inicio", dto.getfecha_inicio());
                    command.Parameters.AddWithValue("@fecha_vencimiento", dto.getfecha_vencimiento());
                    command.Parameters.AddWithValue("@permitir_preguntas", dto.getpermitir_preguntas());
                    command.Parameters.AddWithValue("@permitir_envio", dto.getenvio());
                    command.Parameters.AddWithValue("@precio", dto.getprecio());
                    command.Parameters.AddWithValue("@costo", dto.getcosto());
                    command.Parameters.AddWithValue("@tipo_publicacion",dto.gettipo_publicacion() );
                    command.Parameters.AddWithValue("@idrubro", dto.getidrubro());
                    command.Parameters.AddWithValue("@idusuario", dto.getidusuario());
                    command.Connection = cnn;

                    conectar();
                    command.ExecuteNonQuery();
                }
                System.Console.WriteLine("CONSULTA SQL OK");

            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Hubo un problema con la peticion");
                return false;
            }
            finally //si tiro error o si todo bien, cierra la sesion.
            {
                desconectar();

            }
            return true;
        }



 public Boolean ofertar(publicar_dto dto)
         {
             /*
                        USE [GD1C2016]
GO

DECLARE @RC int
DECLARE @idusuario numeric(18,0)
DECLARE @idpublicacion numeric(18,0)
DECLARE @fecha nvarchar(255)
DECLARE @envio bit
DECLARE @monto numeric(18,2)

-- TODO: Establezca los valores de los parámetros aquí.

EXECUTE @RC = [DALE_SA].[pr_ofertar] 
   @idusuario
  ,@idpublicacion
  ,@fecha
  ,@envio
  ,@monto
GO
            */
             try
             {
                 //conectar();

                 using (var command = new SqlCommand("DALE_SA.pr_ofertar") { CommandType = CommandType.StoredProcedure })
                 {
                     //var dt = new DataTable(); //create your own data table
                     command.Parameters.AddWithValue("@idusuario", dto.getidusuario());
                     command.Parameters.AddWithValue("@idpublicacion", dto.getidpubliacion());               
                     command.Parameters.AddWithValue("@fecha", dto.getfechasys());
                     command.Parameters.AddWithValue("@envio", dto.getenvio());
                     command.Parameters.AddWithValue("@monto", dto.getprecio());
                     
                     
                     command.Connection = cnn;

                     conectar();
                     command.ExecuteNonQuery();
                 }
                 System.Console.WriteLine("CONSULTA SQL OK");

             }
             catch (Exception ex)
             {
                 System.Console.WriteLine("Hubo un problema con la peticion");
                 System.Console.WriteLine("Execpcion decimal compra: "+ex.ToString());
                 return false;
             }
            finally //si tiro error o si todo bien, cierra la sesion.
             {
                 desconectar();

             }
             return true;
         }

 public int AMBvisibilidad(publicar_dto dto)
 {
     int retorno = -1;
     try
     {
         /*
           @idvisibilidad AS Numeric(18,0),
	 @descripcion AS Nvarchar(255),
	 @porcentaje_venta  AS numeric(18,2),
	 @precio_publicacion AS numeric(18,2),
	 @precio_envio AS numeric(18,2),
	 @codigo AS numeric(18),
	 @estado AS bit,
	 @accion AS numeric(1))
          */

         using (var command = new SqlCommand("DALE_SA.ABMvisibilidad") { CommandType = CommandType.StoredProcedure })
         {
             //var dt = new DataTable(); //create your own data table


           /*  MessageBox.Show("idv"+dto.getidvisibilidad());
            
             MessageBox.Show("D"+dto.getdescripcion());
      
            MessageBox.Show("C"+dto.getidrubro());
            
             MessageBox.Show("P"+dto.getporc());
            
             MessageBox.Show("E"+dto.getcosto());
          
             MessageBox.Show("Preci"+dto.getprecio());

             MessageBox.Show("ACCION" + dto.gettipo_publicacion());*/



             command.Parameters.AddWithValue("@idvisibilidad", dto.getidvisibilidad());
             command.Parameters.AddWithValue("@descripcion", dto.getdescripcion());
             command.Parameters.AddWithValue("@porcentaje_venta", dto.getporc());
             command.Parameters.AddWithValue("@precio_publicacion", dto.getprecio());
             command.Parameters.AddWithValue("@precio_envio", dto.getcosto());
             command.Parameters.AddWithValue("@codigo", dto.getidrubro());
             command.Parameters.AddWithValue("@estado", dto.getestado());
             command.Parameters.AddWithValue("@accion", dto.gettipo_publicacion());

             SqlParameter retval = command.Parameters.Add("@b", SqlDbType.Int);
             retval.Direction = ParameterDirection.ReturnValue;
            
             

             command.Connection = cnn;

             conectar();
             

             
             command.ExecuteNonQuery();
             retorno = (int)command.Parameters["@b"].Value;             
         }
         System.Console.WriteLine("CONSULTA SQL OK");

     }
     catch (Exception ex)
     {
         System.Console.WriteLine("Hubo un problema con la peticion");
         System.Console.WriteLine("Execpcion decimal compra: " + ex.ToString());
         //MessageBox.Show(ex.ToString());
         System.Console.WriteLine("-1");
         return -1;
     }
            finally //si tiro error o si todo bien, cierra la sesion.
     {
         desconectar();

     }
     System.Console.WriteLine("CONSULTA SQL OK33333");
     return retorno;
    
 } 



         public Boolean comprar(publicar_dto dto)
         {
             /*
                 DECLARE @RC int
                 DECLARE @cantidad numeric(18,0)
                 DECLARE @idusuario numeric(18,0)
                 DECLARE @idpublicacion numeric(18,0)
                 DECLARE @fecha nvarchar(255)
                 DECLARE @idvisibilidad numeric(18,0)
                 DECLARE @envio bit
                 DECLARE @precio numeric(18,2)
          EXECUTE @RC = [DALE_SA].[pr_comprar] 
             @cantidad
            ,@idusuario
            ,@idpublicacion
            ,@fecha
            ,@idvisibilidad
            ,@envio
            ,@precio
            */
             try
             {
                 //conectar();

                 using (var command = new SqlCommand("DALE_SA.pr_comprar") { CommandType = CommandType.StoredProcedure })
                 {
                     //var dt = new DataTable(); //create your own data table
                     command.Parameters.AddWithValue("@cantidad", dto.getstock());
                     command.Parameters.AddWithValue("@idusuario", dto.getidusuario());
                     command.Parameters.AddWithValue("@idpublicacion", dto.getidpubliacion());               
                     command.Parameters.AddWithValue("@fecha", dto.getfechasys());
                     command.Parameters.AddWithValue("@envio", dto.getenvio());
                     command.Parameters.AddWithValue("@precio", dto.getprecio());
                     System.Console.WriteLine("SARARARAR: "+command.ToString());
                     
                     command.Connection = cnn;

                     conectar();
                     command.ExecuteNonQuery();
                 }
                 System.Console.WriteLine("CONSULTA SQL OK");

             }
             catch (Exception ex)
             {
                 System.Console.WriteLine("Hubo un problema con la peticion");
                 System.Console.WriteLine("Execpcion decimal compra: "+ex.ToString());
                 return false;
             }
            finally //si tiro error o si todo bien, cierra la sesion.
             {
                 desconectar();

             }
             return true;
         } 
        
        
        
        
        
        public void prConsultaUsuarioCliente(string nombre, string apellido, string email, string dni, ref DataTable resultadoConsulta)
         {

             // DataTable resultadoConsulta;
             try
             {
                 conectar();
                 string sql;
                 sql = @"EXEC DALE_SA.prConsultaUsuarioCliente  '" + nombre + @"',
                                                                '" + apellido + @"',
                                                                '" + email + @"',
                                                                '" + dni + @"'
                        ";
                 resultadoConsulta = comando_sql(sql);
                 System.Console.WriteLine("CONSULTA SQL OK");
             }
             catch (Exception ex)
             {
                 System.Console.WriteLine("Hubo un problema con la peticion");
                 //  return null;
             }
            finally //si tiro error o si todo bien, cierra la sesion.
             {
                 desconectar();

             }
             // return resultadoConsulta;
         }

         public void prConsultaUsuarioEmpresa(string razonSocial, string email, string cuit, ref DataTable resultadoConsulta)
         {

             // DataTable resultadoConsulta;
             try
             {
                 conectar();
                 string sql;
                 sql = @"EXEC DALE_SA.prConsultaUsuarioEmpresa  '" + razonSocial + @"',
                                                                '" + email + @"',
                                                                '" + cuit + @"'
                        ";
                 resultadoConsulta = comando_sql(sql);
                 System.Console.WriteLine("CONSULTA SQL OK");
             }
             catch (Exception ex)
             {
                 System.Console.WriteLine("Hubo un problema con la peticion");
                 //  return null;
             }
            finally //si tiro error o si todo bien, cierra la sesion.
             {
                 desconectar();

             }
             // return resultadoConsulta;
         }


    }
    
}
