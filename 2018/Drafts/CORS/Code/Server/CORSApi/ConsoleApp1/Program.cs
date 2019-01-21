using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Type a = new 

            //A obj = new A();
            //bool b = obj is ITest;

            Console.WriteLine("Hello World!");
        }

        
    }

    public interface ITest
    {
    }

    public class A : ITest
    {

    }

    public class FlightNumber
    {
        
        private FlightNumber()
        {
            // Don't delete the Private parameterless Constructor.
            // It is required for the deserialization of the Flight Number.
        }

        public FlightNumber(int flightNumber) : this(flightNumber, CarrierCode.UA)
        {
        }

        public FlightNumber(string flightNumberString) : this(flightNumberString, CarrierCode.UA)
        {
            
        }

        public FlightNumber(string flightNumberString, CarrierCode carrierCode)
        {
            if (int.TryParse(flightNumberString, out int flightNumber))
            {
                Initialize(flightNumber, carrierCode);
            }
            else 
            {
                throw new ArgumentException(nameof(flightNumberString), "Flight number is not valid.");
            }
        }

        //public FlightNumber(int number, string carrierCode)
        //{
        //    Initialize(number, carrierCode);
        //}

        public FlightNumber(int flightNumber, CarrierCode carrierCode)
        {
            Initialize(flightNumber, carrierCode);
        }

        public FlightNumber(FlightNumber otherFlightNumber)
        {
            this.CarrierCode = otherFlightNumber.CarrierCode;
            this.Number = otherFlightNumber.Number;
        }

        private void Initialize(int flightNumber, CarrierCode carrierCode)
        {
            this.Number = flightNumber;
            this.CarrierCode = carrierCode;
        }

        public CarrierCode CarrierCode { get; private set; }

        private int _number;

        public int Number 
        {
            get => _number;
            set
            {
                if (value > 0 && value < 10000) 
                {
                    _number = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(Number), "Flight number is not valid.");
                }
            }
        }
    }

    public class CarrierCode 
    {
        // ReSharper disable once InconsistentNaming
        public static readonly CarrierCode UA = new CarrierCode("UA");

        public static readonly CarrierCode UAX = new CarrierCode("UAX");

        public string Name { get; private set; }

        public CarrierCode(string name)
        {
            if (name.Length > 3)
            {
                throw new ArgumentException("Not a Valid Carrier Code. Carrier Code are always 2 or 3 digits");
            }

            this.Name = name;
        }


        public override string ToString()
        {
            return this.Name;
        }

        // User-defined conversion from CarrierCode to string
        //public static implicit operator string(CarrierCode carrierCode)
        //{
        //    return carrierCode.Name;
        //}
        ////  User-defined conversion from string to CarrierCode
        //public static implicit operator CarrierCode(string inputCarrierCode)
        //{
        //    return new CarrierCode(inputCarrierCode);
        //}

    }
}
