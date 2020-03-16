using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Ji_suan
    {
        float a, b,z;
        string s1,s2;
        public void Ji()
        {
            Console.WriteLine("请输入两个数");
            
             s1=Console.ReadLine();
             s2 = Console.ReadLine();

            try
            {

                a = float.Parse(s1);
                b = float.Parse(s2);
                Console.WriteLine("请输入操作符：");
                string c2 = Console.ReadLine();
                Console.WriteLine(Ji_Suan(c2));
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine(Ji_Suan());
            }

        }
        public float Ji_Suan(string c2)
        {
            
            switch (c2)
            {
                case "+":
                    z = a + b;
                    break;
                case "-":
                    z = a - b;
                    break;
                case "*":
                    z = a * b;
                    break;
                case "/":
                    z = a / b;
                    break;
            }
            return z;

        }
        public string Ji_Suan()
        {
            Console.WriteLine("请输入操作符:");
            string c1 = Console.ReadLine();
            char h=char.Parse(c1);
            string d="";
            char[] q1, q2;
            int count=0;
            switch (h)
            {
                case '+':
                     d = s1 + s2;
                    break;
                case '-':
                    q1=s1.ToCharArray();
                    q2 = s2.ToCharArray();
                  for(int i=0;i<q1.Length;i++)
                    {
                        for(int j = 0; j < q2.Length; j++)
                        {
                            if (q1[i] == q2[j])
                            {
                                q1[i] = ' ';
                                count++;

                            }
                          

                        }
                    }
                    int t = q1.Length;
                    for(int i = 0; i < t; i++)
                    {
                        
                        if(q1[i]==' ')
                        {
                            t-=count;
                            for (int j= i,k=count ; j < t; j++)
                            {

                                q1[j]= q1[k+j];
                                k++;
                               
                            }

                           
                        }

                        d += q1[i];

                    }

                    break;
            }
            return d;
        }

    }
}
