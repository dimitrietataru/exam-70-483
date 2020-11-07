using System;
using System.Collections.Generic;

namespace ExamSnippets.Snippets
{
    public static class TestEventsDelegatesCallbacks
    {
        public static void Run()
        {
            //var lease = new Lease();
            //lease.OnMaximumTermReached += (s, e) => Console.WriteLine("Maximum lease exceeded!");
            //lease.Term = 20;

            //var runner = new Runner();
            //runner.Add("Test");
        }
    }

    #region LEASE
    public class Lease
    {
        public event MaximumTermReachedHandler OnMaximumTermReached;
        private int _term;
        private const int MaximumTerm = 5;
        private const decimal Rate = 0.034m;
        public int Term
        {
            get
            {
                return _term;
            }
            set
            {
                if (value < MaximumTerm)
                {
                    _term = value;
                }
                else
                {
                    OnMaximumTermReached?.Invoke(this, new EventArgs());
                    ////if (OnMaximumTermReached != null)
                    ////{
                    ////    OnMaximumTermReached(this, new EventArgs());
                    ////}
                }
            }
        }
    }
    public delegate void MaximumTermReachedHandler(object source, EventArgs e);
    #endregion

    #region USER TRACKER
    public delegate void AddUserCallback(int i);
    public class UserTracker
    {
        List<object> users = new List<object>();
        public void AddUser(string name, AddUserCallback callback)
        {
            users.Add(new object());
            callback(users.Count);
        }
    }
    public class Runner
    {
        private static void PrintUserCount(int i)
        {
        }
        UserTracker tracker = new UserTracker();
        public void Add(string name)
        {
            AddUserCallback callback = PrintUserCount;
            tracker.AddUser(name, callback);
        }
    }
    #endregion
}
