using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewWhitParameter(string name, string lastname = "any", int age = 33)
        {
            var data = $"{name} {lastname} {age}";
            var nulo = string.IsNullOrEmpty(data) ? "es vacía" : "llena";

            //JSON CON Newtonsoft.Json;
            Json(JsonConvert.SerializeObject(new { Mensaje = "Hola Devs" })); // en la vista recibe respuesta // var response = JSON.parse(respuesta); // response.Mensaje
            Json(new { Mensaje = "Hola Devs" });
            Json(data, JsonRequestBehavior.AllowGet); //permite ajax get
            //con redirect
            Json(new { ok = true, toRedirect = Url.Action("Index") }, JsonRequestBehavior.AllowGet);
            //ampliar capacidad del json
            List<string> datos = new List<string>();
            JsonResult lista = new JsonResult();
            lista.MaxJsonLength = int.MaxValue;
            lista.Data = new { ok = true, datosEnvio = datos };

            //tratar imagen
            var foto = new byte[8]; //foto desde BD
            MemoryStream streamIngreso = new MemoryStream(foto);
            MemoryStream streamSalida = new MemoryStream(foto);
            Image reternoImage = Image.FromStream(streamIngreso);
            Image imagenReducida = reternoImage.GetThumbnailImage(250, 350, null, IntPtr.Zero);
            Bitmap imagenImagen = new Bitmap(imagenReducida);
            imagenImagen.Save(streamSalida, ImageFormat.Png);
            byte[] imagenTratada = streamSalida.ToArray();
            var FOTO = String.Format("data:image/png;base64,{0}", Convert.ToBase64String(imagenTratada));


            return View();
        }

        public ActionResult ExecutePackages(int IdProject)
        {
            List<DTO> DatosFicha = new List<DTO>();
            DataTable resultado = new DataTable();

            // Se utiliza la instrucción using para asegurarnos la destrucción de los objetos y liberar recursos
            using (OracleConnection Conexion = new OracleConnection(ConfigurationManager.ConnectionStrings["ContextoSiathApp"].ConnectionString))
            {
                try
                {
                    OracleCommand comandoOracle = Conexion.CreateCommand();
                    comandoOracle.Connection = Conexion; // Al comando se le asigna la conexión
                    comandoOracle.CommandType = CommandType.StoredProcedure; // Se le indica el tipo de comando y el nombre
                    comandoOracle.CommandText = "PKG_NOVEDAD_GENERAL_SIATH30.F_DATO_FICHA";
                    comandoOracle.BindByName = true; //agregar los parámetros en cualquier orden                    
                    // Se añaden los parámetros de entrada
                    comandoOracle.Parameters.Add(new OracleParameter("RETURN_VALUE", OracleDbType.RefCursor)).Direction = ParameterDirection.ReturnValue;
                    comandoOracle.Parameters.Add(new OracleParameter("P_ID_PROYECTO", OracleDbType.Varchar2)).Value = IdProject;

                    // Se abre la conexión
                    Conexion.Open();
                    resultado.Load(comandoOracle.ExecuteReader());

                    foreach (DataRow fila in resultado.Rows)
                    {
                        DTO ObjR = new DTO
                        {
                            MyProperty = int.Parse(fila["CONSECUTIVO"].ToString())
                        };
                        DatosFicha.Add(ObjR);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return View();
        }
    }
    public class DTO
    {
        public int MyProperty { get; set; }
    }
}