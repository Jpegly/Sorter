using NUnit.Framework;
using SorterApp;
using System;

namespace SorterTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        //Тестирование метода сортировки
        public void Sorting()
        {
            //arange
            var logic = new Logic();
            logic.Text = "зскззкзс";
            logic.Rule = "ЗСК";
            var expected = "ЗЗЗЗССКК";
            //act
            logic.Sorting();
            //assert
            Assert.AreEqual(expected, logic.Result);
        }

        [Test]
        //Тестирование свойства Text при значении в 14 символов
        public void Text_Lenght14_In_Text()
        {
            //arange
            var text = "зскзскзскзскзс";
            var expected = "ЗСКЗСКЗСКЗСКЗС";
            //act
            var logic = new Logic() { Text = text };
            //assert
            Assert.AreEqual(expected, logic.Text);
        }

        [Test]
        //Тестирование свойства Text при значении в 15 символов
        public void Text_Lenght15_In_Text()
        {
            //arange
            var text = "зскзскзскзскзск";
            var expected = "ЗСКЗСКЗСКЗСКЗСК";
            //act
            var logic = new Logic() { Text = text };
            //assert
            Assert.AreEqual(expected, logic.Text);
        }

        [Test]
        //Тестирование свойства Text при значении в 16 символов
        public void Text_Lenght16_In_Text()
        {
            //arange
            var text = "зскзскзскзскзскз";
            //act
            void Check()
            {
                var logic = new Logic() { Text = text };
            }
            //assert
            Assert.Throws(typeof(ArgumentException), Check);
        }

        [Test]
        //Тестирование свойства Text при пустом значении
        public void Text_Lenght0_In_Text()
        {
            //arange
            var text = string.Empty;
            //act
            void Check()
            {
                var logic = new Logic() { Text = text };
            }
            //assert
            Assert.Throws(typeof(ArgumentException), Check);
        }
    }
}