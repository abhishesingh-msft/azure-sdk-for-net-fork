// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary>
    /// An event summary resource.
    /// Serialized Name: EventSummary
    /// </summary>
    public partial class ConsumptionEventSummary : ResourceData
    {
        /// <summary> Initializes a new instance of ConsumptionEventSummary. </summary>
        public ConsumptionEventSummary()
        {
        }

        /// <summary> Initializes a new instance of ConsumptionEventSummary. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="transactOn">
        /// The date of the event.
        /// Serialized Name: EventSummary.properties.transactionDate
        /// </param>
        /// <param name="description">
        /// The description of the event.
        /// Serialized Name: EventSummary.properties.description
        /// </param>
        /// <param name="newCredit">
        /// The amount of new credit or commitment for NewCredit or SettleCharges event.
        /// Serialized Name: EventSummary.properties.newCredit
        /// </param>
        /// <param name="adjustments">
        /// The amount of balance adjustment. The property is not available for ConsumptionCommitment lots.
        /// Serialized Name: EventSummary.properties.adjustments
        /// </param>
        /// <param name="creditExpired">
        /// The amount of expired credit or commitment for NewCredit or SettleCharges event.
        /// Serialized Name: EventSummary.properties.creditExpired
        /// </param>
        /// <param name="charges">
        /// The amount of charges for events of type SettleCharges and PendingEligibleCharges.
        /// Serialized Name: EventSummary.properties.charges
        /// </param>
        /// <param name="closedBalance">
        /// The balance after the event.
        /// Serialized Name: EventSummary.properties.closedBalance
        /// </param>
        /// <param name="eventType">
        /// Identifies the type of the event.
        /// Serialized Name: EventSummary.properties.eventType
        /// </param>
        /// <param name="invoiceNumber">
        /// The number which uniquely identifies the invoice on which the event was billed. This will be empty for unbilled events.
        /// Serialized Name: EventSummary.properties.invoiceNumber
        /// </param>
        /// <param name="billingProfileId">
        /// The ID that uniquely identifies the billing profile for which the event happened. The property is only available for billing account of type MicrosoftCustomerAgreement.
        /// Serialized Name: EventSummary.properties.billingProfileId
        /// </param>
        /// <param name="billingProfileDisplayName">
        /// The display name of the billing profile for which the event happened. The property is only available for billing account of type MicrosoftCustomerAgreement.
        /// Serialized Name: EventSummary.properties.billingProfileDisplayName
        /// </param>
        /// <param name="lotId">
        /// The ID that uniquely identifies the lot for which the event happened.
        /// Serialized Name: EventSummary.properties.lotId
        /// </param>
        /// <param name="lotSource">
        /// Identifies the source of the lot for which the event happened.
        /// Serialized Name: EventSummary.properties.lotSource
        /// </param>
        /// <param name="canceledCredit">
        /// Amount of canceled credit.
        /// Serialized Name: EventSummary.properties.canceledCredit
        /// </param>
        /// <param name="creditCurrency">
        /// The credit currency of the event.
        /// Serialized Name: EventSummary.properties.creditCurrency
        /// </param>
        /// <param name="billingCurrency">
        /// The billing currency of the event.
        /// Serialized Name: EventSummary.properties.billingCurrency
        /// </param>
        /// <param name="reseller">
        /// The reseller of the event.
        /// Serialized Name: EventSummary.properties.reseller
        /// </param>
        /// <param name="creditExpiredInBillingCurrency">
        /// The amount of expired credit or commitment for NewCredit or SettleCharges event in billing currency.
        /// Serialized Name: EventSummary.properties.creditExpiredInBillingCurrency
        /// </param>
        /// <param name="newCreditInBillingCurrency">
        /// The amount of new credit or commitment for NewCredit or SettleCharges event in billing currency.
        /// Serialized Name: EventSummary.properties.newCreditInBillingCurrency
        /// </param>
        /// <param name="adjustmentsInBillingCurrency">
        /// The amount of balance adjustment in billing currency.
        /// Serialized Name: EventSummary.properties.adjustmentsInBillingCurrency
        /// </param>
        /// <param name="chargesInBillingCurrency">
        /// The amount of charges for events of type SettleCharges and PendingEligibleCharges in billing currency.
        /// Serialized Name: EventSummary.properties.chargesInBillingCurrency
        /// </param>
        /// <param name="closedBalanceInBillingCurrency">
        /// The balance in billing currency after the event.
        /// Serialized Name: EventSummary.properties.closedBalanceInBillingCurrency
        /// </param>
        /// <param name="etag">
        /// eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not.
        /// Serialized Name: ProxyResource.eTag
        /// </param>
        internal ConsumptionEventSummary(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? transactOn, string description, ConsumptionAmount newCredit, ConsumptionAmount adjustments, ConsumptionAmount creditExpired, ConsumptionAmount charges, ConsumptionAmount closedBalance, ConsumptionEventType? eventType, string invoiceNumber, ResourceIdentifier billingProfileId, string billingProfileDisplayName, ResourceIdentifier lotId, string lotSource, ConsumptionAmount canceledCredit, string creditCurrency, string billingCurrency, ConsumptionReseller reseller, ConsumptionAmountWithExchangeRate creditExpiredInBillingCurrency, ConsumptionAmountWithExchangeRate newCreditInBillingCurrency, ConsumptionAmountWithExchangeRate adjustmentsInBillingCurrency, ConsumptionAmountWithExchangeRate chargesInBillingCurrency, ConsumptionAmountWithExchangeRate closedBalanceInBillingCurrency, ETag? etag) : base(id, name, resourceType, systemData)
        {
            TransactOn = transactOn;
            Description = description;
            NewCredit = newCredit;
            Adjustments = adjustments;
            CreditExpired = creditExpired;
            Charges = charges;
            ClosedBalance = closedBalance;
            EventType = eventType;
            InvoiceNumber = invoiceNumber;
            BillingProfileId = billingProfileId;
            BillingProfileDisplayName = billingProfileDisplayName;
            LotId = lotId;
            LotSource = lotSource;
            CanceledCredit = canceledCredit;
            CreditCurrency = creditCurrency;
            BillingCurrency = billingCurrency;
            Reseller = reseller;
            CreditExpiredInBillingCurrency = creditExpiredInBillingCurrency;
            NewCreditInBillingCurrency = newCreditInBillingCurrency;
            AdjustmentsInBillingCurrency = adjustmentsInBillingCurrency;
            ChargesInBillingCurrency = chargesInBillingCurrency;
            ClosedBalanceInBillingCurrency = closedBalanceInBillingCurrency;
            ETag = etag;
        }

        /// <summary>
        /// The date of the event.
        /// Serialized Name: EventSummary.properties.transactionDate
        /// </summary>
        public DateTimeOffset? TransactOn { get; }
        /// <summary>
        /// The description of the event.
        /// Serialized Name: EventSummary.properties.description
        /// </summary>
        public string Description { get; }
        /// <summary>
        /// The amount of new credit or commitment for NewCredit or SettleCharges event.
        /// Serialized Name: EventSummary.properties.newCredit
        /// </summary>
        public ConsumptionAmount NewCredit { get; }
        /// <summary>
        /// The amount of balance adjustment. The property is not available for ConsumptionCommitment lots.
        /// Serialized Name: EventSummary.properties.adjustments
        /// </summary>
        public ConsumptionAmount Adjustments { get; }
        /// <summary>
        /// The amount of expired credit or commitment for NewCredit or SettleCharges event.
        /// Serialized Name: EventSummary.properties.creditExpired
        /// </summary>
        public ConsumptionAmount CreditExpired { get; }
        /// <summary>
        /// The amount of charges for events of type SettleCharges and PendingEligibleCharges.
        /// Serialized Name: EventSummary.properties.charges
        /// </summary>
        public ConsumptionAmount Charges { get; }
        /// <summary>
        /// The balance after the event.
        /// Serialized Name: EventSummary.properties.closedBalance
        /// </summary>
        public ConsumptionAmount ClosedBalance { get; }
        /// <summary>
        /// Identifies the type of the event.
        /// Serialized Name: EventSummary.properties.eventType
        /// </summary>
        public ConsumptionEventType? EventType { get; set; }
        /// <summary>
        /// The number which uniquely identifies the invoice on which the event was billed. This will be empty for unbilled events.
        /// Serialized Name: EventSummary.properties.invoiceNumber
        /// </summary>
        public string InvoiceNumber { get; }
        /// <summary>
        /// The ID that uniquely identifies the billing profile for which the event happened. The property is only available for billing account of type MicrosoftCustomerAgreement.
        /// Serialized Name: EventSummary.properties.billingProfileId
        /// </summary>
        public ResourceIdentifier BillingProfileId { get; }
        /// <summary>
        /// The display name of the billing profile for which the event happened. The property is only available for billing account of type MicrosoftCustomerAgreement.
        /// Serialized Name: EventSummary.properties.billingProfileDisplayName
        /// </summary>
        public string BillingProfileDisplayName { get; }
        /// <summary>
        /// The ID that uniquely identifies the lot for which the event happened.
        /// Serialized Name: EventSummary.properties.lotId
        /// </summary>
        public ResourceIdentifier LotId { get; }
        /// <summary>
        /// Identifies the source of the lot for which the event happened.
        /// Serialized Name: EventSummary.properties.lotSource
        /// </summary>
        public string LotSource { get; }
        /// <summary>
        /// Amount of canceled credit.
        /// Serialized Name: EventSummary.properties.canceledCredit
        /// </summary>
        public ConsumptionAmount CanceledCredit { get; }
        /// <summary>
        /// The credit currency of the event.
        /// Serialized Name: EventSummary.properties.creditCurrency
        /// </summary>
        public string CreditCurrency { get; }
        /// <summary>
        /// The billing currency of the event.
        /// Serialized Name: EventSummary.properties.billingCurrency
        /// </summary>
        public string BillingCurrency { get; }
        /// <summary>
        /// The reseller of the event.
        /// Serialized Name: EventSummary.properties.reseller
        /// </summary>
        public ConsumptionReseller Reseller { get; }
        /// <summary>
        /// The amount of expired credit or commitment for NewCredit or SettleCharges event in billing currency.
        /// Serialized Name: EventSummary.properties.creditExpiredInBillingCurrency
        /// </summary>
        public ConsumptionAmountWithExchangeRate CreditExpiredInBillingCurrency { get; }
        /// <summary>
        /// The amount of new credit or commitment for NewCredit or SettleCharges event in billing currency.
        /// Serialized Name: EventSummary.properties.newCreditInBillingCurrency
        /// </summary>
        public ConsumptionAmountWithExchangeRate NewCreditInBillingCurrency { get; }
        /// <summary>
        /// The amount of balance adjustment in billing currency.
        /// Serialized Name: EventSummary.properties.adjustmentsInBillingCurrency
        /// </summary>
        public ConsumptionAmountWithExchangeRate AdjustmentsInBillingCurrency { get; }
        /// <summary>
        /// The amount of charges for events of type SettleCharges and PendingEligibleCharges in billing currency.
        /// Serialized Name: EventSummary.properties.chargesInBillingCurrency
        /// </summary>
        public ConsumptionAmountWithExchangeRate ChargesInBillingCurrency { get; }
        /// <summary>
        /// The balance in billing currency after the event.
        /// Serialized Name: EventSummary.properties.closedBalanceInBillingCurrency
        /// </summary>
        public ConsumptionAmountWithExchangeRate ClosedBalanceInBillingCurrency { get; }
        /// <summary>
        /// eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not.
        /// Serialized Name: ProxyResource.eTag
        /// </summary>
        public ETag? ETag { get; set; }
    }
}
