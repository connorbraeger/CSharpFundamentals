﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void CookieTests()
        {
            Cookie cookie = new Cookie();
            cookie.Name = "Snickerdoodle";
            cookie.HasNuts = false;
            Cookie anotherCookie = new Cookie();
            anotherCookie.Name = "Something else";

            Cookie snickerdoodle = new Cookie("snickerdoodle", false, 11.5);
            Cookie newCookie = new Cookie("Peanut Butter", true, 150);

        }
        [TestMethod]
        public void VehicleTests()//test m tab tab
        {
            Vehicle car = new Vehicle();
            car.TypeOfVehicle = VehicleType.Car;
            Vehicle newCar = new Vehicle//Object intialization syntax
            {
                TypeOfVehicle = VehicleType.Motorcycle,
                Make = "Honda",
            Model = "Civic"
            };
        }
    }
}
