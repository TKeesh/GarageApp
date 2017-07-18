using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace garageModel
{
    public class GarageRepositoryIndexOutOfRange : Exception
    {
    }
    public class GarageRepositoryDoesNotContainGarage : Exception
    {
    }
    public class GarageRepositoryContainsGarage : Exception
    {
    }
    public class DatabaseDoesNotExists : Exception
    {
    }
    public class AddGarageValuesOutOfRange : Exception
    {
    }
    public class GarageTypeParseFailed : Exception
    {
    }
    public class GarageAddressNotSpecified : Exception
    {
    }
    public class UserRepositoryContainsUser : Exception
    {
    }
    public class UserRepositoryDoesNotContainUser : Exception
    {
    }
    public class IncorrectPassword : Exception
    {
    }
    public class GarageIsFull : Exception
    {
    }
    public class GarageIsEmpty : Exception
    {
    }
    public class IndexVehicleOutOfRange : Exception
    {
    }
    public class TotalAmountLowerThenUsed : Exception
    {
    }
}
