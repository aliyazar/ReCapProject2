using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(false, message)//Burada base (yani result a)iki farklı tür gönderevilirsin biri
        {                                                         //biri sacece true diğeride hem true hem mesaj

        }

        public ErrorResult() : base(false)//Burada base (yani result a)mesaj göndermek istmeeyebilirsin gönderevilirsin yani paramatresiz gönderebilirsin
        {//default değer olarak false alır
        }
    }
}
