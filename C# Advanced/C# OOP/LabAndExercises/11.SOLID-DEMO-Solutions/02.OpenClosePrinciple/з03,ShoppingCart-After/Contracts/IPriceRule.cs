﻿namespace p03.ShoppingCart_After.Contracts
{
    public interface IPriceRule
    {
        bool IsMatch(OrderItem item);

        decimal CalculatePrice(OrderItem item);
    }
}
