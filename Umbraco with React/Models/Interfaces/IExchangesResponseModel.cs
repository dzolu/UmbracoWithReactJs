namespace Knowhere_CMS.Models.Interfaces
{
    public interface IExchangesResponseModel
    {
         double CurrentRate { get; }
         double Fee { get; }
         double ReceivingAmount { get; }
    }
}
