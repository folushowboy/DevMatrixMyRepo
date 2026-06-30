using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    public delegate void Notify(); //delegate
    internal class Signalling
    {
        public event Notify ProcessCompleted; //event
        //this is the signal
        public void StartProcess()
        {
            Console.WriteLine("Start process");
            OnprocessCompleted();
        }
        protected virtual void OnprocessCompleted()
        {
            ProcessCompleted.Invoke(); 
            //this is raising the signal
        }
    }
}
