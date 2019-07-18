using System;
namespace Test.Exercise12
{
    public class ComputerFactoryMethod
    {
        public ComputerFactoryMethod()
        {
        }


        public Computer GetComputer(string computerType)
        {
            if (computerType == "Gaming")
            {
                ComputerBuilder temp = new GamerComputerBuilder();
                temp.Buildcomputer();

                return temp.GetComputer();
            }
            else if (computerType == "Office")
            {
                ComputerBuilder temp = new OfficeComputerBuilder();
                temp.Buildcomputer();

                return temp.GetComputer();
            }
            else if (computerType == "Salon")
            {
                ComputerBuilder temp = new SalonComputerBuilder();
                temp.Buildcomputer();

                return temp.GetComputer();
            }

            throw (new Exception("Invalid computer type"));
        }
    }
}

