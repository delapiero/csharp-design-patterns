using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AdapterKlasowy: Dictionary<int,string>, IList<string>
    {
        public int IndexOf(string item)
        {
            foreach (int key in base.Keys)
            {
                if (base[key] == item)
                    return key;
            }
            return -1;
        }

        public void Insert(int index, string item)
        {
            if (ContainsKey(index))
                base[index] = item;
            else
                Add(index, item);
        }

        public void RemoveAt(int index)
        {
            if (base.ContainsKey(index))
                base.Remove(index);
        }

        public void Add(string item)
        {
            int newKey;
            if (base.Keys.Count == 0)
                newKey = 0;
            else
                newKey = base.Keys.Max() + 1;
            base.Add(newKey + 1, item);
        }

        public bool Contains(string item)
        {
            return base.Values.Contains(item);
        }

        public void CopyTo(string[] array, int arrayIndex)
        {
            foreach (string item in base.Values)
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
            foreach(int key in base.Keys)
            {
                if (base[key] == item)
                    toRemove.Add(key);
            }
            if (toRemove.Count > 0)
            {
                foreach(int key in toRemove)
                    base.Remove(key);
                return true;
            }
            else
            {
                return false;
            }
        }

        public new IEnumerator<string> GetEnumerator()
        {
            return Values.GetEnumerator();
        }
    }
}
