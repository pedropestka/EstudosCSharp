namespace Enumeracao1.Entities.Enums
{
    enum OrderStatus : int // Derivaçao de tipos >> orderstatus é derivado do tipo int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}

/*
 pode ter ou nao o numero:
 PendingPayment,
*/

