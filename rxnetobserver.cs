using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Disposables;

namespace ConsoleApplication4
{





    public class MyConsoleObserver<T> : IObserver<T>
    {
        public void OnNext(T value)
        {
            Console.WriteLine("Received value {0}", value);
        }
        public void OnError(Exception error)
        {
            Console.WriteLine("Sequence faulted with {0}", error);
        }
        public void OnCompleted()
        {
            Console.WriteLine("Sequence terminated");
        }
    }

    class rxnetobserver : IObservable<int>
    {
       

        public IDisposable Subscribe(IObserver<int> observer)
        {
            observer.OnNext(1);
            observer.OnNext(2);
            observer.OnCompleted();
            return Disposable.Empty;
        }
        public static void Main(string [] args)
        {
            var numbers = new rxnetobserver();
            var observer = new MyConsoleObserver<int>();
            numbers.Subscribe(observer);
           
            Console.Read();
        }
    }



}
