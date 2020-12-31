using Microsoft.VisualStudio.TestTools.UnitTesting;
using PAPI.Character.Characteristics;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAPITests.Character.Characteristics
{
    [TestClass]
    public class CharacteristicFactoryTests
    {
        private static int TEST_COUNT = 5;

        // --------------------------------------------------------------------------------------------------------------------------------
        // BaseCharacteristicList Tests
        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void BaseCharacteristicList_WithNoParams_CreatesCharacteristicListWith6Entries()
        {
            // Arrange
            List<Characteristic> testList = new List<Characteristic>();
            int expectedListSize = 6;

            // Act
            testList = CharacteristicFactory.BaseCharacteristicList();

            // Assert
            Assert.AreEqual(expectedListSize, testList.Count, "Characteristic List has an incorrect size (" + testList.Count + ")");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void BaseCharacteristicList_WithNoParams_CreatesBasicCharacteristics()
        {
            // Arrange
            List<Characteristic> testList = new List<Characteristic>();
            uint expectedValue = 1;

            // Act
            testList = CharacteristicFactory.BaseCharacteristicList();

            // Assert
            foreach(Characteristic testCharacteristic in testList)
            {
                Assert.AreEqual(expectedValue, testCharacteristic._value, "Characteristic has an incorrect value (" + testCharacteristic._associatedEnum 
                    + ": " +  testCharacteristic._value + ")");
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // Random Characteristics Tests
        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void RandomCharacteristicSet_WithValue0_CreatesValidCompletelyRandomCharacteristicSet()
        {
            // Arrange
            int testValue = 0;
            int minValue = 6;
            int maxValue = 36;
            
            for(int i = 0; i < TEST_COUNT; ++i)
            {
                // Act
                CharacteristicSet testSet = CharacteristicFactory.RandomCharacteristicSet(testValue);

                // Assert
                Assert.IsTrue(SumValues(testSet) >= minValue && SumValues(testSet) <= maxValue, "An invalid sum of characteristics was created (" + SumValues(testSet) + ")");
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void RandomCharacteristicSet_WithValue5_CreatesValidCompletelyRandomCharacteristicSet()
        {
            // Arrange
            int testValue = 5;
            int minValue = 6;
            int maxValue = 36;

            for (int i = 0; i < TEST_COUNT; ++i)
            {
                // Act
                CharacteristicSet testSet = CharacteristicFactory.RandomCharacteristicSet(testValue);

                // Assert
                Assert.IsTrue(SumValues(testSet) >= minValue && SumValues(testSet) <= maxValue, "An invalid sum of characteristics was created (" + SumValues(testSet) + ")");
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void RandomCharacteristicSet_WithValue6_CreatesValidCharacteristicSet()
        {
            // Arrange
            int testValue = 6;
            int minValue = 6;
            int maxValue = 6;

            for (int i = 0; i < TEST_COUNT; ++i)
            {
                // Act
                CharacteristicSet testSet = CharacteristicFactory.RandomCharacteristicSet(testValue);

                // Assert
                Assert.IsTrue(SumValues(testSet) >= minValue && SumValues(testSet) <= maxValue, "An invalid sum of characteristics was created (" + SumValues(testSet) + ")");
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void RandomCharacteristicSet_WithValue10_CreatesValidCharacteristicSet()
        {
            // Arrange
            int testValue = 10;
            int minValue = 10;
            int maxValue = 10;

            for (int i = 0; i < TEST_COUNT; ++i)
            {
                // Act
                CharacteristicSet testSet = CharacteristicFactory.RandomCharacteristicSet(testValue);

                // Assert
                Assert.IsTrue(SumValues(testSet) >= minValue && SumValues(testSet) <= maxValue, "An invalid sum of characteristics was created (" + SumValues(testSet) + ")");
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void RandomCharacteristicSet_WithValue20_CreatesValidCharacteristicSet()
        {
            // Arrange
            int testValue = 20;
            int minValue = 20;
            int maxValue = 20;

            for (int i = 0; i < TEST_COUNT; ++i)
            {
                // Act
                CharacteristicSet testSet = CharacteristicFactory.RandomCharacteristicSet(testValue);

                // Assert
                Assert.IsTrue(SumValues(testSet) >= minValue && SumValues(testSet) <= maxValue, "An invalid sum of characteristics was created (" + SumValues(testSet) + ")");
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void RandomCharacteristicSet_WithValue30_CreatesValidCharacteristicSet()
        {
            // Arrange
            int testValue = 30;
            int minValue = 30;
            int maxValue = 30;

            for (int i = 0; i < TEST_COUNT; ++i)
            {
                // Act
                CharacteristicSet testSet = CharacteristicFactory.RandomCharacteristicSet(testValue);

                // Assert
                Assert.IsTrue(SumValues(testSet) >= minValue && SumValues(testSet) <= maxValue, "An invalid sum of characteristics was created (" + SumValues(testSet) + ")");
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void RandomCharacteristicSet_WithValue31_CreatesValidCompletelyRandomCharacteristicSet()
        {
            // Arrange
            int testValue = 31;
            int minValue = 6;
            int maxValue = 30;

            for (int i = 0; i < TEST_COUNT; ++i)
            {
                // Act
                CharacteristicSet testSet = CharacteristicFactory.RandomCharacteristicSet(testValue);

                // Assert
                Assert.IsTrue(SumValues(testSet) >= minValue && SumValues(testSet) <= maxValue, "An invalid sum of characteristics was created (" + SumValues(testSet) + ")");
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // Helper Methods
        // --------------------------------------------------------------------------------------------------------------------------------

        private int SumValues(CharacteristicSet testSet)
        {
            int sumValues = 0;
            foreach (Characteristic chara in testSet._characteristicList)
            {
                sumValues += (int)chara._value;
            }
            return sumValues;
        }
    }
}
