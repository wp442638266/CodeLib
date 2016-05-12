﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.MySqlFactory;
using FactoryMethod.OracleFactory;
using FactoryMethod.SqlFactory;
using SimpleFactory;

namespace ConsoleInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //单例模式
            //SinglePattern.SinglePattern.singlePattern.Console("12312312");
            //Console.Read();

            //简单工厂模式 
            //var factory = new DataBaseFactory();
            ////var connection = factory.GetConnection("mysql");
            ////var connection = factory.GetConnection("sql");
            //var connection = factory.GetConnection("oracle");
            //connection.ConnectToDataBase();
            //Console.Read();

            //工厂模式
            //var factory = new SqlFactory();
            //var connection = factory.GetConnection();
            //connection.ConnectToDataBase();
            //Console.Read();

            //var factory = new OracleFactory();
            //var connection = factory.GetConnection();
            //connection.ConnectToDataBase();
            //Console.Read();
            
            //抽象工厂
            var factory=new AbstractFactory.MySqlFactory.MysqlFactory();
            var connection = factory.GetConnection();
            var cmd = factory.GetCommond();
            var result = factory.GetResult();
            connection.ConnectToDataBase();
            cmd.GetBaseCommond();
            result.GetBaseResult();
            Console.Read();

        }
    }
}