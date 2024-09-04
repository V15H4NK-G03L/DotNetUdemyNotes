

namespace UdemyBiz
{
    public class Overspeeding
    {
        public void SpeedCheck(int yourSpeed, int speedLimit)
        {
            if (yourSpeed <= speedLimit)
            {
                Console.WriteLine("Speed OK. Keep Driving!");
            }
            else
            {
                Console.WriteLine("Overspeeding Detected!");

                var demeritPoints = (yourSpeed - speedLimit) / 5;
                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended!");
                }
                else
                {
                    Console.WriteLine("License Still Active.");
                }

            }
        }
    }
}
