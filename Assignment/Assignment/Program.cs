using System;
using System.Text;
using static System.Math;
using System.Numerics;
using static System.Numerics.Complex;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }
        Program()
        {
            Console.OutputEncoding = Encoding.Unicode;
        }

        //short in-out
        void outp(string s)
        {
            Console.WriteLine(s);
        }
        string inp(string s)
        {
            outp(s);
            return Console.ReadLine();
        }

        // Bài 1

        //main method:
        void read3Digits()
        {
            string s = inp("Nhập vào số có 3 chữ số: ");
            string result = readChar(s[0]) + " trăm "
                + readChar(s[1]) + " mươi " + readChar(s[2]);
            outp(result);
        }
        string readChar(char c)
        {
            switch (c)
            {
                case '1': return "một";
                case '2': return "hai";
                case '3': return "ba";
                case '4': return "bốn";
                case '5': return "năm";
                case '6': return "sáu";
                case '7': return "bảy";
                case '8': return "tám";
                case '9': return "chín";
                default: return "(something wrong)";
            }
        }

        //Bài 2.1:

        Complex so_phuc()
        {
            outp("nhap so phuc x+yi : ");
            double a = Convert.ToDouble(inp("nhap x: "));
            double b = Convert.ToDouble(inp("nhap y: "));
            return new Complex(a, b);
        }

        //main method:
        void ptBac2()
        {
            outp("Giải phương trình ax^2 +bx +c =0");
            outp("Nhập a: ");
            Complex a = so_phuc();
            outp("Nhập b: ");
            Complex b = so_phuc();
            outp("Nhập c: ");
            Complex c = so_phuc();
            if (a == new Complex(0, 0))
                if (b == new Complex(0, 0))
                    if (c == new Complex(0, 0)) outp("Phương trình vô số nghiệm");
                    else outp("Phương trình vô nghiệm");
                else outp("Phương trình có nghiệm duy nhất x = " + -c / b);
            else
            {
                Complex delta = b * b - 4 * a * c;
                Complex x1, x2;
                x1 = (-b + Sqrt(delta)) / 2 / a;
                x2 = (-b + Sqrt(delta)) / 2 / a;
                if (x1 == x2) outp("phương trình có nghiệm duy nhất x= " + x1);
                else
                {
                    outp("Phương trình có 2 nghiệm: ");
                    outp("x1 = " + x1);
                    outp("x2 = " + x2);
                }
            }
        }

        //Bài 2.2:

        void Factorize()
        {
            int n = Convert.ToInt32(inp("nhập vào số cần phân tích ra thừa số thập phân"));
            var dict = new Dictionary<int, int>();
            int factor = 2;
            while (n > 1)
            {
                if (n % factor == 0)
                {
                    if (!dict.ContainsKey(factor))
                        dict.Add(factor, 1);
                    else dict[factor] += 1;
                    n /= factor;
                }
                else factor++;
            }
            outp("Phân tích thập phân là: ");
            foreach (KeyValuePair<int, int> pair in dict)
            {
                Console.Write("" + pair.Key + "^" + pair.Value + ".");
            }
        }

        //Bài 3:
        int NchooseK(int n, int k)
        {
            if (k == 0 || k == n) return 1;
            else return NchooseK(n - 1, k) + NchooseK(n - 1, k - 1);
        }
        void testb3()
        {
            outp("Tính tổ hợp chập k của n: ");
            int n = Convert.ToInt32(inp("Nhập n:"));
            int k = Convert.ToInt32(inp("Nhập k:"));
            outp(NchooseK(n, k).ToString());
        }

        //Bài 4:

        int[,] setMatrix()
        {
            int n = Convert.ToInt32(inp("Making matrix with size:"));
            var matrix = new int[n, n];
            var row = new int[n];
            for (int i = 0; i < n; i++)
            {
                row = Console.ReadLine().Split(" ").Select(s => Convert.ToInt32(s)).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            return matrix;
        }
        void showMatrix(int[,] matrix)
        {
            outp("here goes the matrix: ");
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,6}", matrix[i, j]);
                }
                outp("");
            }
        }
        int[] diagonal(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            var diag = new int[n];
            for (int i = 0; i < n; i++)
            {
                diag[i] = matrix[i, i];
            }
            return diag;
        }

        int[] upperTriangle(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            var triangle = new int[n * (n - 1) / 2];
            for (int i = 0, k = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    triangle[k] = matrix[i, j];
                    k++;
                }
            }
            return triangle;
        }
        int[] lowerTriangle(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            var triangle = new int[n * (n - 1) / 2];
            for (int i = 0, k = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    triangle[k] = matrix[i, j];
                    k++;
                }
            }
            return triangle;
        }
        int[] sideDiagonal(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            var diag = new int[n];
            for (int i = 0; i < n; i++)
            {
                diag[i] = matrix[i, n - i];
            }
            return diag;
        }
        int[] sideUpperTriangle(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            var triangle = new int[n * (n - 1) / 2];
            for (int i = 0, k = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    triangle[k] = matrix[i, j];
                    k++;
                }
            }
            return triangle;
        }
        int[] sideLowerTriangle(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            var triangle = new int[n * (n - 1) / 2];
            for (int i = 0, k = 0; i < n; i++)
            {
                for (int j = n - i; j < n; j++)
                {
                    triangle[k] = matrix[i, j];
                    k++;
                }
            }
            return triangle;
        }

        //Bài 5.1 + 5.2:
        string inputPath = "..//..//..//input.txt";
        string outputPath = "..//..//..//output.txt";
        void Ford_Bellman()
        {
            //initialize the graph

            var reader = new StreamReader(new FileStream(inputPath, FileMode.Open, FileAccess.Read));
            var input = reader.ReadLine().Split(" ").Select(s => Convert.ToInt32(s)).ToArray();
            int vertices = input[0];
            int edges_number = input[1];
            int s = input[2];
            int f = input[3];
            string result = "Distance from " + s + " to " + f + ": ";

            var edges = new List<KeyValuePair<int, int>>();
            var weights = new Dictionary<KeyValuePair<int, int>, int>();
            KeyValuePair<int, int> tempPair;

            for (int i = 0; i < edges_number; i++)
            {
                input = reader.ReadLine().Split(" ").Select(s => Convert.ToInt32(s)).ToArray();
                tempPair = new KeyValuePair<int, int>(input[0], input[1]);
                edges.Add(tempPair);
                weights.Add(tempPair, input[2]);
            }

            var distance = new int[vertices + 1];
            distance[1] = 0;
            for (int i = 2; i < vertices + 1; i++)
            {
                distance[i] = int.MaxValue;
            }
            var trace = new int[vertices + 1];

            //join each short path:
            int u, v;
            for (int i = 1; i < vertices; i++)
            {
                foreach (var pair in edges)
                {
                    u = pair.Key;
                    v = pair.Value;
                    if (distance[v] > distance[u] + weights[pair])
                    {
                        distance[v] = distance[u] + weights[pair];
                        trace[v] = u;
                    }
                }
            }

            //negative loops
            foreach (var pair in edges)
            {
                u = pair.Key;
                v = pair.Value;
                if (distance[v] > distance[u] + weights[pair])
                    result = "exists negative loops!";
            }

            //output to text file
            result += f.ToString();
            while (f != s)
            {
                f = trace[f];
                result += "<-" + f;
            }
            File.WriteAllText(outputPath, result);
        }
    }
}
