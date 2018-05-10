using BuckarooSdk.Transaction;

namespace BuckarooSdk.Services.BanContact.TransactionRequest
{
    public class BanContactTransaction
    {
        /// <summary>
		/// The configured transaction
		/// </summary>
		private ConfiguredTransaction ConfiguredTransaction { get; set; }

        internal BanContactTransaction(ConfiguredTransaction baseTransaction)
        {
            this.ConfiguredTransaction = baseTransaction;
        }

        /// <summary>
		/// The pay function creates a configured transaction with a BanContactPayRequest, 
        /// that is ready to be executed.
		/// </summary>
		/// <param name="request">A BanContactPayRequestPayRequest</param>
		/// <returns></returns>
		public ConfiguredServiceTransaction Pay(BanContactPayRequest request)
        {
            var parameters = ServiceHelper.CreateServiceParameters(request);
            var configuredServiceTransaction = new ConfiguredServiceTransaction(this.ConfiguredTransaction.BaseTransaction);
            configuredServiceTransaction.BaseTransaction.AddService("Bancontactmrcash", parameters, "pay");

            return configuredServiceTransaction;
        }

        /// <summary>
        /// The refund function creates a configured transaction with a BanContactRefundRequest, 
        /// that is ready to be executed.
        /// </summary>
        /// <param name="request">A BanContactRefundRequest</param>
        /// <returns></returns>
        public ConfiguredServiceTransaction Refund(BanContactRefundRequest request)
        {
            var parameters = ServiceHelper.CreateServiceParameters(request);
            var configuredServiceTransaction = new ConfiguredServiceTransaction(this.ConfiguredTransaction.BaseTransaction);
            configuredServiceTransaction.BaseTransaction.AddService("Bancontactmrcash", parameters, "refund");

            return configuredServiceTransaction;
        }
    }
}
