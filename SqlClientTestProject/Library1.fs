namespace SqlClientTestProject

open System
open System.Data.SqlClient
open FSharp.Data

module Test = 
    let [<Literal>] ConnectionString = "Data Source=.;Initial Catalog=AdventureWorks2012;Integrated Security=True"
    type QueryCommand = SqlCommandProvider<const(SqlFile<"Query.sql">.Text), ConnectionString>
