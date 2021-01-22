namespace Composicao3.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}

// não é class e sim enum
// tipo OrderStatus deriva do tipo int
