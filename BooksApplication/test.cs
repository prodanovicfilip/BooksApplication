using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApplication
{
    public class Test
    {
        private Test() { }

        private Test _instance;
        public Test Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Test();
                    return _instance;
                }
                return _instance;
            }
        }

        
    }
}
