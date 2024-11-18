using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{

    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";
    public int carWeight = 1609;
    public int yearMade = 2009;
    public float maxAcceleration = 0.98f;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;

    int yearNow = 2024;

    public string carMaker;

    public class Fuel
    {
        public int fuelLevel;
        public Fuel(int amount)
        {
            fuelLevel = amount;
        }
    }

    public Fuel carFuel = new Fuel(100);

    void CheckWeight()
    {
        if (carWeight < 1500)
        {
            print("Car's weight is less than 1500");
        }
        else
        {
            print("Car's weight is over 1500");
        }
    }

    void CheckYear()
    {
        if (yearMade <= 2009)
        {
            print("Car was made in " + yearMade);
        } else
        {
            print("Car was made in the 2010s");
            print("Car's max acceleration rate is " + maxAcceleration);
        }

    }    

    int CalculateAge()
    {
        int result = yearNow - yearMade;
        return result;
    }

    string CheckSpecs()
    {
        if (isCarTypeSedan == true)
        {
            return "The car is a sedan type.";
        } else if (hasFrontEngine == true) {
            return "The car is not a sedan, but has a front engine.";
        } else
        {
            return "The car is neither a sedan, nor is its engine a front engine.";
        }
    }
    void ConsumeFuel()
    {
        carFuel.fuelLevel = carFuel.fuelLevel - 10;
    }

    void CheckFuelLevel()
    {
        switch (carFuel.fuelLevel)
        {
            case 70:
                print("Fuel level is nearing two-thirds.");
                break;
            case 50:
                print("Fuel level is at half amount.");
                break;
            case 10:
                print("Warning! Fuel level is critically low.");
                break;
            default:
                print("Nothing to report.");
                break;
        }
    }


    void Start()
    {
        print("This is a " + carMaker);
        print("It's a " + carModel + " model");
        print("And has this " + engineType + " engine");
        CheckWeight();
        CheckYear();

        int carAge = CalculateAge();
        print("Car is " + carAge + " years old");

        print(CheckSpecs());

    }



    void Update()
    {
          if (Input.GetKeyDown(KeyCode.Space))
        {
            ConsumeFuel();
            CheckFuelLevel();
        }
    }
}
