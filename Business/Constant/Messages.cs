using Core.Entities.Concrete;
using Entities.Concrete;

namespace Business.Constant;

public static class Messages
{
    public static string AddressDeleted = "Address successfully deleted";
    public static string AddressUpdated = "Address successfully updated";
    public static string AddressAdded = "Address successfully added";
    
    public static string CreditCardDeleted = "CreditCard successfully deleted";
    public static string CreditCardUpdated = "CreditCard successfully updated";
    public static string CreditCardAdded = "CreditCard successfully added";
    
    public static string CategoryDeleted = "Category successfully deleted";
    public static string CategoryUpdated = "Category successfully updated";
    public static string CategoryAdded = "Category successfully added";

    public static string ProductDeleted = "Product successfully deleted";
    public static string ProductUpdated = "Product successfully updated";
    public static string ProductAdded = "Product successfully added";
    public static string InvalidProductId = "The product with this id could not be found";
    
    public static string UserRegistered = "User successfully registered";

    public static string UserNotExist = "User does not exist";

    public static string InvalidPassword = "Invalid Password";
    public static string SuccessLogin = "User successfully Login";
    public static string TokenCreated = "Token Created";
}