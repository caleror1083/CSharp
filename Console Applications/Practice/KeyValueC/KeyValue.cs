using System;

class KeyValue<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public KeyValue(TKey k, TValue v)
            {
                Key = k;
                Value = v;
            }

        public void ShowData()
            {
                Console.WriteLine($"{Key} is {Value}");
            }
    }