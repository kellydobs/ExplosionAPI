using System;
using Microsoft.AspNetCore.Mvc;






namespace ExplosionAPI.Controllers
{
    [ApiController]
    [Route("/reversestring")]

    public class ReverseString
    {
        [HttpGet("(str)")]
        public string Reverse(string str)
        {
            string reverse = "";
            char[] strInChar = str.ToCharArray();

            for (int i = strInChar.Length - 1; i >= 0; i--) ;

            {
                reverse += strInChar[i];
            }

            return reverse;

        }

    }
}