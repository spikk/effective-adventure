﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateCookies.View;
using System.Data.Common;

namespace CreateCookies.View
{
    class DataAccessLayer
    {
        SqlConnection connection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");

        public void RegisterCustomer(string[] customer)
        {
            SqlCommand command = new SqlCommand(@"insert into Customer (cNumber, cName, cAddress, cPostalAddress, cCountry, cEmail) 
                               values(@cNumber, @cName, @cAddress, @cPostalAddress, @cCountry, @cEmail)", connection);

            command.Parameters.AddWithValue("@cNumber", customer[0]);
            command.Parameters.AddWithValue("@cName", customer[1]);
            command.Parameters.AddWithValue("@cAddress", customer[2]);
            command.Parameters.AddWithValue("@cPostalAddress", customer[3]);
            command.Parameters.AddWithValue("@cCountry", customer[4]);
            command.Parameters.AddWithValue("@cEmail", customer[5]);

            connection.Open();

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally
            {
                connection.Close();
            }

        }

        public void DeleteCustomer(string cNumber)
        {
            SqlCommand command = new SqlCommand("delete from Customer where cNumber='" + cNumber + "'", connection);
            {
                command.Parameters.AddWithValue("@cNumber", cNumber);

                connection.Open();

                try
                {
                    command.ExecuteNonQuery();
                }

                catch (Exception Ex)
                {
                    throw Ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void UpdateCustomer(string[] customer)
        {
            SqlCommand command = new SqlCommand("update Customer set cName=@cName, cAddress= @cAddress, cPostalAddress=@cPostalAddress, cCountry = @cCountry,  cEmail = @cEmail where cNumber=@cNumber", connection);
            {
                command.Parameters.AddWithValue("@cNumber", customer[0]);
                command.Parameters.AddWithValue("@cName", customer[1]);
                command.Parameters.AddWithValue("@cAddress", customer[2]);
                command.Parameters.AddWithValue("@cPostalAddress", customer[3]);
                command.Parameters.AddWithValue("@cCountry", customer[4]);
                command.Parameters.AddWithValue("@cEmail", customer[5]);

                connection.Open();

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    throw Ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public string [] SearchCustomer(string cNumber)
        {
            connection.Open();

            try
            {
                string[] searchCustomerValues = new string[5];

                SqlCommand command = new SqlCommand("select * from Customer where cNumber ='" + cNumber + "'", connection);

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                { 
                    searchCustomerValues[0] = dr["cName"].ToString();
                    searchCustomerValues[1] = dr["cAddress"].ToString();
                    searchCustomerValues[2] = dr["cPostalAddress"].ToString();
                    searchCustomerValues[3] = dr["cCountry"].ToString();
                    searchCustomerValues[4] = dr["cEmail"].ToString();
                }
                return searchCustomerValues;
            }

            catch (Exception Ex)
            {
                throw Ex;
            }

            finally
            {
                connection.Close();
            }
        }
        public void SeeOrder(string cNumber)
        { 
            connection.Open();

            try
            {
                SqlDataAdapter SeeAllOrdersAdapter = new SqlDataAdapter("Select * from Orde where cNumber= '" + cNumber + "'", connection);
                DataTable dt = new DataTable();
                SeeAllOrdersAdapter.Fill(dt);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

            finally
            {
                connection.Close();
            }
        }
        
        //Order
        public void SearchOrder()
        {
            connection.Open();

            try
            {
                SqlDataAdapter dataadapterOrder = new SqlDataAdapter("Select oNumber, expectedDeliveryDate, isDelivered,cNumber from Orde where oNumber like '"+ "%'", connection);


            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                connection.Close();
          }
        }

       
        public void RegisterOrder(string[] Order,string[] Orderspecification)
        {
           
            SqlCommand AddOrderCommand1 = new SqlCommand("insert into Orde (oNumber, isDelivered,expectedDeliveryDate, cNumber) values(@oNumber, @isDelivered,@expectedDeliveryDate, @cNumber)", connection);
            SqlCommand AddOrderCommand2 = new SqlCommand("insert into Orderspecification (oNumber, pNumber, palletQuantity) values(@oNumber, @pNumber, @palletQuantity)", connection);

            AddOrderCommand1.Parameters.AddWithValue("@oNumber", Order[0]);
            AddOrderCommand1.Parameters.AddWithValue("@isDelivered", Order[1]);
            AddOrderCommand1.Parameters.AddWithValue("@expectedDeliveryDate", Order[2]);
            AddOrderCommand1.Parameters.AddWithValue("@cNumber", Order[3]);

            AddOrderCommand2.Parameters.AddWithValue("@oNumber", Orderspecification[0]);
            AddOrderCommand2.Parameters.AddWithValue("@pNumber", Orderspecification[1]);
            AddOrderCommand2.Parameters.AddWithValue("@palletQuantity", Orderspecification[2]);

            connection.Open();

            try
            {
                AddOrderCommand1.ExecuteNonQuery();
                AddOrderCommand2.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally
            {
                connection.Close();
            }

        }

        public void DeleteOrder(string oNumber)
        {
            SqlCommand command = new SqlCommand("delete from Orde where oNumber='" + oNumber + "'", connection);
            {
                command.Parameters.AddWithValue("@oNumber", oNumber);

                connection.Open();

                try
                {
                    command.ExecuteNonQuery();
                }

                catch (Exception Ex)
                {
                    throw Ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        //Production
        public string[] GetProductToProduceValues()
        {
            string[] productList = new string[4];

            connection.Open();

            try
            {
                SqlCommand producttoProduceecmd = new SqlCommand("select * from Product inner join  Orderspecification on (Product.pNumber=Orderspecification.pNumber) inner join Orde on (Orderspecification.oNumber=Orde.oNumber)", connection);

                SqlDataReader dr = producttoProduceecmd.ExecuteReader();

                if (dr.Read())
                {
                    productList[0] = dr["pNumber"].ToString();
                    productList[1] = dr["palletQuantity"].ToString();
                    productList[2] = dr["pName"].ToString();
                    productList[3] = dr["expectedDeliveryDate"].ToString();
                }
                dr.Close();

                return productList;
               
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}

