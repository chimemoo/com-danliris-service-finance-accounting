﻿using Com.Moonlay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Com.Danliris.Service.Finance.Accounting.Lib.Models.GarmentDebtBalance
{
    public class GarmentDebtBalanceModel : StandardEntity
    {
        public GarmentDebtBalanceModel()
        {

        }

        public GarmentDebtBalanceModel(int purchasingCategoryId, string purchasingCategoryName, string billsNo, string paymentBills, int garmentDeliveryOrderId, string garmentDeliveryOrderNo, int supplierId, string supplierCode, string supplierName, bool supplierIsImport, int currencyId, string currencyCode, double currencyRate, string productNames, DateTimeOffset arrivalDate, double dppAmount, double currencyDPPAmount)
        {
            PurchasingCategoryId = purchasingCategoryId;
            PurchasingCategoryName = purchasingCategoryName;
            BillsNo = billsNo;
            PaymentBills = paymentBills;
            GarmentDeliveryOrderId = garmentDeliveryOrderId;
            GarmentDeliveryOrderNo = garmentDeliveryOrderNo;
            SupplierId = supplierId;
            SupplierCode = supplierCode;
            SupplierName = supplierName;
            SupplierIsImport = supplierIsImport;
            CurrencyId = currencyId;
            CurrencyCode = currencyCode;
            CurrencyRate = currencyRate;
            ProductNames = productNames;
            ArrivalDate = arrivalDate;
            DPPAmount = dppAmount;
            CurrencyDPPAmount = currencyDPPAmount;
        }

        public int PurchasingCategoryId { get; private set; }
        [MaxLength(64)]
        public string PurchasingCategoryName { get; private set; }
        [MaxLength(256)]
        public string BillsNo { get; private set; }
        [MaxLength(256)]
        public string PaymentBills { get; private set; }
        public int GarmentDeliveryOrderId { get; private set; }
        [MaxLength(64)]
        public string GarmentDeliveryOrderNo { get; private set; }
        public int SupplierId { get; private set; }
        [MaxLength(256)]
        public string SupplierCode { get; private set; }
        [MaxLength(512)]
        public string SupplierName { get; private set; }
        public bool SupplierIsImport { get; private set; }
        public int CurrencyId { get; private set; }
        [MaxLength(32)]
        public string CurrencyCode { get; private set; }
        public double CurrencyRate { get; private set; }

        public int InvoiceId { get; private set; }
        public DateTimeOffset InvoiceDate { get; private set; }
        [MaxLength(64)]
        public string InvoiceNo { get; private set; }
        public double DPPAmount { get; private set; }
        public double CurrencyDPPAmount { get; private set; }
        public double VATAmount { get; private set; }
        public double CurrencyVATAmount { get; private set; }
        public double IncomeTaxAmount { get; private set; }
        public double CurrencyIncomeTaxAmount { get; private set; }
        public bool IsPayVAT { get; private set; }
        public bool IsPayIncomeTax { get; private set; }

        public int InternalNoteId { get; private set; }
        [MaxLength(64)]
        public string InternalNoteNo { get; private set; }

        public int BankExpenditureNoteId { get; private set; }
        [MaxLength(64)]
        public string BankExpenditureNoteNo { get; private set; }
        public double BankExpenditureNoteInvoiceAmount { get; private set; }
        public double CurrencyBankExpenditureNoteInvoiceAmount { get; private set; }
        public string ProductNames { get; set; }
        public DateTimeOffset ArrivalDate { get; set; }
        public string PaymentType { get; internal set; }

        public void SetInternalNote(int internalNoteId, string internalNoteNo)
        {
            InternalNoteId = internalNoteId;
            InternalNoteNo = internalNoteNo;
        }

        public void SetBankExpenditureNote(int bankExpenditureNoteId, string bankExpenditureNoteNo, double bankExpenditureNoteInvoiceAmount, double currencyBankExpenditureNoteInvoiceAmount)
        {
            BankExpenditureNoteId = bankExpenditureNoteId;
            BankExpenditureNoteNo = bankExpenditureNoteNo;
            BankExpenditureNoteInvoiceAmount = bankExpenditureNoteInvoiceAmount;
            CurrencyBankExpenditureNoteInvoiceAmount = currencyBankExpenditureNoteInvoiceAmount;
        }

        public void SetInvoice(int invoiceId, DateTimeOffset invoiceDate, string invoiceNo, double vatAmount, double incomeTaxAmount, bool isPayVAT, bool isPayIncomeTax, double currencyVATAmount, double currencyIncomeTaxAmount)
        {
            InvoiceId = invoiceId;
            InvoiceDate = invoiceDate;
            InvoiceNo = invoiceNo;
            VATAmount = vatAmount;
            CurrencyVATAmount = currencyVATAmount;
            IncomeTaxAmount = incomeTaxAmount;
            CurrencyIncomeTaxAmount = currencyIncomeTaxAmount;
            IsPayVAT = isPayVAT;
            IsPayIncomeTax = isPayIncomeTax;
        }
    }
}
