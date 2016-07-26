using Entities.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;
using System.Linq;

namespace Tests.Services
{
    [TestClass]
    public class VehicleOperationTests
    {
        [TestMethod]
        public void Can_TransferTruck_FAIL_BAD_DESTINATION()
        {
            // arrange
            var vehicleOps = new VehicleOperations();

            // act
            var retVal = vehicleOps.TransferVehicle(new Truck { VehicleStatus = VehicleStatusEnum.InRepair }, new DistributionCenter(), new Branch());

            // assert
            Assert.IsTrue(retVal.Results.Count == 0, "Expected no results to be returned");
            Assert.IsTrue(retVal.Messages.Count == 1, "Expected the message count to be one and only one");
            Assert.IsTrue(retVal.Messages.Where(x => x.MessageLevel == Entities.FrameworkObjects.OperationMessageLevelEnum.Error).ToList().Count == 1, "Expected one and only one success message to be returned");
        }

        [TestMethod]
        public void Can_TransferTruck_FAIL_BAD_ORIGIN()
        {
            // arrange
            var vehicleOps = new VehicleOperations();

            // act
            var retVal = vehicleOps.TransferVehicle(new Truck { VehicleStatus = VehicleStatusEnum.InRepair }, new Branch(), new DistributionCenter());

            // assert
            Assert.IsTrue(retVal.Results.Count == 0, "Expected no results to be returned");
            Assert.IsTrue(retVal.Messages.Count == 1, "Expected the message count to be one and only one");
            Assert.IsTrue(retVal.Messages.Where(x => x.MessageLevel == Entities.FrameworkObjects.OperationMessageLevelEnum.Error).ToList().Count == 1, "Expected one and only one success message to be returned");
        }

        [TestMethod]
        public void Can_TransferTruck_FAIL_BAD_STATUS()
        {
            // arrange
            var vehicleOps = new VehicleOperations();

            // act
            var retVal = vehicleOps.TransferVehicle(new Truck { VehicleStatus = VehicleStatusEnum.InRepair }, new Branch(), new Branch());

            // assert
            Assert.IsTrue(retVal.Results.Count == 0, "Expected no results to be returned");
            Assert.IsTrue(retVal.Messages.Count == 1, "Expected the message count to be one and only one");
            Assert.IsTrue(retVal.Messages.Where(x => x.MessageLevel == Entities.FrameworkObjects.OperationMessageLevelEnum.Error).ToList().Count == 1, "Expected one and only one success message to be returned");
        }

        [TestMethod]
        public void Can_TransferTruck_SUCCESS()
        {
            // arrange
            var vehicleOps = new VehicleOperations();

            // act
            var retVal = vehicleOps.TransferVehicle(new Truck { VehicleStatus = VehicleStatusEnum.StandBy }, new Branch(), new Branch());

            // assert
            Assert.IsTrue(retVal.Results.Count == 1, "Expected one and only one result to be returned");
            Assert.IsTrue(retVal.Messages.Count == 1, "Expected the message count to be one and only one");
            Assert.IsTrue(retVal.Messages.Where(x => x.MessageLevel == Entities.FrameworkObjects.OperationMessageLevelEnum.Success).ToList().Count == 1, "Expected one and only one success message to be returned");
        }    

        [TestMethod]
        public void Can_TransferVan_FAIL_BAD_DESTINATION()
        {
            // arrange
            var vehicleOps = new VehicleOperations();

            // act
            var retVal = vehicleOps.TransferVehicle(new Van { VehicleStatus = VehicleStatusEnum.InRepair }, new DistributionCenter(), new Branch());

            // assert
            Assert.IsTrue(retVal.Results.Count == 0, "Expected no results to be returned");
            Assert.IsTrue(retVal.Messages.Count == 1, "Expected the message count to be one and only one");
            Assert.IsTrue(retVal.Messages.Where(x => x.MessageLevel == Entities.FrameworkObjects.OperationMessageLevelEnum.Error).ToList().Count == 1, "Expected one and only one success message to be returned");
        }

        [TestMethod]
        public void Can_TransferVan_FAIL_BAD_ORIGIN()
        {
            // arrange
            var vehicleOps = new VehicleOperations();

            // act
            var retVal = vehicleOps.TransferVehicle(new Van { VehicleStatus = VehicleStatusEnum.InRepair }, new Branch(), new DistributionCenter());

            // assert
            Assert.IsTrue(retVal.Results.Count == 0, "Expected no results to be returned");
            Assert.IsTrue(retVal.Messages.Count == 1, "Expected the message count to be one and only one");
            Assert.IsTrue(retVal.Messages.Where(x => x.MessageLevel == Entities.FrameworkObjects.OperationMessageLevelEnum.Error).ToList().Count == 1, "Expected one and only one success message to be returned");
        }

        [TestMethod]
        public void Can_TransferVan_FAIL_BAD_STATUS()
        {
            // arrange
            var vehicleOps = new VehicleOperations();

            // act
            var retVal = vehicleOps.TransferVehicle(new Van { VehicleStatus = VehicleStatusEnum.InRepair }, new Branch(), new Branch());

            // assert
            Assert.IsTrue(retVal.Results.Count == 0, "Expected no results to be returned");
            Assert.IsTrue(retVal.Messages.Count == 1, "Expected the message count to be one and only one");
            Assert.IsTrue(retVal.Messages.Where(x => x.MessageLevel == Entities.FrameworkObjects.OperationMessageLevelEnum.Error).ToList().Count == 1, "Expected one and only one success message to be returned");
        }

        [TestMethod]
        public void Can_TransferVan_SUCCESS()
        {
            // arrange
            var vehicleOps = new VehicleOperations();

            // act
            var retVal = vehicleOps.TransferVehicle(new Van { VehicleStatus = VehicleStatusEnum.StandBy }, new Branch(), new Branch());

            // assert
            Assert.IsTrue(retVal.Results.Count == 1, "Expected one and only one result to be returned");
            Assert.IsTrue(retVal.Messages.Count == 1, "Expected the message count to be one and only one");
            Assert.IsTrue(retVal.Messages.Where(x => x.MessageLevel == Entities.FrameworkObjects.OperationMessageLevelEnum.Success).ToList().Count == 1, "Expected one and only one success message to be returned");
        }

        [TestMethod]
        public void Can_TransferSemi_FAIL_BAD_DESTINATION()
        {
            // arrange
            var vehicleOps = new VehicleOperations();

            // act
            var retVal = vehicleOps.TransferVehicle(new Semi { VehicleStatus = VehicleStatusEnum.StandBy }, new Branch(), new DistributionCenter());

            // assert
            Assert.IsTrue(retVal.Results.Count == 0, "Expected no results to be returned");
            Assert.IsTrue(retVal.Messages.Count == 1, "Expected the message count to be one and only one");
            Assert.IsTrue(retVal.Messages.Where(x => x.MessageLevel == Entities.FrameworkObjects.OperationMessageLevelEnum.Error).ToList().Count == 1, "Expected one and only one success message to be returned");
        }

        [TestMethod]
        public void Can_TransferSemi_FAIL_BAD_ORIGIN()
        {
            // arrange
            var vehicleOps = new VehicleOperations();

            // act
            var retVal = vehicleOps.TransferVehicle(new Semi { VehicleStatus = VehicleStatusEnum.StandBy }, new DistributionCenter(), new Branch());

            // assert
            Assert.IsTrue(retVal.Results.Count == 0, "Expected no results to be returned");
            Assert.IsTrue(retVal.Messages.Count == 1, "Expected the message count to be one and only one");
            Assert.IsTrue(retVal.Messages.Where(x => x.MessageLevel == Entities.FrameworkObjects.OperationMessageLevelEnum.Error).ToList().Count == 1, "Expected one and only one success message to be returned");
        }

        [TestMethod]
        public void Can_TransferSemi_FAIL_BAD_STATUS()
        {
            // arrange
            var vehicleOps = new VehicleOperations();

            // act
            var retVal = vehicleOps.TransferVehicle(new Semi { VehicleStatus = VehicleStatusEnum.InRepair }, new DistributionCenter(), new DistributionCenter());

            // assert
            Assert.IsTrue(retVal.Results.Count == 0, "Expected no results to be returned");
            Assert.IsTrue(retVal.Messages.Count == 1, "Expected the message count to be one and only one");
            Assert.IsTrue(retVal.Messages.Where(x => x.MessageLevel == Entities.FrameworkObjects.OperationMessageLevelEnum.Error).ToList().Count == 1, "Expected one and only one success message to be returned");
        }

        [TestMethod]
        public void Can_TransferSemi_SUCCESS()
        {
            // arrange
            var vehicleOps = new VehicleOperations();

            // act
            var retVal = vehicleOps.TransferVehicle(new Semi { VehicleStatus = VehicleStatusEnum.StandBy }, new DistributionCenter(), new DistributionCenter());

            // assert
            Assert.IsTrue(retVal.Results.Count == 1, "Expected one and only one result to be returned");
            Assert.IsTrue(retVal.Messages.Count == 1, "Expected the message count to be one and only one");
            Assert.IsTrue(retVal.Messages.Where(x => x.MessageLevel == Entities.FrameworkObjects.OperationMessageLevelEnum.Success).ToList().Count == 1, "Expected one and only one success message to be returned");
        }
    }
}