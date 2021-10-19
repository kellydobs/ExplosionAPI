
using System;
using Microsoft.AspNetCore.Mvc;


namespace ExplosionAPI.Controllers
{
    [ApiController]
    [Route("/digits")]
    public class DigitsExplosion
    {
        [HttpGet("(s)")]
        public string Explode(string s)
        {
            string solution = "";

            foreach (char c in s)
            {
                int number = int.Parse(c.ToString());

                for (int i = number; i > 0; i--)

                {
                    solution += number;
                }
            }
            return solution;

        }
    }
}