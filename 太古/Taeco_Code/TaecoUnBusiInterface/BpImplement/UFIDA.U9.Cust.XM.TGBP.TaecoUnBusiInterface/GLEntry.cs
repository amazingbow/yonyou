using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UFIDA.U9.Cust.XM.TGBP.TaecoUnBusiInterface
{
    public class GLEntry
    {
        /* 
        public long ID { get; set; }
        public decimal OCMoney { get; set; }
        public string MyProperty { get; set; }
         */

        #region
        public long ID
        {
            get;
            set;
        }


        public DateTime CreatedOn
        {
            get;
            set;
        }


        public string CreatedBy
        {
            get;
            set;

        }
        public string TaskCode
        {
            get;
            set;
        }
        public string ProjectCode
        {
            get;
            set;
        }
        public decimal ExtraExecutedMoney
        {
            get;
            set;
        }


        public DateTime ModifiedOn
        {
            get;
            set;

        }


        public string ModifiedBy
        {
            get;
            set;

        }


        public new long SysVersion
        {
            get;
            set;

        }


        public long GL_Header_ID
        {
            get;
            set;

        }


        public long EntryID
        {
            get;
            set;

        }


        public int SerialNo
        {
            get;
            set;

        }


        public string Abstracts
        {
            get;
            set;

        }


        public string Account1
        {
            get;
            set;

        }


        public string Account2
        {
            get;
            set;

        }


        public string Account3
        {
            get;
            set;

        }


        public string Account4
        {
            get;
            set;

        }


        public string Account5
        {
            get;
            set;

        }


        public string Account6
        {
            get;
            set;

        }


        public string Account7
        {
            get;
            set;

        }


        public string Account8
        {
            get;
            set;

        }


        public string Account9
        {
            get;
            set;

        }


        public string Account10
        {
            get;
            set;

        }


        public string CurrencyCode
        {
            get;
            set;

        }
        public long Currency
        {
            get;
            set;

        }


        public int ExchangeRateTypes
        {
            get;
            set;

        }


        public decimal OCToFCExchangeRate
        {
            get;
            set;

        }


        public decimal AccountedDr
        {
            get;
            set;

        }


        public decimal AccountedCr
        {
            get;
            set;

        }


        public decimal EnteredDr
        {
            get;
            set;

        }


        public decimal EnteredCr
        {
            get;
            set;

        }


        public decimal AmountDr
        {
            get;
            set;

        }


        public decimal AmountCr
        {
            get;
            set;

        }

        public string BankAccountCode
        {
            get;
            set;

        }
        public string IncomeExpendItemCode
        {
            get;
            set;

        }

        public string SettlementMethodCode
        {
            get;
            set;

        }

        public string DescFlexField_PubDescSeg1
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg2
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg3
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg4
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg5
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg6
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg7
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg8
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg9
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg10
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg11
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg12
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg13
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg14
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg15
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg16
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg17
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg18
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg19
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg20
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg21
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg22
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg23
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg24
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg25
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg26
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg27
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg28
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg29
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg30
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg31
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg32
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg33
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg34
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg35
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg36
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg37
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg38
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg39
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg40
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg41
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg42
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg43
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg44
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg45
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg46
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg47
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg48
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg49
        {
            get;
            set;

        }


        public string DescFlexField_PubDescSeg50
        {
            get;
            set;

        }

        public string DescFlexField_PrivateDescSeg1
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg2
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg3
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg4
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg5
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg6
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg7
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg8
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg9
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg10
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg11
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg12
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg13
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg14
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg15
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg16
        {
            get;
            set;
        }


        public string DescFlexField_PrivateDescSeg17
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg18
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg19
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg20
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg21
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg22
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg23
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg24
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg25
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg26
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg27
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg28
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg29
        {
            get;
            set;

        }


        public string DescFlexField_PrivateDescSeg30
        {
            get;
            set;

        }


        public string InternalApAR
        {
            get;
            set;

        }


        public long Supplier
        {
            get;
            set;

        }


        public string Supplier_Code
        {
            get;
            set;

        }


        public string Supplier_Name
        {
            get;
            set;

        }


        public long Customer
        {
            get;
            set;

        }


        public string Customer_Code
        {
            get;
            set;

        }


        public string Customer_Name
        {
            get;
            set;

        }
        public string UOMCode
        {
            get;
            set;

        }
        public string CustomerSection { get; set; }
        public string CustomerBU { get; set; }
        public void CopyTo(GLEntry entry)
        {
            entry.Abstracts = this.Abstracts;
            entry.Account1 = this.Account1;
            entry.Account10 = this.Account10;
            entry.Account2 = this.Account2;
            entry.Account3 = this.Account3;
            entry.Account4 = this.Account4;
            entry.Account5 = this.Account5;
            entry.Account6 = this.Account6;
            entry.Account7 = this.Account7;
            entry.Account8 = this.Account8;
            entry.Account9 = this.Account9;
            entry.AccountedCr = this.AccountedCr;
            entry.AccountedDr = this.AccountedDr;
            entry.AmountCr = this.AmountCr;
            entry.AmountDr = this.AmountDr;
            entry.BankAccountCode = this.BankAccountCode;
            entry.CreatedBy = this.CreatedBy;
            entry.CreatedOn = this.CreatedOn;
            entry.Currency = this.Currency;
            entry.CurrencyCode = this.CurrencyCode;
            entry.Customer = this.Customer;
            entry.Customer_Code = this.Customer_Code;
            entry.Customer_Name = this.Customer_Name;
            entry.DescFlexField_PrivateDescSeg1 = this.DescFlexField_PrivateDescSeg1;
            entry.DescFlexField_PrivateDescSeg2 = this.DescFlexField_PrivateDescSeg2;
            entry.DescFlexField_PrivateDescSeg3 = this.DescFlexField_PrivateDescSeg3;
            entry.DescFlexField_PrivateDescSeg4 = this.DescFlexField_PrivateDescSeg4;
            entry.DescFlexField_PrivateDescSeg5 = this.DescFlexField_PrivateDescSeg5;
            entry.DescFlexField_PrivateDescSeg6 = this.DescFlexField_PrivateDescSeg6;
            entry.DescFlexField_PrivateDescSeg7 = this.DescFlexField_PrivateDescSeg7;
            entry.DescFlexField_PrivateDescSeg8 = this.DescFlexField_PrivateDescSeg8;
            entry.DescFlexField_PrivateDescSeg9 = this.DescFlexField_PrivateDescSeg9;
            entry.DescFlexField_PrivateDescSeg10 = this.DescFlexField_PrivateDescSeg10;
            entry.DescFlexField_PrivateDescSeg11 = this.DescFlexField_PrivateDescSeg11;
            entry.DescFlexField_PrivateDescSeg12 = this.DescFlexField_PrivateDescSeg12;
            entry.DescFlexField_PrivateDescSeg13 = this.DescFlexField_PrivateDescSeg13;
            entry.DescFlexField_PrivateDescSeg14 = this.DescFlexField_PrivateDescSeg14;
            entry.DescFlexField_PrivateDescSeg15 = this.DescFlexField_PrivateDescSeg15;
            entry.DescFlexField_PrivateDescSeg16 = this.DescFlexField_PrivateDescSeg16;
            entry.DescFlexField_PrivateDescSeg17 = this.DescFlexField_PrivateDescSeg17;
            entry.DescFlexField_PrivateDescSeg18 = this.DescFlexField_PrivateDescSeg18;
            entry.DescFlexField_PrivateDescSeg19 = this.DescFlexField_PrivateDescSeg19;
            entry.DescFlexField_PrivateDescSeg20 = this.DescFlexField_PrivateDescSeg20;
            entry.DescFlexField_PrivateDescSeg21 = this.DescFlexField_PrivateDescSeg21;
            entry.DescFlexField_PrivateDescSeg22 = this.DescFlexField_PrivateDescSeg22;
            entry.DescFlexField_PrivateDescSeg23 = this.DescFlexField_PrivateDescSeg23;
            entry.DescFlexField_PrivateDescSeg24 = this.DescFlexField_PrivateDescSeg24;
            entry.DescFlexField_PrivateDescSeg25 = this.DescFlexField_PrivateDescSeg25;
            entry.DescFlexField_PrivateDescSeg26 = this.DescFlexField_PrivateDescSeg26;
            entry.DescFlexField_PrivateDescSeg27 = this.DescFlexField_PrivateDescSeg27;
            entry.DescFlexField_PrivateDescSeg28 = this.DescFlexField_PrivateDescSeg28;
            entry.DescFlexField_PrivateDescSeg29 = this.DescFlexField_PrivateDescSeg29;
            entry.DescFlexField_PrivateDescSeg30 = this.DescFlexField_PrivateDescSeg30;

            entry.DescFlexField_PubDescSeg1 = this.DescFlexField_PubDescSeg1;
            entry.DescFlexField_PubDescSeg2 = this.DescFlexField_PubDescSeg2;
            entry.DescFlexField_PubDescSeg3 = this.DescFlexField_PubDescSeg3;
            entry.DescFlexField_PubDescSeg4 = this.DescFlexField_PubDescSeg4;
            entry.DescFlexField_PubDescSeg5 = this.DescFlexField_PubDescSeg5;
            entry.DescFlexField_PubDescSeg6 = this.DescFlexField_PubDescSeg6;
            entry.DescFlexField_PubDescSeg7 = this.DescFlexField_PubDescSeg7;
            entry.DescFlexField_PubDescSeg8 = this.DescFlexField_PubDescSeg8;
            entry.DescFlexField_PubDescSeg9 = this.DescFlexField_PubDescSeg9;
            entry.DescFlexField_PubDescSeg10 = this.DescFlexField_PubDescSeg10;
            entry.DescFlexField_PubDescSeg11 = this.DescFlexField_PubDescSeg11;
            entry.DescFlexField_PubDescSeg12 = this.DescFlexField_PubDescSeg12;
            entry.DescFlexField_PubDescSeg13 = this.DescFlexField_PubDescSeg13;
            entry.DescFlexField_PubDescSeg14 = this.DescFlexField_PubDescSeg14;
            entry.DescFlexField_PubDescSeg15 = this.DescFlexField_PubDescSeg15;
            entry.DescFlexField_PubDescSeg16 = this.DescFlexField_PubDescSeg16;
            entry.DescFlexField_PubDescSeg17 = this.DescFlexField_PubDescSeg17;
            entry.DescFlexField_PubDescSeg18 = this.DescFlexField_PubDescSeg18;
            entry.DescFlexField_PubDescSeg19 = this.DescFlexField_PubDescSeg19;
            entry.DescFlexField_PubDescSeg20 = this.DescFlexField_PubDescSeg20;
            entry.DescFlexField_PubDescSeg21 = this.DescFlexField_PubDescSeg21;
            entry.DescFlexField_PubDescSeg22 = this.DescFlexField_PubDescSeg22;
            entry.DescFlexField_PubDescSeg23 = this.DescFlexField_PubDescSeg23;
            entry.DescFlexField_PubDescSeg24 = this.DescFlexField_PubDescSeg24;
            entry.DescFlexField_PubDescSeg25 = this.DescFlexField_PubDescSeg25;
            entry.DescFlexField_PubDescSeg26 = this.DescFlexField_PubDescSeg26;
            entry.DescFlexField_PubDescSeg27 = this.DescFlexField_PubDescSeg27;
            entry.DescFlexField_PubDescSeg28 = this.DescFlexField_PubDescSeg28;
            entry.DescFlexField_PubDescSeg29 = this.DescFlexField_PubDescSeg29;
            entry.DescFlexField_PubDescSeg30 = this.DescFlexField_PubDescSeg30;
            entry.DescFlexField_PubDescSeg31 = this.DescFlexField_PubDescSeg31;
            entry.DescFlexField_PubDescSeg32 = this.DescFlexField_PubDescSeg32;
            entry.DescFlexField_PubDescSeg33 = this.DescFlexField_PubDescSeg33;
            entry.DescFlexField_PubDescSeg34 = this.DescFlexField_PubDescSeg34;
            entry.DescFlexField_PubDescSeg35 = this.DescFlexField_PubDescSeg35;
            entry.DescFlexField_PubDescSeg36 = this.DescFlexField_PubDescSeg36;
            entry.DescFlexField_PubDescSeg37 = this.DescFlexField_PubDescSeg37;
            entry.DescFlexField_PubDescSeg38 = this.DescFlexField_PubDescSeg38;
            entry.DescFlexField_PubDescSeg39 = this.DescFlexField_PubDescSeg39;
            entry.DescFlexField_PubDescSeg40 = this.DescFlexField_PubDescSeg40;
            entry.DescFlexField_PubDescSeg41 = this.DescFlexField_PubDescSeg41;
            entry.DescFlexField_PubDescSeg42 = this.DescFlexField_PubDescSeg42;
            entry.DescFlexField_PubDescSeg43 = this.DescFlexField_PubDescSeg43;
            entry.DescFlexField_PubDescSeg44 = this.DescFlexField_PubDescSeg44;
            entry.DescFlexField_PubDescSeg45 = this.DescFlexField_PubDescSeg45;
            entry.DescFlexField_PubDescSeg46 = this.DescFlexField_PubDescSeg46;
            entry.DescFlexField_PubDescSeg47 = this.DescFlexField_PubDescSeg47;
            entry.DescFlexField_PubDescSeg48 = this.DescFlexField_PubDescSeg48;
            entry.DescFlexField_PubDescSeg49 = this.DescFlexField_PubDescSeg49;
            entry.DescFlexField_PubDescSeg50 = this.DescFlexField_PubDescSeg50;

            entry.EnteredCr = this.EnteredCr;
            entry.EnteredDr = this.EnteredDr;
            entry.ExchangeRateTypes = this.ExchangeRateTypes;
            entry.ExtraExecutedMoney = this.ExtraExecutedMoney;
            entry.GL_Header_ID = this.GL_Header_ID;
            entry.IncomeExpendItemCode = this.IncomeExpendItemCode;
            //entry.InternalApAR
            entry.ModifiedBy = this.ModifiedBy;
            entry.ModifiedOn = this.ModifiedOn;
            entry.OCToFCExchangeRate = this.OCToFCExchangeRate;
            entry.ProjectCode = this.ProjectCode;
            entry.SerialNo = this.SerialNo;
            entry.SettlementMethodCode = this.SettlementMethodCode;
            entry.Supplier = this.Supplier;
            entry.Supplier_Code = this.Supplier_Code;
            entry.Supplier_Name = this.Supplier_Name;
            entry.TaskCode = this.TaskCode;
            entry.UOMCode = this.UOMCode;
            entry.CustomerBU = this.CustomerBU;
            entry.CustomerSection = this.CustomerSection;

        }
        #endregion
    }
}
