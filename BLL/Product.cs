using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Product
    {
        public event ErrorEventHandler ErrorEvent;
        public delegate void ErrorEventHandler(object sender, ErrorEventArgs e);
        public Entities.Product GetProductById(int ID)
        {
            Entities.Product Result;
            if (ID > 0)
            {
                var D = new DAL.Product();
                Result = D.GetProductBYID(ID);
                if (ErrorEvent != null)
                {
                    ErrorEvent(this, new ErrorEventArgs("Producto no encontrado"));
                }
            }
            else
            {
                if (ErrorEvent != null)
                {
                    ErrorEvent(this, new ErrorEventArgs(
                        "EL ID debe ser mayos que cero"
                        ));
                }
                Result = null;
            }
            return Result;
        }
    }
    public class ErrorEventArgs : EventArgs
    {
        public string Message { get; set; }
        public ErrorEventArgs(string message)
        {
            this.Message = message;
        }
    }
}
