using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeOver_Paris.DTO;
using MySql.Data.MySqlClient;
using System.Collections;

namespace MakeOver_Paris.DAO
{
    class MemberDAO
    {
        public Boolean addMember(Member member)
        {
            try
            {
                MySqlConnection cnn = DBUtility.getConnection();
                cnn.Open();
                if (cnn != null)
                {
                    MySqlTransaction transaction = cnn.BeginTransaction();
                    try
                    {
                        String sql = "";
                        MySqlCommand invCommand = new MySqlCommand(sql, cnn);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        transaction.Rollback();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("CONNECTION CATCH :  " + ex.ToString());
            }
            return false;
        }

        public Boolean updateMemeber(Member member)
        {
            try
            {
                MySqlConnection cnn = DBUtility.getConnection();
                cnn.Open();
                if (cnn != null)
                {
                    MySqlTransaction transaction = cnn.BeginTransaction();
                    try
                    {
                        String sql = "";
                        MySqlCommand invCommand = new MySqlCommand(sql, cnn);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        transaction.Rollback();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("CONNECTION CATCH :  " + ex.ToString());
            }
            return false;
        }

        public Member getMemberById(int id)
        {
            try
            {
                Member member = new Member();

                MySqlConnection cnn = DBUtility.getConnection();
                cnn.Open();
                if (cnn != null)
                {
                    MySqlTransaction transaction = cnn.BeginTransaction();
                    try
                    {
                        String sql = "";
                        MySqlCommand invCommand = new MySqlCommand(sql, cnn);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        transaction.Rollback();
                    }
                }
                return member;
            }
            catch (Exception ex)
            {
                Console.WriteLine("CONNECTION CATCH :  " + ex.ToString());
            }
            return null;
        }

        public ArrayList getAllMembers()
        {
            try
            {
                ArrayList members = new ArrayList();

                MySqlConnection cnn = DBUtility.getConnection();
                cnn.Open();
                if (cnn != null)
                {
                    MySqlTransaction transaction = cnn.BeginTransaction();
                    try
                    {
                        String sql = "";
                        MySqlCommand invCommand = new MySqlCommand(sql, cnn);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        transaction.Rollback();
                    }
                }
                return members;
            }
            catch (Exception ex)
            {
                Console.WriteLine("CONNECTION CATCH :  " + ex.ToString());
            }
            return null;
        }
    }
}
