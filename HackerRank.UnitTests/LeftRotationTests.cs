﻿using HackerRank.Solutions;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.UnitTests
{
    [TestClass]
    public class LeftRotationTests
    {
        private LeftRotation _solution;

        [TestInitialize]
        public void TestInitialize()
        {
            _solution = new LeftRotation();
        }

        [TestMethod]
        public void RotateLeft_Scenario1_Rotate2Times()
        {
            //Arrange
            int[] firstArray = new int[] { 1, 2, 3, 4, 5 };
            int rotations = 2;
            int[] expected = new int[] { 3, 4, 5, 1, 2 };

            //Act
            var actual = _solution.RotateLeft(firstArray, rotations);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RotateLeft_ShouldRotate_4Times()
        {
            //Arrange
            int[] firstArray = new[] { 1, 2, 3, 4, 5 };
            int rotations = 4;
            int[] expected = new[] { 5, 1, 2, 3, 4 };
            //Act
            int[] actual = _solution.RotateLeft(firstArray, rotations);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RotateLeft_ShouldRotate_10Times()
        {
            //Arrange
            int[] firstArray = new[] { 41, 73, 89, 7, 10, 1, 59, 58, 84, 77, 77, 97, 58, 1, 86, 58, 26, 10, 86, 51 };
            int rotations = 10;
            int[] expected = new[] { 77, 97, 58, 1, 86, 58, 26, 10, 86, 51, 41, 73, 89, 7, 10, 1, 59, 58, 84, 77 };
            //Act
            int[] actual = _solution.RotateLeft(firstArray, rotations);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
