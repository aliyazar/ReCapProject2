using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public interface IDataResult<T>:IResult// hangi tip döndüreceğini T ile söyle aynı zamanda mesaj ve işlem sonucu versin 
    {// bunun için burası aynı zamanda bir IResult sın diyoruz
    //ama senin içinde IResult taki verilere ek olarak T türünde data olacak
   
    T Data { get; }
    }
}
