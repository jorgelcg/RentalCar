using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Moq;
using RentalCar.Controlles;
using System.Collections;
using Web.Api.Domain.Services;
using Web.Api.Infrastructure.Models;
using Xunit;

namespace Web.Api.Test
{
    public class UnitTest1
    {
        Mock mockCollection = new Mock<IMongoCollection<Vehicle>>();
        RentalCarController RentalCarController;
        RentSevice rentSevice;

        //Testing herbyid method
        [Fact]
        public async Task GetTest()
        {
            // Arrange

            Vehicle vehicle = new Vehicle();
            vehicle.Id = 1;
            vehicle.Type = "campero";
            vehicle.Brand = "mazda";
            vehicle.Color = "azul";
            vehicle.Location = "suba";
            vehicle.State = "disponible";
            vehicle.CantDay = 0;
            vehicle.Amount = 0;
            vehicle.Iduser = "1234";

            // Act
            IEnumerable RentSevices = (IEnumerable)RentalCarController.GetByLocation(vehicle.Location);


            // Assert
             Assert.Equal((IEnumerable<Vehicle>)vehicle, RentSevices);

        }
    }
}