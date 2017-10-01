using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MD.GA.COMMOM.Response
{
    public class Response<T>
    {
        private T value;
        private String errorMensaje;
        private String mensaje = "";
        private bool isValid = true;

        public string Mensaje
        {
            get
            {
                return mensaje;
            }
            set
            {
                this.mensaje = value;
            }
        }
        public T Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public string ErrorMensaje
        {
            get
            {
                return errorMensaje;
            }
        }

        public bool IsValid
        {
            get
            {
                return isValid;
            }

            set
            {
                isValid = value;
            }
        }

        public Response<T> Error(String mensaje)
        {
            this.errorMensaje = mensaje;
            this.value = default(T);
            this.isValid = false;
            return this;
        }

        
    }
}
