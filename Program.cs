using System;
using System.Collections.Generic;

namespace _0718_Ball_AOJ
{
    class Inputs
    {
        public readonly int N;
        public readonly int M;

        public readonly List<int> X = new List<int>();
        public readonly  List<int> Y = new List<int>();

        public Inputs()
        {
            var inputString = Console.ReadLine() ?? "";
            var stringArray = inputString.Split(" ");

            N = int.Parse(stringArray[0]);
            M = int.Parse(stringArray[1]);

            for(var j = 0; j < M; j++)
            {
                inputString = Console.ReadLine() ?? "";
                stringArray = inputString.Split(" ");
                X.Add(int.Parse(stringArray[0]));
                Y.Add(int.Parse(stringArray[1]));
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var inputs = new Inputs();
            var Outputs = moveBallPosition(inputs);
            outputResults(Outputs);
        }


        static IEnumerable<int> moveBallPosition(Inputs inputs)
        {
            
            var ball = new int[inputs.N + 1];

            // 箱 i (1≦i≦N) には最初，ボール i が入っていた．
            for (var i = 1; i <= inputs.N; i++)
            {
                // NOTE:ボール[i]の位置 = 箱iとして代入
                ball[i] = i;
            }

            // JOI 高校の生徒である葵は，この状態から箱とボールに対して M 回の操作を行った．j 回目 (1≦j≦M) の操作は，次のように行われた．
            // ボール Xj が入っている箱を探し，その箱からボール Xj を取り出す．その後，箱 Yj にボール Xj を入れる．
            for(var j = 0; j < inputs.M; j++)
            {
                // NOTE:ボール[Xj]の位置 = 箱Yjとして再代入
                ball[inputs.X[j]] = inputs.Y[j];
            }

            return ball;

        }

        static void outputResults(IEnumerable<int> outputs)
        {
            foreach(var elem in outputs)
            {
                if (elem != 0)
                {
                    System.Console.WriteLine(elem);
                }
            }
        }
    }
}