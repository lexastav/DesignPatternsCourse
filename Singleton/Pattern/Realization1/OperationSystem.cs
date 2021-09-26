using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Singleton.Pattern.Realization1
{
    class OperationSystem
    {
        private static OperationSystem instance;
        public string Name { get; private set; }
        
        // это понадобится для упаковки

        //private static object syncRoot = new Object();


        protected OperationSystem(string name)
        {
            this.Name = name;
        }

        public static OperationSystem getInstance(string name)
        {
            if (instance == null)
            {
                instance = new OperationSystem(name);
            }
            return instance;

            // вариант кода для многопотока

            //if (instance == null)
            //{
            //    lock (syncRoot)
            //    {
            //        if (instance == null)
            //        {
            //            instance = new OperationSystem(name);
            //        }
            //    }
            //}
            //return instance;



        }
    }
}
