
using Microsoft.Web.WebSockets;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

using static KmnlkCommon.Shareds.LoggerManagement;

namespace KmnlkRealTimeDll.Management
{
    public class BussinessRealTimeManagement
    {
        public RealTimeManagement RTM;
        public ILog logger;
        public BussinessRealTimeManagement(ILog logger)
        {
            this.logger = logger;
            RTM = new RealTimeManagement(logger);
        }

        public bool register()
        {
            return true;
        }
        //public Image getBarcode(string text, bool withText, int type)
        //{
        //    if (BarcodePackage == "zen")
        //    {
        //        switch (type)
        //        {
        //            case (int)Enum_Barcode_Type.CODE_128:
        //                return BRM.convertTextToBarcodeImageZEN(text, withText);
        //            case (int)Enum_Barcode_Type.CODE_QR:
        //                return QRM.convertTextToBarcodeImageZEN(text, withText);
        //            default:
        //                return BRM.convertTextToBarcodeImageZEN(text, withText);
        //        }
        //    }
        //    else
        //    {
        //        switch (type)
        //        {
        //            case (int)Enum_Barcode_Type.CODE_128:
        //                return BRM.convertTextToBarcodeImageZXING(text, withText);
        //            case (int)Enum_Barcode_Type.CODE_QR:
        //                return QRM.convertTextToBarcodeImageZXING(text, withText);
        //            default:
        //                return BRM.convertTextToBarcodeImageZXING(text, withText);
        //        }
        //    }

        //}
    }
}