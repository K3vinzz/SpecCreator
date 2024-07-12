using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OuterSpec.Models;

namespace OuterSpec.Context;

public partial class InsFormatContext : DbContext
{
    public InsFormatContext()
    {
    }

    public InsFormatContext(DbContextOptions<InsFormatContext> options)
        : base(options)
    {
    }

    public virtual DbSet<InsFormat> InsFormats { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=sql.pksit.net;Database=FET_DBS;User Id=kai;Password=Aa1108168*;TrustServerCertificate=True; persist security info=True;MultipleActiveResultSets=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<InsFormat>(entity =>
        {
            entity.HasKey(e => e.Ifcode);

            entity.ToTable("Ins_Format", tb => tb.HasComment("保單格式設定"));

            entity.Property(e => e.Ifcode)
                .HasComment("格式識別碼")
                .HasColumnName("IFCode");
            entity.Property(e => e.AddCost)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("加費指示");
            entity.Property(e => e.Agcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("經代或送件代號")
                .HasColumnName("AGCode");
            entity.Property(e => e.Age)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保年齡");
            entity.Property(e => e.Antype)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("給付項目")
                .HasColumnName("ANType");
            entity.Property(e => e.Anway)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("給付方式")
                .HasColumnName("ANWay");
            entity.Property(e => e.Arate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("發佣率")
                .HasColumnName("ARate");
            entity.Property(e => e.Area)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("坪數");
            entity.Property(e => e.AutoRc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("自動續保")
                .HasColumnName("AutoRC");
            entity.Property(e => e.BargainRate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("議價佣率");
            entity.Property(e => e.BargainReason)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("議價原因");
            entity.Property(e => e.Bdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("要保書申請日")
                .HasColumnName("BDate");
            entity.Property(e => e.BeName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("受益人");
            entity.Property(e => e.Bedate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("保障到期日")
                .HasColumnName("BEDate");
            entity.Property(e => e.Benefits)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("保額");
            entity.Property(e => e.Bname)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("獎金名稱")
                .HasColumnName("BName");
            entity.Property(e => e.BonusSel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("紅利選擇方式");
            entity.Property(e => e.Brate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("來佣率")
                .HasColumnName("BRate");
            entity.Property(e => e.BusinessSource)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("業務來源");
            entity.Property(e => e.Byp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("長火保障年期")
                .HasColumnName("BYP");
            entity.Property(e => e.Bypa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("繳費年期ABCDEF")
                .HasColumnName("BYPA");
            entity.Property(e => e.CarCc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("CC數")
                .HasColumnName("CarCC");
            entity.Property(e => e.CarMark)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("車輛廠牌");
            entity.Property(e => e.CarModel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("車籍資料");
            entity.Property(e => e.CarNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("車號");
            entity.Property(e => e.CarStyle)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("廠牌車型");
            entity.Property(e => e.CarType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("車輛種類");
            entity.Property(e => e.CardType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("信用卡別");
            entity.Property(e => e.Cdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("異動日")
                .HasColumnName("CDate");
            entity.Property(e => e.Ckc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("檢查碼")
                .HasColumnName("CKC");
            entity.Property(e => e.Cm1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("服務費")
                .HasColumnName("CM1");
            entity.Property(e => e.Cm2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("匯費補貼")
                .HasColumnName("CM2");
            entity.Property(e => e.Cm3)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("獎勵金")
                .HasColumnName("CM3");
            entity.Property(e => e.Cm4)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("收費津貼")
                .HasColumnName("CM4");
            entity.Property(e => e.Cm5)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("行政津貼")
                .HasColumnName("CM5");
            entity.Property(e => e.Cm6)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("其他津貼")
                .HasColumnName("CM6");
            entity.Property(e => e.Cm7)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("其他獎金")
                .HasColumnName("CM7");
            entity.Property(e => e.Cnt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("配息次數");
            entity.Property(e => e.Cost)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("持有原幣成本");
            entity.Property(e => e.Crc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("NTD")
                .HasComment("幣別")
                .HasColumnName("CRC");
            entity.Property(e => e.Crc2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("標的幣別")
                .HasColumnName("CRC2");
            entity.Property(e => e.Crcrate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("匯率")
                .HasColumnName("CRCRate");
            entity.Property(e => e.Crcrate2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("標的投入日匯率")
                .HasColumnName("CRCRate2");
            entity.Property(e => e.Days)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("其他天數");
            entity.Property(e => e.DealerNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("盤商代號");
            entity.Property(e => e.Discount)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("折扣金額");
            entity.Property(e => e.DlvBdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("進件申請日")
                .HasColumnName("DlvBDate");
            entity.Property(e => e.Ebnf)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("地震保額")
                .HasColumnName("EBnf");
            entity.Property(e => e.Edate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("到期應繳日")
                .HasColumnName("EDate");
            entity.Property(e => e.Eedate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("地震到期日")
                .HasColumnName("EEDate");
            entity.Property(e => e.Eft)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("檔案代碼")
                .HasColumnName("EFT");
            entity.Property(e => e.Efyb)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("地震佣金")
                .HasColumnName("EFYB");
            entity.Property(e => e.Efyp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("地震保費")
                .HasColumnName("EFYP");
            entity.Property(e => e.Eia)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("預估配息原幣金額")
                .HasColumnName("EIA");
            entity.Property(e => e.EndPayWay)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("滿期給付方式");
            entity.Property(e => e.EngNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("引擎號碼");
            entity.Property(e => e.Eperiod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("到期月份")
                .HasColumnName("EPeriod");
            entity.Property(e => e.Eport)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("迄埠")
                .HasColumnName("EPort");
            entity.Property(e => e.Esdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("地震生效日")
                .HasColumnName("ESDate");
            entity.Property(e => e.ExIno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("前保單號碼")
                .HasColumnName("ExINo");
            entity.Property(e => e.FactoryDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("出廠日");
            entity.Property(e => e.FactoryYm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("出廠年月")
                .HasColumnName("FactoryYM");
            entity.Property(e => e.Fbi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("FBI")
                .HasColumnName("FBI");
            entity.Property(e => e.Fbnf)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("火險保額")
                .HasColumnName("FBnf");
            entity.Property(e => e.Fcompany)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("投資標的物公司代碼")
                .HasColumnName("FCompany");
            entity.Property(e => e.Fedate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("火險到期日")
                .HasColumnName("FEDate");
            entity.Property(e => e.Ffyb)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("外幣或火險佣金")
                .HasColumnName("FFYB");
            entity.Property(e => e.Ffyp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("外幣或火險保費")
                .HasColumnName("FFYP");
            entity.Property(e => e.Files)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("附件檔名");
            entity.Property(e => e.Fitem)
                .HasMaxLength(20)
                .HasComment("格式名稱")
                .HasColumnName("FItem");
            entity.Property(e => e.FixTm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("可維修次數/金額")
                .HasColumnName("FixTM");
            entity.Property(e => e.FixedTm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("已維修次數/金額")
                .HasColumnName("FixedTM");
            entity.Property(e => e.Floor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("樓層");
            entity.Property(e => e.FloorDown)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("地下樓層數");
            entity.Property(e => e.FloorUp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("地上樓層數")
                .HasColumnName("FloorUP");
            entity.Property(e => e.Fname)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("投資標的名稱")
                .HasColumnName("FName");
            entity.Property(e => e.Fno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("投資標的代號")
                .HasColumnName("FNo");
            entity.Property(e => e.FreeDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("免解約金日");
            entity.Property(e => e.Fsdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("火險生效日")
                .HasColumnName("FSDate");
            entity.Property(e => e.Ft)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("分隔類型")
                .HasColumnName("FT");
            entity.Property(e => e.Fya)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("發佣")
                .HasColumnName("FYA");
            entity.Property(e => e.Fyb)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("台幣或附加來佣")
                .HasColumnName("FYB");
            entity.Property(e => e.Fyear)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("建造年份")
                .HasColumnName("FYear");
            entity.Property(e => e.Fyp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("台幣或附加保費")
                .HasColumnName("FYP");
            entity.Property(e => e.Fypacc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("累計實繳原幣保費")
                .HasColumnName("FYPACC");
            entity.Property(e => e.Fyptype)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("保費類型")
                .HasColumnName("FYPType");
            entity.Property(e => e.Gc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("單位代碼")
                .HasColumnName("GC");
            entity.Property(e => e.Goal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("標的餘額");
            entity.Property(e => e.Grade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("建物等級");
            entity.Property(e => e.Hgno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("獎品卡號")
                .HasColumnName("HGNo");
            entity.Property(e => e.Hid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("招攬人ID")
                .HasColumnName("HID");
            entity.Property(e => e.Hid2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("招攬人2ID")
                .HasColumnName("HID2");
            entity.Property(e => e.Hname)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("招攬人姓名")
                .HasColumnName("HName");
            entity.Property(e => e.Iaddr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人寄送地址")
                .HasColumnName("IAddr");
            entity.Property(e => e.IaddrNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人寄送郵編")
                .HasColumnName("IAddrNo");
            entity.Property(e => e.Idate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("核保簽單")
                .HasColumnName("IDate");
            entity.Property(e => e.Iename)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人英文姓名")
                .HasColumnName("IEName");
            entity.Property(e => e.Ifyb)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("外幣佣金")
                .HasColumnName("IFYB");
            entity.Property(e => e.Ifyp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("外幣保費")
                .HasColumnName("IFYP");
            entity.Property(e => e.InWay)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("配息方式");
            entity.Property(e => e.Ino)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("保單號碼")
                .HasColumnName("INo");
            entity.Property(e => e.InsAddr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人戶籍地址");
            entity.Property(e => e.InsAddrNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人戶籍郵編");
            entity.Property(e => e.InsBdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人生日")
                .HasColumnName("InsBDate");
            entity.Property(e => e.InsCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("商品代碼")
                .HasColumnName("Ins_Code");
            entity.Property(e => e.InsContry)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("要保人聯絡地址國家");
            entity.Property(e => e.InsCost)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("保險成本");
            entity.Property(e => e.InsEmail)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人EMAIL")
                .HasColumnName("InsEMail");
            entity.Property(e => e.InsFax)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人傳真");
            entity.Property(e => e.InsHomeAddr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人住居地址");
            entity.Property(e => e.InsHomeAddrNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人住居地址郵遞區號");
            entity.Property(e => e.InsHomeContry)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("要保人住居地址國家");
            entity.Property(e => e.InsHtel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人電話")
                .HasColumnName("InsHTEL");
            entity.Property(e => e.InsId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人ID")
                .HasColumnName("InsID");
            entity.Property(e => e.InsInd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人職業代碼");
            entity.Property(e => e.InsMobile)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人手機");
            entity.Property(e => e.InsMrg)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人婚姻")
                .HasColumnName("InsMRG");
            entity.Property(e => e.InsName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人姓名");
            entity.Property(e => e.InsOtel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人公司電話")
                .HasColumnName("InsOTEL");
            entity.Property(e => e.InsPartEdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("批單止日")
                .HasColumnName("InsPartEDate");
            entity.Property(e => e.InsPartSdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("批單起日")
                .HasColumnName("InsPartSDate");
            entity.Property(e => e.InsRegAddr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人通訊地址");
            entity.Property(e => e.InsRegAddrNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人通訊郵編");
            entity.Property(e => e.InsRegContry)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("要保人戶籍地址國家");
            entity.Property(e => e.InsSex)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人性別");
            entity.Property(e => e.InsWork)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人任職工作名稱");
            entity.Property(e => e.InsWorkCt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人工作內容");
            entity.Property(e => e.InvNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("發票號碼");
            entity.Property(e => e.InvType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("投資標的類型");
            entity.Property(e => e.Itype)
                .HasDefaultValue((byte)1)
                .HasComment("格式類型")
                .HasColumnName("IType");
            entity.Property(e => e.LicenceNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("行照號碼");
            entity.Property(e => e.LicenceYm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("原始發照年份")
                .HasColumnName("LicenceYM");
            entity.Property(e => e.Lid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("主管ID")
                .HasColumnName("LID");
            entity.Property(e => e.Lname)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("主管姓名")
                .HasColumnName("LName");
            entity.Property(e => e.Maddr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("標的物地址")
                .HasColumnName("MAddr");
            entity.Property(e => e.Maddr2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("建物地址")
                .HasColumnName("MAddr2");
            entity.Property(e => e.Main)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("主附約");
            entity.Property(e => e.Mbday)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("繳款人生日")
                .HasColumnName("MBDay");
            entity.Property(e => e.Mcontry)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("繳款人國籍")
                .HasColumnName("MContry");
            entity.Property(e => e.MdfDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("修改日期")
                .HasColumnType("datetime")
                .HasColumnName("MDF_Date");
            entity.Property(e => e.MdfUser)
                .HasComment("修改人")
                .HasColumnName("MDF_User");
            entity.Property(e => e.Mid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("繳款人ID")
                .HasColumnName("MID");
            entity.Property(e => e.Mname)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("繳款人姓名")
                .HasColumnName("MName");
            entity.Property(e => e.Msex)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("繳款人性別")
                .HasColumnName("MSex");
            entity.Property(e => e.Nce)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("NCE碼")
                .HasColumnName("NCE");
            entity.Property(e => e.Ndlist)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("名單細項")
                .HasColumnName("NDList");
            entity.Property(e => e.Nlist)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("名單種類")
                .HasColumnName("NList");
            entity.Property(e => e.Ocor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("原幣貸款本金")
                .HasColumnName("OCor");
            entity.Property(e => e.Odtype)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("其他子類別")
                .HasColumnName("ODType");
            entity.Property(e => e.Oin)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("原幣貸款利息");
            entity.Property(e => e.Ono)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("其他代號")
                .HasColumnName("ONo");
            entity.Property(e => e.Otype)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("其他類別")
                .HasColumnName("OType");
            entity.Property(e => e.OutOfAccountPeriod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("出帳月份");
            entity.Property(e => e.Oyn)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("其他")
                .HasColumnName("OYN");
            entity.Property(e => e.Paddr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("要保人戶籍地址")
                .HasColumnName("PAddr");
            entity.Property(e => e.PaddrNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("要保人戶籍郵編")
                .HasColumnName("PAddrNo");
            entity.Property(e => e.PartEdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("批單止日")
                .HasColumnName("PartEDate");
            entity.Property(e => e.PartNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasComment("批單號碼");
            entity.Property(e => e.PayAmt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("付款金額");
            entity.Property(e => e.PayBank)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("發卡或轉帳銀行");
            entity.Property(e => e.PayNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("放貸款帳號");
            entity.Property(e => e.PayWay)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("繳費方式");
            entity.Property(e => e.PayWayS)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("續期繳費方式");
            entity.Property(e => e.Payment)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("卡號或委扣帳號");
            entity.Property(e => e.Pbdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("要保人生日")
                .HasColumnName("PBDate");
            entity.Property(e => e.Pcontry)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人聯絡地址國家")
                .HasColumnName("PContry");
            entity.Property(e => e.Pdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("繳費日")
                .HasColumnName("PDate");
            entity.Property(e => e.Pemail)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("要保人EMail")
                .HasColumnName("PEMail");
            entity.Property(e => e.Pename)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("持有人英文姓名")
                .HasColumnName("PEName");
            entity.Property(e => e.Period)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("佣金月份");
            entity.Property(e => e.Pfax)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("要保人傳真")
                .HasColumnName("PFax");
            entity.Property(e => e.PhomeAddr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("要保人住居地址")
                .HasColumnName("PHomeAddr");
            entity.Property(e => e.PhomeAddrNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("要保人住居地址郵遞區號")
                .HasColumnName("PHomeAddrNo");
            entity.Property(e => e.PhomeContry)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人住居地址國家")
                .HasColumnName("PHomeContry");
            entity.Property(e => e.PhoneImei)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("IMEI/SN")
                .HasColumnName("Phone_IMEI");
            entity.Property(e => e.PhoneNmber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("手機門號")
                .HasColumnName("Phone_Nmber");
            entity.Property(e => e.PhonePayment)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("承保自付額")
                .HasColumnName("Phone_Payment");
            entity.Property(e => e.PhonePrice)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("空機價格")
                .HasColumnName("Phone_Price");
            entity.Property(e => e.PhoneStyle)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("手機廠牌")
                .HasColumnName("Phone_Style");
            entity.Property(e => e.PhoneType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("手機型號")
                .HasColumnName("Phone_Type");
            entity.Property(e => e.Phtel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("要保人電話")
                .HasColumnName("PHTEL");
            entity.Property(e => e.Pia)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("實際配息金額")
                .HasColumnName("PIA");
            entity.Property(e => e.Piarate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("實際配息率")
                .HasColumnName("PIARate");
            entity.Property(e => e.Pid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("要保人ID")
                .HasColumnName("PID");
            entity.Property(e => e.Pmobile)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("要保人手機")
                .HasColumnName("PMobile");
            entity.Property(e => e.Pmrg)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("要保人婚姻")
                .HasColumnName("PMRG");
            entity.Property(e => e.Pname)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("要保人姓名")
                .HasColumnName("PName");
            entity.Property(e => e.Potel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("要保人公司電話")
                .HasColumnName("POTEL");
            entity.Property(e => e.PptcarType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("車險件別")
                .HasColumnName("PPTCarType");
            entity.Property(e => e.PregAddr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("要保人寄送地址")
                .HasColumnName("PRegAddr");
            entity.Property(e => e.PregAddrNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("要保人寄送郵編")
                .HasColumnName("PRegAddrNo");
            entity.Property(e => e.PregContry)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("被保人戶籍地址國家")
                .HasColumnName("PRegContry");
            entity.Property(e => e.Priv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("密戶指示");
            entity.Property(e => e.PrjCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("專案代碼")
                .HasColumnName("Prj_Code");
            entity.Property(e => e.PrmRate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("約定比率");
            entity.Property(e => e.ProName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("商品名稱")
                .HasColumnName("Pro_Name");
            entity.Property(e => e.ProType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("商品別");
            entity.Property(e => e.Procs).HasComment("特處碼");
            entity.Property(e => e.PromotionNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("促銷代號");
            entity.Property(e => e.Psex)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("要保人性別")
                .HasColumnName("PSex");
            entity.Property(e => e.Pt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("繳次")
                .HasColumnName("PT");
            entity.Property(e => e.Pw)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("繳別")
                .HasColumnName("PW");
            entity.Property(e => e.Pwtype)
                .HasComment("繳別類型")
                .HasColumnName("PWType");
            entity.Property(e => e.Rdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("受理日")
                .HasColumnName("RDate");
            entity.Property(e => e.Rditem)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("通路細項")
                .HasColumnName("RDItem");
            entity.Property(e => e.Relation)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("要被保關係");
            entity.Property(e => e.Remark)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("備註");
            entity.Property(e => e.Remark2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("備註2");
            entity.Property(e => e.RepDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("停效迄日");
            entity.Property(e => e.Ritem)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("通路代碼")
                .HasColumnName("RItem");
            entity.Property(e => e.Roa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("原幣含息報酬率")
                .HasColumnName("ROA");
            entity.Property(e => e.Roi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("原幣不含息報酬率")
                .HasColumnName("ROI");
            entity.Property(e => e.Roof)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("天花板");
            entity.Property(e => e.S1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("預留1");
            entity.Property(e => e.S2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("預留2");
            entity.Property(e => e.S3)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("預留3");
            entity.Property(e => e.Sdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("生效日")
                .HasColumnName("SDate");
            entity.Property(e => e.SendDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("保單郵寄日");
            entity.Property(e => e.Sfyp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("應收佣金")
                .HasColumnName("SFYP");
            entity.Property(e => e.Ship)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("航班");
            entity.Property(e => e.Sia)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("儲存生息餘額")
                .HasColumnName("SIA");
            entity.Property(e => e.Siadate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("儲存生息餘額計算日")
                .HasColumnName("SIADate");
            entity.Property(e => e.Sitem)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("客戶來源")
                .HasColumnName("SItem");
            entity.Property(e => e.Sno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("受理編號")
                .HasColumnName("SNo");
            entity.Property(e => e.SoundNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("錄音資料序號");
            entity.Property(e => e.SpDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("停效起日");
            entity.Property(e => e.Sport)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("起埠")
                .HasColumnName("SPort");
            entity.Property(e => e.Srv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("服務費")
                .HasColumnName("SRV");
            entity.Property(e => e.St)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("保單狀態碼")
                .HasColumnName("ST");
            entity.Property(e => e.Stage)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("分期期數");
            entity.Property(e => e.Struc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("結構");
            entity.Property(e => e.Supplier)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("保險公司");
            entity.Property(e => e.TargetCost)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("持有標的成本");
            entity.Property(e => e.TargetRoa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("標的含息報酬率")
                .HasColumnName("TargetROA");
            entity.Property(e => e.TargetRoi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("標的不含息報酬率")
                .HasColumnName("TargetROI");
            entity.Property(e => e.TargetValue)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("目前標的價值");
            entity.Property(e => e.TargetWithdraw)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("標的已領現金配息");
            entity.Property(e => e.TargetWithdrawAcc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("標的累計現金配息")
                .HasColumnName("TargetWithdrawACC");
            entity.Property(e => e.Tcor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("臺幣貸款本金")
                .HasColumnName("TCor");
            entity.Property(e => e.Tcost)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("持有台幣成本")
                .HasColumnName("TCost");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("保單簽收日")
                .HasColumnName("TDate");
            entity.Property(e => e.Tfypacc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("累計實繳台幣保費")
                .HasColumnName("TFYPACC");
            entity.Property(e => e.Tin)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("臺幣貸款利息");
            entity.Property(e => e.Troa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("台幣含息報酬率")
                .HasColumnName("TROA");
            entity.Property(e => e.Troi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("台幣不含息報酬率")
                .HasColumnName("TROI");
            entity.Property(e => e.Tvalue)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("目前台幣價值")
                .HasColumnName("TValue");
            entity.Property(e => e.Twithdraw)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("累計台幣提領金額")
                .HasColumnName("TWithdraw");
            entity.Property(e => e.TwithdrawAcc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("台幣累計現金配息")
                .HasColumnName("TWithdrawACC");
            entity.Property(e => e.Ufyp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("表訂保費")
                .HasColumnName("UFYP");
            entity.Property(e => e.Unit)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("保額單位");
            entity.Property(e => e.Url)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("網址")
                .HasColumnName("URL");
            entity.Property(e => e.Value)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("目前原幣價值");
            entity.Property(e => e.Withdraw)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("累計原幣提領金額");
            entity.Property(e => e.WithdrawAcc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("累計原幣現金配息")
                .HasColumnName("WithdrawACC");
            entity.Property(e => e.WriteOffNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("銷帳編號");
            entity.Property(e => e.WriteOffSdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("銷帳起始日")
                .HasColumnName("WriteOffSDate");
            entity.Property(e => e.Xfyb)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("附約佣金")
                .HasColumnName("XFYB");
            entity.Property(e => e.Xfyp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("附約保費")
                .HasColumnName("XFYP");
            entity.Property(e => e.Yp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("繳費年期")
                .HasColumnName("YP");
            entity.Property(e => e.Ypa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("保障年期ABC")
                .HasColumnName("YPA");
            entity.Property(e => e.Yr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("保單年度")
                .HasColumnName("YR");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
