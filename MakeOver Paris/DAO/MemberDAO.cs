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
    // TODO: THIS CLASS WE USE FOR MANIPULATE DATA WITH DATABASE
    // CREATED DATE:    31-01-2016
    // CREATED BY:      DARA PENHCHET
    // UPDATED DATE:    31-01-2016
    // UPDATED BY:      DARA PENHCHET
    // REVISION : V.001
    class MemberDAO
    {
        // TODO: TO ADD NEW MEMBER
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
                        String sql = @"INSERT INTO members(
                                              membername
                                            , membercode
                                            , phonenumber
                                            , createddate
                                            , createdby
                                            , discountrate)             
                                       VALUES(@memberName
                                            , @memberCode
                                            , @phoneNumber
                                            , NOW()
                                            , @createdBy
                                            , @discountRate)";
                        MySqlCommand cmd = new MySqlCommand(sql, cnn);
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@memberName", member.Membername);
                        cmd.Parameters.AddWithValue("@memberCode", member.MemberCode);
                        cmd.Parameters.AddWithValue("@phoneNumber", member.Phonenumber);
                        //cmd.Parameters.AddWithValue("@createdDate", member.Createddate);
                        cmd.Parameters.AddWithValue("@createdBy", member.Createdby.Staffid);
                        //cmd.Parameters.AddWithValue("@updatedDate", member.Updateddate);
                        //.Parameters.AddWithValue("@updatedBy", member.Updatedby);
                        cmd.Parameters.AddWithValue("@discountRate", member.Discountrate);
                        int result = cmd.ExecuteNonQuery();
                        transaction.Commit();
                        if (result != 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        
                        transaction.Rollback();
                    }
                    finally
                    {
                        cnn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("CONNECTION CATCH :  " + ex.ToString());
            }
            return false;
        }

        // TODO: TO UPDATE THE EXISTING MEMBER
        public Boolean updateMemeber(Member member)
        {
            try
            {
                String sql = @"UPDATE members 
                                SET membername = @p1
                                    , membercode = @p2
                                    , phonenumber = @p3
                                    , updateddate = NOW()
                                    , updatedby = @p4
                                    , discountrate = @p5
                                WHERE memberid = @p6";
                return DBUtility.ExecuteNonQuery(sql, member.Membername, member.MemberCode, member.Phonenumber, member.Updatedby.Staffid, member.Discountrate, member.Memberid);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        // TODO: TO GET A MEMBER BY ID
        public Member getMemberById(int id)
        {
            try
            {
                Member member = new Member();
                String sql = @"SELECT memberid
                                    , membercode
                                    , membername
                                    , phonenumber
                                    , createddate
                                    , (SELECT staffname FROM staffs WHERE staffs.staffid = members.createdby) AS createdby
                                    , updateddate
                                    , (SELECT staffname FROM staffs WHERE staffs.staffid = members.updatedby) AS updatedby
                                    , discountrate
                                FROM members 
                                WHERE memberid = @p1";
                DataSet ds = DBUtility.ExecuteQuery(sql, id);
                member.Memberid = (int)ds.Tables[0].Rows[0]["memberid"];
                member.MemberCode = ds.Tables[0].Rows[0]["membercode"].ToString();
                member.Membername = ds.Tables[0].Rows[0]["membername"].ToString();
                member.Phonenumber = ds.Tables[0].Rows[0]["phonenumber"].ToString();
                member.Createddate = (System.DateTime)ds.Tables[0].Rows[0]["createddate"];

                Staff createdStaff = new Staff();
                createdStaff.Staffname = ds.Tables[0].Rows[0]["createdby"].ToString();
                member.Createdby = createdStaff;
                member.Createddate = (System.DateTime)ds.Tables[0].Rows[0]["createddate"];

                Staff updatedStaff = new Staff();
                updatedStaff.Staffname = ds.Tables[0].Rows[0]["updatedby"].ToString();
                member.Updatedby = updatedStaff;
                member.Updateddate = (System.DateTime)ds.Tables[0].Rows[0]["updateddate"];

                member.Discountrate = decimal.Parse(ds.Tables[0].Rows[0]["discountrate"].ToString());

                return member;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        // TODO: TO GET ALL THE MEMBERS
        public List<Member> getAllMembers()
        {
            try
            {
                List<Member> members = new List<Member>();
                String sql = @"SELECT memberid
                                , membercode
                                , membername
                                , phonenumber
                                , members.createddate
                                , createddate
                                , (SELECT staffname FROM staffs WHERE staffs.staffid = members.createdby) AS createdby
                                , updateddate
                                , (SELECT staffname FROM staffs WHERE staffs.staffid = members.updatedby) AS updatedby
                                , discountrate
                            FROM members";
                DataSet ds = DBUtility.ExecuteQuery(sql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Member member = new Member();
                    member.Memberid = (int)ds.Tables[0].Rows[i]["memberid"];
                    member.MemberCode = ds.Tables[0].Rows[i]["membercode"].ToString();
                    member.Membername = ds.Tables[0].Rows[i]["membername"].ToString();
                    member.Phonenumber = ds.Tables[0].Rows[i]["phonenumber"].ToString();
                    member.Createddate = (System.DateTime)ds.Tables[0].Rows[i]["createddate"];

                    Staff createdStaff = new Staff();
                    createdStaff.Staffname = ds.Tables[0].Rows[i]["createdby"].ToString();
                    member.Createdby = createdStaff;
                    member.Createddate = (System.DateTime)ds.Tables[0].Rows[i]["createddate"];

                    Staff updatedStaff = new Staff();
                    updatedStaff.Staffname = ds.Tables[0].Rows[i]["updatedby"].ToString();
                    member.Updatedby = updatedStaff;
                    member.Updateddate = (System.DateTime)ds.Tables[0].Rows[i]["updateddate"];
                }
                return members;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        // TODO: TO GET ALL MEMBERS WITH DATASET
        public DataSet getAllMembersWithDataSet()
        {
            try
            {
                List<Member> members = new List<Member>();
                String sql = @"SELECT memberid
                                , membercode
                                , membername
                                , phonenumber
                                , discountrate
                                , createddate
                                , (SELECT staffname FROM staffs WHERE staffs.staffid = members.createdby) AS createdby
                                , updateddate
                                , (SELECT staffname FROM staffs WHERE staffs.staffid = members.updatedby) AS updatedby
                               
                            FROM members";
                DataSet ds = DBUtility.ExecuteQuery(sql);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
        public bool DeleteMember(int memberId)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                try
                {
                    cnn.Open();
                    const string SQL = @"DELETE FROM 
											members 
										WHERE 
											memberid = @memberid";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@memberid", memberId);
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
    }
}
