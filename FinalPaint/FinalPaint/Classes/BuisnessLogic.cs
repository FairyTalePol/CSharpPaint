using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Classes
{
    class BuisnessLogic
    {
        private static BuisnessLogic _bl;
        private BuisnessLogic()
        {

        }

        public BuisnessLogic Create()
        {
            if (_bl==null)
            {
                _bl = new BuisnessLogic();
            }
            return _bl;
        }


    }
}
