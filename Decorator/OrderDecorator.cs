using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class OrderDecorator : Order
    {
        protected Order _order;

        public OrderDecorator(Order o, string title) : base(title)
        {
            _order = o;
        }

        public override int CountPrice()
        {
            if (_order != null)
                return _order.CountPrice();
            throw new NullReferenceException("Нет базы бутерброда!");
        }
    }

    public class WithMushroom : OrderDecorator
    {
        public WithMushroom(Order o) : base(o, o.Name + ", с грибами") { }
        public override int CountPrice()
        {
            return _order.CountPrice() + 35;
        }
    }

    public class WithCheese : OrderDecorator
    {
        public WithCheese(Order o) : base(o, o.Name + ", с сыром") { }
        public override int CountPrice()
        {
            return _order.CountPrice() + 20;
        }
    }

    public class WithSalami : OrderDecorator
    {
        public WithSalami(Order o) : base(o, o.Name + ", с салями") { }
        public override int CountPrice()
        {
            return _order.CountPrice() + 30;
        }
    }

    public class WithChicken : OrderDecorator
    {
        public WithChicken(Order o) : base(o, o.Name + ", с курицей") { }
        public override int CountPrice()
        {
            return _order.CountPrice() + 30;
        }
    }

    public class WithBeacon : OrderDecorator
    {
        public WithBeacon(Order o) : base(o, o.Name + ", с беконом") { }
        public override int CountPrice()
        {
            return _order.CountPrice() + 36;
        }
    }

    public class WithRoastBeef : OrderDecorator
    {
        public WithRoastBeef(Order o) : base(o, o.Name + ", с говядиной") { }
        public override int CountPrice()
        {
            return _order.CountPrice() + 45;
        }
    }

    public class WithHam : OrderDecorator
    {
        public WithHam(Order o) : base(o, o.Name + ", с ветчиной") { }
        public override int CountPrice()
        {
            return _order.CountPrice() + 32;
        }
    }

    public class WithKetchup : OrderDecorator
    {
        public WithKetchup(Order o) : base(o, o.Name + ", с кетчупом") { }
        public override int CountPrice()
        {
            return _order.CountPrice() + 10;
        }
    }

    public class WithMayo : OrderDecorator
    {
        public WithMayo(Order o) : base(o, o.Name + ", с майонезом") { }
        public override int CountPrice()
        {
            return _order.CountPrice() + 10;
        }
    }

    public class WithMustard : OrderDecorator
    {
        public WithMustard(Order o) : base(o, o.Name + ", с горчицей") { }
        public override int CountPrice()
        {
            return _order.CountPrice() + 10;
        }
    }

    public class WithTomato : OrderDecorator
    {
        public WithTomato(Order o) : base(o, o.Name + ", с томатами") { }
        public override int CountPrice()
        {
            return _order.CountPrice() + 15;
        }
    }

    public class WithCucumber : OrderDecorator
    {
        public WithCucumber(Order o) : base(o, o.Name + ", с маринованным огурчиком") { }
        public override int CountPrice()
        {
            return _order.CountPrice() + 18;
        }
    }

    public class WithFish : OrderDecorator
    {
        public WithFish(Order o) : base(o, o.Name + ", с рыбой") { }
        public override int CountPrice()
        {
            return _order.CountPrice() + 43;
        }
    }
}
