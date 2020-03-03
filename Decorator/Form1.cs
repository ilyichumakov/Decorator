using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace Decorator
{
    public partial class Form1 : Form
    {
        private static Dictionary<CheckBox, Type> inners;
        private static Dictionary<RadioButton, Type> basis;
        private Order sandwich;

        public Form1()
        {
            InitializeComponent();

            basis = new Dictionary<RadioButton, Type>();
            basis.Add(WhiteRadio, typeof(WhiteSandwich));
            basis.Add(GreyRadio, typeof(GreySandwich));
            basis.Add(smallRadio, typeof(SmallSandwich));
            basis.Add(regularRadio, typeof(RegularSandwich));
            basis.Add(ExtraRadio, typeof(ExtraSandwich));

            inners = new Dictionary<CheckBox, Type>();
            inners.Add(mushroomBox, typeof(WithMushroom));
            inners.Add(tomatoBox, typeof(WithTomato));
            inners.Add(cucumberBox, typeof(WithCucumber));
            inners.Add(cheeseBox, typeof(WithCheese));
            inners.Add(chickenBox, typeof(WithChicken));
            inners.Add(hamBox, typeof(WithHam));
            inners.Add(salamiBox, typeof(WithSalami));
            inners.Add(roastbeefBox, typeof(WithRoastBeef));
            inners.Add(fishBox, typeof(WithFish));
            inners.Add(mayoBox, typeof(WithMayo));
            inners.Add(ketchupBox, typeof(WithKetchup));
            inners.Add(mustardBox, typeof(WithMustard));
            inners.Add(beaconBox, typeof(WithBeacon));
        }

        private void innerBox_CheckedChanged(object sender, EventArgs e)
        {
            ShowSandwich();
        }

        private void ShowSandwich()
        {
            foreach(RadioButton r in lenBox.Controls)
            {
                if(r.Checked)
                {
                    ConstructorInfo c = basis[r].GetConstructor(new Type[0]);
                    sandwich = (Order) c.Invoke(new object[0]);
                }
            }
            foreach (RadioButton r in BreadBox.Controls)
            {
                if (r.Checked)
                {
                    ConstructorInfo c = basis[r].GetConstructor(new Type[] { typeof(Order)});
                    sandwich = (Order)c.Invoke(new object[] { sandwich });
                }
            }
            foreach (CheckBox r in innerBox.Controls)
            {
                if (r.Checked)
                {
                    ConstructorInfo c = inners[r].GetConstructor(new Type[] { typeof(Order) });
                    sandwich = (OrderDecorator)c.Invoke(new object[] { sandwich });
                }
            }
            sandwichDesc.Text = sandwich.Name;
            priceLabel.Text = sandwich.CountPrice().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowSandwich();
        }
    }
}
