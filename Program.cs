namespace deliverable5_Methods
{
    internal class Program
    {
        //Establish the function randomArray
        static int[] randomArray(int array_length)
        {
            //Create variable random and each time random is used to intialize with a random number regardless of previous numbers drawn
            Random random   = new Random();

            //Create MyArray and with its length determined by array_length
            int[] MyArray = new int[array_length];

            //While i is less than array_length add a number to the array at i between the numbers 10 and 50
            for (int i = 0; i < array_length; i++)
            {
                MyArray[i] =  random.Next(10,50);
            }
            //Return the values stored in the Array when called
            return MyArray;
        }
        //Establish the function sum
        static int sum(int[] array)
        {
            //Initialize the variable sum with the value of 0
            int sum = 0;

            //Establish local variable item that grabs the numbers stored within an array to return its sum
            foreach(int item in array)
            {
                sum = sum + item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            //Ask the user for an input between 5 and 15
            Console.WriteLine("Write an integer between 5 and 15");
            //Use a try-catch block to catch any invalid inputs or expections
            try
            {
                //Not sure why this is giving a code CS8604. Please let me know.
                int input = int.Parse(Console.ReadLine());
                
                //Create an if statement to only accept inputs between the numbers 5 and 15
                if (input >= 5 && input <= 15)
                {

                    //Establish a local variable array that called the method randomArray to use input as array_length
                    int[] sampleArray = randomArray(input);
                    Console.WriteLine("The elements in the random array are: ");

                    //Establish variable element that stands for the values stored within the sampleArray and list them all out on the command prompt
                    foreach (int element in sampleArray)
                    {
                        Console.Write(element + " ");
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("The sum is: " + sum(sampleArray));

                }
                //Catch if any numbers entered that do not fit the input requirements
                else
                {
                    Console.WriteLine("Only numbers between 5 and 15");
                }
            }
            //Catch if anything other than whole numbers is entered into console
            catch
            {
                Console.WriteLine("Please enter only whole numbers between 5 and 15");
            }
        }
    }
}