using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Amazon.S3;
using Amazon.S3.Model;
using awsTestUpload;
using System.IO;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Stream st = FileUpload1.PostedFile.InputStream;
        string name = Path.GetFileName(FileUpload1.FileName);
        string myBucketName = "YOURBUCKETNAME";   //your	s3	bucket	name	goe here

        string s3DirectoryName = "MyFolder2";
        string s3FileName = @name;
        bool a;
        AmazonUploader myUploader = new AmazonUploader();
        a = myUploader.sendMyFileToS3(st, myBucketName, s3DirectoryName, s3FileName);
        if (a == true)
        {
            Response.Write("successfully	uploaded");
        }
        else
            Response.Write("Error");
    }
}
