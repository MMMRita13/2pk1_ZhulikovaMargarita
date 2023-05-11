namespace pz_28
{
        class Program
        {
            static void Main(string[] args)
            {
                Counter counter = new Counter();

                var wait200 = new Wait(() => Console.WriteLine("Value 200 reached!"));
                counter.ValueReached += wait200.OnValueReached;

                var wait800 = new Wait(() => Console.WriteLine("Value 800 reached!"));
                counter.ValueReached += wait800.OnValueReached;

                counter.Start();

            }
        }

        class Counter
        {
            public event Action ValueReached;
            public void Start()
            {
                for (int i = 1; i <= 1000; i++)
                {
                    if (i == 200 || i == 800)
                    {
                        ValueReached?.Invoke();
                    }
                }
            }
        }

        class Wait
        {
            private Action _action;

            public Wait(Action action)
            {
                _action = action;
            }

            public void OnValueReached()
            {
                _action();
            }
        }
    }
        
       

   