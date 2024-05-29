namespace DairyDelightsLibrary.BL
{
    public class Order
    {
        private string OrderID;
        private Cart UserCart;
        private Customer Customer;
        private string DeliveryType;
        private string IsDelivered;
        private string OrderAmount;


        public Order(string OrderID, Cart cart, Customer customer, string DeliveryType, string OrderAmount)
        {
            this.OrderID = OrderID;
            this.UserCart = cart;
            this.Customer = customer;
            this.DeliveryType = DeliveryType;
            this.OrderAmount = OrderAmount;
            this.IsDelivered = "No";
        }

        public string GetOrderID()
        {
            return this.OrderID;
        }
        public bool SetOrderID(string OrderID)
        {
            this.OrderID = OrderID;
            return true;
        }

        public Customer GetCustomer() 
        {
            return this.Customer;
        }
        public bool SetCustomer(Customer Customer)
        {
            this.Customer = Customer;
            return true;
        }
        public Cart GetCart()
        {
            return this.UserCart;
        }
        public bool SetCart(Cart Cart)
        {
            this.UserCart = Cart;
            return true;
        }
        public string GetDeliveryType()
        {
            return this.DeliveryType;
        }
        public bool SetDeliveryType(string DeliveryType)
        {
            this.DeliveryType = DeliveryType;
            return true;
        }

        public string GetIsDelivered()
        {
            return this.IsDelivered;
        }
        public bool SetIsDelivered(string IsDelivered)
        {
            this.IsDelivered = IsDelivered;
            return true;
        }
        public string GetOrderAmount()
        {
            return this.OrderAmount;
        }
        public bool SetOrderAmount(string OrderAmount)
        {
            this.OrderAmount = OrderAmount;
            return true;
        }



    }
}
