using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DelegateR
{
    
    class ActionAndFunc
    {
        #region Anonymous Function
        //private delegate double OperationChoise(double x, double y);
        //private Dictionary<string, OperationChoise> _op;
        //public ActionAndFunc()
        //{
        //    _op = new Dictionary<string, OperationChoise>
        //    {
        //        {  "+", delegate (double x, double y)  {return x+y; } }
        //        , {"-", delegate(double x, double y) {return x-y; } },
        //        { "*", delegate(double x, double y) {return x*y; } }, 
        //        { "/", delegate(double x, double y) {return x/y; } }
        //    };

        //} 
        #endregion

        #region Lymbda

        
        private delegate double OperationChoise(double x, double y);
        private Dictionary<string, Func<double, double, double>> _op;
        public ActionAndFunc()
        {
            _op = new Dictionary<string, Func<double, double, double>>
            {
                {  "+", (x, y) => x+y },
                { "-", (x, y) => x-y },
                { "*", delegate(double x, double y) {return x*y; } },
                { "/", delegate(double x, double y) {return x/y; } }
            };

        }
        #endregion

        public double PerfOperation(string op, double x, double y)
        {
            if (!_op.ContainsKey(op)) throw new ArgumentException(string.Format("operation {0} is invalid {1}", op), "op");
            return _op [op](x, y) ;
        }
        public void AddOperation(string oper, Func<double, double, double> Function)
        {
            if(_op.ContainsKey(oper)) return;
            _op.Add(oper, Function);
        }
       
    }
}
