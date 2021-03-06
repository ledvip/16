﻿using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.domain;
using System.Xml.Serialization;

namespace _1688openapisdk.orderpush.domain
{
    public class OfferModel
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        public long offerId{get;set;}
        /// <summary>
        /// 是否为私密offer的标志位。true：私密产品 false：普通产品
        /// </summary>
        public Boolean isPrivate{get;set;}
        /// <summary>
        /// 私密属性列举。该字段列举此产品里面的所有私密字段。描述格式如下：私密字段1：私密字段2：私密字段n（‘:’为属性分隔符） 比如此产品的价格跟图片为私密，则privateProperties值为price:image
        /// </summary>
        public string privateProperties{get;set;}
        /// <summary>
        /// 商品详情地址
        /// </summary>
        public string detailsUrl{get;set;}
        /// <summary>
        /// 商品类型。Sale：供应信息，Buy：求购信息
        /// </summary>
        public string type{get;set;}
        /// <summary>
        /// 贸易类型。1：产品，2：加工，3：代理，4：合作，5：商务服务
        /// </summary>
        public String tradeType{get;set;}
        /// <summary>
        /// 所属叶子类目ID
        /// </summary>
        public int postCategryId{get;set;}
        /// <summary>
        /// 状态。auditing：审核中；online：已上网；FailAudited：审核未通过；outdated：已过期；member delete(d)：用户删除；delete：审核删除
        /// </summary>
        public string offerStatus{get;set;}
        /// <summary>
        /// 卖家会员ID
        /// </summary>
        public string memberId{get;set;}
        /// <summary>
        /// 商品标题
        /// </summary>
        public string  subject{get;set;}
        /// <summary>
        /// 详情说明
        /// </summary>
        public string details{get;set;}
        /// <summary>
        /// 商品信息质量星级( 取值为1到5)。1：一星；2：二星；3：三星；4：四星；5：五星
        /// </summary>
        public string qualityLevel { get; set; }

        /// <summary>
        /// 商品图片列表
        /// </summary>
        public ImageList imageList { get; set; }

        /// <summary>
        /// 商品属性信息
        /// </summary>
        public ProductFeatureList productFeatureList { get; set; }

        /// <summary>
        /// 是否支持网上交易。true：支持网上订购；false：不支持网上订购
        /// </summary>
        public Boolean isOfferSupportOnlineTrade { get; set; }
        /// <summary>
        /// 支持的交易方式。当isOfferSupportOnlineTrade为true的时候本字段有效：Escrow:支付宝担保交易； PreCharge：支付宝预存款交易；ForexPay：支付宝境外支付交易；多种交易方式间通过;分隔。
        /// </summary>
        public string  tradingType { get; set; }
        /// <summary>
        /// 是否支持混批。true：支持混批；false：不支持混批
        /// </summary>
        public Boolean isSupportMix { get; set; }
        /// <summary>
        /// 计量单位
        /// </summary>
        public string  unit { get; set; }
        /// <summary>
        /// 交易币种
        /// </summary>
        public string  priceUnit { get; set; }
        /// <summary>
        /// 供货量
        /// </summary>
        public int amount { get; set; }
        /// <summary>
        /// 可售数量
        /// </summary>
        public int amountOnSale { get; set; }
        /// <summary>
        /// 已销售量
        /// </summary>
        public int saledCount { get; set; }
        /// <summary>
        /// 建议零售价
        /// </summary>
        public double retailPrice { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public double unitPrice { get; set; }
        /// <summary>
        /// 价格区间
        /// </summary>
        public PriceRangeList priceRangeList { get; set; }
        /// <summary>
        /// 有效期(单位：天)
        /// </summary>
        public int termOfferProcess { get; set; }
        /// <summary>
        /// 物流模板id
        /// </summary>
        public int freightTemplateId { get; set; }
        /// <summary>
        /// 发货地址id
        /// </summary>
        public int sendGoodsId { get; set; }
        /// <summary>
        /// 单位重量
        /// </summary>
        public int productUnitWeight { get; set; }
        /// <summary>
        /// T:运费模板 D：运费说明 F：卖家承担运费
        /// </summary>
        public int freightType { get; set; }
        /// <summary>
        /// 是否为SKU商品
        /// </summary>
        public Boolean isSkuOffer { get; set; }
        /// <summary>
        /// 是否支持按照规格报价
        /// </summary>
        public Boolean isSkuTradeSupported { get; set; }
        /// <summary>
        /// SKU规格属性信息{fid:value}当有多个值时用"#"联接
        /// </summary>
        [XmlIgnore]
        public Dictionary<Object,Object> skuArray { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        public string gmtCreate { get; set; }
        /// <summary>
        /// 最近修改时间
        /// </summary>
        public string gmtModified { get; set; }
        /// <summary>
        /// 最近重发时间
        /// </summary>
        public string gmtLastRepost { get; set; }
        /// <summary>
        /// 审核通过时间
        /// </summary>
        public string gmtApproved { get; set; }
        /// <summary>
        /// 过期日期
        /// </summary>
        public string gmtExpire { get; set; }

    }
}
