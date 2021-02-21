using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //DataREsult Çalıştırılırken verilen Parametre T olacak
    public class DataResult<T> : Result, IDataResult<T>//sen aslından bir Result sın
    {
        public DataResult(T data,bool success,string message):base(success,message)// base e de success ve message ı yolla
        {
            Data = data;

        }

        public DataResult(T data,bool succes):base(succes)// mesaj göndermeyebilirsin
        {
            Data = data;
        }
        public T Data { get; }
    }
}
