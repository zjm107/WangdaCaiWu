using System;
using System.Data;
using Tiger.Tools;
namespace WangDaDll.Common
{


    partial class FileDataSet
    {
        public SysTools DBHelper = new SysTools();

        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="dst"></param>
        public void SaveFile()
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
        /// 保存文件相关信息，不包括文件流
        /// </summary>
        public void SaveFileInfo()
        {
            try
            {
                DataTable tb = TF_FILE.GetChanges();
                if (tb != null && tb.Rows.Count > 0)
                {
                    tb.Columns.Remove("FileByte");
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
        /// 上传文件
        /// </summary>
        /// <param name="filebyte"></param>
        /// <param name="fileName"></param>
        /// <param name="fileType"></param>
        /// <param name="fkID"></param>
        /// <returns></returns>
        public string AddFile(byte[] filebyte, string fileName, string fileType, string fkID)
        {
            string imgOID = "";
            var row = this.TF_FILE.NewTF_FILERow();
            row.Upload_Date = DateTime.Now;
            row.Uploader = Security.UserName;

            row.FileID = Guid.NewGuid().ToString();
            row.FileByte = filebyte;
            //C:\Users\Administrator\Desktop\公式.png
            string[] imgNames = fileName.Split('\\');
            if (imgNames.Length >= 1)
                row.FileName = imgNames[imgNames.Length - 1];
            else
                row.FileName = fileName;
            row.FKID = fkID;
            row.FileType = fileType; //类型，合同或者档案
            this.TF_FILE.Rows.Add(row);
            this.SaveFile();
            imgOID = row["FileID"].ToString();
            return imgOID;
        }

        /// <summary>
        /// 获取p16OID
        /// </summary>
        /// <param name="p16OID"></param>
        public void GetFile(string fkID, string fileType = "档案")
        {
            try
            {

                DataSet dst = DBHelper.WangDaSer.GetImage(fkID, fileType);
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
        public byte[] GetFileByID(string fileId)
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
        /// <summary>
        /// 根据FkId获取文件列表
        /// </summary>
        /// <param name="fkId"></param>
        public void GetFileListByFkId(string fkId)
        {
            try
            {
                DataSet dst = DBHelper.WangDaSer.GetFileListByFkId(fkId);
                dst.Tables[0].ImpDataSet(TF_FILE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 根据FkId删除文件
        /// </summary>
        /// <param name="FkId"></param>
        public void DeleteFile(string FkId)
        {
           
            try
            {
                DBHelper.WangDaSer.DelFile(FkId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }   



    }
}
