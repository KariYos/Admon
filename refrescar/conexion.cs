using System;

public class Class1
{
	public Class1()
	{
                 public static MySqlConnection ObtenerConexion()
         {
             MySqlConnection conectar = new MySqlConnection("server=192.localhost;database=refrescar;pwd=12345678;");
             conectar.Open();
             //MessageBox.Show("Conexion Exitosa");
             return conectar;
         }
	}
}
