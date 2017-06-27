using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UFIDA.U9.Cust.XM.TGBP.TaecoUnBusiInterface
{
    public class GLVoucher
    {
        public List<GLEntry> GLEntryList { get; set; }

        #region property

        public override string ToString()
        {
            return ID;
        }
        public string ID
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

        public long SOB
        {
            get;
            set;
        }


        public string SOB_Code
        {
            get;
            set;
        }


        public string SOB_Name
        {
            get;
            set;
        }

        public string VoucherCategoryCode
        {
            get;
            set;
        }

        public string DescFlexField_PrivateDescSeg2
        {
            get;
            set;
        }


        public DateTime CreateDate
        {
            get;
            set;
        }


        public string PostedPeriod
        {
            get;
            set;
        }
        /// <summary>
        /// 需要核销的科目
        /// </summary>
        public string Segment
        {
            get;
            set;
        }
        /// <summary>
        /// 需要核销的科目ID
        /// </summary>
        public long SegmentAccountID
        {
            get;
            set;
        }

        public int AttachmentCount
        {
            get;
            set;
        }
        public string VoucherType { get; set; }

        public long VoucherID
        {
            get;
            set;
        }
        public bool IsInternal
        {
            get;
            set;
        }

        public bool IsGenesis
        {
            get;
            set;
        }
        //转回功能字段
        public bool IsNeedReverse { get; set; }
        public int ReverseMethod { get; set; }
        public string ReversalPostPeriod { get; set; }
        public void CopyTo(GLVoucher voucher)
        {
            voucher.SOB = this.SOB;
            voucher.SOB_Code = SOB_Code;
            voucher.SOB_Name = SOB_Name;
            voucher.VoucherCategoryCode = VoucherCategoryCode;
            voucher.DescFlexField_PrivateDescSeg2 = DescFlexField_PrivateDescSeg2;
            voucher.CreateDate = CreateDate;
            voucher.PostedPeriod = PostedPeriod;
            voucher.AttachmentCount = AttachmentCount;
            voucher.IsInternal = IsInternal;
        }
        #endregion
    }
}
