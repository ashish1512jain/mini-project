using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabiesRecordsManagementSystem.DataAccess
{
    public static class Extension
    {
        public static Char ToIndicator(this bool source)
        {
            return source ? 'Y' : 'N';
        }

        public static Nullable<Char> ToIndicator(this bool? source)
        {
            if (source.HasValue)
                return source.Value ? (Nullable<Char>)'Y' : (Nullable<Char>)'N';

            return null;
        }

        public static Nullable<int> ToValue(this string source)
        {
            if (string.IsNullOrWhiteSpace(source))
            {
                return null;
            }

            return Convert.ToInt32(source);
        }
    }

    public static class BabiesDataAccess
    {
        public static void SaveBaby(string babyName, long position, bool gender, int year, long rank)
        {
            Database objDB = new SqlDatabase(ConfigurationManager.ConnectionStrings["DBaseConnectionString"].ConnectionString);
            using (DbCommand objCMD = objDB.GetStoredProcCommand("PSP_Babies_Save"))
            {
                objDB.AddInParameter(objCMD, "@Name",
                                     DbType.String, babyName);
                objDB.AddInParameter(objCMD, "@Gender",
                                     DbType.String, gender.ToIndicator());
                objDB.AddInParameter(objCMD, "@Position",
                                    DbType.Int64, position);
                objDB.AddInParameter(objCMD, "@Rank",
                                     DbType.Int64, rank);
                objDB.AddInParameter(objCMD, "@Year",
                                    DbType.Int32, year);

                //objDB.AddOutParameter(objCMD, "@strMessage", DbType.String, 255);

                try
                {
                    objDB.ExecuteNonQuery(objCMD);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        //fetch record
        public static DataTable GetImportedRecords(int? top = 1000, bool direction = true, string name = "",
             bool? gender = null, int? year = null, long? rank = null)
        {
            Database objDB = new SqlDatabase(ConfigurationManager.ConnectionStrings["DBaseConnectionString"].ConnectionString);
            DataSet _ds = new DataSet();
            using (DbCommand objCMD = objDB.GetStoredProcCommand("PSP_Babies_Get"))
            {
                objDB.AddInParameter(objCMD, "@Top",
                                     DbType.Int32, top??1000000);
                objDB.AddInParameter(objCMD, "@SortingDirection",
                                     DbType.String, direction.ToIndicator());

                objDB.AddInParameter(objCMD, "@Name",
                                     DbType.String, name);
                objDB.AddInParameter(objCMD, "@Gender",
                                     DbType.String, gender.ToIndicator());
                objDB.AddInParameter(objCMD, "@Year",
                                     DbType.Int32, year);
                objDB.AddInParameter(objCMD, "@Rank",
                                     DbType.Int64, rank);

                try
                {
                    _ds = objDB.ExecuteDataSet(objCMD);
                    return _ds != null ? _ds.Tables[0] : new DataTable();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static DataTable GetBabiesRanking(string babyName, int dateFrom, int dataTo,bool? gender)
        {
            Database objDB = new SqlDatabase(ConfigurationManager.ConnectionStrings["DBaseConnectionString"].ConnectionString);
            DataSet _ds = new DataSet();
            using (DbCommand objCMD = objDB.GetStoredProcCommand("PSP_BabiesRanking_Get"))
            {
                objDB.AddInParameter(objCMD, "@Name",
                                     DbType.String, babyName);
                objDB.AddInParameter(objCMD, "@YearFrom",
                                     DbType.Int32, dateFrom);

                objDB.AddInParameter(objCMD, "@YearTo",
                                     DbType.Int32, dataTo);
                objDB.AddInParameter(objCMD, "@Gender",
                                     DbType.Int32, gender.ToIndicator());

                try
                {
                    _ds = objDB.ExecuteDataSet(objCMD);
                    return _ds != null ? _ds.Tables[0] : new DataTable();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
