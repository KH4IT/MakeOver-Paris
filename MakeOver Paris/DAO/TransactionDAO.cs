using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeOver_Paris.DTO;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Data;

namespace MakeOver_Paris.DAO
{
    class TransactionDAO
    {
        public bool AddTransaction(Transaction transaction)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
				cnn.Open();
                MySqlTransaction tran = cnn.BeginTransaction();
                try
                {
                    const string SQL = @"INSERT INTO 
											transactions(
												incomeamount
												, expenseamount
												, createdby
												, remark
											) 
										VALUES(
											@incomeamount
											, @expenseamount
											, @createdby
											, @remark
										);";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@incomeamount", transaction.Incomeamount);
					command.Parameters.AddWithValue("@expenseamount", transaction.Expenseamount);
					command.Parameters.AddWithValue("@createdby", transaction.Createdby);
					command.Parameters.AddWithValue("@remark", transaction.Remark);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        tran.Commit();
                        return true;
                    }
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e);
                    tran.Rollback();
                }
                finally
                {
                    cnn.Close();
                }
            }
            return false;
        }

        public bool UpdateTransaction(Transaction transaction)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
				cnn.Open();
                MySqlTransaction trans = cnn.BeginTransaction();
                try
                {
                    const string SQL = @"UPDATE 
											transactions 
										SET 
											incomeamount = @incomeamount
											, expenseamount = @expenseamount
											, createdby = @createdby
											, remark = @remark
										WHERE
											transactionid = @transactionid;";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@incomeamount", transaction.Incomeamount);
					command.Parameters.AddWithValue("@expenseamount", transaction.Expenseamount);
					command.Parameters.AddWithValue("@createdby", transaction.Createdby);
					command.Parameters.AddWithValue("@remark", transaction.Remark);
					command.Parameters.AddWithValue("@transactionid", transaction.Transactionid);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        trans.Commit();
                        return true;
                    }
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e);
                    trans.Rollback();
                }
                finally
                {
                    cnn.Close();
                }
            }
            return false;
        }

		public DataSet GetAllTransactions()
		{
			try
            {
                List<Transaction> transactions = new List<Transaction>();
                String sql = @"SELECT 
								transactionid
                                , transactiondate
								, incomeamount
								, expenseamount
								, staffname
								, remark
                            FROM transactions
                            INNER JOIN 
                                staffs
                            ON staffs.staffid = transactions.createdby";
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