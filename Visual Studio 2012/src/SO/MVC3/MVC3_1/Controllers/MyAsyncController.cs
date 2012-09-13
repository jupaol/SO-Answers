using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVC3_1.Controllers
{
    public class MyAsyncController : AsyncController
    {
        //
        // GET: /MyAsync/

        public void IndexAsync()
        {
            this.AsyncManager.OutstandingOperations.Increment(2);

            var workerThreadID = Thread.CurrentThread.ManagedThreadId;

            Task.Factory.StartNew(() =>
                {
                    Thread.Sleep(4000);
                    var message = string.Format("Task 1, Thread ID: {0}, Worker Tread ID: {1}, called at {2}", Thread.CurrentThread.ManagedThreadId, workerThreadID, DateTime.Now);
                    this.AsyncManager.Parameters["m1"] = message;
                    this.AsyncManager.OutstandingOperations.Decrement();
                });

            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(6000);
                var message = string.Format("Task 2, Thread ID: {0}, Worker Tread ID: {1}, called at {2}", Thread.CurrentThread.ManagedThreadId, workerThreadID, DateTime.Now);
                this.AsyncManager.Parameters["m2"] = message;
                this.AsyncManager.OutstandingOperations.Decrement();
            });
        }

        public ActionResult IndexCompleted(string m1, string m2)
        {
            this.ViewData["m1"] = m1 + " Final Worker Thread ID: " + Thread.CurrentThread.ManagedThreadId;
            this.ViewData["m2"] = m2 + " Final Worker Thread ID: " + Thread.CurrentThread.ManagedThreadId;

            return View();
        }

    }
}
