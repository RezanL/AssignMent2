using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //0342 start input
            //5356 also working
            var location1 = 0;
            var location2 = 3;
            var jumpRate1 = 4;
            var jumpRate2 = 2;

            bool running = true;
            //calculate the difference of location and jumprate
            var location = location2 - location1;
            var jumpRate = jumpRate1 - jumpRate2;


            //Rule out that jumprate is not the same, because at different locations they will never meet. And that difference of jumprate and location is not fractioned, because if it's not and integer they will never meet.

                if (jumpRate == 0 || location % jumpRate != 0)
                {
                    Console.WriteLine("They will never meet");
             
                }

                //calculate the time (point) of interception 
                var time = location / jumpRate;
               


                while (running)
                {
                    location1 = location1 + jumpRate1;

                    location2 =  location2 + jumpRate2;
      
                    //make sure it is not now or the past by getting 0 or negative numbers 
                    if (location1 == location2 && time != 0 && time > 0)
                    {
                        Console.WriteLine(location1 + " " + time);
                        break;
                    }


                }


                
   
           




        }
    }
}
