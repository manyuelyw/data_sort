using System;

namespace data_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数据(分隔符为:空格/制表符)：");
            string a = Console.ReadLine();
            string[] index;
            index = a.Split(new char[2] { ' ', '\t'});
            int num = index.Length;
            int[] data = new int[num];
            try
            {
                for (int i = 0; i < num; i++)
                {
                    data[i] = int.Parse(index[i]);
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("您输入的数据格式错误：非数字类型！");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("您输入的数据已溢出：超过能表示数的范围！");
                return;
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("您未输入数据：输入数据不能为空！");
                return;
            }
            for (int i = 0; i < num; i++)
            {
                for (int j = 1; j < num - i; j++)
                {
                    if (data[j - 1] > data[j])
                    {
                        int temp = data[j - 1];
                        data[j - 1] = data[j];
                        data[j] = temp;
                    }
                }
            }
            Console.WriteLine("按照从小到大排序后的数组为：");
            for (int i = 0; i < num; i++)
            {
                Console.Write("{0} ", data[i]);
            }
        }
    }
}
