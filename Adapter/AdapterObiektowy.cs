using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class AdapterObiektowy: IList<string>
    {
        private Dictionary<int, string> dict = new Dictionary<int, string>();

        public int IndexOf(string item)
        {
            foreach (int key in dict.Keys)
            {
                if (dict[key] == item)
                    return key;
            }
            return -1;
        }

        public void Insert(int index, string item)
        {
            if (dict.ContainsKey(index))
                dict[index] = item;
            else
                dict.Add(index, item);
        }

        public void RemoveAt(int index)
        {
            if (dict.ContainsKey(index))
                dict.Remove(index);
        }

        public void Add(string item)
        {
            int newKey = dict.Keys.Max() + 1;
            dict.Add(newKey + 1, item);
        }

        public bool Contains(string item)
        {
            return dict.Values.Contains(item);
        }

        public void CopyTo(string[] array, int arrayIndex)
        {
            foreach (string item in dict.Values)
            {
                if (arrayIndex < array.Length)
                {
                    array[arrayIndex] = item;
                    ++arrayIndex;
                }
            }
        }

        public bool IsReadOnly
        {
            get { return this.IsReadOnly; }
        }

        public bool Remove(string item)
        {
            IList<int> toRemove = new List<int>();
            foreach (int key in dict.Keys)
            {
                if (dict[key] == item)
                    toRemove.Add(key);
            }
            if (toRemove.Count > 0)
            {
                foreach (int key in toRemove)
                    dict.Remove(key);
                return true;
            }
            else
            {
                return false;
            }
        }

        public new IEnumerator<string> GetEnumerator()
        {
            return dict.Values.GetEnumerator();
        }


        public string this[int index]
        {
            get
            {
                return dict[index];
            }
            set
            {
                dict[index] = value;
            }
        }


        public void Clear()
        {
            dict.Clear();
        }

        public int Count
        {
            get { return dict.Keys.Count; }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return dict.GetEnumerator();
        }
    }
}
