using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace something
{
    class persistence
    {
        public int maxrecord;
        public int Import()
        {
            if (File.Exists("data.txt") == true)
            {
                StreamReader file = new StreamReader("data.txt");
                maxrecord = Convert.ToInt32(file.ReadLine());
                file.Close();
                return maxrecord;
            }
            else
            {
                File.Create("data.txt");
                return 0;
            }

        }
        public bool Export(int score)
        {
            if (score > maxrecord)
            {
                StreamWriter file = new StreamWriter("data.txt");
                file.WriteLine(score);
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
