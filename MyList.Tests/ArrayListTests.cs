using NUnit.Framework;
using System.Collections;
using MyArrayList;
using System;
using MyList.Tests.MyListTestSources;

namespace MyList.Tests
{
    public class Tests
    {
        [TestCaseSource(typeof(DeleteEveryElementByValueTestSource))]
        public void DeleteEveryElementByValueTest(int value, AList list, AList expectedList, int expectedNumber)
        {
            int actualNumber = list.DeleteEveryElementByValue(value);

            AList arrayList = list;

            Assert.AreEqual(expectedNumber, actualNumber);
            Assert.AreEqual(expectedList, arrayList);
        }

        [TestCaseSource(typeof(AddLastTestSource))]
        public void AddLastTest(int value, AList list, AList expectedList)
        {
            list.AddLast(value);

            AList arrayList = list;

            Assert.AreEqual(expectedList, arrayList);
        }

        [TestCaseSource(typeof(AddFirstTestSource))]
        public void AddFirstTest(int value, AList list, AList expectedList)
        {
            list.AddFirst(value);

            AList arrayList = list;

            Assert.AreEqual(expectedList, arrayList);
        }

        [TestCaseSource(typeof(InsertByIndexTestSource))]
        public void InsertByIndexTest(int value, int index, AList list, AList expectedList)
        {
            list.InsertByIndex(value, index);

            AList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ArrayDoesNotHaveThisIndexTestSource))]
        public void InsertByIndexTest_WhenListIsEmpty_ShouldTrowException(int value, int index, AList list)
        {
           
            Assert.Throws<Exception>(() => list.InsertByIndex(value, index));
        }

        [TestCaseSource(typeof(DeleteLastTestSource))]
        public void DeleteLastTest(AList list, AList expectedList)
        {
            list.DeleteLast();

            AList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }

        [Test]
        public void DeleteLastTest_WhenListIsEmpty_ShoudThrowException()
        {
            AList list = new AList();
            Assert.Throws<Exception>(() => list.DeleteLast());
        }

        [TestCaseSource(typeof(DeleteFirstTestSource))]
        public void DeleteFirstTest(AList list, AList expectedList)
        {
            list.DeleteFirst();

            AList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }

        [Test]
        public void DeleteFirstTest_WhenListIsEmpty_ShoudThrowException()
        {
            AList list = new AList();
            Assert.Throws<Exception>(() => list.DeleteFirst());
        }

        [TestCaseSource(typeof(DeleteByIndexTestSource))]
        public void DeleteByIndexTest(int index, AList list, AList expectedList)
        {
            list.DeleteByIndex(index);

            AList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(IndexDoesNotExistTestSourse))]
        public void DeleteByIndex_WhenIndexDoesNotExist_ShouldThrowException(int index, AList list)
        {
            Assert.Throws<Exception>(() => list.DeleteByIndex(index));
        }

        [TestCaseSource(typeof(ArrayIsEmptyWithAmountTestSource))]
        public void DeleteFewElementsFromStart_WhenListIsEmpty_ShouldThrowException(int index, AList list)
        {
            Assert.Throws<Exception>(()=>list.DeleteByIndex(index));
        }

        [TestCaseSource(typeof(ArrayDoesNotHaveThisIndexTestSourceThatMuchElementsTestSource))]
        public void DeleteFewElementsFromStart_WhenAmountMoreThanLength_ShouldThrowExeption(int amount, AList list)
        {
            Assert.Throws<Exception>(()=>list.DeleteFewElementsFromStart(amount));
        }

        [TestCaseSource(typeof(DeleteFewElementsFromStartTestSource))]
        public void DeleteFewElementsFromStartTest(int amount, AList list, AList expectedList)
        {
            list.DeleteFewElementsFromStart(amount);

            AList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFewElementsFromTheEndTestSource))]
        public void DeleteFewElementsFromTheEndTest(int amount, AList list, AList expectedList)
        {
            list.DeleteFewElementsFromTheEnd(amount);   
            AList actualList = list;
            Assert.AreEqual(expectedList, actualList);

        }

        [Test]
        public void DeleteFewElementsFromTheEnd_WhenArrayIsEmpty_ShoulExceptionTest()
        {
            AList list = new AList();
            int amount = 10;
            Assert.Throws<Exception>(() => list.DeleteFewElementsFromTheEnd(amount));
        }

        [Test]
        public void DeleteFewElementsFromTheEnd_WhenAmountMoreThanLength_ShoulExceptionTest()
        {
            AList list = new AList(new int[] { 1, 5, 2 });
            int amount = 10;
            Assert.Throws<Exception>(()=>list.DeleteFewElementsFromTheEnd(amount)); 
        }

        [TestCaseSource(typeof(DeleteFewElementsByIndexTestSource))]
        public void DeleteFewElementsByIndexTest(int index, int amount, AList list, AList expectedList)
        {
            list.DeleteFewElementsByIndex(index, amount);
            AList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [Test]
        public void DeleteFewElementsByIndex_WhenArrayIsEmpty_ShouldExceptionTest()
        {
            int index = 15;
            int amount = 25;
            AList list = new AList();
            Assert.Throws<Exception>(() => list.DeleteFewElementsByIndex(index, amount));
        }

        [Test]
        public void DeleteFewElementsByIndex_WhenAmountMoreThanLength_ShouldExceptionTest()
        {
            int index = 10;
            int amount = 25;
            AList list = new AList(new int[] { 1, 5, 2 });
            Assert.Throws<Exception>(() => list.DeleteFewElementsByIndex(index, amount));
        }
        [Test]
        public void DeleteFewElementsByIndex_WhenIndexOutOfRange_ShouldExceptionTest()
        {
            int index = 10;
            int amount = 25;
            AList list = new AList(new int[] { 1, 5, 2 });
            Assert.Throws<Exception>(() => list.DeleteFewElementsByIndex(index, amount));
        }

        [TestCaseSource(typeof(ShowValueByIndexTestSource))]
        public void ShowValueByIndexTest(int index, AList list, int expectedValue)
        {
            int actualValue = list.ShowValueByIndex(index);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ShowValueByIndex_WhenArrayIsEmpty_ShouldExceptionTest()
        {
            int index = 15;
            AList list = new AList();
            Assert.Throws<Exception>(() => list.ShowValueByIndex(index));
        }
        
        [Test]
        public void ShowValueByIndex_WhenIndexIsMoreThanLength_ShouldExceptionTest()
        {
            int index = 99;
            AList list = new AList(new int[] { 1, 4, 5 });
            Assert.Throws<Exception>(() => list.ShowValueByIndex(index));
        }
        
        [TestCaseSource(typeof(ShowIndexByValueTestSource))]
        public void ShowIndexByValueTest(int value, AList list, int expectedIndex)
        {
            int actualIndex = list.ShowIndexByValue(value);

            Assert.AreEqual(expectedIndex, actualIndex);
    
        }

        [Test]
        public void ShowIndexByValue_WhenTheArrayIsEmpty_ShoulsExcpetionTest()
        {
            int value = 50;
            AList list = new AList();
            Assert.Throws<Exception>(() => list.ShowIndexByValue(value));
        }

        [TestCaseSource(typeof(ChangeElementByIndexTestSource))]
        public void ChangeElementByIndexTest(int value, int index, AList list, AList expectedList)
        { 
            list.ChangeElementByIndex(value, index);

            AList actualList = list;

            Assert.AreEqual(expectedList, actualList);

        }

        [Test]
        public void ChangeElementByIndex_WhenArrayIsEmpty_ShouldExceptionTest()
        {
            int value = 15;
            int index = 20;
            AList list = new AList();
            Assert.Throws<Exception>(() => list.ChangeElementByIndex(value, index));
        }

        [Test]
        public void ChangeElementByIndex_WhenIndexOutOfRange_ShouldException()
        {
            int index = 19;
            int value = 10;
            AList list = new AList();
            Assert.Throws<Exception>(() => list.ChangeElementByIndex(value, index));
        }

        [TestCaseSource(typeof(FindMaxElementTestSource))]
        public void FindMaxElementTest(AList list, int expectedMax)
        {
            int actualMax=list.FindMaxElement();
            Assert.AreEqual(expectedMax, actualMax);
        }

        [Test]
        public void FindMaxElement_WhenArrayIsEmpty_ShoulExceptionTest()
        {
            AList list = new AList();
            Assert.Throws<Exception>(()=>list.FindMaxElement());
        }

        [TestCaseSource(typeof(FindMinElementTestSource))]
        public void FindMinElementTest(AList list, int expectedMin)
        {
            int actualMin = list.FindMinElement();
            Assert.AreEqual(expectedMin, actualMin);
        }

        [Test]
        public void FindMinElement_WhenArrsyIsEmpty_ShouldExceptionTest()
        {
            AList list = new AList();
            Assert.Throws<Exception>(()=>list.FindMinElement());    
        }

        [TestCaseSource(typeof(FindIndexOfMinElementTestSource))]
        public void FindIndexOfMinElementTest(AList list, int expectedIndexOfMinElement)
        {
            int actualIndexOfMinElement = list.FindIndexOfMinElement();

            Assert.AreEqual(expectedIndexOfMinElement, actualIndexOfMinElement);
        }

        [Test]
        public void FindIndexOfMinElement_WhenArrayIsEmpty_ShouldExceptionTest()
        {
            AList list = new AList();
            Assert.Throws<Exception>(() => list.FindIndexOfMinElement());
        }

        [TestCaseSource(typeof(FindInedxOfMaxElementTestSource))]
        public void FindInedxOfMaxElementTest(AList list, int expectedIndexOfMaxElement)
        {
            int actualIndexOfMaxElement = list.FindInedxOfMaxElement();
            
            Assert.AreEqual(expectedIndexOfMaxElement, actualIndexOfMaxElement);
        }

        [Test]
        public void FindInedxOfMaxElement_WhenArrayIsEmpty_ShouldExceptionTest()
        {
            AList list = new AList();
            Assert.Throws<Exception>(() => list.FindInedxOfMaxElement());
        }

        [TestCaseSource(typeof(SortFromMinToMaxTestSource))]
        public void SortFromMinToMaxTest(AList list, AList expectedList)
        {
            list.SortFromMinToMax();
            AList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [Test]
        public void SortFromMinToMax_WhenArrayIsEmpty_ShouldExceptionTest()
        {
            AList list = new AList();
            Assert.Throws<Exception>(() => list.SortFromMinToMax());
        }

        [TestCaseSource(typeof(SortFromMaxToMinTestSource))]
        public void SortFromMaxToMinTest(AList list, AList expectedList)
        {
            list.SortFromMaxToMin();
            AList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [Test]
        public void SortFromMaxToMin_WhenArrayIsEmpty_ShouldExceptionTest()
        {
            AList list = new AList();
            Assert.Throws<Exception>(() => list.SortFromMaxToMin());
        }

        [TestCaseSource(typeof(DeleteFirstByElementTestSource))]
        public void DeleteFirstByElementTest(int value, AList list, AList expectedList, int expectedIndex)
        {
            int actualIndex = list.DeleteFirstByElement(value);
            AList actualList = list;

            Assert.AreEqual(expectedList, actualList);
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [Test]
        public void DeleteFirstByElement_WhenArrayIsEmpty_ShouldExceptionTest()
        {
            AList list = new AList();
            int value = 55;
            Assert.Throws<Exception>(() => list.DeleteFirstByElement(value));
        }

        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(AList list, AList expectedList)
        {
            list.Reverse();
            AList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }
        
        [Test]
        public void DeleteEveryElementByValue_WhenArrayIsEmpty_ShouldExceptionTest()
        {
            AList list = new AList();
            int value = 55;
            Assert.Throws<Exception>(() => list.DeleteEveryElementByValue(value));
        }

        [TestCaseSource(typeof(AddListInTheStartTestSource))]
        public void AddListInTheStartTest(AList extraList, AList list, AList expectedList)
        {
            list.AddListInTheStart(extraList);
            AList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListInTheEndTestSource))]
        public void AddListInTheEndTest(AList extraList, AList list, AList expectedList)
        {
            list.AddListInTheEnd(extraList);
            AList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListByIndexTestSource))]
        public void AddListByIndexTest(AList extraList, int index, AList list, AList expectedList)
        {
            list.AddListByIndex(extraList, index);
            AList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListByIndex_WhenIndexMoreThanLength_ShouldExceptionTestSource))]
        public void AddListByIndex_WhenIndexMoreThanLength_ShouldExceptionTest(AList extraList, int index,AList list)
        {
            Assert.Throws<IndexOutOfRangeException>(()=>list.AddListByIndex(extraList, index)); 
        }
    }

    

    

 

    



    

    

    

   

    

    

    

    

    

    

    

    

    

    

    

    
    

   

    
}