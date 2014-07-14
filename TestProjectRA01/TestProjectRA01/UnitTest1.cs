using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WatiN.Core;


namespace TestProjectRA01
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IE ie = new IE("http://192.168.97.22/raweb/weblogin.aspx");
            
            ie.TextField("txtPass").TypeText("111111");
            
            ie.Image("Image1").Click();

            SelectList ddl = ie.SelectList(Find.ById("comTransact")); 
            ddl.Option("BJCA前台受理点").Select();

            ie.Button("btNext").Click();

            ///换成可配置地址
            IE ie2 = new IE("http://192.168.97.22/raweb/input/operationfirst.aspx");

            SelectList ddlchannel = ie.SelectList(Find.ById("comChannel"));
            ddlchannel.Option("北京地税渠道").Select();

            SelectList ddlcerttype = ie.SelectList(Find.ById("comCertType"));
            ddlcerttype.Option("RSA单位证书").Select();
            Random rd = new Random();
            string paperid = rd.Next(100000000, 999999999).ToString();
            ie.TextField("txtUniqueId").TypeText("paperid");

        }
    }
}
