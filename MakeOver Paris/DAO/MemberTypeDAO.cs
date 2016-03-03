using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeOver_Paris.DAO;
using MakeOver_Paris.DTO;
using System.Data;
using MySql.Data.MySqlClient;

namespace MakeOver_Paris.DAO
{
    class MemberTypeDAO
    {
        public bool AddMemberType(MemberType memberType)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                cnn.Open();
                MySqlTransaction transaction = cnn.BeginTransaction();
                try
                {
                    const string SQL = @"INSERT INTO 
											membertypes(
												membertype
											) 
										VALUES(
											@membertype
										);";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@membertype", memberType.MemberTypeName);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        transaction.Commit();
                        return true;
                    }
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e);
                    transaction.Rollback();
                }
                finally
                {
                    cnn.Close();
                }
            }
            return false;
        }

        public bool DeleteMemberType(int memberTypeId)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                try
                {
                    cnn.Open();
                    const string SQL = @"DELETE FROM 
											membertypes 
										WHERE 
											membertypeid = @membertypeid";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@membertypeid", memberTypeId);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    cnn.Close();
                }
            }
            return false;
        }

        public bool UdateMemberType(MemberType memberType)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                try
                {
                    cnn.Open();
                    const string SQL = @"UPDATE 
											membertypes 
										SET 
											membertypename = @membertypename 
										WHERE 
											membertypeid = @membertypeid";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@membertypename", memberType.MemberTypeName);
                    command.Parameters.AddWithValue("@membertypeid", memberType.MemberTypeId);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    cnn.Close();
                }
            }
            return false;
        }

        public DataSet GetAllCategories()
        {
            try
            {
                List<Member> members = new List<Member>();
                String sql = @"SELECT membertypeid
                                , membertypename
                            FROM membertypes";
                DataSet ds = DBUtility.ExecuteQuery(sql);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
