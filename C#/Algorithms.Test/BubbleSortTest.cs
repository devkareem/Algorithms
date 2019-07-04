using Algorithms.Implementation.BubbleSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algorithems.Test
{
    public class BubbleSortTest
    {
        
        [Fact]
        public void Sort_HappyScenario()
        {
            //Arrange
            BubbleSort bubbleSort = new BubbleSort();
            int[] intArray = new int[] { 20, 35, -15, 7, 55, 1, -22 };
            int[] assertArray = new int[] { -22, -15, 1, 7, 20, 35, 55 };

            //Act
            var result=bubbleSort.Sort(intArray);
            //Assert
            Assert.Equal(result, assertArray);
        }

        [Fact]
        public void Sort_NullValue()
        {
            //Arrange
            BubbleSort bubbleSort = new BubbleSort();
            int[] intArray = null;
            var assertMessage = new ArgumentNullException("Int Array", "don't allow to you pass null value for this Method");
            //Act
            var expation = Assert.Throws<ArgumentNullException>(()=>bubbleSort.Sort(intArray));
            //Assert
            Assert.Equal(assertMessage.Message, expation.Message);
        }
        [Fact]
        public void Sort_With_Length_Of_One()
        {
            //Arrange
            BubbleSort bubbleSort = new BubbleSort();
            int[] intArray = new int[] { 20};
            int[] assertArray = new int[] { 20 };
            //Act
            var result = bubbleSort.Sort(intArray);
            //Assert
            Assert.Equal(result, assertArray);
        }
    }
}
