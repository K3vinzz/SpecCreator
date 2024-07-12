using System;
using System.Collections.Generic;

namespace OuterSpec.Models;

/// <summary>
/// 保單格式設定
/// </summary>
public partial class InsFormat
{
    /// <summary>
    /// 格式識別碼
    /// </summary>
    public int Ifcode { get; set; }

    /// <summary>
    /// 格式類型
    /// </summary>
    public byte? Itype { get; set; }

    /// <summary>
    /// 格式名稱
    /// </summary>
    public string? Fitem { get; set; }

    /// <summary>
    /// 分隔類型
    /// </summary>
    public string? Ft { get; set; }

    /// <summary>
    /// 檔案代碼
    /// </summary>
    public string? Eft { get; set; }

    /// <summary>
    /// 繳別類型
    /// </summary>
    public int? Pwtype { get; set; }

    /// <summary>
    /// 檢查碼
    /// </summary>
    public string? Ckc { get; set; }

    /// <summary>
    /// 特處碼
    /// </summary>
    public int? Procs { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime? MdfDate { get; set; }

    /// <summary>
    /// 修改人
    /// </summary>
    public int? MdfUser { get; set; }

    /// <summary>
    /// 佣金月份
    /// </summary>
    public string? Period { get; set; }

    /// <summary>
    /// 獎金名稱
    /// </summary>
    public string? Bname { get; set; }

    /// <summary>
    /// 保險公司
    /// </summary>
    public string? Supplier { get; set; }

    /// <summary>
    /// 受理編號
    /// </summary>
    public string? Sno { get; set; }

    /// <summary>
    /// 保單號碼
    /// </summary>
    public string? Ino { get; set; }

    /// <summary>
    /// 批單號碼
    /// </summary>
    public string? PartNo { get; set; }

    /// <summary>
    /// 前保單號碼
    /// </summary>
    public string? ExIno { get; set; }

    /// <summary>
    /// 到期月份
    /// </summary>
    public string? Eperiod { get; set; }

    /// <summary>
    /// NCE碼
    /// </summary>
    public string? Nce { get; set; }

    /// <summary>
    /// 自動續保
    /// </summary>
    public string? AutoRc { get; set; }

    /// <summary>
    /// 客戶來源
    /// </summary>
    public string? Sitem { get; set; }

    /// <summary>
    /// 保單狀態碼
    /// </summary>
    public string? St { get; set; }

    /// <summary>
    /// 受理日
    /// </summary>
    public string? Rdate { get; set; }

    /// <summary>
    /// 核保簽單
    /// </summary>
    public string? Idate { get; set; }

    /// <summary>
    /// 生效日
    /// </summary>
    public string? Sdate { get; set; }

    /// <summary>
    /// 到期應繳日
    /// </summary>
    public string? Edate { get; set; }

    /// <summary>
    /// 繳費日
    /// </summary>
    public string? Pdate { get; set; }

    /// <summary>
    /// 要保書申請日
    /// </summary>
    public string? Bdate { get; set; }

    /// <summary>
    /// 異動日
    /// </summary>
    public string? Cdate { get; set; }

    /// <summary>
    /// 經代或送件代號
    /// </summary>
    public string? Agcode { get; set; }

    /// <summary>
    /// 單位代碼
    /// </summary>
    public string? Gc { get; set; }

    /// <summary>
    /// 招攬人ID
    /// </summary>
    public string? Hid { get; set; }

    /// <summary>
    /// 招攬人姓名
    /// </summary>
    public string? Hname { get; set; }

    /// <summary>
    /// 招攬人2ID
    /// </summary>
    public string? Hid2 { get; set; }

    /// <summary>
    /// 主管ID
    /// </summary>
    public string? Lid { get; set; }

    /// <summary>
    /// 主管姓名
    /// </summary>
    public string? Lname { get; set; }

    /// <summary>
    /// 滿期給付方式
    /// </summary>
    public string? EndPayWay { get; set; }

    /// <summary>
    /// 紅利選擇方式
    /// </summary>
    public string? BonusSel { get; set; }

    /// <summary>
    /// 商品代碼
    /// </summary>
    public string? InsCode { get; set; }

    /// <summary>
    /// 專案代碼
    /// </summary>
    public string? PrjCode { get; set; }

    /// <summary>
    /// 商品別
    /// </summary>
    public string? ProType { get; set; }

    /// <summary>
    /// 主附約
    /// </summary>
    public string? Main { get; set; }

    /// <summary>
    /// 繳別
    /// </summary>
    public string? Pw { get; set; }

    /// <summary>
    /// 繳次
    /// </summary>
    public string? Pt { get; set; }

    /// <summary>
    /// 保費類型
    /// </summary>
    public string? Fyptype { get; set; }

    /// <summary>
    /// 繳費方式
    /// </summary>
    public string? PayWay { get; set; }

    /// <summary>
    /// 保單年度
    /// </summary>
    public string? Yr { get; set; }

    /// <summary>
    /// 繳費年期
    /// </summary>
    public string? Yp { get; set; }

    /// <summary>
    /// 長火保障年期
    /// </summary>
    public string? Byp { get; set; }

    /// <summary>
    /// 保障到期日
    /// </summary>
    public string? Bedate { get; set; }

    /// <summary>
    /// 保額
    /// </summary>
    public string? Benefits { get; set; }

    /// <summary>
    /// 保額單位
    /// </summary>
    public string? Unit { get; set; }

    /// <summary>
    /// 幣別
    /// </summary>
    public string? Crc { get; set; }

    /// <summary>
    /// 匯率
    /// </summary>
    public string? Crcrate { get; set; }

    /// <summary>
    /// 表訂保費
    /// </summary>
    public string? Ufyp { get; set; }

    /// <summary>
    /// 台幣或附加保費
    /// </summary>
    public string? Fyp { get; set; }

    /// <summary>
    /// 來佣率
    /// </summary>
    public string? Brate { get; set; }

    /// <summary>
    /// 台幣或附加來佣
    /// </summary>
    public string? Fyb { get; set; }

    /// <summary>
    /// 發佣率
    /// </summary>
    public string? Arate { get; set; }

    /// <summary>
    /// 發佣
    /// </summary>
    public string? Fya { get; set; }

    /// <summary>
    /// 折扣金額
    /// </summary>
    public string? Discount { get; set; }

    /// <summary>
    /// 服務費
    /// </summary>
    public string? Srv { get; set; }

    /// <summary>
    /// 被保人寄送郵編
    /// </summary>
    public string? IaddrNo { get; set; }

    /// <summary>
    /// 被保人寄送地址
    /// </summary>
    public string? Iaddr { get; set; }

    /// <summary>
    /// 要保人ID
    /// </summary>
    public string? Pid { get; set; }

    /// <summary>
    /// 要保人姓名
    /// </summary>
    public string? Pname { get; set; }

    /// <summary>
    /// 要保人生日
    /// </summary>
    public string? Pbdate { get; set; }

    /// <summary>
    /// 要保人性別
    /// </summary>
    public string? Psex { get; set; }

    /// <summary>
    /// 要保人婚姻
    /// </summary>
    public string? Pmrg { get; set; }

    /// <summary>
    /// 要保人電話
    /// </summary>
    public string? Phtel { get; set; }

    /// <summary>
    /// 要保人公司電話
    /// </summary>
    public string? Potel { get; set; }

    /// <summary>
    /// 要保人傳真
    /// </summary>
    public string? Pfax { get; set; }

    /// <summary>
    /// 要保人手機
    /// </summary>
    public string? Pmobile { get; set; }

    /// <summary>
    /// 要保人EMail
    /// </summary>
    public string? Pemail { get; set; }

    /// <summary>
    /// 要保人寄送郵編
    /// </summary>
    public string? PregAddrNo { get; set; }

    /// <summary>
    /// 要保人寄送地址
    /// </summary>
    public string? PregAddr { get; set; }

    /// <summary>
    /// 要保人戶籍郵編
    /// </summary>
    public string? PaddrNo { get; set; }

    /// <summary>
    /// 要保人戶籍地址
    /// </summary>
    public string? Paddr { get; set; }

    /// <summary>
    /// 被保人ID
    /// </summary>
    public string? InsId { get; set; }

    /// <summary>
    /// 被保人姓名
    /// </summary>
    public string? InsName { get; set; }

    /// <summary>
    /// 被保人生日
    /// </summary>
    public string? InsBdate { get; set; }

    /// <summary>
    /// 被保人性別
    /// </summary>
    public string? InsSex { get; set; }

    /// <summary>
    /// 被保年齡
    /// </summary>
    public string? Age { get; set; }

    /// <summary>
    /// 被保人婚姻
    /// </summary>
    public string? InsMrg { get; set; }

    /// <summary>
    /// 被保人電話
    /// </summary>
    public string? InsHtel { get; set; }

    /// <summary>
    /// 被保人公司電話
    /// </summary>
    public string? InsOtel { get; set; }

    /// <summary>
    /// 被保人傳真
    /// </summary>
    public string? InsFax { get; set; }

    /// <summary>
    /// 被保人手機
    /// </summary>
    public string? InsMobile { get; set; }

    /// <summary>
    /// 被保人EMAIL
    /// </summary>
    public string? InsEmail { get; set; }

    /// <summary>
    /// 被保人通訊郵編
    /// </summary>
    public string? InsRegAddrNo { get; set; }

    /// <summary>
    /// 被保人通訊地址
    /// </summary>
    public string? InsRegAddr { get; set; }

    /// <summary>
    /// 被保人戶籍郵編
    /// </summary>
    public string? InsAddrNo { get; set; }

    /// <summary>
    /// 被保人戶籍地址
    /// </summary>
    public string? InsAddr { get; set; }

    /// <summary>
    /// 被保人職業代碼
    /// </summary>
    public string? InsInd { get; set; }

    /// <summary>
    /// 受益人
    /// </summary>
    public string? BeName { get; set; }

    /// <summary>
    /// 要被保關係
    /// </summary>
    public string? Relation { get; set; }

    /// <summary>
    /// 外幣或火險保費
    /// </summary>
    public string? Ffyp { get; set; }

    /// <summary>
    /// 外幣或火險佣金
    /// </summary>
    public string? Ffyb { get; set; }

    /// <summary>
    /// 火險保額
    /// </summary>
    public string? Fbnf { get; set; }

    /// <summary>
    /// 火險生效日
    /// </summary>
    public string? Fsdate { get; set; }

    /// <summary>
    /// 火險到期日
    /// </summary>
    public string? Fedate { get; set; }

    /// <summary>
    /// 地震保費
    /// </summary>
    public string? Efyp { get; set; }

    /// <summary>
    /// 地震佣金
    /// </summary>
    public string? Efyb { get; set; }

    /// <summary>
    /// 地震保額
    /// </summary>
    public string? Ebnf { get; set; }

    /// <summary>
    /// 地震生效日
    /// </summary>
    public string? Esdate { get; set; }

    /// <summary>
    /// 地震到期日
    /// </summary>
    public string? Eedate { get; set; }

    /// <summary>
    /// 放貸款帳號
    /// </summary>
    public string? PayNo { get; set; }

    /// <summary>
    /// 信用卡別
    /// </summary>
    public string? CardType { get; set; }

    /// <summary>
    /// 發卡或轉帳銀行
    /// </summary>
    public string? PayBank { get; set; }

    /// <summary>
    /// 卡號或委扣帳號
    /// </summary>
    public string? Payment { get; set; }

    /// <summary>
    /// 付款金額
    /// </summary>
    public string? PayAmt { get; set; }

    /// <summary>
    /// 其他代號
    /// </summary>
    public string? Ono { get; set; }

    /// <summary>
    /// 其他類別
    /// </summary>
    public string? Otype { get; set; }

    /// <summary>
    /// 其他子類別
    /// </summary>
    public string? Odtype { get; set; }

    /// <summary>
    /// 其他天數
    /// </summary>
    public string? Days { get; set; }

    /// <summary>
    /// 其他
    /// </summary>
    public string? Oyn { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 車號
    /// </summary>
    public string? CarNo { get; set; }

    /// <summary>
    /// CC數
    /// </summary>
    public string? CarCc { get; set; }

    /// <summary>
    /// 車輛廠牌
    /// </summary>
    public string? CarMark { get; set; }

    /// <summary>
    /// 出廠日
    /// </summary>
    public string? FactoryDate { get; set; }

    /// <summary>
    /// 行照號碼
    /// </summary>
    public string? LicenceNo { get; set; }

    /// <summary>
    /// 引擎號碼
    /// </summary>
    public string? EngNo { get; set; }

    /// <summary>
    /// 樓層
    /// </summary>
    public string? Floor { get; set; }

    /// <summary>
    /// 結構
    /// </summary>
    public string? Struc { get; set; }

    /// <summary>
    /// 天花板
    /// </summary>
    public string? Roof { get; set; }

    /// <summary>
    /// 坪數
    /// </summary>
    public string? Area { get; set; }

    /// <summary>
    /// 建造年份
    /// </summary>
    public string? Fyear { get; set; }

    /// <summary>
    /// 航班
    /// </summary>
    public string? Ship { get; set; }

    /// <summary>
    /// 起埠
    /// </summary>
    public string? Sport { get; set; }

    /// <summary>
    /// 迄埠
    /// </summary>
    public string? Eport { get; set; }

    /// <summary>
    /// 發票號碼
    /// </summary>
    public string? InvNo { get; set; }

    /// <summary>
    /// 獎品卡號
    /// </summary>
    public string? Hgno { get; set; }

    /// <summary>
    /// 通路代碼
    /// </summary>
    public string? Ritem { get; set; }

    /// <summary>
    /// 通路細項
    /// </summary>
    public string? Rditem { get; set; }

    /// <summary>
    /// 名單種類
    /// </summary>
    public string? Nlist { get; set; }

    /// <summary>
    /// 名單細項
    /// </summary>
    public string? Ndlist { get; set; }

    /// <summary>
    /// 累計實繳原幣保費
    /// </summary>
    public string? Fypacc { get; set; }

    /// <summary>
    /// 累計實繳台幣保費
    /// </summary>
    public string? Tfypacc { get; set; }

    /// <summary>
    /// 累計原幣提領金額
    /// </summary>
    public string? Withdraw { get; set; }

    /// <summary>
    /// 累計台幣提領金額
    /// </summary>
    public string? Twithdraw { get; set; }

    /// <summary>
    /// 保障年期ABC
    /// </summary>
    public string? Ypa { get; set; }

    /// <summary>
    /// 繳費年期ABCDEF
    /// </summary>
    public string? Bypa { get; set; }

    /// <summary>
    /// 預留1
    /// </summary>
    public string? S1 { get; set; }

    /// <summary>
    /// 預留2
    /// </summary>
    public string? S2 { get; set; }

    /// <summary>
    /// 預留3
    /// </summary>
    public string? S3 { get; set; }

    /// <summary>
    /// 服務費
    /// </summary>
    public string? Cm1 { get; set; }

    /// <summary>
    /// 匯費補貼
    /// </summary>
    public string? Cm2 { get; set; }

    /// <summary>
    /// 獎勵金
    /// </summary>
    public string? Cm3 { get; set; }

    /// <summary>
    /// 收費津貼
    /// </summary>
    public string? Cm4 { get; set; }

    /// <summary>
    /// 行政津貼
    /// </summary>
    public string? Cm5 { get; set; }

    /// <summary>
    /// 其他津貼
    /// </summary>
    public string? Cm6 { get; set; }

    /// <summary>
    /// 其他獎金
    /// </summary>
    public string? Cm7 { get; set; }

    /// <summary>
    /// 原始發照年份
    /// </summary>
    public string? LicenceYm { get; set; }

    /// <summary>
    /// 出廠年月
    /// </summary>
    public string? FactoryYm { get; set; }

    /// <summary>
    /// 車輛種類
    /// </summary>
    public string? CarType { get; set; }

    /// <summary>
    /// 附約保費
    /// </summary>
    public string? Xfyp { get; set; }

    /// <summary>
    /// 附約佣金
    /// </summary>
    public string? Xfyb { get; set; }

    /// <summary>
    /// 外幣保費
    /// </summary>
    public string? Ifyp { get; set; }

    /// <summary>
    /// 外幣佣金
    /// </summary>
    public string? Ifyb { get; set; }

    /// <summary>
    /// 應收佣金
    /// </summary>
    public string? Sfyp { get; set; }

    /// <summary>
    /// 網址
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// 附件檔名
    /// </summary>
    public string? Files { get; set; }

    /// <summary>
    /// 持有人英文姓名
    /// </summary>
    public string? Pename { get; set; }

    /// <summary>
    /// 被保人英文姓名
    /// </summary>
    public string? Iename { get; set; }

    /// <summary>
    /// 原幣貸款利息
    /// </summary>
    public string? Oin { get; set; }

    /// <summary>
    /// 原幣貸款本金
    /// </summary>
    public string? Ocor { get; set; }

    /// <summary>
    /// 臺幣貸款利息
    /// </summary>
    public string? Tin { get; set; }

    /// <summary>
    /// 臺幣貸款本金
    /// </summary>
    public string? Tcor { get; set; }

    /// <summary>
    /// 投資標的代號
    /// </summary>
    public string? Fno { get; set; }

    /// <summary>
    /// 投資標的名稱
    /// </summary>
    public string? Fname { get; set; }

    /// <summary>
    /// 投資標的物公司代碼
    /// </summary>
    public string? Fcompany { get; set; }

    /// <summary>
    /// 標的餘額
    /// </summary>
    public string? Goal { get; set; }

    /// <summary>
    /// 配息次數
    /// </summary>
    public string? Cnt { get; set; }

    /// <summary>
    /// FBI
    /// </summary>
    public string? Fbi { get; set; }

    /// <summary>
    /// 預估配息原幣金額
    /// </summary>
    public string? Eia { get; set; }

    /// <summary>
    /// 標的幣別
    /// </summary>
    public string? Crc2 { get; set; }

    /// <summary>
    /// 標的投入日匯率
    /// </summary>
    public string? Crcrate2 { get; set; }

    /// <summary>
    /// 配息方式
    /// </summary>
    public string? InWay { get; set; }

    /// <summary>
    /// 儲存生息餘額
    /// </summary>
    public string? Sia { get; set; }

    /// <summary>
    /// 儲存生息餘額計算日
    /// </summary>
    public string? Siadate { get; set; }

    /// <summary>
    /// 實際配息金額
    /// </summary>
    public string? Pia { get; set; }

    /// <summary>
    /// 實際配息率
    /// </summary>
    public string? Piarate { get; set; }

    /// <summary>
    /// 續期繳費方式
    /// </summary>
    public string? PayWayS { get; set; }

    /// <summary>
    /// 停效起日
    /// </summary>
    public string? SpDate { get; set; }

    /// <summary>
    /// 停效迄日
    /// </summary>
    public string? RepDate { get; set; }

    /// <summary>
    /// 免解約金日
    /// </summary>
    public string? FreeDate { get; set; }

    /// <summary>
    /// 保單郵寄日
    /// </summary>
    public string? SendDate { get; set; }

    /// <summary>
    /// 密戶指示
    /// </summary>
    public string? Priv { get; set; }

    /// <summary>
    /// 保單簽收日
    /// </summary>
    public string? Tdate { get; set; }

    /// <summary>
    /// 加費指示
    /// </summary>
    public string? AddCost { get; set; }

    /// <summary>
    /// 給付項目
    /// </summary>
    public string? Antype { get; set; }

    /// <summary>
    /// 給付方式
    /// </summary>
    public string? Anway { get; set; }

    /// <summary>
    /// 投資標的類型
    /// </summary>
    public string? InvType { get; set; }

    /// <summary>
    /// 持有原幣成本
    /// </summary>
    public string? Cost { get; set; }

    /// <summary>
    /// 持有台幣成本
    /// </summary>
    public string? Tcost { get; set; }

    /// <summary>
    /// 持有標的成本
    /// </summary>
    public string? TargetCost { get; set; }

    /// <summary>
    /// 目前原幣價值
    /// </summary>
    public string? Value { get; set; }

    /// <summary>
    /// 目前台幣價值
    /// </summary>
    public string? Tvalue { get; set; }

    /// <summary>
    /// 目前標的價值
    /// </summary>
    public string? TargetValue { get; set; }

    /// <summary>
    /// 原幣含息報酬率
    /// </summary>
    public string? Roa { get; set; }

    /// <summary>
    /// 台幣含息報酬率
    /// </summary>
    public string? Troa { get; set; }

    /// <summary>
    /// 標的含息報酬率
    /// </summary>
    public string? TargetRoa { get; set; }

    /// <summary>
    /// 原幣不含息報酬率
    /// </summary>
    public string? Roi { get; set; }

    /// <summary>
    /// 台幣不含息報酬率
    /// </summary>
    public string? Troi { get; set; }

    /// <summary>
    /// 標的不含息報酬率
    /// </summary>
    public string? TargetRoi { get; set; }

    /// <summary>
    /// 標的已領現金配息
    /// </summary>
    public string? TargetWithdraw { get; set; }

    /// <summary>
    /// 累計原幣現金配息
    /// </summary>
    public string? WithdrawAcc { get; set; }

    /// <summary>
    /// 台幣累計現金配息
    /// </summary>
    public string? TwithdrawAcc { get; set; }

    /// <summary>
    /// 標的累計現金配息
    /// </summary>
    public string? TargetWithdrawAcc { get; set; }

    /// <summary>
    /// 備註2
    /// </summary>
    public string? Remark2 { get; set; }

    /// <summary>
    /// 建物等級
    /// </summary>
    public string? Grade { get; set; }

    /// <summary>
    /// 標的物地址
    /// </summary>
    public string? Maddr { get; set; }

    /// <summary>
    /// 建物地址
    /// </summary>
    public string? Maddr2 { get; set; }

    /// <summary>
    /// 廠牌車型
    /// </summary>
    public string? CarStyle { get; set; }

    /// <summary>
    /// 車險件別
    /// </summary>
    public string? PptcarType { get; set; }

    /// <summary>
    /// 地上樓層數
    /// </summary>
    public string? FloorUp { get; set; }

    /// <summary>
    /// 地下樓層數
    /// </summary>
    public string? FloorDown { get; set; }

    /// <summary>
    /// 被保人住居地址
    /// </summary>
    public string? InsHomeAddr { get; set; }

    /// <summary>
    /// 要保人住居地址
    /// </summary>
    public string? PhomeAddr { get; set; }

    /// <summary>
    /// 要保人戶籍地址國家
    /// </summary>
    public string? InsRegContry { get; set; }

    /// <summary>
    /// 要保人聯絡地址國家
    /// </summary>
    public string? InsContry { get; set; }

    /// <summary>
    /// 要保人住居地址國家
    /// </summary>
    public string? InsHomeContry { get; set; }

    /// <summary>
    /// 被保人戶籍地址國家
    /// </summary>
    public string? PregContry { get; set; }

    /// <summary>
    /// 被保人聯絡地址國家
    /// </summary>
    public string? Pcontry { get; set; }

    /// <summary>
    /// 被保人住居地址國家
    /// </summary>
    public string? PhomeContry { get; set; }

    /// <summary>
    /// 被保人住居地址郵遞區號
    /// </summary>
    public string? InsHomeAddrNo { get; set; }

    /// <summary>
    /// 要保人住居地址郵遞區號
    /// </summary>
    public string? PhomeAddrNo { get; set; }

    /// <summary>
    /// 錄音資料序號
    /// </summary>
    public string? SoundNo { get; set; }

    /// <summary>
    /// 商品名稱
    /// </summary>
    public string? ProName { get; set; }

    /// <summary>
    /// 約定比率
    /// </summary>
    public string? PrmRate { get; set; }

    /// <summary>
    /// 保險成本
    /// </summary>
    public string? InsCost { get; set; }

    /// <summary>
    /// 車籍資料
    /// </summary>
    public string? CarModel { get; set; }

    /// <summary>
    /// 手機廠牌
    /// </summary>
    public string? PhoneStyle { get; set; }

    /// <summary>
    /// 手機型號
    /// </summary>
    public string? PhoneType { get; set; }

    /// <summary>
    /// IMEI/SN
    /// </summary>
    public string? PhoneImei { get; set; }

    /// <summary>
    /// 空機價格
    /// </summary>
    public string? PhonePrice { get; set; }

    /// <summary>
    /// 手機門號
    /// </summary>
    public string? PhoneNmber { get; set; }

    /// <summary>
    /// 承保自付額
    /// </summary>
    public string? PhonePayment { get; set; }

    /// <summary>
    /// 分期期數
    /// </summary>
    public string? Stage { get; set; }

    /// <summary>
    /// 業務來源
    /// </summary>
    public string? BusinessSource { get; set; }

    /// <summary>
    /// 銷帳起始日
    /// </summary>
    public string? WriteOffSdate { get; set; }

    /// <summary>
    /// 批單止日
    /// </summary>
    public string? PartEdate { get; set; }

    /// <summary>
    /// 批單起日
    /// </summary>
    public string? InsPartSdate { get; set; }

    /// <summary>
    /// 批單止日
    /// </summary>
    public string? InsPartEdate { get; set; }

    /// <summary>
    /// 出帳月份
    /// </summary>
    public string? OutOfAccountPeriod { get; set; }

    /// <summary>
    /// 進件申請日
    /// </summary>
    public string? DlvBdate { get; set; }

    /// <summary>
    /// 盤商代號
    /// </summary>
    public string? DealerNo { get; set; }

    /// <summary>
    /// 促銷代號
    /// </summary>
    public string? PromotionNo { get; set; }

    /// <summary>
    /// 被保人任職工作名稱
    /// </summary>
    public string? InsWork { get; set; }

    /// <summary>
    /// 被保人工作內容
    /// </summary>
    public string? InsWorkCt { get; set; }

    /// <summary>
    /// 銷帳編號
    /// </summary>
    public string? WriteOffNo { get; set; }

    /// <summary>
    /// 議價佣率
    /// </summary>
    public string? BargainRate { get; set; }

    /// <summary>
    /// 議價原因
    /// </summary>
    public string? BargainReason { get; set; }

    /// <summary>
    /// 可維修次數/金額
    /// </summary>
    public string? FixTm { get; set; }

    /// <summary>
    /// 已維修次數/金額
    /// </summary>
    public string? FixedTm { get; set; }

    /// <summary>
    /// 繳款人ID
    /// </summary>
    public string? Mid { get; set; }

    /// <summary>
    /// 繳款人姓名
    /// </summary>
    public string? Mname { get; set; }

    /// <summary>
    /// 繳款人生日
    /// </summary>
    public string? Mbday { get; set; }

    /// <summary>
    /// 繳款人性別
    /// </summary>
    public string? Msex { get; set; }

    /// <summary>
    /// 繳款人國籍
    /// </summary>
    public string? Mcontry { get; set; }
}
