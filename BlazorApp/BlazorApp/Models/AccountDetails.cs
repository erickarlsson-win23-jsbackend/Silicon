namespace BlazorApp.Models;

public class AccountDetails
{
    public string Title { get; set; } = "Account Details";

    public AccountDetailsBasicInfoModel BasicInfo { get; set; } = new AccountDetailsBasicInfoModel();

    public AccountDetailsAddressInfoModel AddressInfo { get; set; } = new AccountDetailsAddressInfoModel();
}
