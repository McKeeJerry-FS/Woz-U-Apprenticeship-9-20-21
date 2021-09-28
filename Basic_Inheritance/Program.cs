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
    public string MotorCycleType;
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

        // try to attach a parent to a child
        v = a;    // auto is supposed to be derived from vehicle
        mv = a;   // auto is supposed to be derived from motorized vehicle
        mv = m;   // motorcycle is supposed to be derived from motorized vehicle
        v = b;    // bicycle is supposed to be derived from vehicle
        // b = m;    // supposed to fail.  cannot connect siblings like bicycle and motorcycle.  will need to comment this line out


        Console.WriteLine("Success");
    }
}