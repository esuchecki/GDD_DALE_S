using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class publicar_dto
    {
        private DateTime fechasys;
        private string stock;
        private string descripcion;        
        private string estado ;
        private string idvisibilidad;
        private DateTime fecha_inicio;
        private DateTime fecha_vencimiento;
        private string permitir_preguntas ;
        private string precio ;
        private string costo ;
        private string porc;
        private string tipo_publicacion ;
        private string idrubro ;
        private string idusuario;
        private string idpublicacion;
        private string envio;
       
     public void setstock(string stock)
    {
      this.stock=stock;
     }
     public void setfechasys(DateTime fecha)
     {
         this.fechasys = fecha;
     }
        
        public void setidpublicacion(string idpublicacion)
     { this.idpublicacion = idpublicacion; }
     public void setenvio(string envio)
     { this.envio = envio; }
        
        public void setdescp(string descripcion)
     {
         this.descripcion = descripcion;
     }
     public void setestado(string estado)
     {
         this.estado = estado;
     }
     public void setidvisibilidad(string idvisibilidad)
     {
         this.idvisibilidad = idvisibilidad;
     }
     public void setfecha_inicio(DateTime fecha_inicio)
     {
         this.fecha_inicio = fecha_inicio;
     }
     public void setfecha_vencimiento(DateTime fecha_vencimiento)
     {
         this.fecha_vencimiento = fecha_vencimiento;
     }
     public void setpermitir_preguntas(string permitir_preguntas)
     {
         this.permitir_preguntas = permitir_preguntas;
     }
     public void setprecio(string precio)
     {
         this.precio = precio.Replace(',','.');
     }
     public void setcosto(string costo)
     {
         this.costo = costo.Replace(',', '.');
     }

     public void setporc(string porc)
     {
         this.porc = porc.Replace(',', '.');
     }
    
        public void setidrubro(string idrubro)
     {
         this.idrubro = idrubro;

     }
     public void setidusuario(string idusuario)
     {
         this.idusuario = idusuario;
     }
     public void settipo_publicacion(string tipo_publicacion)
     {
         this.tipo_publicacion = tipo_publicacion;
     }
        
        
        
        
        
        
        
        
        
        
        
        
        
        //getters

     public DateTime getfechasys()
     {
         return this.fechasys;
     }

     public string getporc()
     {
         return this.porc;
     }
     
        public string getstock()
     {
         return this.stock;
     }
     public string getdescripcion()
     {
         return this.descripcion;
     }
     public string getestado()
     {
         return this.estado ;
     }
     public string getidvisibilidad()
     {
         return this.idvisibilidad;
     }
     public DateTime getfecha_inicio()
     {
         return this.fecha_inicio;
     }
     public DateTime getfecha_vencimiento()
     {
         return this.fecha_vencimiento;
     }
     public string getpermitir_preguntas()
     {
         return this.permitir_preguntas;
     }
     public string getprecio()
     {
         return this.precio;
     }

     public string getcosto()
     {
         return this.costo;
     }

     public string gettipo_publicacion()
     {
         return this.tipo_publicacion;
     }
     public string getidrubro()
     {
         return this.idrubro ;
     }
     public string getidusuario()
     {
         return this.idusuario;
     }

     public string getenvio()
     { return this.envio; }
     public string getidpubliacion()
     { return this.idpublicacion; }
    
    
    }
}
