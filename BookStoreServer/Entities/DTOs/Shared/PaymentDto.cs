using Iyzipay.Model;
using Entities.Models;

namespace Entities.DTOs.Shared;
public sealed record PaymentDto(
    int? AppUserId,
    List<Book> Books,
    Buyer Buyer,
    Iyzipay.Model.Address ShippingAddress,
    Iyzipay.Model.Address BillingAddress,
    PaymentCard PaymentCard,
    decimal ShippingAndCartTotal,
    string Currency);
