using System;
using System.Diagnostics;

class Checker
{
    static bool batteryIsOk(float temperature, float soc, float chargeRate) {            
        return (tempInRange(temperature)&&(socInRange(soc))&&chargeRateInRange(chargeRate));
    }
    
    static void printToConsole(string message)
    {
        Console.WriteLine(message);
    }

    static bool socInRange(float soc)
    {
        bool result= false;
        if(soc<20||soc>80)
            return result;
        else
            return true;
                       
            
        //if(result==false)
            //printToConsole("State of Charge is out of range!");
        return result;
        
    }    
    
    static bool tempInRange(float temp)
    {
        bool result= (temp<0||temp>45)?false:true;
        //if(result==false)
            //printToConsole("Temperature is out of range !");
        return result;
    }
    static bool chargeRateInRange(float chargeRate)
    {
        
        bool result= (chargeRate>0.8)?false:true;
        //if(result==false)
            //printToConsole("Charge Rate is out of range!");
        return result;
    
    }

    static void ExpectTrue(bool expression) {
        if(!expression) {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }
    static void ExpectFalse(bool expression) {
        if(expression) {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    }
    static int Main() {
        ExpectTrue(batteryIsOk(25, 70, 0.7f));
        ExpectFalse(batteryIsOk(50, 85, 0.0f));
        Console.WriteLine("All ok");
        return 0;
    }
}
