using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Mediator.MediatorDataSetTableAdapters;



namespace Mediator
{
    public static class LoginInfo
    {
        public static string id;
        public static string name;
        public static string username;
        public static string printer;
        //public static string currentdate;

        public static bool loading;





        public static void Backup_database()
        {

            try
            {
                System.ComponentModel.BackgroundWorker gBgwDownload = new System.ComponentModel.BackgroundWorker(); /* added this line will fix problem */
                gBgwDownload.DoWork += (object ss, System.ComponentModel.DoWorkEventArgs ee) =>
                {
                    try
                    {
                        //SqlCommand cmd = new SqlCommand("DECLARE @SQL_SCRIPT nvarchar(max), @TEMPLATE nvarchar(max), @databasename nvarchar(max) = DB_NAME() SET @TEMPLATE = 'DECLARE @path nvarchar(max) select @path=backup_path from sittings BACKUP DATABASE {databasename} To DISK=@path' ; SET @SQL_SCRIPT = REPLACE(@TEMPLATE, '{databasename}', @databasename) EXECUTE(@SQL_SCRIPT)", cn);
                        //SqlCommand cmd = new SqlCommand(@"BACKUP DATABASE restaurant To DISK=N'D:\restaurant\restaurant.BAK' WITH FORMAT, MEDIANAME = 'Native_SQLServerBackup', NAME = 'Full-restaurant backup';", cn);
                        SqlConnection cn = new SqlConnection(Properties.Settings.Default.MediatorConnectionString);
                        SqlCommand cmd = new SqlCommand("use Mediator DECLARE @path nvarchar(max) select @path=backup_path from sittings BACKUP DATABASE Mediator To DISK=@path ;", cn);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        LoginInfo.log("[Backup Database Success]");
                    }
                    catch (Exception errortext)
                    {
                        LoginInfo.log(" حدث خطأ فى النسخ الأحتياطى " + errortext.ToString());
                    }
                };

                gBgwDownload.RunWorkerAsync();
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى النسخ الأحتياطى " +  errortext.ToString());
            }

        }

        public static  void log(string descripe)
        {
            try
            {
                System.ComponentModel.BackgroundWorker gBgwDownload = new System.ComponentModel.BackgroundWorker(); /* added this line will fix problem */
                gBgwDownload.DoWork += (object ss, System.ComponentModel.DoWorkEventArgs ee) =>
                {
                    try
                    {
                        system_logTableAdapter logTableAdapter = new system_logTableAdapter();

                        TimeZoneInfo maltaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Egypt Standard Time");
                        DateTime utc = DateTime.UtcNow;
                        DateTime d = TimeZoneInfo.ConvertTimeFromUtc(utc, maltaTimeZone);


                        if (LoginInfo.id == null || LoginInfo.id == "" || LoginInfo.id == string.Empty)
                        {
                            logTableAdapter.Insert(null, descripe, d);
                        }
                        else
                        {
                            logTableAdapter.Insert(int.Parse(LoginInfo.id), descripe, d);
                        }


                    }
                    catch (Exception)
                    {
                    }
                };

                gBgwDownload.RunWorkerAsync();
            }
            catch (Exception)
            {
                
            }
        }























    }
}
