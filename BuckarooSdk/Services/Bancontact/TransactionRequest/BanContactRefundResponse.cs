﻿namespace BuckarooSdk.Services.BanContact.TransactionRequest
{
    /// <summary>
    /// A BanContact refund does not have reponse parameters
    /// </summary>
    public class BanContactRefundResponse : ActionResponse
    {
	    public override ServiceEnum ServiceEnum => ServiceEnum.BanContact;
    }
}
