#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Newtonsoft.Json;
using Syncfusion.EJ.PdfViewer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Grading_SOH_Final_Rel.Controllers
{
    public class PdfViewerController : ApiController
    {
	    PdfViewerHelper helper = new PdfViewerHelper();
        public object PostViewerAction(Dictionary<string, string> jsonResult)
        {
            //load the multiple document from client side 
            if (jsonResult.ContainsKey("newFileName"))
            {
                var name = jsonResult["newFileName"];
                var pdfName = name.ToString() + ".pdf";
                helper.Load(Helper.GetFilePath("" + pdfName));
            }
            else
            {
                //Initially load the PDF document from the data folder.
                if (jsonResult.ContainsKey("isInitialLoading"))
                    helper.Load(Helper.GetFilePath("HTTP Succinctly.pdf"));
            }
            return JsonConvert.SerializeObject(helper.ProcessPdf(jsonResult));
        }
		 public object FileUploadPostAction(Dictionary<string, string> jsonResult)
        {
            if (jsonResult.ContainsKey("uploadedFile"))
            {
                var fileurl = jsonResult["uploadedFile"];
                byte[] byteArray = Convert.FromBase64String(fileurl);
                MemoryStream stream = new MemoryStream(byteArray);
                helper.Load(stream);
            }
            string output = JsonConvert.SerializeObject(helper.ProcessPdf(jsonResult));
            return output;
        }
		 public object DocumentDownloadAction(Dictionary<string, string> jsonResult)
        {
            return new { DocumentStream = Convert.ToBase64String(helper.DocumentStream.ToArray()) };
        }	
    }

    public class Helper
    {
        public static string GetFilePath(string path)
        {
            string _dataPath = GetCommonFolder(new DirectoryInfo(HttpContext.Current.Request.PhysicalApplicationPath));
            _dataPath += @"\" + path;
            return _dataPath;
        }

        static string GetCommonFolder(DirectoryInfo dtInfo)
        {
            var _folderNames = dtInfo.GetDirectories("Data/PdfViewer");
            if (_folderNames.Length > 0)
            {
                return _folderNames[0].FullName;
            }

            return dtInfo.Parent != null ? GetCommonFolder(dtInfo.Parent) : string.Empty;
        }
    }
}