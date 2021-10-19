using System;
using Microsoft.AspNetCore.Mvc;



namespace ExplosionAPI.Controllers
{
    [ApiController]
    [Route("/accum")]

    public class Accum
    {
        [HttpGet("(accum)")]
        public string WeirdSTring(string accum)
        {
            string solution = "";

            for (int i = 0; i < accum.Length; i++)
            {
                solution += accum[i].ToString().ToUpper();

                for (int j = i; j > 0; j--)
                {
                    solution += accum[i].ToString().ToLower();
                }

                if (i != accum.Length - 1) solution += "-";
            }

            return solution;
        }
    }
}