using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool success, string message):this(success)//Resulta contractor yardımıyla iki tane veri gönderiyorsun
        {// bir parametre yollarsan burası, iki parametre yolarsan this aracılığıyla success de çalışır.
            Message = message;
            
        }
        // sadece sonuç yollamak istenebilir
        public Result(bool success)//Resulta contractor yardımıyla bir tane veri gönderiyorsun
        {
            
            Success = success;
        }

        public bool Success { get; }//get return edilecek

        public string Message { get; }
    }
}
