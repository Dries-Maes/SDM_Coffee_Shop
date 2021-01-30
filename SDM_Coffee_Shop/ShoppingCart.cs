using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM_Coffee_Shop
{
    class ShoppingCart : IShoppingCart
    {
        private List<IBeverage> _beverages;

        private static ShoppingCart _cart;

        public ShoppingCart()
        {
            _beverages = new List<IBeverage>();
        }

        public static ShoppingCart GetShoppingCart()
        {
            if (_cart == null)
            {
                _cart = new ShoppingCart();
            }

            return _cart;
        }

        public double CalculatePrice()
        {
            double totalPrice = 0;
            foreach (var beverage in _beverages)
            {
                totalPrice += beverage.Price;
            }

            return totalPrice;
        }

        public void AddBeverageToCart(IBeverage beverage)
        {
            _beverages.Add(beverage);
        }

        public List<IBeverage> GetBeveragesInCart()
        {
            return _beverages;
        }

        public IBeverage GetBeverageInCart(int id)
        {            
           
            var drink = _beverages.Where(x => x.ID == id).FirstOrDefault();

            return drink;
        }
        public void RemoveBeverageFromCart(IBeverage beverageToRemove)
        {
            _beverages.Remove(beverageToRemove);
        }

        public void ClearCart()
        {
            _beverages.Clear();
        }
    }
}
