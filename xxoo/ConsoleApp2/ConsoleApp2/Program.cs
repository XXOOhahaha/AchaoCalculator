using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ConsoleApp2
{
    public class Program
    {
         static void Main(string[] args)
        {
           string str= Console.ReadLine();
            
            for (int i = 0; i < Convert.ToInt32(str); i++)
            {
                int A = 200;
                int d = 200;
                pp Q = new pp();
                int P = Q.rd(0, 2), P1 = Q.rd(0, 2), P2 =Q. rd(1, 3), P3 = Q.rd(1, 4);
                int B =Q.rd(1, 100), C = Q.rd(1, 100), D = Q.rd(1, 100);
                int a = Q.rd(1, 100), b =Q. rd(1, 100);

               
                if (Q.calculator(d,a,b,A,B,C,D,P,P1,P2,P3) < 0)
                    i--;

            }
           

            

            System.Console.WriteLine("hahaha");
            System.Threading.Thread.Sleep(1000000000); 
        }


        
    }
   public class pp
    {
        public int rd(int p, int q)
        {
            long tick = DateTime.Now.Ticks;
            System.Threading.Thread.Sleep(1);
            Random rd1 = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));

            return rd1.Next(p, q);


        }

        public int calculator(int d, int a, int b, int A, int B, int C, int D, int P, int P1, int P2, int P3)
        {

            int answer = 0;//P为三项式或四项式（0,1），P1为是否有除（0,1）

            while (d > 100)
            {
                a = rd(1, 100); b = rd(1, 100); //生成六个100以内的整数
                d = a * b;
            }
            while (A > 100)
            {
                B = rd(1, 100); C = rd(1, 100); D = rd(1, 100);
                A = B + C + D;
            }

            if (P == 1)//为四项多项式
            {
                if (P1 == 1)
                {

                    if (P2 == 1)//两除
                    {
                        if (P3 == 1)//加
                        {
                            answer = ((d / a) / b) + A;
                            if (answer > 0)
                                Console.WriteLine(d + "÷" + a + "÷" + b + "+" + A + "          答案：" + answer);
                        }
                        else if (P3 == 2)//减
                        {
                            answer = ((d / a) / b) - A;
                            if (answer > 0)
                                Console.WriteLine(d + "÷" + a + "÷" + b + "-" + A + "          答案：" + answer);
                        }
                        else if (P3 == 3)//乘
                        {
                            answer = ((d / a) / b) * A;
                            if (answer > 0)
                                Console.WriteLine(d + "÷" + a + "÷" + b + "x" + A + "          答案：" + answer);
                        }

                    }
                    else if (P2 == 2)//一除
                    {
                        if (P3 == 1)//+-
                        {
                            answer = (d / a) + B - A;
                            if (answer > 0)
                                Console.WriteLine(d + "÷" + a + "+" + B + "-" + A + "          答案：" + answer);
                        }
                        else if (P3 == 2)//x+
                        {
                            answer = ((d / a) * B) + A;
                            if (answer > 0)
                                Console.WriteLine(d + "÷" + a + "x" + B + "+" + A + "          答案：" + answer);
                        }
                        else if (P3 == 3)//x-
                        {
                            answer = ((d / a) * B) - A;
                            if (answer > 0)
                                Console.WriteLine(d + "÷" + a + "x" + B + "-" + A + "          答案：" + answer);
                        }
                    }
                }
                else if (P1 == 0)//没除
                {
                    if (P2 == 1)//一乘
                    {
                        if (P3 == 1)//+-
                        {
                            answer = A * B + C - D;
                            if (answer > 0)
                                Console.WriteLine(A + "x" + B + "+" + C + "-" + D + "          答案：" + answer);
                        }
                        else if (P3 == 2)//++
                        {
                            answer = A * B + C + D;
                            if (answer > 0)
                                Console.WriteLine(A + "x" + B + "+" + C + "+" + D + "          答案：" + answer);
                        }
                        else if (P3 == 3)//--
                        {
                            answer = A * B - C - D;
                            if (answer > 0)
                                Console.WriteLine(A + "x" + B + "-" + C + "-" + D + "          答案：" + answer);
                        }
                    }
                    if (P2 == 2)//两乘
                    {
                        if (P3 == 1 || P3 == 2)//+
                        {
                            answer = A * B * C + D;
                            if (answer > 0)
                                Console.WriteLine(A + "x" + B + "x" + C + "+" + D + "          答案：" + answer);
                        }
                        else if (P3 == 1 || P3 == 2)//-
                        {
                            answer = A * B * C - D;
                            if (answer > 0)
                                Console.WriteLine(A + "x" + B + "x" + C + "-" + D + "          答案：" + answer);
                        }
                    }
                }
            }
            else if (P == 0)//三项式
            {
                if (P1 == 1)//有除
                {


                    if (P3 == 1)//加
                    {
                        answer = d / a + A;
                        if (answer > 0)
                            Console.WriteLine(d + "÷" + a + "+" + A + "          答案：" + answer);
                    }
                    else if (P3 == 2)//减
                    {
                        answer = d / a - A;
                        if (answer > 0)
                            Console.WriteLine(d + "÷" + a + "-" + A + "          答案：" + answer);
                    }
                    else if (P3 == 3)//乘
                    {
                        answer = d / a * A;
                        if (answer > 0)
                            Console.WriteLine(d + "÷" + a + "x" + A + "          答案：" + answer);
                    }
                }


                else if (P1 == 0)//无除
                {
                    if (P3 == 1)//+-
                    {
                        answer = A + B - C;
                        if (answer > 0)
                            Console.WriteLine(A + "+" + B + "-" + C + "          答案：" + answer);
                    }
                    else if (P3 == 2)//x+
                    {
                        answer = A * B + C;
                        if (answer > 0)
                            Console.WriteLine(A + "x" + B + "+" + C + "          答案：" + answer);
                    }
                    else if (P3 == 3)//x-
                    {
                        answer = A * B - C;
                        if (answer > 0)
                            Console.WriteLine(A + "x" + B + "-" + C + "          答案：" + answer);
                    }
                }

            }
            return answer;
        }
    }

}
