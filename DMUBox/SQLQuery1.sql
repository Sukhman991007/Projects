USE [D:\DATABASE MANAGMENT\DMUBOX\DMUBOX.MDF]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sprocInsertStudentRows]

SELECT	@return_value as 'Return Value'

GO
