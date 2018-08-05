using System;
using System.Data;
using Tiger.Tools;
namespace WangDaDll.Common
{


    partial class FileDataSet
    {
        public SysTools DBHelper = new SysTools();

        /// <summary>
        /// 保存16的图片
        /// </summary>
        /// <param name="dst"></param>
        public void SaveImage()
        {
            try
            {
                DataTable tb = TF_FILE.GetChanges();
                if (tb != null && tb.Rows.Count > 0)
                {
                    tb.TableName = "TF_FILE";
                    DataSet dst = new DataSet();
                    dst.Tables.Add(tb);
                    DBHelper.BasicSer.SaveFileDataSet(dst);
                    this.TF_FILE.AcceptChanges();
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 添加图片
        /// </summary>
        /// <param name="imageFile"></param>
        /// <param name="imageName"></param>
        /// <param name="imageText"></param>
        /// <returns></returns>
        public string AddImage(byte[] imageFile, string imageName, string imageType, string fkID)
        {
            string imgOID = "";
            var row = this.TF_FILE.NewTF_FILERow();
            row.Upload_Date = DateTime.Now;
            row.Uploader = Security.UserName;
            
            row.FileID = Guid.NewGuid().ToString();
            row.FileByte = imageFile;
            //C:\Users\Administrator\Desktop\公式.png
            string[] imgNames = imageName.Split('\\');
            if (imgNames.Length >= 1)
                row.FileName = imgNames[imgNames.Length - 1];
            else
                row.FileName = imageName;
            row.FKID = fkID;
            row.FileType = imageType; //类型，合同或者档案
            this.TF_FILE.Rows.Add(row);
            this.SaveImage();
            imgOID = row["FileID"].ToString();
            return imgOID;
        }

        /// <summary>
        /// 获取p16OID
        /// </summary>
        /// <param name="p16OID"></param>
        public void GetImage(string fkID,string fileType="档案")
        {
            try
            {
              
                DataSet dst = DBHelper.WangDaSer.GetImage(fkID,fileType);
                dst.Tables[0].ImpDataSet(TF_FILE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 根据ID获取文件信息
        /// </summary>
        /// <param name="fileId"></param>
        public byte[] GetImageByID(string fileId)
        {
            try
            {

                DataSet dst = DBHelper.WangDaSer.GetImagebyID(fileId);
                if (dst.Tables[0].Rows.Count > 0)
                    return dst.Tables[0].Rows[0]["FileByte"] as byte[];
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
