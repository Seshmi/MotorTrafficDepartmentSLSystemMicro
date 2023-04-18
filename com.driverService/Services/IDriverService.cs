﻿namespace com.driverService.Services
{
    public interface IDriverService
    {
        List<Models.Driver> GetDrivers();
        Models.Driver? GetDriver(int Id);
        Models.Driver? AddDriver(Models.Driver driver);
        Models.Driver UpdateDriver(Models.Driver driver);
        bool? DeleteDriver(int Id);
    }
}
