using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        /*public void TestMethod1()
        {
            //准备
            ConsoleApp2.pp test = new ConsoleApp2.pp();

            //设定测试用例
            int d = 10; int a = 5; int b = 2; int A = 30; int B = 15; int C = 10; int D = 5; int P = 1; int P1 = 1; int P2 = 2; int P3 = 2;
            //测试标准
            int actual=test.calculator(d, a,  b,  A,  B, C, D, P, P1, P2, P3);
            int expect = 60;
            //判断
            Assert.AreEqual(expected: expect,actual: actual, message: "除乘加不正确");
        }*/

        public void TestMethod2()
        {
            //准备
            ConsoleApp2.pp test = new ConsoleApp2.pp();

            //设定测试用例
            int d = 10; int a = 5; int b = 2; int A = 30; int B = 15; int C = 10; int D = 5; int P = 1; int P1 = 0; int P2 = 1; int P3 = 1;
            //测试标准
            int actual = test.calculator(d, a, b, A, B, C, D, P, P1, P2, P3);
            int expect = 455;
            //判断
            Assert.AreEqual(expected: expect, actual: actual, message: "乘加减不正确");
        }

        public void TestMethod3()
        {
            //准备
            ConsoleApp2.pp test = new ConsoleApp2.pp();

            //设定测试用例
            int d = 10; int a = 5; int b = 2; int A = 30; int B = 15; int C = 10; int D = 5; int P = 0; int P1 = 1; int P2 = 2; int P3 = 1;
            //测试标准
            int actual = test.calculator(d, a, b, A, B, C, D, P, P1, P2, P3);
            int expect = 32;
            //判断
            Assert.AreEqual(expected: expect, actual: actual, message: "除乘加不正确");
        }

        public void TestMethod4()
        {
            //准备
            ConsoleApp2.pp test = new ConsoleApp2.pp();

            //设定测试用例
            int d = 10; int a = 5; int b = 2; int A = 30; int B = 15; int C = 10; int D = 5; int P = 0; int P1 = 0; int P2 = 2; int P3 = 1;
            //测试标准
            int actual = test.calculator(d, a, b, A, B, C, D, P, P1, P2, P3);
            int expect = 35;
            //判断
            Assert.AreEqual(expected: expect, actual: actual, message: "除乘加不正确");
        }
    }
}
