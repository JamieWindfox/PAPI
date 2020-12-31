using Microsoft.VisualStudio.TestTools.UnitTesting;
using PAPI.Character.Characteristics;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAPITests.Character.Characteristics
{
    [TestClass]
    public class CharacteristicSetTests
    {
        private static int TEST_COUNT = 5;

        // --------------------------------------------------------------------------------------------------------------------------------
        // Constructor Tests
        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void CharacteristicSetCtor_WithNull_CreatesCharacteristicSetWithAll1()
        {
            // Arrange
            uint expectedValue = 1;

            // Act
            CharacteristicSet testSet = new CharacteristicSet(null);

            // Assert
            foreach(Characteristic chara in testSet._characteristicList)
            {
                Assert.AreEqual(expectedValue, chara._value,
                    chara._associatedEnum.ToString() + " haven't got the correct value (expected: " + expectedValue + ", assigned: " + chara._value + ")");
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void CharacteristicSetCtor_WithNotAllCharacteristics_CreatesValidCharacteristicSet()
        {
            // Arrange
            uint expectedAutoValue = 1;

            // Act
            CharacteristicSet testSet = new CharacteristicSet(new List<Characteristic>() {
                new Characteristic(CharacteristicEnum.BRAWN, 2, null)
            });

            // Assert
            foreach (Characteristic chara in testSet._characteristicList)
            {
                if (chara._associatedEnum != CharacteristicEnum.BRAWN)
                {
                    Assert.AreEqual(expectedAutoValue, chara._value,
                    chara._associatedEnum.ToString() + " haven't got the correct value (expected: " + expectedAutoValue + ", assigned: " + chara._value + ")");
                }
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void CharacteristicSetCtor_WithDoubleCharacteristics_CreatesValidCharacteristicSet()
        {
            // Arrange
            uint expectedAutoValue = 1;
            uint expectedBrawn = 2;

            // Act
            CharacteristicSet testSet = new CharacteristicSet(new List<Characteristic>() {
                new Characteristic(CharacteristicEnum.BRAWN, 2, null),
                new Characteristic(CharacteristicEnum.BRAWN, 3, null)
            });

            // Assert
            foreach (Characteristic chara in testSet._characteristicList)
            {
                if (chara._associatedEnum != CharacteristicEnum.BRAWN)
                {
                    Assert.AreEqual(expectedAutoValue, chara._value,
                    chara._associatedEnum.ToString() + " haven't got the correct value (expected: " + expectedAutoValue + ", assigned: " + chara._value + ")");
                }
                else
                {
                    Assert.AreEqual(expectedBrawn, chara._value,
                    chara._associatedEnum.ToString() + " haven't got the correct value (expected: " + expectedBrawn + ", assigned: " + chara._value + ")");
                }
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void CharacteristicSetCtor_WithInvalidCharacteristics_CreatesValidCharacteristicSet()
        {
            // Arrange
            uint expectedAutoValue = 1;

            // Act
            CharacteristicSet testSet = new CharacteristicSet(new List<Characteristic>() {
                new Characteristic(CharacteristicEnum.BRAWN, 0, null),
                new Characteristic(CharacteristicEnum.CUNNING, 6, null)
            });

            // Assert
            foreach (Characteristic chara in testSet._characteristicList)
            {
                Assert.AreEqual(expectedAutoValue, chara._value,
                chara._associatedEnum.ToString() + " haven't got the correct value (expected: " + expectedAutoValue + ", assigned: " + chara._value + ")");
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void CharacteristicSetCtor_WithTooManyCharacteristics_CreatesValidCharacteristicSet()
        {
            // Arrange
            uint expectedValue = 2;

            // Act
            CharacteristicSet testSet = new CharacteristicSet(new List<Characteristic>() {
                new Characteristic(CharacteristicEnum.BRAWN, 2, null),
                new Characteristic(CharacteristicEnum.BRAWN, 3, null),
                new Characteristic(CharacteristicEnum.AGILITY, 2, null),
                new Characteristic(CharacteristicEnum.CUNNING, 2, null),
                new Characteristic(CharacteristicEnum.PRESENCE, 2, null),
                new Characteristic(CharacteristicEnum.WILLPOWER, 2, null),
                new Characteristic(CharacteristicEnum.INTELLECT, 2, null),
                new Characteristic(CharacteristicEnum.INTELLECT, 4, null)
            }) ;

            // Assert
            foreach (Characteristic chara in testSet._characteristicList)
            {
                if (chara._associatedEnum != CharacteristicEnum.BRAWN)
                {
                    Assert.AreEqual(expectedValue, chara._value,
                    chara._associatedEnum.ToString() + " haven't got the correct value (expected: " + expectedValue + ", assigned: " + chara._value + ")");
                }
                Assert.IsTrue(testSet._characteristicList.Count == 6, 
                    "The testSet has the wrong number of elements (Expected: 6, Added: " + testSet._characteristicList.Count + ")");
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void CharacteristicSetCtor_WithAllValidCharacteristics_CreatesValidCharacteristicSet()
        {
            // Arrange
            uint expectedValue = 2;

            // Act
            CharacteristicSet testSet = new CharacteristicSet(new List<Characteristic>() {
                new Characteristic(CharacteristicEnum.BRAWN, 2, null),
                new Characteristic(CharacteristicEnum.AGILITY, 2, null),
                new Characteristic(CharacteristicEnum.CUNNING, 2, null),
                new Characteristic(CharacteristicEnum.PRESENCE, 2, null),
                new Characteristic(CharacteristicEnum.WILLPOWER, 2, null),
                new Characteristic(CharacteristicEnum.INTELLECT, 2, null)
            });

            // Assert
            foreach (Characteristic chara in testSet._characteristicList)
            {
                if (chara._associatedEnum != CharacteristicEnum.BRAWN)
                {
                    Assert.AreEqual(expectedValue, chara._value,
                    chara._associatedEnum.ToString() + " haven't got the correct value (expected: " + expectedValue + ", assigned: " + chara._value + ")");
                }
                Assert.IsTrue(testSet._characteristicList.Count == 6,
                    "The testSet has the wrong number of elements (Expected: 6, Added: " + testSet._characteristicList.Count + ")");
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // Get Characteristic Value from Enum
        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void GetCharacteristic_WithEnum_GetsCharacteristic()
        {
            // Arrange
            uint expectedBrawn = 2;
            uint expectedAgility = 2;
            uint expectedIntellect = 2;
            uint expectedCunning = 2;
            uint expectedWillpower = 2;
            uint expectedPresence = 2;

            // Act
            CharacteristicSet testSet = new CharacteristicSet(new List<Characteristic>() {
                new Characteristic(CharacteristicEnum.BRAWN, expectedBrawn, null),
                new Characteristic(CharacteristicEnum.AGILITY, expectedAgility, null),
                new Characteristic(CharacteristicEnum.CUNNING, expectedCunning, null),
                new Characteristic(CharacteristicEnum.PRESENCE, expectedPresence, null),
                new Characteristic(CharacteristicEnum.WILLPOWER, expectedWillpower, null),
                new Characteristic(CharacteristicEnum.INTELLECT, expectedIntellect, null)
            });

            // Assert
            Assert.AreEqual(expectedBrawn, testSet.Get(CharacteristicEnum.BRAWN)._value, 
                "BRAWN is not the expected Value (Expected: " + expectedBrawn + ", is: " + testSet.Get(CharacteristicEnum.BRAWN)._value);
            Assert.AreEqual(expectedAgility, testSet.Get(CharacteristicEnum.AGILITY)._value, 
                "AGILITY is not the expected Value (Expected: " + expectedAgility + ", is: " + testSet.Get(CharacteristicEnum.AGILITY)._value);
            Assert.AreEqual(expectedIntellect, testSet.Get(CharacteristicEnum.INTELLECT)._value, 
            "INTELLECT is not the expected Value (Expected: " + expectedIntellect + ", is: " + testSet.Get(CharacteristicEnum.INTELLECT)._value);
            Assert.AreEqual(expectedCunning, testSet.Get(CharacteristicEnum.CUNNING)._value, 
            "CUNNING is not the expected Value (Expected: " + expectedCunning + ", is: " + testSet.Get(CharacteristicEnum.CUNNING)._value);
            Assert.AreEqual(expectedWillpower, testSet.Get(CharacteristicEnum.WILLPOWER)._value, 
            "WILLPOWER is not the expected Value (Expected: " + expectedWillpower + ", is: " + testSet.Get(CharacteristicEnum.WILLPOWER)._value);
            Assert.AreEqual(expectedPresence, testSet.Get(CharacteristicEnum.PRESENCE)._value, 
            "PRESENCE is not the expected Value (Expected: " + expectedPresence + ", is: " + testSet.Get(CharacteristicEnum.PRESENCE)._value);

        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // Train given Characteristic
        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void TrainCharacteristic_WithValidCharacteristic_IncreasesTheCharacteristicValueBy1()
        {
            // Arrange
            CharacteristicSet testSet = new CharacteristicSet(new List<Characteristic>() {
                new Characteristic(CharacteristicEnum.BRAWN, 2, null),
                new Characteristic(CharacteristicEnum.AGILITY, 2, null),
                new Characteristic(CharacteristicEnum.CUNNING, 2, null),
                new Characteristic(CharacteristicEnum.PRESENCE, 2, null),
                new Characteristic(CharacteristicEnum.WILLPOWER, 2, null),
                new Characteristic(CharacteristicEnum.INTELLECT, 2, null)
            });

            uint expectedValue1 = 3;
            uint expectedValue2 = expectedValue1 + 1;

            // Act
            testSet.TrainCharacteristic(CharacteristicEnum.BRAWN);
            testSet.TrainCharacteristic(CharacteristicEnum.AGILITY);
            testSet.TrainCharacteristic(CharacteristicEnum.PRESENCE);
            testSet.TrainCharacteristic(CharacteristicEnum.INTELLECT);
            testSet.TrainCharacteristic(CharacteristicEnum.WILLPOWER);
            testSet.TrainCharacteristic(CharacteristicEnum.CUNNING);
            testSet.TrainCharacteristic(CharacteristicEnum.BRAWN);
            testSet.TrainCharacteristic(CharacteristicEnum.AGILITY);

            // Assert
            Assert.AreEqual(expectedValue2, testSet.Get(CharacteristicEnum.BRAWN)._value, "BRAWN is not the expected Value after training");
            Assert.AreEqual(expectedValue2, testSet.Get(CharacteristicEnum.AGILITY)._value, "AGILITY is not the expected Value after training");
            Assert.AreEqual(expectedValue1, testSet.Get(CharacteristicEnum.INTELLECT)._value, "INTELLECT is not the expected Value after training");
            Assert.AreEqual(expectedValue1, testSet.Get(CharacteristicEnum.CUNNING)._value, "CUNNING is not the expected Value after training");
            Assert.AreEqual(expectedValue1, testSet.Get(CharacteristicEnum.WILLPOWER)._value, "WILLPOWER is not the expected Value after training");
            Assert.AreEqual(expectedValue1, testSet.Get(CharacteristicEnum.PRESENCE)._value, "PRESENCE is not the expected Value after training");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void TrainCharacteristic_WithMaxedCharacteristic_DoesNotIncreasesTheCharacteristic()
        {
            // Arrange
            CharacteristicSet testSet = new CharacteristicSet(new List<Characteristic>() {
                new Characteristic(CharacteristicEnum.BRAWN, 5, null),
                new Characteristic(CharacteristicEnum.AGILITY, 2, null),
                new Characteristic(CharacteristicEnum.CUNNING, 2, null),
                new Characteristic(CharacteristicEnum.PRESENCE, 2, null),
                new Characteristic(CharacteristicEnum.WILLPOWER, 2, null),
                new Characteristic(CharacteristicEnum.INTELLECT, 2, null)
            });

            uint expectedValue = 5;

            // Act
            testSet.TrainCharacteristic(CharacteristicEnum.BRAWN);

            // Assert
            Assert.AreEqual(expectedValue, testSet.Get(CharacteristicEnum.BRAWN)._value, "BRAWN is not the expected Value after training");
        }

    }
}
