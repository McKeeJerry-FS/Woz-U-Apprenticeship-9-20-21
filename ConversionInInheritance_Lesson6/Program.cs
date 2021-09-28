using System;

class Vehicle
{
    public int PassengerCapacity;
}

class Bicycle : Vehicle
{
    public int NumberOfSpeeds;
}

class MotorizedVehicle : Vehicle
{
    public int FuelCapacity;
}

class MotorCycle : MotorizedVehicle
{
    public string MotorcycleType;
}

class Auto : MotorizedVehicle
{
    public string Make;
    public string Model;
}

class StudentProgram
{
    public static void Main()
    {
        Vehicle v = new Vehicle();
        Bicycle b = new Bicycle();
        MotorizedVehicle mv = new MotorizedVehicle();
        MotorCycle m = new MotorCycle();
        Auto a = new Auto();

        // try some implicit conversions
        v = a;    // auto is supposed to be derived from vehicle
        mv = a;   // auto is supposed to be derived from motorized vehicle
        mv = m;   // motorcycle is supposed to be derived from motorized vehicle
        v = b;    // bicycle is supposed to be derived from vehicle

        // try some explicit conversions

        v = a;  // should work (an auto is a motorized vehicle.  implicit conversion)
        Console.WriteLine("mv = (MotorizedVehicle) v; ");
        mv = (MotorizedVehicle)v;  // should work.  v is attached to an auto which is derived from motorized vehicle

        v = b;  // should work (a bicycle is a vehicle)
        Console.WriteLine("mv = (MotorizedVehicle) v; ");
        // NOTE: The following line will issue this error at RUNTIME: 
        //           Unhandled exception. System.InvalidCastException: Unable to cast object of type 'Bicycle' to type 'MotorizedVehicle'.
        //           at StudentProgram.StudentTest() in C:\Users\brian\source\repos\Vehicles\Vehicles\Program.cs:line XX
        //           at program.Main() in C:\Users\brian\source\repos\Vehicles\Vehicles\Program.cs:line YY
        //   Comment out the line after running the code to see the exception
        // mv = (MotorizedVehicle)v;  // should not work. v is attached to a bicycle which is not derived from vehicle.  comment out this line after testing.


        // try some AS conversions

        v = a;  // should work (an auto is a motorized vehicle.  implicit conversion)
        mv = v as MotorizedVehicle;  // should work.  v is attached to an auto which is derived from motorized vehicle.  mv is attached
        Console.WriteLine($"mv =  v as MotorizedVehicle: '{mv}' ");

        v = b;  // should work (a bicycle is a motorized vehicle.  implicit conversion)
        mv = v as MotorizedVehicle;  // should Not work.  v is attached to a bicycle which is NOT derived from motorized vehicle.  mv is null
        Console.WriteLine($"mv =  v as MotorizedVehicle: '{mv}' ");


        // try some IS conversions

        bool test;

        v = a;  // should work (an auto is a motorized vehicle.  implicit conversion)
        test = v is MotorizedVehicle;  // should work.  v is attached to an auto which is derived from motorized vehicle.  test is 'true'
        Console.WriteLine($"test =  v is MotorizedVehicle: '{test}' ");

        v = b;  // should work (a bicycle is a motorized vehicle.  implicit conversion)
        test = v is MotorizedVehicle;  // should Not work.  v is attached to a bicycle which is NOT derived from motorized vehicle.  test is 'false'
        Console.WriteLine($"test =  v as MotorizedVehicle: '{test}' ");



        Console.WriteLine("Success");

    }
}