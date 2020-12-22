using Microsoft.VisualStudio.TestTools.UnitTesting;
using PAPI.Character.Characteristics;
using PAPI.DataTypes;

namespace PAPITests.Character.Characteristics
{
    [TestClass]
    public class CharacteristicTests
    {

        // --------------------------------------------------------------------------------------------------------------------------------
        // Constructor Tests
        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void CharacteristicCtor_WithMinValidValue_CreatesValidCharacteristic()
        {
            // Arrange
            CharacteristicEnum charaEnum = CharacteristicEnum.BRAWN;
            uint value = 1;
            Modification modification = new Modification(0, GameTimeInterval.NOT_VALID);

            // Act
            Characteristic testCharacteristic = new Characteristic(charaEnum, value, modification);

            // Assert
            Assert.AreEqual(CharacteristicEnum.BRAWN, testCharacteristic._associatedEnum, "Characteristic Enum was not assigned correcty");
            Assert.AreEqual(value, testCharacteristic._value, "Characteristic Value was not assigned correcty");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void CharacteristicCtor_WithMaxValidValue_CreatesValidCharacteristic()
        {
            // Arrange
            CharacteristicEnum charaEnum = CharacteristicEnum.AGILITY;
            uint value = 5;
            Modification modification = new Modification(0, GameTimeInterval.NOT_VALID);

            // Act
            Characteristic testCharacteristic = new Characteristic(charaEnum, value, modification);

            // Assert
            Assert.AreEqual(CharacteristicEnum.AGILITY, testCharacteristic._associatedEnum, "Characteristic Enum was not assigned correcty");
            Assert.AreEqual(value, testCharacteristic._value, "Characteristic Value was not assigned correcty");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void CharacteristicCtor_WithTooSmallValue_CreatesValidCharacteristicWithMinValue()
        {
            // Arrange
            CharacteristicEnum charaEnum = CharacteristicEnum.INTELLECT;
            uint value = 0;
            Modification modification = new Modification(0, GameTimeInterval.NOT_VALID);

            // Act
            Characteristic testCharacteristic = new Characteristic(charaEnum, value, modification);

            // Assert
            Assert.AreEqual(CharacteristicEnum.INTELLECT, testCharacteristic._associatedEnum, "Characteristic Enum was not assigned correcty");
            Assert.AreEqual(Characteristic.MIN_VALUE, testCharacteristic._value, "Characteristic Value was not assigned correcty");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void CharacteristicCtor_WithTooBigValue_CreatesValidCharacteristicWithMinValue()
        {
            // Arrange
            CharacteristicEnum charaEnum = CharacteristicEnum.CUNNING;
            uint value = 6;
            Modification modification = new Modification(0, GameTimeInterval.NOT_VALID);

            // Act
            Characteristic testCharacteristic = new Characteristic(charaEnum, value, modification);

            // Assert
            Assert.AreEqual(CharacteristicEnum.CUNNING, testCharacteristic._associatedEnum, "Characteristic Enum was not assigned correcty");
            Assert.AreEqual(Characteristic.MIN_VALUE, testCharacteristic._value, "Characteristic Value was not assigned correcty");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // Training Tests
        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void CharacteristicTraining_WithMinValue_ReturnsTrue()
        {
            // Arrange
            Characteristic testCharacteristic = new Characteristic(CharacteristicEnum.WILLPOWER, 1, null);

            // Assert
            Assert.AreEqual(true, testCharacteristic.Training(), "Characteristic Value didn't return the correct bool");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void CharacteristicTraining_WithValueOneSmallerThanMax_ReaturnsTrue()
        {
            // Arrange
            Characteristic testCharacteristic = new Characteristic(CharacteristicEnum.WILLPOWER, 4, null);

            // Assert
            Assert.AreEqual(true, testCharacteristic.Training(), "Characteristic Value didn't return the correct bool");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void CharacteristicTraining_WithAlreadyMax_ReturnsFalse()
        {
            // Arrange
            Characteristic testCharacteristic = new Characteristic(CharacteristicEnum.WILLPOWER, 5, null);

            // Assert
            Assert.AreEqual(false, testCharacteristic.Training(), "Characteristic Value didn't return the correct bool");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void CharacteristicTraining_WithMinValue_IncreasesValueBy1()
        {
            // Arrange
            Characteristic testCharacteristic = new Characteristic(CharacteristicEnum.WILLPOWER, 1, null);
            uint expectedValue = 2;

            // Act
            testCharacteristic.Training();

            // Assert
            Assert.AreEqual(expectedValue, testCharacteristic._value, "Characteristic Value didn't train correctly");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void CharacteristicTraining_WithValueOneSmallerThanMax_IncreasesValueBy1()
        {
            // Arrange
            Characteristic testCharacteristic = new Characteristic(CharacteristicEnum.WILLPOWER, 4, null);
            uint expectedValue = 5;

            // Act
            testCharacteristic.Training();

            // Assert
            Assert.AreEqual(expectedValue, testCharacteristic._value, "Characteristic Value didn't train correctly");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void CharacteristicTraining_WithAlreadyMax_DoesNotIncreaseValue()
        {
            // Arrange
            Characteristic testCharacteristic = new Characteristic(CharacteristicEnum.WILLPOWER, 5, null);
            uint expectedValue = 5;

            // Act
            testCharacteristic.Training();

            // Assert
            Assert.AreEqual(expectedValue, testCharacteristic._value, "Characteristic Value didn't train correctly");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // Training Cost Tests
        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void GetTrainingCost_WithValue1_ReturnsCorrectCost()
        {
            // Arrange
            Characteristic testCharacteristic = new Characteristic(CharacteristicEnum.PRESENCE, 1, null);
            uint expectedValue = 20;

            // Assert
            Assert.AreEqual(expectedValue, testCharacteristic.GetTrainingCost(), "Characteristic Training Cost wasn't calculated correctly");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void GetTrainingCost_WithValue2_ReturnsCorrectCost()
        {
            // Arrange
            Characteristic testCharacteristic = new Characteristic(CharacteristicEnum.PRESENCE, 2, null);
            uint expectedValue = 30;

            // Assert
            Assert.AreEqual(expectedValue, testCharacteristic.GetTrainingCost(), "Characteristic Training Cost wasn't calculated correctly");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void GetTrainingCost_WithValue3_ReturnsCorrectCost()
        {
            // Arrange
            Characteristic testCharacteristic = new Characteristic(CharacteristicEnum.PRESENCE, 3, null);
            uint expectedValue = 40;

            // Assert
            Assert.AreEqual(expectedValue, testCharacteristic.GetTrainingCost(), "Characteristic Training Cost wasn't calculated correctly");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void GetTrainingCost_WithValue4_ReturnsCorrectCost()
        {
            // Arrange
            Characteristic testCharacteristic = new Characteristic(CharacteristicEnum.PRESENCE, 4, null);
            uint expectedValue = 50;

            // Assert
            Assert.AreEqual(expectedValue, testCharacteristic.GetTrainingCost(), "Characteristic Training Cost wasn't calculated correctly");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void GetTrainingCost_WithValue5_ReturnsInvalidCost()
        {
            // Arrange
            Characteristic testCharacteristic = new Characteristic(CharacteristicEnum.PRESENCE, 5, null);
            uint expectedValue = 0;

            // Assert
            Assert.AreEqual(expectedValue, testCharacteristic.GetTrainingCost(), "Characteristic Training Cost wasn't calculated correctly");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // Is Maximized Tests
        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void IsMaximized_WithNotMaximizedCharacteristic_ReturnsFalse()
        {
            // Arrange
            Characteristic testCharacteristic = new Characteristic(CharacteristicEnum.PRESENCE, 4, null);
            bool expectedValue = false;

            // Assert
            Assert.AreEqual(expectedValue, testCharacteristic.IsMaximized(), "Characteristic IsMaximized didn't return the correct bool");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void IsMaximized_WithMaximizedCharacteristic_ReturnsTrue()
        {
            // Arrange
            Characteristic testCharacteristic = new Characteristic(CharacteristicEnum.PRESENCE, 5, null);
            bool expectedValue = true;

            // Assert
            Assert.AreEqual(expectedValue, testCharacteristic.IsMaximized(), "Characteristic IsMaximized didn't return the correct bool");
        }

        // --------------------------------------------------------------------------------------------------------------------------------


    }
}
