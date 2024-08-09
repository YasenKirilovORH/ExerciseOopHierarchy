using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{
    public class Order
    {
        private List<MenuItem> _items;

        public Order()
        {
            _items = new List<MenuItem>();
        }

        public IReadOnlyCollection<MenuItem> Items => this._items.AsReadOnly();
        public void AddItem(MenuItem item)
        {
            this._items.Add(item);
        }

        public decimal GetTotal()
        {
            //decimal totalPrice = 0;
            //foreach (MenuItem item in _items)
            //{
            //    totalPrice += item.Price;
            //}
            //return totalPrice;

            return _items.Select(i => i.Price).Sum();
        }
    }
}
