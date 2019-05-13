<%@ Page Title="商品详细信息" Language="C#" MasterPageFile="~/MainPage.master" AutoEventWireup="true" CodeFile="FlowerInfo.aspx.cs" Inherits="FlowerInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="goodinfotitle"></div>
    <div id="goodinfotitleline"></div>
    <div id="goodinfomaintopleft">
        <div id="goodinfomaintopleftpictop"></div>
        <div id="goodinfomaintopleftpicleft"></div>
        <div id="goodinfomaintopleftpicmain">
            <div id="goodinfomaintopleftpic">
                <asp:Image ID="imgGoodPic" runat="server" Width="325px" Height="273px" />
            </div>
            <div id="goodinfomaintopleftpicbottom"></div>
        </div>
        <div id="goodinfomaintopleftpicright"></div>
    </div>
    <div id="goodinfomaintopright">
    
        <table width="345px" style=" color:#762697; text-align:left; font-size:14px;">
            <tr>
                <td style=" height:43px; ">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="lblId" runat="server" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr style="background-color:#FDF8FF; height:30px">
                <td style=" font-weight:bold; width:80px;">
                    名&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 称：</td>
                <td>
                    <asp:Label ID="lblName" runat="server" Text="" Font-Size="14px" Width="260px"></asp:Label></td>
            </tr>
            <tr style="height:30px">
                <td style=" font-weight:bold ;width:80px;">
                   组&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;成：</td>
                <td>
                    <asp:Label ID="lblComponent" runat="server" Text="" Font-Size="14px" Width="260px"></asp:Label></td>
            </tr>
            <tr style="background-color:#FDF8FF;height:30px">
                <td style=" font-weight:bold; width:80px;">
                    包&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;装：</td>
                <td>
                    <asp:Label ID="lblPackage" runat="server" Text="" Font-Size="14px" Width="260px"></asp:Label></td>
            </tr>
            <tr style="height:30px">
                <td style=" font-weight:bold; width:80px;">
                    花&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;语：</td>
                <td>
                    <asp:Label ID="lblDescribe" runat="server" Text="" Font-Size="14px" Width="260px"></asp:Label></td>
            </tr>
            <tr style="background-color:#FDF8FF;height:30px">
                <td style=" font-weight:bold; width:80px;">
                    配送范围：</td>
                <td>
                    <asp:Label ID="lblSendRange" runat="server" Text="" Font-Size="14px" Width="260px"></asp:Label></td>
            </tr>
            <tr style="height:30px">
                <td style=" font-weight:bold; width:80px;">
                    价&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;格：</td>
                <td>
                    <asp:Label ID="lblPrice" runat="server" Text="" Font-Size="14px" Width="260px"></asp:Label></td>
            </tr>
            <tr>
                <td style=" font-weight:bold; width:80px;">
                    &nbsp;</td>
                <td style=" text-align:right;">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style=" font-weight:bold; width:80px;">
                    &nbsp;</td>
                <td style=" text-align:right;">
                    <asp:ImageButton ID="imgBtnSubmit" runat="server" 
                        ImageUrl="~/Image/flowerinfo_submit.jpg" onclick="imgBtnSubmit_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    <div class="indextitleline"></div>
    <div id="goodinfomainnote">
        <div id="goodinfomainnoteleft"></div>
        <div id="goodinfomain">
            
            <table  style="width: 100%; text-align:left;color:#666666">
                <tr>
                    <td style="font-size: 14px;	color: #ffae01;	font-weight: bold;height:30px">
                        订花温馨提示：</td>
                </tr>
                <tr>
                    <td style="font-size: 14px;	font-weight: bold;height:30px">
                        替换原则</td>
                </tr>
                <tr>
                    <td style=" line-height:20px">
                        由于季节及当日店内花材的限制，需要更换主花材时，我们将电话向订货人提出更换建议，假如在有效配送时间内得不到订货人的确认，我们将采用同等价值或相同寓意的花材代替。由于当日店内配花配草的限制，没有的配花配草我们将自行按排相似效果的材料代替。</td>
                </tr>
                <tr>
                    <td style="height:10px">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="font-size: 14px;	font-weight: bold;height:30px">
                        会员制度</td>
                </tr>
                <tr>
                    <td style=" line-height:20px">
                        本站不用注册就可直接购买。<br />
                        活跃会员可获得更多优惠!</td>
                </tr>
                <tr>
                    <td style="height:30px">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="font-size: 14px;	font-weight: bold;height:30px">
                        配送说明</td>
                </tr>
                <tr>
                    <td style=" line-height:20px">
                       <strong>1、配送时间</strong><br />
          A、我们的日常配送时间是每天8：00 -- 20：00 节假日照常,其它时间需要根据情况加10-30元配送费用。在平时您可以规定具体时间配送，如“早9点送达”。我们承诺时间为您规定时间的正负30分钟内。一定要求几点几分送到的订单需要加收30元的定时服务费用。<br />
          B、非常规配送时间：每年大年三十早8：00 -- 大年初一晚22：00 期间请咨询我们，在可以配送的前提下需要收取50-100元的服务费.<br />
          C、重大节日的配送时间：在情人节、母亲节、圣诞节等重大节日，我们只保证当天送达，不能指定时间段,不提供定时服务。<br />
          <strong>2、配送范围</strong><br />
          全国大中城市,目前支持500多个城市,市区免费配送,郊区及郊县需要按当地习惯划分,并加收配送费20-100元不等。收花人地址能否配送到及配送费用,请点击查这里查看。<br />
          <strong>3 配送说明</strong><br />
          A、如无特殊要求，我们可能会在配送前与接收人电话联系，以确保递送成功。 <br />
          B、“配送前不要和接收人联系”“必须本人签收”等此类配送要求，希望您务必在订单中的“特殊要求”一栏中注明，否则请原谅我们无法承担相应的责任。如果因为客观原因如地点不明确，接收人长时间外出，无法联系接收人等，我们将会直接和您联系，协商解决。<br />
          C、经过与收花人联系，配送地址更改为免费配送区域以外地点时，需要您补交配送费用。<br />
          D、如果接收人出于非我们的原因而拒收，我们将直接和您联系，并视为订单递送完成。</td>
                </tr>
                <tr>
                    <td style="height:10px">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="font-size: 14px;	font-weight: bold;height:30px">
                        服务时间</td>
                </tr>
                <tr>
                    <td style=" line-height:20px">
                        365天，节假日不休息，每周7天，全天候服务，24小时接单； 每日送花时间：8:00-20：00。<br />
          国内热线:0311-******** [24小时]</td>
                </tr>
            </table>
            
        </div>
    </div>
</asp:Content>

