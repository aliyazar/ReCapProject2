using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public class SuccessResult:Result
    {
        public SuccessResult(string message) : base(true, message)//Burada base (yani result a)iki farklı tür gönderevilirsin biri
        {                                                         //biri sacece true diğeride hem true hem mesaj

        }

        public SuccessResult() : base(true)//Burada base (yani result a)mesaj göndermek istmeeyebilirsin gönderevilirsin yani paramatresiz gönderebilirsin
        {//default değer olarak true alır
        }

    }
}
