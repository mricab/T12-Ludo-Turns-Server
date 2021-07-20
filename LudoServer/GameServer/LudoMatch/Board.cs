using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoMatch
{
    public class Board // V1.2
    {
        public int size;
        public string[] cells; 

        public Board(string[] data)
        {
            int.TryParse(data[0], out this.size);
            cells = new string[data.Length - 1];
            Array.Copy(data, 1, cells, 0, data.Length - 1);
        }
    }
}
