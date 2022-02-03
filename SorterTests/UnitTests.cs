using NUnit.Framework;
using SorterApp;
using System;

namespace SorterTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        //������������ ������ ����������
        public void Sorting()
        {
            //arange
            var logic = new Logic();
            logic.Text = "��������";
            logic.Rule = "���";
            var expected = "��������";
            //act
            logic.Sorting();
            //assert
            Assert.AreEqual(expected, logic.Result);
        }

        [Test]
        //������������ �������� Text ��� �������� � 14 ��������
        public void Text_Lenght14_In_Text()
        {
            //arange
            var text = "��������������";
            var expected = "��������������";
            //act
            var logic = new Logic() { Text = text };
            //assert
            Assert.AreEqual(expected, logic.Text);
        }

        [Test]
        //������������ �������� Text ��� �������� � 15 ��������
        public void Text_Lenght15_In_Text()
        {
            //arange
            var text = "���������������";
            var expected = "���������������";
            //act
            var logic = new Logic() { Text = text };
            //assert
            Assert.AreEqual(expected, logic.Text);
        }

        [Test]
        //������������ �������� Text ��� �������� � 16 ��������
        public void Text_Lenght16_In_Text()
        {
            //arange
            var text = "����������������";
            //act
            void Check()
            {
                var logic = new Logic() { Text = text };
            }
            //assert
            Assert.Throws(typeof(ArgumentException), Check);
        }

        [Test]
        //������������ �������� Text ��� ������ ��������
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