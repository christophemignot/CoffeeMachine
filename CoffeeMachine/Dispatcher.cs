namespace CoffeeMachine
{
    using System;
    
    public class Dispatcher
    {
        private readonly IDrinkMaker drinkMaker;
        private readonly ICustomer customer;

        public Dispatcher(ICustomer customer, IDrinkMaker drinkMaker)
        {
            this.drinkMaker = drinkMaker;
            this.customer = customer;
        }

        public void Order(OrderDetail command)
        {
            drinkMaker.Order(command.ToString());
        }

        public void Notify(string message)
        {
            if (!message.StartsWith("M:"))
            {
                throw new ArgumentException("Message do not start with 'M:'");
            }
            customer.Notify(message);
        }
    }
}
