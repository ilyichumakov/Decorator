using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Order
    {
        private string _bread;
        private int _breadPrice;
        private string _title;
        public string Name
        {
            get { return this._title; }
        }
        
        public Order(string title)
        {
            this._title = title;
        }

        abstract public int CountPrice();
    }

    public class WhiteSandwich : Order
    {
        private Order _order;
        public WhiteSandwich(Order o) : base(o.Name + ", на белом хлебе")
        {
            _order = o;
        }

        public override int CountPrice()
        {
            if (_order != null)
                return _order.CountPrice();
            throw new NullReferenceException("Не указана длина бутерброда!");
        }
    }

    public class GreySandwich : Order
    {
        private Order _order;
        public GreySandwich(Order o) : base(o.Name + ", на ржаном хлебе")
        {
            _order = o;
        }

        public override int CountPrice()
        {
            if (_order != null)
                return _order.CountPrice();
            throw new NullReferenceException("Не указана длина бутерброда!");
        }
    }

    public class SmallSandwich : Order
    {       
        public SmallSandwich() : base("Бутерброд 15 см") { }

        public override int CountPrice()
        {
            return 80;
        }
    }

    public class RegularSandwich : Order
    {
        public RegularSandwich() : base("Бутерброд 20 см") { }

        public override int CountPrice()
        {
            return 120;
        }
    }

    public class ExtraSandwich : Order
    {
        public ExtraSandwich() : base("Огромный бутерброд 30 см") { }

        public override int CountPrice()
        {
            return 170;
        }
    }
}
