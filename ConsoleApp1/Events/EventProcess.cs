using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Events
{
    #region Raising Event
    public delegate void Notify();
    public class EventProcessPublisher
    {
        public event Notify ProcessComplete;
        public void StartProcess()
        {
            Console.WriteLine("Process Started..");
            OnProcessComplete();
        }

        protected virtual void OnProcessComplete() //protected virtual method
        {
            //if ProcessCompleted is not null then call delegate
            ProcessComplete?.Invoke();
        }
    }


    #endregion


    // Cnsuming event

    public static class EventSubscribe 
    {

        public static void Consume_Event()
        {
            EventProcessPublisher publisher = new EventProcessPublisher();
            publisher.ProcessComplete += handler_ProcessCompleted;
            publisher.StartProcess();
        }

        // event handler
        public static void handler_ProcessCompleted()
        {
            Console.WriteLine("Process Completed!");
        }


    }


}
