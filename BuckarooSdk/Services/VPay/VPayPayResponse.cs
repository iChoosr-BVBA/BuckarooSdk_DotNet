namespace BuckarooSdk.Services.VPay
{
  public class VPayPayResponse : ActionResponse
  {
    public override ServiceEnum ServiceEnum => ServiceEnum.VPay;
    public string CardExpirationDate { get; set; }
  }
}