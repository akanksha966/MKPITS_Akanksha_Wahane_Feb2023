/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [userid]
      ,[username]
      ,[password]
  FROM [connection].[dbo].[userdetail]
  select * from userdetail