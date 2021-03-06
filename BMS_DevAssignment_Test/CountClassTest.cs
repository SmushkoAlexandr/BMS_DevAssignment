﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BMS_DevAssignment;

namespace BMS_DevAssignment_Test
{
    [TestClass]
    public class CountClassTest
    {
        string loremIpsum = "Lorem ipsum dolor sit amet, no nonumy numquam detraxit pri. " +
                "No nam impetus integre inermis, qui dictas aeterno aliquip in. Te sit sapientem persecuti. " +
                "Vel choro altera dolorem in. Te vel congue voluptua.";
        int expected, actual;

        [TestMethod]
        public void GetWordsByLength_LoremIpsum_5characters_()
        {
            //arrange
            
            int characterNumber = 5;
            expected = 4;

            // act
            actual = CountClass.GetWordsByLength(loremIpsum, characterNumber);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetCharacterOccurrences_LoremIpsum_L_8charakter()
        {
            expected = 8;

            actual = CountClass.GetCharacterOccurrences(loremIpsum, 'l');

            Assert.AreEqual(expected, actual);
        }
    }
}
